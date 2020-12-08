using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_7
{
    public class Rectangle : IFigure, ICloneable
    {
        public int a
        {  get; set; }//Свойство 1й стороны
        public int b
        {  get; set; }//Свойство 2й стороны

        public double Perimetr()
        {
            return (a + b) * 2;

        }

        public double Area()
        {
            return a * b;
        }

        public string Print()
        {
            return "Сторона А: " + a + " , " + "сторона В: " + b + " , " + "Периметр: " + ((a + b) * 2) + " , " + "Площадь: " + (a * b);
        }

        public object Clone()
        {
            Rectangle r = new Rectangle
            {
                a = this.a,
                b = this.b
            };
            return r;
        }
    }

    public class Circle : IFigure, ICloneable
    {
        const double P = 3.14; //Число π
        public int r { get; set;} //Радиус

        public double Perimetr()
        {
            return 2 * P * r;
        }

        public double Area()
        {
            return P * (r * r);
        }

        public string Print()
        {
            return "Радиус " + r + " , " + "Периметр: " + (2 * P * r) + " , " + "Площадь: " + (P * (r * r));
        }

        public object Clone()
        {
            Circle c = new Circle
            {
                r = this.r
            };
            return c;
        }
    }
}
