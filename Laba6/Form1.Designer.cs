namespace Laba6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(288, 124);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Введите слово";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Вывести найденные предложения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(337, 13);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(183, 124);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "Введите текст";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(337, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Исправить запятые";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(565, 12);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(183, 124);
            this.richTextBox3.TabIndex = 5;
            this.richTextBox3.Text = "Мерсер А. Д. – 192 см – 90 кг\nДжеймс Х. Х. – 178 см – 90 кг\nКарен П. Р. – 170 см " +
    "– 65 кг";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(565, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Рост превашет 190 см";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(765, 13);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(243, 124);
            this.richTextBox4.TabIndex = 7;
            this.richTextBox4.Text = resources.GetString("richTextBox4.Text");
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(765, 140);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(243, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Найти количество предлогов \"не\"";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 292);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Button button4;
    }
}

