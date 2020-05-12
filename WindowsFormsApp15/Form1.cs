using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[,] Input(out int n, out int m)
        {
            n = int.Parse(Nn.Text);
            m = int.Parse(Mm.Text);
            int[,] a = new int[n, m];
            Random rand = new Random();
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                {   
                    a[i, j] = rand.Next(-100, 200);
                }
            return a;
        }

        public void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i)
            {
                for (int j = 0; j < a.GetLength(1); ++j)
                    mas.Text += a[i, j] + " ";
                mas.Text += Environment.NewLine;
            }
        }


        public void Rezalt(int[,] a)
        {
            int count = 0;

            for (int i = 0; i < a.GetLength(0); ++i)
            {
                bool plus = true;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] < 0)
                    {
                        plus = false;
                        break;
                    }
                }
                if (plus)
                    count = 1;
            }
            if (count == 1) rez.Text=Convert.ToString("Строка, состоящая только из положительных элементов есть");
            else rez.Text = Convert.ToString("Такой строки нет");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n, m;
                int[,] myArray = Input(out n, out m);
                Print(myArray);
                Rezalt(myArray);
            }
            catch { rez.Text = Convert.ToString("Некорректный ввод!");
                mas.Clear();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nn.Clear();
            rez.Clear();
            Mm.Clear();
            mas.Clear();
        }
    }
}
