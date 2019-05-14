using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Interpreter;

namespace Interpreter
{
    public partial class CPusPlusForm : Form
    {
        //problems file
        public string[] problemText;
        public static ushort problemNumber = 0;

        //start code file
        public string[] codesText;

        //files with practical tasks
        public string[] practiceText;
        public string[] tasksText;

        public static string currentProblemName = "";
        public static string currentPracticeProblemName = "";

        /// <summary>
        /// Array of code lines from CodingRTB to be sent to Interpreter class
        /// </summary>
        public static string[] solutionStrings;

        public string nameOfCurrentProblem = "";

        //  array of languages
        public const string langRus = "rus";
        public const string langEng = "eng";
        public const string langPol = "pol";
        public string currentLanguage = langRus;

        /// <summary>
        /// Array of keywords - strings to highlight
        /// </summary>
        public List<string> keywords = new List<string>();
        public List<string> includes = new List<string>();

        public bool isCodeLighted = true;
        public bool isCodeChecked = false;

        public const string startStringRus = "Изучаем язык С++, начиная с основ и заканчивая рекурсивными алгоритмами.\n" +
                                "Выберите раздел и тему для изучения из списка слева.\n" +
                                "Изучив теорию и решив задачу, нажмите на кнопку \"Готово\" в правом нижнем углу экрана.";

        public const string practiceStringRus = "В этом разделе вы можете отработать изученный материал на практике.\n" + 
                            "Выберите задачу из списка слева; решите ее, набрав код в блоке ниже, и нажмите на кнопку " + 
                            "\"Готово\" в правом нижнем углу экрана, чтобы проверить решение на правильность.";

