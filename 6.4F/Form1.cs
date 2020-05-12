using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._4F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int[][] Input()
        {
            Random rnd = new Random();
            int n = int.Parse(N.Text);
            int[][] a = new int[n][];
            for (int i = 0; i < n; ++i)
            {
                a[i] = new int[n];
                for (int j = 0; j < n; ++j)
                {
                    a[i][j] = rnd.Next(-2, 2);
                }
            }
            return a;
        }

        private void Print1(int[] a)
        {
            V.Text += Environment.NewLine;
            for (int i = 0; i < a.Length; ++i)
                V.Text += a[i] + "  ";
        }

        private void Print2(int[][] a)
        {
            V.Text += Environment.NewLine;
            for (int i = 0; i < a.Length; ++i, V.Text += Environment.NewLine)
                for (int j = 0; j < a[i].Length; ++j)
                    V.Text +=  a[i][j] + "  ";
        }

        private int Otric(int[] a)
        {
            int j= -5;
            for (int i = 0; i < a.Length; ++i)
                
                if (a[i] < 0) {j = i; break; }
            return j;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                V.Text = "";
                int[][] mas = Input();
                V.Text += "Исходный массив:";
                V.Text += Environment.NewLine;
                Print2(mas);
                int[] rez = new int[mas.Length];
                for (int i = 0; i < mas.Length; ++i)
                    rez[i] = Otric(mas[i]);
                V.Text += Environment.NewLine;
                V.Text += "Новый массив: ";
                Print1(rez);
            }
            catch
            {
                V.Text += "Неккоректные данные";
            }
        }
    }
}
