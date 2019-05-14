namespace Interpreter
{
    partial class StartForm
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
            this.CPlusPlusButton = new System.Windows.Forms.Button();
            this.JavaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CPlusPlusButton
            // 
            this.CPlusPlusButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CPlusPlusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CPlusPlusButton.Location = new System.Drawing.Point(213, 176);
            this.CPlusPlusButton.Name = "CPlusPlusButton";
            this.CPlusPlusButton.Size = new System.Drawing.Size(169, 23);
            this.CPlusPlusButton.TabIndex = 0;
            this.CPlusPlusButton.Text = "C++";
            this.CPlusPlusButton.UseVisualStyleBackColor = false;
            this.CPlusPlusButton.Click += new System.EventHandler(this.CPlusPlusButton_Click);
            // 
            // JavaButton
            // 
            this.JavaButton.Location = new System.Drawing.Point(213, 205);
            this.JavaButton.Name = "JavaButton";
            this.JavaButton.Size = new System.Drawing.Size(169, 23);
            this.JavaButton.TabIndex = 1;
            this.JavaButton.Text = "Java";
            this.JavaButton.UseVisualStyleBackColor = true;
            this.JavaButton.Click += new System.EventHandler(this.JavaButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 276);
            this.Controls.Add(this.JavaButton);
            this.Controls.Add(this.CPlusPlusButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi Language Interpreter 1.0.0.1(beta)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CPlusPlusButton;
        private System.Windows.Forms.Button JavaButton;
    }
}