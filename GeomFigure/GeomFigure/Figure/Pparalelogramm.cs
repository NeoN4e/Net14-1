using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomFigure
{
    /// <summary> Прямоугольник </summary>
    class Paralelogramm : Figure
    {
        /// <summary>
        /// Паралелограм
        /// </summary>
        /// <param name="side1">1-я Сторона</param>
        /// <param name="side2">2-я Сторона</param>
        /// <param name="angle">Угол между сторонами</param>
        public Paralelogramm(double side1, double side2, int angle)
        {
            if (angle >= 180) throw new RectangleExeption("Недопустимое значение угла");
            
            this.Angle = angle;
            
            this.SideLenght = new double[2];
            this.SideLenght[0] = side1;
            this.SideLenght[1] = side2;
        }

        //a*b*sin l
        public override double Area
        {
            get { return this.SideLenght[0] * this.SideLenght[1] * Math.Sin(Math.PI/180*this.Angle); }
        }

        public override double Perimeter
        {
            get { return 2 * this.SideLenght[0] + 2 * this.SideLenght[1]; }
        }

        public override string ToString()
        {
            return string.Format("Паралелограм (1-я Сторона={0},2-я Сторона={1},Угол={2})", this.SideLenght[0], this.SideLenght[1],this.Angle);
        }

        public double mArea()
        { return this.Area; }

        public double mPerimeter()
        { return this.Perimeter; }
    }

    class RectangleExeption : ApplicationException
    {
        public RectangleExeption(String msg)
            :base(msg)
        {}
    }
}
