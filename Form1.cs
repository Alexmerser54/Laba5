using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba6
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word = textBox1.Text;
            string text = richTextBox1.Text;
            string[] separator = new string[] { ". " };
            string[] sentences = text.Split(separator, StringSplitOptions.None);
            bool flag = false;
            richTextBox1.Text = "";
            foreach (var sentence in sentences)
            {
                flag = false;
                foreach (var item in sentence.Split(' '))
                {
                    if (item.ToLower() == word.ToLower())
                    {
                        flag = true;
                    }
                }
                if (flag) richTextBox1.Text += sentence + ". ";
            }


        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pattern = @"(\s*),(\s*)";
            Regex regex = new Regex(pattern);
            string orig = richTextBox2.Text;
            richTextBox2.Text = "";
            string result = regex.Replace(orig, @", ");
            richTextBox2.Text = result;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string orig = richTextBox3.Text;
            richTextBox3.Text = "";

            Regex regex = new Regex(@"\d*\s(см)");
            Regex regex2 = new Regex(@"\d*");

            int height;
            foreach (var item in orig.Split('\n'))
            {
                string founded = regex.Match(item).ToString();
                height = Convert.ToInt32(regex2.Match(founded).ToString());
                if (height > 190) richTextBox3.Text += item + "\n";

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"(\s|)не(\s|\.)", RegexOptions.IgnoreCase);
            int count = regex.Matches(" " + richTextBox4.Text).Count;
            richTextBox4.Text = count.ToString();
        }
    }
}
