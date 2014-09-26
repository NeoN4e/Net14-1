using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeika
{
    delegate void MyEventDelegate(Zmeya.Point P);

    class Zmeya
    {
        /// <summary>Направление движения</summary>
        MoveVektor vektor = MoveVektor.Right;

        public class Point : IEquatable<Point>
        {
            public int X {get; private set;}
            public int Y {get; private set;}
            
            public Point(int x,int y)
            {
                this.X=x;
                this.Y=y;
            }

            public bool Equals(Point p)
            {
                if (this.X == p.X && this.Y == p.Y) return true;
                else return false;
            }
        }

        /// <summary>Координаты частей тела змейки</summary>
        List<Point> Position = new List<Point>();

        public Zmeya()
        {
            Position.Add(new Point(0, 0));
            Position.Add(new Point(1, 0));
        }

        /// <summary>Проверяем есть ли кусок змеи по заданным координатам</summary>
        public bool exist(int x, int y)
        {
            return Position.Contains(new Point(x,y));
        }

        
        public event MyEventDelegate OnMove;

        /// <summary> Движение змейки</summary>
        public void move()
        {
            this.Position.Remove(this.Position[0]); //Удалим последнюю позицию

            Point HeadPoint = this.Position[this.Position.Count -1];
            Point newPosition;
            switch (this.vektor)
            {
                case MoveVektor.Right:  newPosition = new Point(HeadPoint.X + 1,     HeadPoint.Y     ); break;
                case MoveVektor.Down:   newPosition = new Point(HeadPoint.X,         HeadPoint.Y + 1 ); break;
                case MoveVektor.Left:   newPosition = new Point(HeadPoint.X - 1,     HeadPoint.Y     ); break;
                default:                newPosition = new Point(HeadPoint.X,         HeadPoint.Y - 1 ); break;
            }

            Position.Add(newPosition);
            if (OnMove != null) OnMove(newPosition);
        }

    }

    //Направление движения
    enum MoveVektor { Right,Down,Left,Top}
}
