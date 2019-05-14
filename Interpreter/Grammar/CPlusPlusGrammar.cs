using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter
{
    public class CPlusPlusGrammar : CommonGrammar
    {
        //  constructor
        static CPlusPlusGrammar()
        {
            InitGrammar(typeof(CPlusPlusGrammar));
        }

        //  ---     BLOCK OF LITERAL GRAMMAR        ---

        //  not sure whether we'll need it or not
        public static Rule F = CharSet("fF");
        public static Rule U = CharSet("uU");
        public static Rule L = CharSet("lL");

        public static Rule IntPrefix = (U + Opt(L)) | (L + Opt(U));
        public static Rule FloatPrefix = CharSet("fFdD");

        new public static Rule Identifier = Node(CommonGrammar.Identifier);
        new public static Rule Integer = Node(CommonGrammar.Integer + Opt(IntPrefix));
        new public static Rule Float = Node(CommonGrammar.Float + Opt(FloatPrefix));

        public static Rule EscapedChar = Node(MatchChar('\\') + CharSet("\\bnrt'\""));
        public static Rule CharContent = Node(EscapedChar | ExceptCharSet("\""));
        public static Rule String = Node(MatchChar('"') + ZeroOrMore(CharContent) + MatchChar('"'));
        public static Rule Char = MatchChar('\'') + CharContent + MatchChar('\'');
        public static Rule Bool = Node(Keyword("true") | Keyword("false"));

        public static Rule Literal = Node(String | Char | Integer | Float | Bool);

        //  ---     BLOCK OF EXPRESSIONAL GRAMMAR   ---

        public static Rule RecursiveExpression = Recursive(() => Expression);

        public static Rule Block = Node(CharToken('{') + ZeroOrMore(Recursive(() => Statement)) + WS + CharToken('}'));
        public static Rule ExpressionStatement = Node(RecursiveExpression + WS + Eos);
        public static Rule ReturnExpression = Node(Keyword("return") + Opt(RecursiveExpression) + WS + Eos);
        public static Rule Statement = Node(Block | ExpressionStatement | ReturnExpression);

        public static Rule SymbolChar = CharSet("~!^&*<>/+-=%?");
        public static Rule TypeName = Node(Identifier + WS + ZeroOrMore(Dot + Identifier + WS));
        public static Rule TypeArgs = Node(Opt(CharToken('<') + CommaUnlimited(Recursive(() => TypeExpr)) + CharToken('>')));
        public static Rule TypeArrayIndicator = Node(CharToken('[') + CharToken(']'));
        public static Rule TypeExpr = Node(TypeName + Opt(TypeArgs) + Opt(TypeArrayIndicator));
        public static Rule TypedLambdaParam = Node(TypeExpr + WS + Identifier + WS);
        public static Rule UntypedLambdaParam = Node(Identifier + WS);
        public static Rule LambdaParam = TypedLambdaParam | UntypedLambdaParam;
        public static Rule LambdaParams = Node(UntypedLambdaParam | ParentBlock(CommaUnlimited(LambdaParam)));
        public static Rule LambdaExpr = Node(LambdaParams + WS + MatchString("=>") + WS + (Block | RecursiveExpression));
        public static Rule ArgList = Node(CharToken('(') + CommaUnlimited(RecursiveExpression) + CharToken(')'));
        public static Rule Indexer = Node(CharToken('[') + RecursiveExpression + CharToken(']'));
        public static Rule Selector = Node(CharToken('.') + Identifier);
        public static Rule Inc = Node(MatchString("++"));
        public static Rule Dec = Node(MatchString("--"));
        public static Rule PostfixOp = Node(Inc | Dec | Indexer | ArgList | Selector);
        public static Rule PrefixOp = Node(At(SymbolChar) + MatchStringSet("++ -- ! - ~"));
        public static Rule BinaryOp = Node(At(SymbolChar) + MatchStringSet(">>= <<= <= >= == != << >> += -= *= %= /= && || ?? < > & | + - * % / ="));
        public static Rule ParenthesizedExpr = Node(ParentBlock(RecursiveExpression));
        public static Rule FieldInitializer = Node(Identifier + WS + Equal + RecursiveExpression);
        public static Rule TypeInitializerField = Node(FieldInitializer | Recursive(() => TypeInitializer) | RecursiveExpression);
        public static Rule TypeInitializer = Node(CharToken('{') + CommaUnlimited(TypeInitializerField) + CharToken('}'));
        public static Rule NewExpr = Node(Keyword("new") + Opt(TypeExpr) + WS + Opt(ArgList) + WS + Opt(TypeInitializer));
        public static Rule LeafExpr = Node((LambdaExpr | ParenthesizedExpr | NewExpr | Identifier | Integer | Float | String) + WS);
        public static Rule PrefixExpr = Node(PrefixOp + WS + Recursive(() => PrefixExpr) | LeafExpr);
        public static Rule UnaryExpr = Node(PrefixExpr + ZeroOrMore(PostfixOp + WS));
        public static Rule BinaryExpr = Node(UnaryExpr + ZeroOrMore(BinaryOp + WS + UnaryExpr));
        public static Rule TertiaryExpr = Node(BinaryExpr + Opt(CharToken('?') + RecursiveExpression + WS + CharToken(':') + RecursiveExpression));
        public static Rule Expression = Node(TertiaryExpr);

        public static Rule LibraryIncludeOp = Node(MatchChar('#') + Keyword("include") + 
            MatchStringSet("<stdio.h> <math.h> <stdlib.h> <conio.h> <iostream>"));
    }
}
