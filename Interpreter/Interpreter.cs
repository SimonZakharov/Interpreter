using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;



namespace Interpreter
{
    public class Interpreter
    {
        // pattern strings to analyse source code
        private string[] valueTypes = new string[7] { "int", "long", "short", "float", "double", "char", "bool" };

        //  blocks of code from CodingRTB
        public static string sourceCode = "";
        public static string[] instructionLines;

        /// <summary>
        /// Boolean variable indicates whether solution of the problem is correct
        /// </summary>
        public static bool isSolutionCorrect = true;

        public static CPusPlusForm form1 = new CPusPlusForm();

        public static void GetCode()
        {
                        
        }

        /// <summary>
        /// Method checks if every opening brace of any possible kind is closed
        /// </summary>
        /// <returns></returns>
        private static bool AreBracesCorrect()
        {
            int count = 0;
            var braces = Regex.Matches(sourceCode, "{");
            count = braces.Count;
            braces = Regex.Matches(sourceCode, "}");
            count -= braces.Count;
            if (count != 0)
                return false;
            braces = Regex.Matches(sourceCode, @"\(");
            count = braces.Count;
            braces = Regex.Matches(sourceCode, @"\)");
            count -= braces.Count;
            if (count != 0)
                return false;
            braces = Regex.Matches(sourceCode, @"\[");
            count = braces.Count;
            braces = Regex.Matches(sourceCode, @"\]");
            count -= braces.Count;
            if (count != 0)
                return false;
            return true;
        }