        public const string JavaStartStringRus = "Изучаем язык Java, начиная с основ и заканчивая рекурсивными алгоритмами.\n" + 
                                "Выберите раздел и тему для изучения из списка слева.\n" +
                                "Изучив теорию и решив задачу, нажмите на кнопку \"Готово\" в правом нижнем углу экрана.";
        public CPusPlusForm()
        {
            InitializeComponent();
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space || e.KeyCode == Keys.Up || e.KeyCode == Keys.Left
                || e.KeyCode == Keys.Down || e.KeyCode == Keys.Right)
            {
                if (getCodeLightout())
                {
                    CodingRTB.SuspendLayout();
                    text_Lightout();
                    CodingRTB.ResumeLayout();
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            richTextBox1_KeyDown(this, e);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            ProblemRTB.Text = startStringRus;
            codesText = File.ReadAllLines("codes.dat"); problemNumber = 0;
            CodingRTB.Text = "";
            keywords.Clear(); keywords.Add("include"); keywords.Add("void");
            keywords.Add("int"); keywords.Add("return"); keywords.Add("using"); keywords.Add("namespace");
            keywords.Add("unsigned");
            keywords.Add("float"); keywords.Add("double"); keywords.Add("short"); keywords.Add("char"); keywords.Add("long");
            keywords.Add("bool"); keywords.Add("true"); keywords.Add("false"); keywords.Add("if"); keywords.Add("else");
            keywords.Add("switch"); keywords.Add("case"); keywords.Add("default"); keywords.Add("break");
            keywords.Add("for"); keywords.Add("while"); keywords.Add("do"); keywords.Add("class");
            if (isCodeLighted)
            {
                CodingRTB.SuspendLayout();
                text_Lightout();
                CodingRTB.ResumeLayout();
            }
            CodingRTB.SelectionStart = CodingRTB.Find("{") + 2; CodingRTB.SelectionLength = 0;
            ResultsTB.Text = "0";
            rankLabel.Visible = false;
            problemText = File.ReadAllLines("problems.dat");
            practiceText = File.ReadAllLines("practice.dat");
            tasksText = File.ReadAllLines("tasks.dat");
            currentProblemName = "escape"; currentPracticeProblemName = "escape";
            OKButton.Enabled = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// This is used to check text of program written in CodingRTB. Good place to put a contextual breakpoint
        /// </summary>
        /// <returns></returns>
        public bool isCodeCorrect()
        {
            Interpreter.sourceCode = CodingRTB.Text;
            if (currentPracticeProblemName == "escape")
            {
                ResultsTB.Text = Interpreter.CheckSolution(currentProblemName);
                if (!Interpreter.isSolutionCorrect)
                    ResultsTB.Text = "0";
                return Interpreter.isSolutionCorrect;
            }
            else if (currentProblemName == "escape")
            {
                ResultsTB.Text = Interpreter.CheckSolution(currentPracticeProblemName);
                if (!Interpreter.isSolutionCorrect)
                    ResultsTB.Text = "0";
                return Interpreter.isSolutionCorrect;
            }
            else return false;
        }

        public bool getCodeLightout()
        {
            return isCodeLighted;
        }

        public void setCodeLighout(bool unconditional)
        {
            if (unconditional)
            {
                switch (currentLanguage)
                {
                    case langRus:
                        lightOutSettingItem.Text = "Отключить подсветку";
                        break;
                    case langEng:
                        lightOutSettingItem.Text = "Disable lightout";
                        break;
                    case langPol:
                        lightOutSettingItem.Text = "Отключить подсветку";
                        break;
                }
            }
            else
            {
                switch (currentLanguage)
                {
                    case langRus:
                        lightOutSettingItem.Text = "Включить подсветку";
                        break;
                    case langEng:
                        lightOutSettingItem.Text = "Enable lightout";
                        break;
                    case langPol:
                        lightOutSettingItem.Text = "Включить подсветку";
                        break;
                }
            }
            isCodeLighted = unconditional;
        }

        /// <summary>
        /// Method to organize syntax lightout
        /// </summary>
        public void text_Lightout()
        {
            CodingRTB.Focus();
            this.SuspendLayout();
            int firstPosition = 0, lastPos = CodingRTB.SelectionStart;
            CodingRTB.SelectAll(); CodingRTB.SelectionColor = Color.Black;
            //if (StartForm.Language == "CPlusPlus")
                for (int i = 0; i < keywords.Count; i++)
                {
                    var matches = Regex.Matches(CodingRTB.Text, @"\b" + keywords.ElementAt(i));
                    foreach (var match in matches.Cast<Match>())
                    {
                        CodingRTB.Select(match.Index, match.Length); CodingRTB.SelectionColor = Color.Blue;
                    }
                }
            if (StartForm.Language == "Java")
                for (int i = 0; i < keywords.Count; i++)
                {
                    var matches = Regex.Matches(CodingRTB.Text, @"\b" + keywords.ElementAt(i));
                    foreach (var match in matches.Cast<Match>())
                    {
                        CodingRTB.Select(match.Index, match.Length); CodingRTB.SelectionColor = Color.DarkViolet;
                    }
                }
            CodingRTB.Select(lastPos, 0); CodingRTB.SelectionColor = Color.Black;
            for (int i = 0; i < CodingRTB.Text.Length; i++)
            {
                if (CodingRTB.Text[i] == '0')
                {
                    lastPos = CodingRTB.SelectionStart; firstPosition = i; CodingRTB.SelectionLength = 1; CodingRTB.SelectionColor = Color.Black;
                    CodingRTB.SelectionStart = lastPos; CodingRTB.SelectionLength = 0; CodingRTB.SelectionColor = Color.Black;
                }
            }
            
            this.ResumeLayout(true);
        }

        //  OK button click
        private void OKButton_Click(object sender, EventArgs e)
        {
            int t = CodingRTB.Lines.Count();
                if (!isCodeChecked)
                    //  if the code is correct
                    if (isCodeCorrect())
                    {
                        OKButton.Text = @"Далее->"; isCodeChecked = true; rankLabel.ForeColor = Color.ForestGreen;
                        rankLabel.Text = @"Решение верно! Нажмите 'Далее' для продолжения";
                        rankLabel.Visible = true;
                    }
                    //  otherwise
                    else
                    {
                        OKButton.Text = "Готово"; isCodeChecked = false; rankLabel.ForeColor = Color.Crimson;
                        rankLabel.Text = "Решение содержит ошибку";
                        rankLabel.Visible = true;
                    }
                else
                {
                    //  Next button click
                    //  !!!
                    isCodeChecked = false;
                    OKButton.Text = "Готово"; ResultsTB.Text = "0";
                    rankLabel.Visible = false;
                    nextTheme(currentProblemName);
                }
        }

        /// <summary>
        /// Selection of the current THEORETICAL theme from the treeView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            setCurrentProblem(TheoryTreeView.SelectedNode.Name);
            if (isCodeLighted)
            {
                CodingRTB.SuspendLayout(); text_Lightout(); CodingRTB.ResumeLayout();
            }
        }

        /// <summary>
        /// Setting new THEORETICAL problem text and start code
        /// </summary>
        /// <param name="problemName"></param>
        private void setCurrentProblem(string problemName)
        {
            currentProblemName = problemName; currentPracticeProblemName = "escape";
            string currentProblem = problemText[0]; ProblemRTB.Text = "";
            switch (currentProblemName)
            {
                default:
                    readProblem(currentProblemName);
                    readCode(currentProblemName);
                    OKButton.Enabled = true;
                    break;
                case "Basics":
                    ProblemRTB.Text = startStringRus; OKButton.Enabled = false; CodingRTB.Text = "";
                    break;
                case "DataTypes":
                    ProblemRTB.Text = startStringRus; OKButton.Enabled = false; CodingRTB.Text = "";
                    break;
                case "OOP":
                    ProblemRTB.Text = startStringRus; OKButton.Enabled = false; CodingRTB.Text = "";
                    break;
                case "SimplestOperations":
                    ProblemRTB.Text = startStringRus; OKButton.Enabled = false; CodingRTB.Text = "";
                    break;
                case "IfConstruction":
                    ProblemRTB.Text = startStringRus; OKButton.Enabled = false; CodingRTB.Text = "";
                    break;
                case "Loops":
                    ProblemRTB.Text = startStringRus; OKButton.Enabled = false; CodingRTB.Text = "";
                    break;
                case "Arrays":
                    ProblemRTB.Text = startStringRus; OKButton.Enabled = false; CodingRTB.Text = "";
                    break;
                case "Recursion":
                    ProblemRTB.Text = startStringRus; OKButton.Enabled = false; CodingRTB.Text = "";
                    break;
            }
            isCodeChecked = false; OKButton.Text = "Готово"; ResultsTB.Text = "0";
            rankLabel.Visible = false;
        }

        /// <summary>
        /// Setting new PRACTICAL problem text and start code
        /// </summary>
        /// <param name="practiceName"></param>
        private void setCurrentPracticeProblem(string practiceName)
        {
            currentPracticeProblemName = practiceName; currentProblemName = "escape"; 
            ProblemRTB.Text = "";
            readPracticeProblem(practiceName); readPracticeStartCode(practiceName);
        }
        
        /// <summary>
        /// Leave the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemExit_Click(object sender, EventArgs e)
        {
            this.Close(); Application.Exit();
        }

        // switching on/off the syntax lightout
        private void lightOutSettingItem_Click(object sender, EventArgs e)
        {
            setCodeLighout(!isCodeLighted);
            if (getCodeLightout())
            {
                text_Lightout();
            }
            else
            {
                int length = CodingRTB.TextLength; int lastPos = CodingRTB.SelectionStart;
                CodingRTB.SelectionStart = 0; CodingRTB.SelectionLength = length; CodingRTB.SelectionColor = Color.Black;
                CodingRTB.SelectionStart = lastPos; CodingRTB.SelectionLength = 0;
            }
        }

        //  reading next problem
        public void readProblem(string nameOfProblem)
        {
            string currentProblem = problemText[0]; ProblemRTB.Text = ""; int i = 0; 
            while (currentProblem != nameOfProblem)
            {
                i++; currentProblem = problemText[i];
            }
            i++;
            while (problemText[i] != "!")
            {
                ProblemRTB.Text += problemText[i] + "\n"; i++;
            }
            var task = Regex.Match(ProblemRTB.Text, "Задание:");
            if (task.Success)
            {
                ProblemRTB.Select(task.Index, task.Length); ProblemRTB.SelectionColor = Color.Crimson;
                ProblemRTB.SelectionLength = 0;
            }
        }

        //  reading next PRACTICAL problem
        public void readPracticeProblem(string nameOfPracticeProblem)
        {
            string currentProblem = practiceText[0]; ProblemRTB.Text = ""; int i = 0;
            while (currentProblem != nameOfPracticeProblem)
            {
                i++; currentProblem = practiceText[i];
            }
            i++;
            while (practiceText[i] != "!")
            {
                ProblemRTB.Text += practiceText[i] + "\n"; i++;
            }
            var task = Regex.Match(ProblemRTB.Text, "Задание:");
            if (task.Success)
            {
                ProblemRTB.Select(task.Index, task.Length); ProblemRTB.SelectionColor = Color.Crimson;
                ProblemRTB.SelectionLength = 0;
            }
        }

        /// <summary>
        /// reading start code to the current THEORETICAL task
        /// </summary>
        /// <param name="nameOfProblem"></param>
        public void readCode(string nameOfProblem)
        {
            string currentCode = codesText[0]; CodingRTB.Text = ""; int i = 0;
            while (currentCode != nameOfProblem)
            {
                i++; currentCode = codesText[i];
            }
            i++;
            while (codesText[i] != "!")
            {
                CodingRTB.Text += codesText[i] + "\n"; i++;
            }
        }

        /// <summary>
        /// Reading start code to the current PRACTICAL task
        /// </summary>
        /// <param name="nameOfTask"></param>
        public void readPracticeStartCode(string nameOfTask)
        {
            string currentCode = tasksText[0]; CodingRTB.Text = ""; int i = 0;
            while (currentCode != nameOfTask)
            {
                i++; currentCode = tasksText[i];
            }
            i++;
            while (tasksText[i] != "!")
            {
                CodingRTB.Text += tasksText[i] + "\n"; i++;
            }
        }

        /// <summary>
        /// Come to the next theme in DataTreeView
        /// </summary>
        /// <param name="nameOfTheCurrentTheme"></param>
        private void nextTheme(string nameOfTheCurrentTheme)
        {
            if (currentPracticeProblemName == "escape")
            {
                Interpreter.nextTheme(currentProblemName);
                setCurrentProblem(currentProblemName);
            }
            else
            {
                Interpreter.nextTheme(currentPracticeProblemName);
                setCurrentPracticeProblem(currentPracticeProblemName);
            }
            if (isCodeLighted)
            {
                CodingRTB.SuspendLayout(); text_Lightout(); CodingRTB.ResumeLayout();
            }
        }

        /// <summary>
        /// Selection of a PRACTICAL problem from the treeView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PracticeTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            currentPracticeProblemName = PracticeTreeView.SelectedNode.Name;
            currentProblemName = "escape";
            switch (currentPracticeProblemName)
            {
                default:
                    readPracticeProblem(currentPracticeProblemName);
                    readPracticeStartCode(currentPracticeProblemName);
                    if (isCodeLighted)
                    {
                        text_Lightout();
                    }
                    OKButton.Enabled = true;
                    break;
                case "LinearAlgs":
                    ProblemRTB.Text = practiceStringRus; OKButton.Enabled = false; CodingRTB.Text = "";
                    break;
                case "ConditionalAlgs":
                    ProblemRTB.Text = practiceStringRus; OKButton.Enabled = false; CodingRTB.Text = "";
                    break;
                case "LoopAlgs":
                    ProblemRTB.Text = practiceStringRus; OKButton.Enabled = false; CodingRTB.Text = "";
                    break;
                case "Methods":
                    ProblemRTB.Text = practiceStringRus; OKButton.Enabled = false; CodingRTB.Text = "";
                    break;
                case "Arrays":
                    ProblemRTB.Text = practiceStringRus; OKButton.Enabled = false; CodingRTB.Text = "";
                    break;
                case "RecursiveAlgs":
                    ProblemRTB.Text = practiceStringRus; OKButton.Enabled = false; CodingRTB.Text = "";
                    break;
                case "":
                    break;
            }
            isCodeChecked = false; OKButton.Text = "Готово"; ResultsTB.Text = "0";
            rankLabel.Visible = false;
        }

