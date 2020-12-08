using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_7
{
    interface IFigure
    {
        double Area();
        double Perimetr();
    }

    interface ICloneable
    {
        object Clone();
    }

    interface IComparable
    {
        int CompareTo(object obj);
    }

}
