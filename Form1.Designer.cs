namespace Laba5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.matrix1Button = new System.Windows.Forms.Button();
            this.matrix2Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SumButton = new System.Windows.Forms.Button();
            this.randCheckBox1 = new System.Windows.Forms.CheckBox();
            this.randCheckBox2 = new System.Windows.Forms.CheckBox();
            this.scalarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "n = ";
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(44, 10);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(100, 20);
            this.nTextBox.TabIndex = 1;
            this.nTextBox.Leave += new System.EventHandler(this.nTextBox_Leave);
            // 
            // matrix1Button
            // 
            this.matrix1Button.Location = new System.Drawing.Point(16, 48);
            this.matrix1Button.Name = "matrix1Button";
            this.matrix1Button.Size = new System.Drawing.Size(128, 23);
            this.matrix1Button.TabIndex = 2;
            this.matrix1Button.Text = "Ввод матрицы 1 …";
            this.matrix1Button.UseVisualStyleBackColor = true;
            this.matrix1Button.Click += new System.EventHandler(this.matrix1Button_Click);
            // 
            // matrix2Button
            // 
            this.matrix2Button.Location = new System.Drawing.Point(16, 77);
            this.matrix2Button.Name = "matrix2Button";
            this.matrix2Button.Size = new System.Drawing.Size(128, 23);
            this.matrix2Button.TabIndex = 3;
            this.matrix2Button.Text = "Ввод матрицы 2 …";
            this.matrix2Button.UseVisualStyleBackColor = true;
            this.matrix2Button.Click += new System.EventHandler(this.matrix2Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(16, 106);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(260, 23);
            this.multiplyButton.TabIndex = 6;
            this.multiplyButton.Text = "Умножить";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(16, 197);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(260, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Сохранить в файле “Res_Matr.txt";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // SumButton
            // 
            this.SumButton.Location = new System.Drawing.Point(16, 135);
            this.SumButton.Name = "SumButton";
            this.SumButton.Size = new System.Drawing.Size(260, 23);
            this.SumButton.TabIndex = 8;
            this.SumButton.Text = "Сложить";
            this.SumButton.UseVisualStyleBackColor = true;
            this.SumButton.Click += new System.EventHandler(this.SumButton_Click);
            // 
            // randCheckBox1
            // 
            this.randCheckBox1.AutoSize = true;
            this.randCheckBox1.Location = new System.Drawing.Point(193, 53);
            this.randCheckBox1.Name = "randCheckBox1";
            this.randCheckBox1.Size = new System.Drawing.Size(73, 17);
            this.randCheckBox1.TabIndex = 9;
            this.randCheckBox1.Text = "Случайно";
            this.randCheckBox1.UseVisualStyleBackColor = true;
            this.randCheckBox1.CheckedChanged += new System.EventHandler(this.randCheckBox1_CheckedChanged);
            // 
            // randCheckBox2
            // 
            this.randCheckBox2.AutoSize = true;
            this.randCheckBox2.Location = new System.Drawing.Point(193, 82);
            this.randCheckBox2.Name = "randCheckBox2";
            this.randCheckBox2.Size = new System.Drawing.Size(73, 17);
            this.randCheckBox2.TabIndex = 10;
            this.randCheckBox2.Text = "Случайно";
            this.randCheckBox2.UseVisualStyleBackColor = true;
            this.randCheckBox2.CheckedChanged += new System.EventHandler(this.randCheckBox2_CheckedChanged);
            // 
            // scalarButton
            // 
            this.scalarButton.Location = new System.Drawing.Point(16, 164);
            this.scalarButton.Name = "scalarButton";
            this.scalarButton.Size = new System.Drawing.Size(260, 23);
            this.scalarButton.TabIndex = 11;
            this.scalarButton.Text = "Скалярно умножить";
            this.scalarButton.UseVisualStyleBackColor = false;
            this.scalarButton.Click += new System.EventHandler(this.scalarButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 246);
            this.Controls.Add(this.scalarButton);
            this.Controls.Add(this.randCheckBox2);
            this.Controls.Add(this.randCheckBox1);
            this.Controls.Add(this.SumButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.matrix2Button);
            this.Controls.Add(this.matrix1Button);
            this.Controls.Add(this.nTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор матриц";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.Button matrix2Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button saveButton;
        public System.Windows.Forms.Button matrix1Button;
        private System.Windows.Forms.Button SumButton;
        private System.Windows.Forms.CheckBox randCheckBox1;
        private System.Windows.Forms.CheckBox randCheckBox2;
        private System.Windows.Forms.Button scalarButton;
    }
}

