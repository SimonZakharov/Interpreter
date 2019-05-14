using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter
{
    public class CommonGrammar : Grammar
    {
        //  constructor
        static CommonGrammar()
        {
            InitGrammar(typeof(CommonGrammar));
        }

        public static Rule MatchAnyString(params string[] st) { return Choice(st.Select(x => MatchString(x)).ToArray()); }
        public static Rule MatchStringSet(string s) { return MatchAnyString(s.Split(' ')); }

        //  here we got most common elements for any programming language
        public static Rule MultiLineComment = MatchString("/*") + AdvanceWhileNot(MatchString("*/"));
        public static Rule LineComment      = MatchString("//") + AdvanceWhileNot(MatchString("\n"));
        public static Rule Digit            = MatchChar(Char.IsDigit);
        public static Rule Digits           = OneOrMore(Digit);
        public static Rule Letter           = MatchChar(Char.IsLetter);
        public static Rule LetterOrDigit    = MatchChar(Char.IsLetterOrDigit);
        public static Rule WS               = Pattern(@"\s*");
        public static Rule IdentFirstChar   = MatchChar(c => Char.IsLetter(c) || c == '_');
        public static Rule IdentNextChar    = MatchChar(c => Char.IsLetterOrDigit(c) || c == '_');
        public static Rule Identifier       = IdentFirstChar + ZeroOrMore(IdentNextChar);
        public static Rule Fraction         = MatchChar('.') + Digits;
        public static Rule Integer          = Digits + Not(MatchChar('.'));
        public static Rule Float            = Digits + ((Fraction + Opt(Exp)) | Exp);
        public static Rule HexDigit         = Digits | CharRange('a', 'f') | CharRange('A', 'F');
        public static Rule E                = (MatchChar('e') | MatchChar('E')) + Opt(MatchChar('+') | MatchChar('-'));
        public static Rule Exp              = E + Digits;

        public static Rule CharToken(char c) { return MatchChar(c) + WS; }
        public static Rule StringToken(string s) { return MatchString(s) + WS; }
        public static Rule CommaUnlimited(Rule rule) { return Opt(rule + (ZeroOrMore(CharToken(',') + rule) + Opt(CharToken(',')))); }

        public static Rule Comma            = CharToken(',');
        public static Rule Dot              = CharToken('.');
        public static Rule Equal            = CharToken('=');
        public static Rule Eos              = CharToken(';');

        public static Rule Keyword(string s) { return MatchString(s) + Not(LetterOrDigit) + WS; }
        public static Rule ParentBlock(Rule rule) { return CharToken('(') + rule + WS + CharToken(')'); }
    }
}