        /// <summary>
        /// Method checks the solution of the choisen problem, using algorythm of syntax analysis
        /// </summary>
        /// <param name="nameOfProblem">Name of the problem solved</param>
        /// <returns></returns>
        public static string CheckSolution(string nameOfProblem)
        {
            switch (nameOfProblem)
            {
                default:
                    return "0";
                //  *** THEORETICAL PROBLEMS    *** //
                case "Beginning":
                    if (!AreBracesCorrect())
                    {
                        isSolutionCorrect = false; return "0";
                    }
                    isSolutionCorrect = true; 
                    return "0";
                case "Alphabet":
                    if (!AreBracesCorrect())
                    {
                        isSolutionCorrect = false; return "0";
                    }
                    string coutPattern = @"\bcout\s*<<\s*" + "\"" + @"[A-Za-z ]*" + "\"" + @"\s*;";
                    var match = Regex.Match(sourceCode, coutPattern); string s = "";
                    if (match.Success)
                    {
                        match = Regex.Match(sourceCode, "\"");
                        s = sourceCode.Substring(match.Index + 1);
                        match = Regex.Match(s, "\"");
                        s = s.Substring(0, match.Index);
                    }
                    return s;
                case "Syntax":
                    if (!AreBracesCorrect()) {
                        isSolutionCorrect = false; return "0";
                    }
                    return "0";
                case "Grammar":
                    if (!AreBracesCorrect())
                    {
                        isSolutionCorrect = false; return "0";
                    }
                    return "0";
                case "Boolean":
                    if (!AreBracesCorrect())
                    {
                        isSolutionCorrect = false; return "0";
                    }
                    match = Regex.Match(sourceCode, @";;");
                    if (match.Success)
                    {
                        isSolutionCorrect = false; return "0";
                    }
                    string logicPattern1 = @"\bbool\s*alpha\s*=\s*true\s*;";
                    string logicPattern2 = @"\bbool\s*beta\s*=\s*false\s*;";
                    string valuePattern1 = @"\balpha\s*=\s*true\s*;";
                    string valuePattern2 = @"\balpha\s*=\s*true\s*;";
                    match = Regex.Match(sourceCode, logicPattern1);
                    if (match.Success)
                    {
                        match = Regex.Match(sourceCode, logicPattern2);
                        if (match.Success)
                        {
                            isSolutionCorrect = true; return "0";
                        }
                    }
                    else
                    {
                        match = Regex.Match(sourceCode, valuePattern1);
                        if (match.Success)
                        {
                            match = Regex.Match(sourceCode, valuePattern2);
                            if (match.Success)
                            {
                                isSolutionCorrect = true; return "0";
                            }
                        }
                    }
                    isSolutionCorrect = false;
                    return "0";
                case "Negation":
                    if (!AreBracesCorrect())
                    {
                        isSolutionCorrect = false; return "0";
                    }
                    string negPattern = @"\bbool\s*anotherVariable\s*=\s*\!\s*variable\s*;";
                    match = Regex.Match(sourceCode, negPattern);
                    if (match.Success)
                    {
                        isSolutionCorrect = true; return "0";
                    }
                    return "0";
                //  *** PRACTICAL PROBLEMS  *** //
                case "Evaluation":
                    if (!AreBracesCorrect())
                    {
                        isSolutionCorrect = false; return "0";
                    }
                    return "0";
                case "PointAndLine":
                    if (!AreBracesCorrect())
                    {
                        isSolutionCorrect = false; return "0";
                    }
                    string cinPattern1 = @"\bcin\s*\>\>\s*x\s*;";
                    string cinPattern2 = @"\bcin\s*\>\>\s*x\s*;";
                    string cinCommonPattern = @"\bcin\s*\>\>\s*x\s*\>\>\s*y\s*\s*;";
                    logicPattern1 = @"\bresult\s*=\s*A\s*\*\s*x\s*\+\s*B\s*\*\s*y\s*\+\s*C\s*==\s*0\s*;";
                    string explPattern = @"A\s*\*\s*x\s*\+\s*B\s*\*\s*y\s*\+\s*C\s*==\s*0\s*";
                    logicPattern2 = @"\bif\s*\(\s*" + explPattern + @"\)";
                    string resultToTruePattern = @"\bresult\s*=\s*true\s*;";
                    string elsePattern = @"\belse";
                    string resultToFalsePattern = @"\bresult\s*=\s*false\s*;";
                    match = Regex.Match(sourceCode, cinPattern1);
                    if (match.Success)
                    {
                        match = Regex.Match(sourceCode, cinPattern2);
                        if (match.Success)
                        {
                            match = Regex.Match(sourceCode, logicPattern1);
                            if (match.Success)
                            {
                                isSolutionCorrect = true; return "0";
                            }
                            else
                            {
                                match = Regex.Match(sourceCode, logicPattern2);
                                if (match.Success)
                                {
                                    match = Regex.Match(sourceCode, resultToTruePattern);
                                    if (match.Success)
                                    {
                                        match = Regex.Match(sourceCode, elsePattern);
                                        if (match.Success)
                                        {
                                            match = Regex.Match(sourceCode, resultToFalsePattern);
                                            if (match.Success)
                                            {
                                                isSolutionCorrect = true; return "0";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        match = Regex.Match(sourceCode, cinCommonPattern);
                        if (match.Success)
                        {
                            match = Regex.Match(sourceCode, logicPattern1);
                            if (match.Success)
                            {
                                isSolutionCorrect = true; return "0";
                            }
                            else
                            {
                                match = Regex.Match(sourceCode, logicPattern2);
                                if (match.Success)
                                {
                                    match = Regex.Match(sourceCode, resultToTruePattern);
                                    if (match.Success)
                                    {
                                        match = Regex.Match(sourceCode, elsePattern);
                                        if (match.Success)
                                        {
                                            match = Regex.Match(sourceCode, resultToFalsePattern);
                                            if (match.Success)
                                            {
                                                isSolutionCorrect = true; return "0";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    isSolutionCorrect = false;
                    return "0";
                case "InSquarePow":
                    string intParamPattern = @"\s*int\s+\D\w*\s*";
                    string funcPattern = @"\bint\s+\D\w*\(\s*int\s+\D\w*\s*\)";
                    string returnSquarePattern = @"\breturn\s+\D\w*\s*\*\s*\D\w*;";
                    string returnValuePattern = @"\breturn\s+\d+\w*;";
                    string returnVariablePattern = @"\breturn\s+\D\w*";
                    string AssingToSquarePattern = @"\bint\s+\D\w*\s*=\s*\D\w*\s*\*\s*\D\w*;";
                    string settingPattern = @"\bexample\s*=\s*\D\w*\(\s*example\s*\)\s*;";
                    //  checking braces
                    if (!AreBracesCorrect())
                    {
                        isSolutionCorrect = false; return "0";
                    }
                    var matches = Regex.Matches(sourceCode, funcPattern);
                    if (matches.Count == 1)
                    {
                        match = Regex.Match(sourceCode, settingPattern);
                        if (!match.Success)
                        {
                            isSolutionCorrect = false; return "0";
                        }
                        matches = Regex.Matches(sourceCode, returnSquarePattern);
                        if (matches.Count == 1)
                        {
                            s = matches[0].Value; s = s.Substring(7); string s1 = s;
                            int i = 0;
                            while (s[i] == ' ') i++;
                            s = s.Substring(i); i = 0;
                            while (s[i] != '*' && s[i] != ' ') i++;
                            s = s.Substring(0, i);
                            var square = Regex.Match(s1, @"\b" + s + @"\s*\*\s*" + s + ";");
                            if (square.Success)
                                isSolutionCorrect = true;
                            else
                            {
                                isSolutionCorrect = false; return "0";
                            }
                            return "0";
                        }
                        else
                        {
                            matches = Regex.Matches(sourceCode, AssingToSquarePattern);
                            int c1 = matches.Count;
                            matches = Regex.Matches(sourceCode, returnVariablePattern);
                            int c2 = matches.Count;
                            if (c1 == 1 && c2 == 1)
                            {
                                isSolutionCorrect = true; return "0";
                            }
                            else
                            {
                                isSolutionCorrect = false; return "0";
                            }
                        }
                    }
                    else isSolutionCorrect = false;
                    matches = Regex.Matches(sourceCode, returnValuePattern);
                    return matches.Count.ToString();
                case "InNthPow":
                    string intArgPattern = @"int\s+\D\w*\s*=\s*\d+\s*;\s*";
                    string forPattern = @"\bfor\s*\(" + intArgPattern + @"\D\w*\s*<\s*\D\w*\s*;\s*\D\w*\+\+\s*\)";
                    intParamPattern = @"\s*int\s+\D\w*\s*";
                    funcPattern = @"\bint\s+\D\w*\(" + intParamPattern + "," + intParamPattern + @"\)";
                    if (!AreBracesCorrect())
                    {
                        isSolutionCorrect = false; return "0";
                    }
                    match = Regex.Match(sourceCode, funcPattern);
                    if (match.Success)
                    {
                        match = Regex.Match(sourceCode, forPattern);
                        isSolutionCorrect = match.Success;
                    }
                    else
                    {
                        isSolutionCorrect = false; return "0";
                    }
                    return "0";
                case "DistanceBetweenPoints":
                    intParamPattern = @"\s*int\s+\D\w*\s*";
                    returnVariablePattern = @"\breturn\s+\D\w*\s*;";
                    string sqrFuncPattern = @"sqr\(\s*\D\w*\s*-\s*\D\w*\s*\)";
                    string sqrtSimplePattern = @"\(\s*\D\w*\s*-\s*\D\w*\s*\)\s*\*\s*\(\s*\D\w*\s*-\s*\D\w*\s*\)";
                    funcPattern = @"\bfloat\s+\D\w*\(" + intParamPattern + "," + intParamPattern + "," 
                        + intParamPattern + "," + intParamPattern + @"\)";
                    string sqrtPattern1 = @"sqrtf\(\s*" + sqrFuncPattern + @"\s*\+\s*" + sqrFuncPattern + @"\s*\)\s*;";
                    string sqrtPattern2 = @"sqrtf\(\s*" + sqrtSimplePattern + @"\s*\+\s*" + sqrtSimplePattern + @"\s*\)\s*;";
                    if (!AreBracesCorrect())
                    {
                        isSolutionCorrect = false; return "0";
                    }
                    match = Regex.Match(sourceCode, funcPattern);
                    if (match.Success)
                    {
                        match = Regex.Match(sourceCode, @"\bfloat\s*distance\s*=\s*\D\w*\(");
                        if (!match.Success)
                            match = Regex.Match(sourceCode, @"\bdistance\s*=\s*\D\w*\(");
                        if (!match.Success)
                        {
                            isSolutionCorrect = false; return "0";
                        }
                        match = Regex.Match(sourceCode, returnVariablePattern);
                        if (match.Success)
                        {
                            match = Regex.Match(sourceCode, @"\b\D\w*\s*=\s*" + sqrtPattern1);
                            if (!match.Success)
                                match = Regex.Match(sourceCode, @"\b\D\w*\s*=\s*" + sqrtPattern2);
                            isSolutionCorrect = match.Success;
                            return "0";
                        }
                        else
                        {
                            match = Regex.Match(sourceCode, @"\breturn\s*" + sqrtPattern1);
                            if (!match.Success)
                                match = Regex.Match(sourceCode, @"\breturn\s*" + sqrtPattern2);
                            isSolutionCorrect = match.Success;
                            return "0";
                        }
                    }
                    else
                    {
                        isSolutionCorrect = false; return "0";
                    }
                    //return "0";
                case "SumOfElements":
                    return "0";
            }
        }

        /// <summary>
        /// Switching to the next theoretical or practical task, after successful completion of the current one
        /// </summary>
        /// <param name="nameOfProblem">Name of current problem</param>
        public static void nextTheme(string nameOfProblem)
        {
            switch (nameOfProblem)
            {
            //  ****    THEORETICAL PROBLEMS    ****
                case "Beginning":
                    CPusPlusForm.currentProblemName = "Alphabet";
                    break;
                case "Alphabet":
                    CPusPlusForm.currentProblemName = "Syntax";
                    break;
                case "Syntax":
                    CPusPlusForm.currentProblemName = "Grammar";
                    break;
                case "Grammar":
                    CPusPlusForm.currentProblemName = "ValueTypes";
                    break;
                case "ValueTypes":
                    CPusPlusForm.currentProblemName = "ReferenceTypes";
                    break;
                case "ReferenceTypes":
                    CPusPlusForm.currentProblemName = "PointerType";
                    break;
                case "PointerType":
                    CPusPlusForm.currentProblemName = "Boolean";
                    break;
                case "Boolean":
                    CPusPlusForm.currentProblemName = "UInteger";
                    break;
                case "UInteger":
                    CPusPlusForm.currentProblemName = "Integer";
                    break;
                case "Integer":
                    CPusPlusForm.currentProblemName = "FloatType";
                    break;
                case "FloatType":
                    CPusPlusForm.currentProblemName = "Chars";
                    break;
                case "Chars":
                    CPusPlusForm.currentProblemName = "Classes";
                    break;
                case "Classes":
                    CPusPlusForm.currentProblemName = "Structs";
                    break;
                case "Structs":
                    CPusPlusForm.currentProblemName = "Unions";
                    break;
                case "Unions":
                    CPusPlusForm.currentProblemName = "Negation";
                    break;
                case "Negation":
                    CPusPlusForm.currentProblemName = "ConjunctionAndDisjunction";
                    break;
                case "ConjunctionAndDisjunction":
                    CPusPlusForm.currentProblemName = "ImplicationAndEquivalention";
                    break;
                case "ImplicationAndEquivalention":
                    CPusPlusForm.currentProblemName = "Xor";
                    break;
                case "Xor":
                    CPusPlusForm.currentProblemName = "ObjectsOfDifferentTypes";
                    break;
                case "ObjectsOfDifferentTypes":
                    CPusPlusForm.currentProblemName = "IncDec";
                    break;
                case "IncDec":
                    CPusPlusForm.currentProblemName = "Ariphmetics";
                    break;
                case "Ariphmetics":
                    CPusPlusForm.currentProblemName = "MathClass";
                    break;
                case "MathClass":
                    CPusPlusForm.currentProblemName = "ControlSymbols";
                    break;
                case "ControlSymbols":
                    CPusPlusForm.currentProblemName = "CtypeFunctions";
                    break;
                case "CtypeFunctions":
                    CPusPlusForm.currentProblemName = "CheckTruth";
                    break;
                case "CheckTruth":
                    CPusPlusForm.currentProblemName = "CheckFalse";
                    break;
                case "CheckFalse":
                    CPusPlusForm.currentProblemName = "AddConditions";
                    break;
                case "AddConditions":
                    CPusPlusForm.currentProblemName = "SwitchOperator";
                    break;
                case "SwitchOperator":
                    CPusPlusForm.currentProblemName = "DefaultCase";
                    break;
                case "DefaultCase":
                    CPusPlusForm.currentProblemName = "ForDefinition";
                    break;
                case "ForDefinition":
                    CPusPlusForm.currentProblemName = "CounterTypes";
                    break;
                case "CounterTypes":
                    CPusPlusForm.currentProblemName = "NestedLoops";
                    break;
                case "NestedLoops":
                    CPusPlusForm.currentProblemName = "WhileDefinition";
                    break;
                case "WhileDefinition":
                    CPusPlusForm.currentProblemName = "FalseCondition";
                    break;
                case "FalseCondition":
                    CPusPlusForm.currentProblemName = "DoWhileDefinition";
                    break;
                case "DoWhileDefinition":
                    CPusPlusForm.currentProblemName = "DoWhileFalseCondition";
                    break;
                case "DoWhileFalseCondition":
                    CPusPlusForm.currentProblemName = "FuncInit";
                    break;
                case "FuncInit":
                    CPusPlusForm.currentProblemName = "ReturnType";
                    break;
                case "ReturnType":
                    CPusPlusForm.currentProblemName = "FuncArgs";
                    break;
                case "FuncArgs":
                    CPusPlusForm.currentProblemName = "ProcInit";
                    break;
                case "ProcInit":
                    CPusPlusForm.currentProblemName = "VoidReturn";
                    break;
                case "VoidReturn":
                    CPusPlusForm.currentProblemName = "ProcArgs";
                    break;
                case "ProcArgs":
                    CPusPlusForm.currentProblemName = "DoWhileFalseCondition";
                    break;
                case "LinearArrays":
                    CPusPlusForm.currentProblemName = "Matrixes";
                    break;
                case "Matrixes":
                    CPusPlusForm.currentProblemName = "WhatIsRecursion";
                    break;
                case "WhatIsRecursion":
                    CPusPlusForm.currentProblemName = "ExampleOfRF";
                    break;
                case "ExampleOfRF":
                    CPusPlusForm.currentProblemName = "TailRecursion";
                    break;
                case "TailRecursion":
                    CPusPlusForm.currentProblemName = "TailorsSeries";
                    break;
                //  ****    PRACTICAL PROBLEMS  ****
                case "Evaluation":
                    CPusPlusForm.currentPracticeProblemName = "PointAndLine";
                    break;
                case "PointAndLine":
                    CPusPlusForm.currentPracticeProblemName = "InSquarePow";
                    break;
                case "InSquarePow":
                    CPusPlusForm.currentPracticeProblemName = "InNthPow";
                    break;
                case "InNthPow":
                    CPusPlusForm.currentPracticeProblemName = "DistanceBetweenPoints";
                    break;
                case "DistanceBetweenPoints":
                    CPusPlusForm.currentPracticeProblemName = "ToBinaryNumberSystem";
                    break;
                case "ToBinaryNumberSystem":
                    CPusPlusForm.currentPracticeProblemName = "ToAnyNumberSystem";
                    break;
                case "ToAnyNumberSystem":
                    CPusPlusForm.currentPracticeProblemName = "SumOfElements";
                    break;
                case "SumOfElements":
                    CPusPlusForm.currentPracticeProblemName = "SumOfEvenElements";
                    break;
                case "SumOfEvenElements":
                    CPusPlusForm.currentPracticeProblemName = "ArrayReverse";
                    break;
                case "ArrayReverse":
                    CPusPlusForm.currentPracticeProblemName = "ArrayQuickSort";
                    break;
                //  **** BY DEFAULT  ****
                default:
                    CPusPlusForm.currentProblemName = "Beginning";
                    break;
            }
        }
    }

    public class IntegerValue
    {
        public string Name { get; set; }
        public string ActualType { get; set; }
        public long Value { get; set; }

        //  constructor
        public IntegerValue(string name, string actType, long value)
        {
            if (name != "" && actType != "")
            {
                Name = name; ActualType = actType; Value = value;
            }
            else throw new ArgumentNullException("None of arguments of an integer can be empty. Can not create new integer.");
        }

        public override string ToString()
        {
            return Name + " " + Value.ToString();
        }
    }

    public class FloatValue
    {
        public string Name { get; set; }
        public string ActualType { get; set; }
        public double Value { get; set; }

        //  constructor
        public FloatValue(string name, string actType, double value)
        {
            if (name != "" && actType != "")
            {
                Name = name; ActualType = actType; Value = value;
            }
            else throw new ArgumentNullException("None of arguments of a float object can be empty. Can not create new float.");
        }

        public override string ToString()
        {
            return Name + " " + Value.ToString();
        }
    }

    public class CharValue
    {
        public string Name { get; set; }
        public char Value { get; set; }

        //  constructor
        public CharValue(string name, char value)
        {
            if (name != "")
            {
                Name = name; Value = value;
            }
            else throw new ArgumentNullException("None of arguments of a char can be empty. Can not create new char.");
        }

        public override string ToString()
        {
            return Name + " " + Value.ToString();
        }
    }

    public class BoolValue
    {
        public string Name { get; set; }
        public bool Value { get; set; }

        //  constructor
        public BoolValue(string name, bool value)
        {
            if (name != "")
            {
                Name = name; Value = value;
            }
            else throw new ArgumentNullException("None of arguments of a boolean can be empty. Can not create new boolean.");
        }

        public override string ToString()
        {
            return Name + " " + Value.ToString();
        }
    }

    public class Function
    {
        public string Name { get; set; }
        public string Type { get; set; }
        //  arrays of function's arguments
        private IntegerValue[] intParams = new IntegerValue[5];
        private FloatValue[] floatParams = new FloatValue[5];
        private CharValue[] charParams = new CharValue[5];
        private BoolValue[] boolParams = new BoolValue[5];

        //  lists of internal variables for a function
        private List<IntegerValue> intVariables = new List<IntegerValue>();
        private List<FloatValue> floatVariables = new List<FloatValue>();
        private List<BoolValue> boolValues = new List<BoolValue>();
        private List<CharValue> charValues = new List<CharValue>();

        //  constructor without parameters
        public Function(string name, string type)
        {
            if (name != "" && type != "")
            {
                Name = name; Type = type;
            }
            else throw new ArgumentNullException("Neither name nor type of a function can be empty. Can not create new function.");
        }

        //  constructor with parameters
        public Function(string name, string type, params IntegerValue[] intV)
        {
            if (name != "" && type != "")
            {
                Name = name; Type = type;
                for (int i = 0; i < 5; i++)
                    if (intV[i] != null)
                        intVariables[i] = intV[i];
            }
        }
    }

    public class Procedure
    {
        public string Name { get; set; }
        //  arrays of function's arguments
        private IntegerValue[] intParams = new IntegerValue[5];
        private FloatValue[] floatParams = new FloatValue[5];
        private CharValue[] charParams = new CharValue[5];
        private BoolValue[] boolParams = new BoolValue[5];

        //  lists of internal variables for a function
        private List<IntegerValue> intVariables = new List<IntegerValue>();
        private List<FloatValue> floatVariables = new List<FloatValue>();
    }
}