        /// <summary>
        /// Exit the application as soon as the form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Showing the form with programming language chosen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CPusPlusForm_Shown(object sender, EventArgs e)
        {
            switch (StartForm.Language)
            {
                default:
                    //  C++ language
                    break;
                //  Java language
                case "Java":
                    ProblemRTB.Text = JavaStartStringRus;
                    codesText = File.ReadAllLines("javacodes.dat"); problemNumber = 0;
                    CodingRTB.Text = "";
                    //  Theory block forming
                    TheoryTreeView.Nodes.Clear();
                    TreeNode Beginning = new TreeNode("Основы языка Java"); Beginning.Name = "Beginning";
                    TreeNode Datatypes = new TreeNode("Типы данных"); Datatypes.Name = "Datatypes";
                    TreeNode Algorythms = new TreeNode("Алгоритмические конструкции"); Algorythms.Name = "Algorythms";
                    //  inside Beginning
                    TreeNode AboutJava = new TreeNode("Что такое Java?"); AboutJava.Name = "AboutJava";
                    TreeNode JavaAlphabet = new TreeNode("Алфавит языка Java"); JavaAlphabet.Name = "JavaAlphabet";
                    TreeNode JavaSyntax = new TreeNode("Синтаксис языка Java"); JavaSyntax.Name = "JavaSyntax";
                    TreeNode JavaGrammar = new TreeNode("Семантика языка Java"); JavaGrammar.Name = "JavaGrammar";
                    Beginning.Nodes.Add(AboutJava); Beginning.Nodes.Add(JavaAlphabet); Beginning.Nodes.Add(JavaSyntax);
                    Beginning.Nodes.Add(JavaGrammar);
                    //  inside Datatypes
                    TreeNode JavaValueTypes = new TreeNode("Типы значений"); JavaValueTypes.Name = "JavaValueTypes";
                    Datatypes.Nodes.Add(JavaValueTypes);
                    TreeNode JLogicalType = new TreeNode("Логический тип"); JLogicalType.Name = "JLogicalType";
                    TreeNode JIntegerTypes = new TreeNode("Типы целых чисел"); JIntegerTypes.Name = "JIntegerTypes";
                    TreeNode JRealTypes = new TreeNode("Типы вещественных чисел"); JRealTypes.Name = "JRealTypes";
                    TreeNode JCharType = new TreeNode("Тип символов"); JCharType.Name = "JCharType";
                    JavaValueTypes.Nodes.Add(JLogicalType); JavaValueTypes.Nodes.Add(JIntegerTypes); 
                    JavaValueTypes.Nodes.Add(JRealTypes); JavaValueTypes.Nodes.Add(JCharType);
                    //  inside Algorythms
                    TreeNode JLinearAlgs = new TreeNode("Линейные алгоритмы"); JLinearAlgs.Name = "JLinearAlgs";
                    TreeNode JConditionalAlgs = new TreeNode("Разветвляющиеся алгоритмы"); JConditionalAlgs.Name = "JConditionalAlgs";
                    Algorythms.Nodes.Add(JLinearAlgs); Algorythms.Nodes.Add(JConditionalAlgs);
                    TreeNode [] treeNodes = {Beginning, Datatypes, Algorythms};
                    TheoryTreeView.Nodes.AddRange(treeNodes);

                    //  Practice block forming
                    PracticeTreeView.Nodes.Clear();
                    TreeNode NumericTask = new TreeNode("Вычисление значения числового выражения");
                    NumericTask.Name = "NumericTask";
                    TreeNode LogicalTask = new TreeNode("Определение истинности логического выражения");
                    LogicalTask.Name = "LogicalTask";
                    PracticeTreeView.Nodes.Add(NumericTask); PracticeTreeView.Nodes.Add(LogicalTask);
                    
                    keywords.Clear();
                    keywords.Add("public"); keywords.Add("static"); keywords.Add("final"); keywords.Add("class");
                    keywords.Add("void"); keywords.Add("new"); keywords.Add("short"); keywords.Add("int"); keywords.Add("long");
                    keywords.Add("float"); keywords.Add("double"); keywords.Add("boolean"); keywords.Add("char");
                    if (isCodeLighted)
                    {
                        CodingRTB.SuspendLayout();
                        text_Lightout();
                        CodingRTB.ResumeLayout();
                    }
                    CodingRTB.SelectionStart = CodingRTB.Find("{") + 2; CodingRTB.SelectionLength = 0;
                    ResultsTB.Text = "0";
                    problemText = File.ReadAllLines("javaproblems.dat");
                    rankLabel.Visible = false;
                    OKButton.Enabled = false;
                    break;
            }
        }
    }
}
