using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Interpreter
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        public static string Language = "";

        //  open Form with C++ programming language course
        private void CPlusPlusButton_Click(object sender, EventArgs e)
        {
            CPusPlusForm CPlusPlusForm = new CPusPlusForm();
            Language = "CPlusPlus";
            CPlusPlusForm.Show();
            this.Hide();
        }

        //  open Form with Java programming language course
        private void JavaButton_Click(object sender, EventArgs e)
        {
            CPusPlusForm CPlusPlusForm = new CPusPlusForm();
            Language = "Java";
            CPlusPlusForm.Show();
            this.Hide();
        }
    }
}
