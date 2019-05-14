namespace Interpreter
{
    partial class CPusPlusForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Что такое С++?");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Алфавит языка C++");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Синтаксис языка С++");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Семантика языка С++");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Основы языка C++", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Типы значений");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Типы ссылок");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Тип указателей");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Структура типов данных", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Логический тип");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Целые числа без знака");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Целые числа со знаком");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Вещественные числа");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Символы");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Фундаментальные типы", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Классы");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Структуры");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Объединения");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Классы, структуры, объединения", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Типы данных", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode15,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Отрицание");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Конъюнкция и дизъюнкция");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Импликация и эквиваленция");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Сумма по модулю 2");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Сравнение объектов разных типов");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Логические операции", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Инкремент и декремент");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Арифметические операции");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Методы библиотеки <math.h>");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Операции с числами", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28,
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Управляющие последовательности");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Методы библиотеки <ctype.h>");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Операции с символами", new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode32});
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Простейшие операции", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode30,
            treeNode33});
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Проверка истинности условия");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Проверка ложности условия");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Проверка 2 и более условий");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Тривиальный выбор", new System.Windows.Forms.TreeNode[] {
            treeNode35,
            treeNode36,
            treeNode37});
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Проверка многих условий");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Условие по умолчанию");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Множественный выбор", new System.Windows.Forms.TreeNode[] {
            treeNode39,
            treeNode40});
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Разветвляющиеся алгоритмы", new System.Windows.Forms.TreeNode[] {
            treeNode38,
            treeNode41});
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Конструкция цикла");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Возможные типы счетчика");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Вложенные циклы");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Цикл со счетчиком", new System.Windows.Forms.TreeNode[] {
            treeNode43,
            treeNode44,
            treeNode45});
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Конструкция цикла");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Цикл с ложным условием");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Цикл с предусловием", new System.Windows.Forms.TreeNode[] {
            treeNode47,
            treeNode48});
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Конструкция цикла");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Цикл с ложным условием");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Цикл с постусловием", new System.Windows.Forms.TreeNode[] {
            treeNode50,
            treeNode51});
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Циклические алгоритмы", new System.Windows.Forms.TreeNode[] {
            treeNode46,
            treeNode49,
            treeNode52});
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("Правила инициализации");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("Тип возвращаемого значения");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("Аргументы функции");
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("Функции", new System.Windows.Forms.TreeNode[] {
            treeNode54,
            treeNode55,
            treeNode56});
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("Правила инициализации");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("Основное отличие от функций");
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("Аргументы процедуры");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("Процедуры", new System.Windows.Forms.TreeNode[] {
            treeNode58,
            treeNode59,
            treeNode60});
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("Функции и процедуры", new System.Windows.Forms.TreeNode[] {
            treeNode57,
            treeNode61});
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("Линейные массивы");
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("Многомерные массивы");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("Простые структуры данных", new System.Windows.Forms.TreeNode[] {
            treeNode63,
            treeNode64});
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("Что такое рекурсия?");
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("Пример рекурсивной функции");
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("Хвостовая рекурсия");
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("Приближение функции синуса");
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("Рекурсивные алгоритмы", new System.Windows.Forms.TreeNode[] {
            treeNode66,
            treeNode67,
            treeNode68,
            treeNode69});
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("Вычисление значения выражения");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("Линейные алгоритмы", new System.Windows.Forms.TreeNode[] {
            treeNode71});
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("Принадлежность точки прямой");
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("Разветвляющиеся алгоритмы", new System.Windows.Forms.TreeNode[] {
            treeNode73});
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("Циклические алгоритмы");
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("Возведение в квадрат");
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("Возведение в степень");
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("Расстояние между точками");
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("Двоичная СС");
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("Произвольная СС");
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("Процедуры и функции", new System.Windows.Forms.TreeNode[] {
            treeNode76,
            treeNode77,
            treeNode78,
            treeNode79,
            treeNode80});
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("Сумма элементов");
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("Сумма четных элементов");
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("Реверс массива");
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("Простые структуры данных", new System.Windows.Forms.TreeNode[] {
            treeNode82,
            treeNode83,
            treeNode84});
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("Быстрая сортировка");
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("Рекурсивные алгоритмы", new System.Windows.Forms.TreeNode[] {
            treeNode86});
            this.CodingRTB = new System.Windows.Forms.RichTextBox();
            this.TheoryTreeView = new System.Windows.Forms.TreeView();
            this.OKButton = new System.Windows.Forms.Button();
            this.ProblemRTB = new System.Windows.Forms.RichTextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.itemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.языкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.русскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polskiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подсветкаСинтаксисаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightOutSettingItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.руководствоПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ResultsTB = new System.Windows.Forms.TextBox();
            this.ProblemsDataSet = new System.Data.DataSet();
            this.rankLabel = new System.Windows.Forms.Label();
            this.TaskBoxLabel = new System.Windows.Forms.Label();
            this.CodingBlockLabel = new System.Windows.Forms.Label();
            this.TheoryPartLabel = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.PracticeTreeView = new System.Windows.Forms.TreeView();
            this.ProblemPartLabel = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProblemsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // CodingRTB
            // 
            this.CodingRTB.AcceptsTab = true;
            this.CodingRTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CodingRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CodingRTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CodingRTB.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CodingRTB.ForeColor = System.Drawing.Color.Black;
            this.CodingRTB.Location = new System.Drawing.Point(271, 293);
            this.CodingRTB.Name = "CodingRTB";
            this.CodingRTB.Size = new System.Drawing.Size(597, 299);
            this.CodingRTB.TabIndex = 0;
            this.CodingRTB.Text = "";
            this.CodingRTB.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.CodingRTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            // 
            // TheoryTreeView
            // 
            this.TheoryTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TheoryTreeView.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheoryTreeView.FullRowSelect = true;
            this.TheoryTreeView.HideSelection = false;
            this.TheoryTreeView.Location = new System.Drawing.Point(12, 45);
            this.TheoryTreeView.Name = "TheoryTreeView";
            treeNode1.Name = "Beginning";
            treeNode1.Tag = "Beginning";
            treeNode1.Text = "Что такое С++?";
            treeNode2.Name = "Alphabet";
            treeNode2.Tag = "Alphabet";
            treeNode2.Text = "Алфавит языка C++";
            treeNode3.Name = "Syntax";
            treeNode3.Tag = "Syntax";
            treeNode3.Text = "Синтаксис языка С++";
            treeNode4.Name = "Grammar";
            treeNode4.Tag = "Grammar";
            treeNode4.Text = "Семантика языка С++";
            treeNode5.Name = "Basics";
            treeNode5.Tag = "Basics";
            treeNode5.Text = "Основы языка C++";
            treeNode6.Name = "ValueTypes";
            treeNode6.Text = "Типы значений";
            treeNode7.Name = "ReferenceTypes";
            treeNode7.Text = "Типы ссылок";
            treeNode8.Name = "PointerType";
            treeNode8.Text = "Тип указателей";
            treeNode9.Name = "StructureOfDatatypes";
            treeNode9.Tag = "StructureOfDatatypes";
            treeNode9.Text = "Структура типов данных";
            treeNode10.Name = "Boolean";
            treeNode10.Text = "Логический тип";
            treeNode11.Name = "UInteger";
            treeNode11.Text = "Целые числа без знака";
            treeNode12.Name = "Integer";
            treeNode12.Text = "Целые числа со знаком";
            treeNode13.Name = "FloatType";
            treeNode13.Text = "Вещественные числа";
            treeNode14.Name = "Chars";
            treeNode14.Text = "Символы";
            treeNode15.Name = "FundamentalTypes";
            treeNode15.Tag = "FundamentalTypes";
            treeNode15.Text = "Фундаментальные типы";
            treeNode16.Name = "Classes";
            treeNode16.Text = "Классы";
            treeNode17.Name = "Structs";
            treeNode17.Text = "Структуры";
            treeNode18.Name = "Unions";
            treeNode18.Text = "Объединения";
            treeNode19.Name = "ClassesStructsUnions";
            treeNode19.Text = "Классы, структуры, объединения";
            treeNode20.Name = "DataTypes";
            treeNode20.Tag = "DataTypes";
            treeNode20.Text = "Типы данных";
            treeNode21.Name = "Negation";
            treeNode21.Text = "Отрицание";
            treeNode22.Name = "ConjunctionAndDisjunction";
            treeNode22.Text = "Конъюнкция и дизъюнкция";
            treeNode23.Name = "ImplicationAndEquivalention";
            treeNode23.Text = "Импликация и эквиваленция";
            treeNode24.Name = "Xor";
            treeNode24.Text = "Сумма по модулю 2";
            treeNode25.Name = "ObjectsOfDifferentTypes";
            treeNode25.Text = "Сравнение объектов разных типов";
            treeNode26.Name = "LogicalOperations";
            treeNode26.Text = "Логические операции";
            treeNode27.Name = "IncDec";
            treeNode27.Text = "Инкремент и декремент";
            treeNode28.Name = "Ariphmetics";
            treeNode28.Text = "Арифметические операции";
            treeNode29.Name = "MathClass";
            treeNode29.Text = "Методы библиотеки <math.h>";
            treeNode30.Name = "NumbersOperations";
            treeNode30.Text = "Операции с числами";
            treeNode31.Name = "ControlSymbols";
            treeNode31.Text = "Управляющие последовательности";
            treeNode32.Name = "CtypeFunctions";
            treeNode32.Text = "Методы библиотеки <ctype.h>";
            treeNode33.Name = "CharOperations";
            treeNode33.Text = "Операции с символами";
            treeNode34.Name = "SimplestOperations";
            treeNode34.Text = "Простейшие операции";
            treeNode35.Name = "CheckTruth";
            treeNode35.Text = "Проверка истинности условия";
            treeNode36.Name = "CheckFalse";
            treeNode36.Text = "Проверка ложности условия";
            treeNode37.Name = "AddConditions";
            treeNode37.Text = "Проверка 2 и более условий";
            treeNode38.Name = "ChoiceFromTwo";
            treeNode38.Text = "Тривиальный выбор";
            treeNode39.Name = "SwitchOperator";
            treeNode39.Text = "Проверка многих условий";
            treeNode40.Name = "DefaultCase";
            treeNode40.Text = "Условие по умолчанию";
            treeNode41.Name = "SwitchConstruction";
            treeNode41.Text = "Множественный выбор";
            treeNode42.Name = "IfConstruction";
            treeNode42.Text = "Разветвляющиеся алгоритмы";
            treeNode43.Name = "ForDefinition";
            treeNode43.Text = "Конструкция цикла";
            treeNode44.Name = "CounterTypes";
            treeNode44.Text = "Возможные типы счетчика";
            treeNode45.Name = "NestedLoops";
            treeNode45.Text = "Вложенные циклы";
            treeNode46.Name = "ForConstruction";
            treeNode46.Text = "Цикл со счетчиком";
            treeNode47.Name = "WhileDefinition";
            treeNode47.Text = "Конструкция цикла";
            treeNode48.Name = "FalseCondition";
            treeNode48.Text = "Цикл с ложным условием";
            treeNode49.Name = "WhileConstruction";
            treeNode49.Text = "Цикл с предусловием";
            treeNode50.Name = "DoWhileDefinition";
            treeNode50.Text = "Конструкция цикла";
            treeNode51.Name = "DoWhileFalseCondition";
            treeNode51.Text = "Цикл с ложным условием";
            treeNode52.Name = "DoWhileConstruction";
            treeNode52.Text = "Цикл с постусловием";
            treeNode53.Name = "Loops";
            treeNode53.Text = "Циклические алгоритмы";
            treeNode54.Name = "FuncInit";
            treeNode54.Text = "Правила инициализации";
            treeNode55.Name = "ReturnType";
            treeNode55.Text = "Тип возвращаемого значения";
            treeNode56.Name = "FuncArgs";
            treeNode56.Text = "Аргументы функции";
            treeNode57.Name = "Functions";
            treeNode57.Text = "Функции";
            treeNode58.Name = "ProcInit";
            treeNode58.Text = "Правила инициализации";
            treeNode59.Name = "VoidReturn";
            treeNode59.Text = "Основное отличие от функций";
            treeNode60.Name = "ProcArgs";
            treeNode60.Text = "Аргументы процедуры";
            treeNode61.Name = "Procedures";
            treeNode61.Text = "Процедуры";
            treeNode62.Name = "ProceduresFunctions";
            treeNode62.Text = "Функции и процедуры";
            treeNode63.Name = "LinearArrays";
            treeNode63.Text = "Линейные массивы";
            treeNode64.Name = "Matrixes";
            treeNode64.Text = "Многомерные массивы";
            treeNode65.Name = "Arrays";
            treeNode65.Text = "Простые структуры данных";
            treeNode66.Name = "WhatIsRecursion";
            treeNode66.Text = "Что такое рекурсия?";
            treeNode67.Name = "ExampleOfRF";
            treeNode67.Text = "Пример рекурсивной функции";
            treeNode68.Name = "TailRecursion";
            treeNode68.Text = "Хвостовая рекурсия";
            treeNode69.Name = "TailorsSeries";
            treeNode69.Text = "Приближение функции синуса";
            treeNode70.Name = "Recursion";
            treeNode70.Text = "Рекурсивные алгоритмы";
            this.TheoryTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode20,
            treeNode34,
            treeNode42,
            treeNode53,
            treeNode62,
            treeNode65,
            treeNode70});
            this.TheoryTreeView.Size = new System.Drawing.Size(253, 245);
            this.TheoryTreeView.TabIndex = 1;
            this.TheoryTreeView.TabStop = false;
            this.TheoryTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.BackColor = System.Drawing.Color.ForestGreen;
            this.OKButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OKButton.Location = new System.Drawing.Point(742, 604);
            this.OKButton.MinimumSize = new System.Drawing.Size(60, 21);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(126, 33);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "Готово";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ProblemRTB
            // 
            this.ProblemRTB.BackColor = System.Drawing.SystemColors.Window;
            this.ProblemRTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProblemRTB.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProblemRTB.Location = new System.Drawing.Point(271, 45);
            this.ProblemRTB.Name = "ProblemRTB";
            this.ProblemRTB.ReadOnly = true;
            this.ProblemRTB.Size = new System.Drawing.Size(482, 220);
            this.ProblemRTB.TabIndex = 3;
            this.ProblemRTB.Text = "";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemFile,
            this.itemSettings,
            this.itemHelp,
            this.itemExit});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(880, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // itemFile
            // 
            this.itemFile.Name = "itemFile";
            this.itemFile.Size = new System.Drawing.Size(48, 20);
            this.itemFile.Text = "Файл";
            // 
            // itemSettings
            // 
            this.itemSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.языкToolStripMenuItem,
            this.подсветкаСинтаксисаToolStripMenuItem,
            this.видToolStripMenuItem});
            this.itemSettings.Name = "itemSettings";
            this.itemSettings.Size = new System.Drawing.Size(79, 20);
            this.itemSettings.Text = "Настройки";
            // 
            // языкToolStripMenuItem
            // 
            this.языкToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.русскийToolStripMenuItem,
            this.englishToolStripMenuItem,
            this.polskiToolStripMenuItem});
            this.языкToolStripMenuItem.Name = "языкToolStripMenuItem";
            this.языкToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.языкToolStripMenuItem.Text = "Язык";
            // 
            // русскийToolStripMenuItem
            // 
            this.русскийToolStripMenuItem.Name = "русскийToolStripMenuItem";
            this.русскийToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.русскийToolStripMenuItem.Text = "Русский";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.englishToolStripMenuItem.Text = "English";
            // 
            // polskiToolStripMenuItem
            // 
            this.polskiToolStripMenuItem.Name = "polskiToolStripMenuItem";
            this.polskiToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.polskiToolStripMenuItem.Text = "Polski";
            // 
            // подсветкаСинтаксисаToolStripMenuItem
            // 
            this.подсветкаСинтаксисаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightOutSettingItem});
            this.подсветкаСинтаксисаToolStripMenuItem.Name = "подсветкаСинтаксисаToolStripMenuItem";
            this.подсветкаСинтаксисаToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.подсветкаСинтаксисаToolStripMenuItem.Text = "Подсветка синтаксиса";
            // 
            // lightOutSettingItem
            // 
            this.lightOutSettingItem.Name = "lightOutSettingItem";
            this.lightOutSettingItem.Size = new System.Drawing.Size(199, 22);
            this.lightOutSettingItem.Text = "Отключить подстветку";
            this.lightOutSettingItem.Click += new System.EventHandler(this.lightOutSettingItem_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // itemHelp
            // 
            this.itemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.руководствоПользователяToolStripMenuItem});
            this.itemHelp.Name = "itemHelp";
            this.itemHelp.Size = new System.Drawing.Size(65, 20);
            this.itemHelp.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // руководствоПользователяToolStripMenuItem
            // 
            this.руководствоПользователяToolStripMenuItem.Name = "руководствоПользователяToolStripMenuItem";
            this.руководствоПользователяToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.руководствоПользователяToolStripMenuItem.Text = "Руководство пользователя";
            // 
            // itemExit
            // 
            this.itemExit.Name = "itemExit";
            this.itemExit.Size = new System.Drawing.Size(53, 20);
            this.itemExit.Text = "Выход";
            this.itemExit.Click += new System.EventHandler(this.itemExit_Click);
            // 
            // ResultsTB
            // 
            this.ResultsTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultsTB.BackColor = System.Drawing.SystemColors.MenuText;
            this.ResultsTB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ResultsTB.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultsTB.ForeColor = System.Drawing.SystemColors.Window;
            this.ResultsTB.Location = new System.Drawing.Point(759, 45);
            this.ResultsTB.MinimumSize = new System.Drawing.Size(70, 70);
            this.ResultsTB.Multiline = true;
            this.ResultsTB.Name = "ResultsTB";
            this.ResultsTB.ReadOnly = true;
            this.ResultsTB.Size = new System.Drawing.Size(109, 220);
            this.ResultsTB.TabIndex = 5;
            // 
            // ProblemsDataSet
            // 
            this.ProblemsDataSet.DataSetName = "Problems";
            // 
            // rankLabel
            // 
            this.rankLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rankLabel.AutoSize = true;
            this.rankLabel.BackColor = System.Drawing.Color.Transparent;
            this.rankLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rankLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.rankLabel.Location = new System.Drawing.Point(313, 610);
            this.rankLabel.Name = "rankLabel";
            this.rankLabel.Size = new System.Drawing.Size(423, 19);
            this.rankLabel.TabIndex = 6;
            this.rankLabel.Text = "Решение верно! Нажмите \"Далее\" для продолжения";
            // 
            // TaskBoxLabel
            // 
            this.TaskBoxLabel.AutoSize = true;
            this.TaskBoxLabel.BackColor = System.Drawing.Color.Transparent;
            this.TaskBoxLabel.ForeColor = System.Drawing.Color.White;
            this.TaskBoxLabel.Location = new System.Drawing.Point(271, 27);
            this.TaskBoxLabel.Name = "TaskBoxLabel";
            this.TaskBoxLabel.Size = new System.Drawing.Size(119, 15);
            this.TaskBoxLabel.TabIndex = 7;
            this.TaskBoxLabel.Text = "Текущее задание:";
            // 
            // CodingBlockLabel
            // 
            this.CodingBlockLabel.AutoSize = true;
            this.CodingBlockLabel.BackColor = System.Drawing.Color.Transparent;
            this.CodingBlockLabel.ForeColor = System.Drawing.Color.White;
            this.CodingBlockLabel.Location = new System.Drawing.Point(271, 275);
            this.CodingBlockLabel.Name = "CodingBlockLabel";
            this.CodingBlockLabel.Size = new System.Drawing.Size(112, 15);
            this.CodingBlockLabel.TabIndex = 8;
            this.CodingBlockLabel.Text = "Решение задачи:";
            // 
            // TheoryPartLabel
            // 
            this.TheoryPartLabel.AutoSize = true;
            this.TheoryPartLabel.BackColor = System.Drawing.Color.Transparent;
            this.TheoryPartLabel.ForeColor = System.Drawing.Color.White;
            this.TheoryPartLabel.Location = new System.Drawing.Point(12, 27);
            this.TheoryPartLabel.Name = "TheoryPartLabel";
            this.TheoryPartLabel.Size = new System.Drawing.Size(147, 15);
            this.TheoryPartLabel.TabIndex = 9;
            this.TheoryPartLabel.Text = "Теоретическая часть:";
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.BackColor = System.Drawing.Color.Transparent;
            this.OutputLabel.ForeColor = System.Drawing.Color.White;
            this.OutputLabel.Location = new System.Drawing.Point(756, 27);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(91, 15);
            this.OutputLabel.TabIndex = 10;
            this.OutputLabel.Text = "Окно вывода:";
            // 
            // PracticeTreeView
            // 
            this.PracticeTreeView.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PracticeTreeView.Location = new System.Drawing.Point(12, 308);
            this.PracticeTreeView.Name = "PracticeTreeView";
            treeNode71.Name = "Evaluation";
            treeNode71.Text = "Вычисление значения выражения";
            treeNode72.Name = "LinearAlgs";
            treeNode72.Text = "Линейные алгоритмы";
            treeNode73.Name = "PointAndLine";
            treeNode73.Text = "Принадлежность точки прямой";
            treeNode74.Name = "ConditionalAlgs";
            treeNode74.Text = "Разветвляющиеся алгоритмы";
            treeNode75.Name = "LoopAlgs";
            treeNode75.Text = "Циклические алгоритмы";
            treeNode76.Name = "InSquarePow";
            treeNode76.Text = "Возведение в квадрат";
            treeNode77.Name = "InNthPow";
            treeNode77.Text = "Возведение в степень";
            treeNode78.Name = "DistanceBetweenPoints";
            treeNode78.Text = "Расстояние между точками";
            treeNode79.Name = "ToBinaryNumberSystem";
            treeNode79.Text = "Двоичная СС";
            treeNode80.Name = "ToAnyNumberSystem";
            treeNode80.Text = "Произвольная СС";
            treeNode81.Name = "Methods";
            treeNode81.Text = "Процедуры и функции";
            treeNode82.Name = "SumOfElements";
            treeNode82.Text = "Сумма элементов";
            treeNode83.Name = "SumOfEvenElements";
            treeNode83.Text = "Сумма четных элементов";
            treeNode84.Name = "ArrayReverse";
            treeNode84.Text = "Реверс массива";
            treeNode85.Name = "Arrays";
            treeNode85.Text = "Простые структуры данных";
            treeNode86.Name = "ArrayQuickSort";
            treeNode86.Text = "Быстрая сортировка";
            treeNode87.Name = "RecursiveAlgs";
            treeNode87.Text = "Рекурсивные алгоритмы";
            this.PracticeTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode72,
            treeNode74,
            treeNode75,
            treeNode81,
            treeNode85,
            treeNode87});
            this.PracticeTreeView.Size = new System.Drawing.Size(253, 329);
            this.PracticeTreeView.TabIndex = 11;
            this.PracticeTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.PracticeTreeView_AfterSelect);
            // 
            // ProblemPartLabel
            // 
            this.ProblemPartLabel.AutoSize = true;
            this.ProblemPartLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProblemPartLabel.ForeColor = System.Drawing.Color.White;
            this.ProblemPartLabel.Location = new System.Drawing.Point(12, 290);
            this.ProblemPartLabel.Name = "ProblemPartLabel";
            this.ProblemPartLabel.Size = new System.Drawing.Size(140, 15);
            this.ProblemPartLabel.TabIndex = 12;
            this.ProblemPartLabel.Text = "Практическая часть:";
            // 
            // CPusPlusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(880, 649);
            this.Controls.Add(this.ProblemPartLabel);
            this.Controls.Add(this.PracticeTreeView);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.TheoryPartLabel);
            this.Controls.Add(this.CodingBlockLabel);
            this.Controls.Add(this.TaskBoxLabel);
            this.Controls.Add(this.rankLabel);
            this.Controls.Add(this.ResultsTB);
            this.Controls.Add(this.ProblemRTB);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.TheoryTreeView);
            this.Controls.Add(this.CodingRTB);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "CPusPlusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interpreter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.CPusPlusForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProblemsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        public System.Windows.Forms.RichTextBox ProblemRTB;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem itemFile;
        private System.Windows.Forms.ToolStripMenuItem itemSettings;
        private System.Windows.Forms.ToolStripMenuItem языкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem русскийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polskiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подсветкаСинтаксисаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemHelp;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem руководствоПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemExit;
        private System.Windows.Forms.ToolStripMenuItem lightOutSettingItem;
        public System.Windows.Forms.RichTextBox CodingRTB;
        public System.Windows.Forms.TextBox ResultsTB;
        private System.Data.DataSet ProblemsDataSet;
        private System.Windows.Forms.Label rankLabel;
        private System.Windows.Forms.Label TaskBoxLabel;
        private System.Windows.Forms.Label CodingBlockLabel;
        private System.Windows.Forms.Label TheoryPartLabel;
        private System.Windows.Forms.Label OutputLabel;
        public System.Windows.Forms.TreeView TheoryTreeView;
        private System.Windows.Forms.Label ProblemPartLabel;
        public System.Windows.Forms.TreeView PracticeTreeView;

    }
}

