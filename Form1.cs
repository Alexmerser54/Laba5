using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Laba5
{
    public partial class Form1 : Form
    {

        const int MaxN = 10; // максимально допустимая размерность матрицы
        int n = 3; // текущая размерность матрицы
        TextBox[,] MatrText = null; // матрица элементов типа TextBox
        double[,] Matr1 = new double[MaxN, MaxN]; // матрица 1 чисел с плавающей точкой
        double[,] Matr2 = new double[MaxN, MaxN]; // матрица 2 чисел с плавающей точкой
        double[,] Matr3 = new double[MaxN, MaxN]; // матрица результатов
        double[,] ScalarMatr = new double[MaxN, 1];
        bool f1; // флажок, который указывает о вводе данных в матрицу Matr1
        bool f2; // флажок, который указывает о вводе данных в матрицу Matr2
        int dx = 40, dy = 20; // ширина и высота ячейки в MatrText[,]
        Form2 form2 = null;   // экземпляр (объект) класса формы Form2

        public Form1()
        {
            InitializeComponent();
        }

        private void RandomizeMatrix(double[,] matrx, int n)
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrx[i, j] = rand.Next(1, 10);
                }
            }
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (randCheckBox1.Checked) RandomizeMatrix(Matr1, n);
            if (randCheckBox2.Checked) RandomizeMatrix(Matr2, n);

            // 1. Проверка, введены ли данные в обеих матрицах
            if (!((f1 == true) && (f2 == true))) return;

            // 2. Вычисление произведения матриц. Результат в Matr3
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    Matr3[j, i] = 0;
                    for (int k = 0; k < n; k++)
                        Matr3[j, i] = Matr3[j, i] + Matr1[k, i] * Matr2[j, k];
                }

            // 3. Внесение данных в MatrText
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    // 3.1. Порядок табуляции
                    MatrText[i, j].TabIndex = i * n + j + 1;

                    // 3.2. Перевести число в строку
                    MatrText[i, j].Text = Matr3[i, j].ToString();
                }

            // 4. Вывод формы
            form2.ShowDialog();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            FileStream fw = null;
            string msg;
            byte[] msgByte = null; // байтовый массив

            // 1. Открыть файл для записи
            fw = new FileStream("Res_Matr.txt", FileMode.Create);

            // 2. Запись матрицы результата в файл
            // 2.1. Сначала записать число элементов матрицы Matr3
            msg = n.ToString() + "\r\n";
            // перевод строки msg в байтовый массив msgByte
            msgByte = Encoding.Default.GetBytes(msg);

            // запись массива msgByte в файл
            fw.Write(msgByte, 0, msgByte.Length);

            // 2.2. Теперь записать саму матрицу
            msg = "";
            for (int i = 0; i < n; i++)
            {
                // формируем строку msg из элементов матрицы
                for (int j = 0; j < n; j++)
                    msg = msg + Matr3[i, j].ToString() + "  ";
                msg = msg + "\r\n"; // добавить перевод строки
            }

            // 3. Перевод строки msg в байтовый массив msgByte
            msgByte = Encoding.Default.GetBytes(msg);

            // 4. запись строк матрицы в файл
            fw.Write(msgByte, 0, msgByte.Length);

            // 5. Закрыть файл
            if (fw != null) fw.Close();
        }

        private void matrix1Button_Click(object sender, EventArgs e)
        {
            // 1. Чтение размерности матрицы
            if (nTextBox.Text == "") return;
            n = int.Parse(nTextBox.Text);

            // 2. Обнуление ячейки MatrText
            Clear_MatrText();

            // 3. Настройка свойств ячеек матрицы MatrText
            //    с привязкой к значению n и форме Form2
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    // 3.1. Порядок табуляции
                    MatrText[i, j].TabIndex = i * n + j + 1;

                    // 3.2. Сделать ячейку видимой
                    MatrText[i, j].Visible = true;
                }

            // 4. Корректировка размеров формы
            form2.Width = 10 + n * dx + 20;
            form2.Height = 10 + n * dy + form2.button1.Height + 50;

            // 5. Корректировка позиции и размеров кнопки на форме Form2
            form2.button1.Left = 10;
            form2.button1.Top = 10 + n * dy + 10;
            form2.button1.Width = form2.Width - 30;

            // 6. Вызов формы Form2
            if (form2.ShowDialog() == DialogResult.OK)
            {
                // 7. Перенос строк из формы Form2 в матрицу Matr1
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        if (MatrText[i, j].Text != "")
                            Matr1[i, j] = Double.Parse(MatrText[i, j].Text);
                        else
                            Matr1[i, j] = 0;
                // 8. Данные в матрицу Matr1 внесены
                f1 = true;
                label2.Text = "true";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // І. Инициализация элементов управления и внутренних переменных
            nTextBox.Text = "";
            f1 = f2 = false; // матрицы еще не заполнены
            label2.Text = "false";
            label3.Text = "false";

            // ІІ. Выделение памяти и настройка MatrText
            int i, j;

            // 1. Выделение памяти для формы Form2
            form2 = new Form2();

            // 2. Выделение памяти под самую матрицу
            MatrText = new TextBox[MaxN, MaxN];

            // 3. Выделение памяти для каждой ячейки матрицы и ее настройка
            for (i = 0; i < MaxN; i++)
                for (j = 0; j < MaxN; j++)
                {
                    // 3.1. Выделить память
                    MatrText[i, j] = new TextBox();

                    // 3.2. Обнулить эту ячейку
                    MatrText[i, j].Text = "0";

                    // 3.3. Установить позицию ячейки в форме Form2
                    MatrText[i, j].Location = new System.Drawing.Point(10 + i * dx, 10 + j * dy);

                    // 3.4. Установить размер ячейки
                    MatrText[i, j].Size = new System.Drawing.Size(dx, dy);

                    // 3.5. Пока что спрятать ячейку
                    MatrText[i, j].Visible = false;

                    // 3.6. Добавить MatrText[i,j] в форму form2
                    form2.Controls.Add(MatrText[i, j]);
                }
        }


        private void matrix2Button_Click(object sender, EventArgs e)
        {
            // 1. Чтение размерности матрицы
            if (nTextBox.Text == "") return;
            n = int.Parse(nTextBox.Text);

            // 2. Обнулить ячейки MatrText
            Clear_MatrText();

            // 3. Настройка свойств ячеек матрицы MatrText
            //    с привязкой к значению n и форме Form2
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    // 3.1. Порядок табуляции
                    MatrText[i, j].TabIndex = i * n + j + 1;

                    // 3.2. Сделать ячейку видимой
                    MatrText[i, j].Visible = true;
                }

            // 4. Корректировка размеров формы
            form2.Width = 10 + n * dx + 20;
            form2.Height = 10 + n * dy + form2.button1.Height + 50;

            // 5. Корректировка позиции и размеров кнопки на форме Form2
            form2.button1.Left = 10;
            form2.button1.Top = 10 + n * dy + 10;
            form2.button1.Width = form2.Width - 30;

            // 6. Вызов формы Form2
            if (form2.ShowDialog() == DialogResult.OK)
            {
                // 7. Перенос строк из формы Form2 в матрицу Matr2
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        Matr2[i, j] = Double.Parse(MatrText[i, j].Text);

                // 8. Матрица Matr2 сформирована
                f2 = true;
                label3.Text = "true";
            }
        }

        private void nTextBox_Leave(object sender, EventArgs e)
        {
            int nn;
            nn = Int16.Parse(nTextBox.Text);
            if (nn != n)
            {
                f1 = f2 = false;
                label2.Text = "false";
                label3.Text = "false";
            }
        }

        private void SumButton_Click(object sender, EventArgs e)
        {

            if (randCheckBox1.Checked) RandomizeMatrix(Matr1, n);
            if (randCheckBox2.Checked) RandomizeMatrix(Matr2, n);

            if (!((f1 == true) && (f2 == true))) return;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Matr3[j, i] = Matr1[j, i] + Matr2[j, i];
                }
            }

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    //Порядок табуляции
                    MatrText[i, j].TabIndex = i * n + j + 1;
                    MatrText[i, j].Text = Matr3[i, j].ToString();
                }

            // 4. Вывод формы
            form2.ShowDialog();
        }

        private void randCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Clear_MatrText();
            f1 = randCheckBox1.Checked;
            label2.Text = f1 ? "true" : "false";
        }

        private void randCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            Clear_MatrText();
            f2 = randCheckBox2.Checked;
            label3.Text = f2 ? "true" : "false";
        }

        private void scalarButton_Click(object sender, EventArgs e)
        {
            if (randCheckBox1.Checked) RandomizeMatrix(Matr1, n);
            if (randCheckBox2.Checked) RandomizeMatrix(Matr2, n);

            if (!((f1 == true) && (f2 == true))) return;

            double temp = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    temp += Matr1[i, j] * Matr2[i, j];
                }
                Matr3[i, 0] = temp;
                temp = 0;
            }

          
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    MatrText[i, 0].Text = $"{i+1} ст.";
                    MatrText[i, 0].TabIndex = i * n;
                }
            }

            for (int i = n; i > n; i--)
            {

                    MatrText[i, 0].TabIndex = i * n;
                    MatrText[i, 0].Text = Matr3[i, 0].ToString();
            }


            // 4. Вывод формы
            form2.ShowDialog();
        }

        private void Clear_MatrText()
        {
            // Обнуление ячеек MatrText
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    MatrText[i, j].Text = "0";
                }
            }
        }

    }
}
