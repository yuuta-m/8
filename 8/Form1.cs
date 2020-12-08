using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_7;

namespace _8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа №8. Бороненкова Дария, гр.ИСП - 31.\n" +
                "Создать интерфейс – фигура (площадь, периметр).\n" +
                "Создать классы - прямоугольник, круг.\n" +
                "Классы должны включать конструкторы, функцию для формирования строки информации о фигуре.\n" +
                "Сравнение производить по площади.",
                "О программе");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Lib_7.Rectangle rectangle = new Lib_7.Rectangle();
        Circle circle = new Circle();

        private void задатьСтороныПрямоугольникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(A.Text, out int a) && Int32.TryParse(B.Text, out int b))
                if (a > 0 && b > 0)
                {
                    rectangle.a = a;
                    rectangle.b = b;
                }
                else
                {
                    MessageBox.Show("Введите положительное число", "Ошибка");
                }
            else
            {
                MessageBox.Show("Введите число", "Ошибка");
            }
        }

        private void очиститьСтороныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A.Clear();
            B.Clear();
        }

        private void рассчитатьПериметрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            perRectangle.Text = rectangle.Perimetr().ToString();
        }

        private void рассчитатьПлощадьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            areaRectangle.Text = rectangle.Area().ToString();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A.Clear();
            B.Clear();
            perRectangle.Clear();
            areaRectangle.Clear();
        }

        private void вывестиИнформациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoRectangle.Text = rectangle.Print();
        }

        private void клонироватьИнформациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lib_7.Rectangle rectangle2 = (Lib_7.Rectangle)rectangle.Clone();
            infoRectangleClone.Text = rectangle2.Print();
        }

        private void очиститьИнформациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoRectangle.Clear();
            infoRectangleClone.Clear();
        }

        private void задатьСтороныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(R.Text, out int r))
                if (r > 0 )
                {
                    circle.r = r;
                }
                else
                {
                    MessageBox.Show("Введите положительное число", "Ошибка");
                }
            else
            {
                MessageBox.Show("Введите число", "Ошибка");
            }
        }

        private void рассчитатьПериметрToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            perCircle.Text = circle.Perimetr().ToString();
        }

        private void рассчитатьПлощадьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            areaCircle.Text = circle.Area().ToString();
        }

        private void очиститьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            R.Clear();
            perCircle.Clear();
            areaCircle.Clear();
        }

        private void вывестиИнформациюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            infoCircle.Text = circle.Print();
        }

        private void клонироватьИнформациюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Circle circle2 = (Circle)circle.Clone();
            infoCircleClone.Text = circle2.Print();
        }

        private void очиститьИнформациюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            infoCircle.Clear();
            infoCircleClone.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
