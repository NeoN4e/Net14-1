using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomFigure
{
    abstract class Figure
    {
        ///<summary> Площадь </summary>
        abstract public double Area { get; }

        ///<summary> Периметр </summary>
        abstract public double Perimeter { get;  }

        ///<summary> Угол между сторонами </summary>
        public int Angle { get; set; }

        ///<summary> Массив длин сторон </summary>
        public double[] SideLenght { get; set; }

    }

    /// <summary>Многоугольник</summary>
    interface polygon
    {
        int SideQty { get; set; }
        double Hight { get; set; }
    }
}