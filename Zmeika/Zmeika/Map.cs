using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeika
{
    class Map
    {
        /// <summary>Поле по которому двигаеться змейка</summary>
        char[,] field;
        Zmeya zmeya;

        void OnZmeyMove(Zmeya.Point p)
        { 
            //Выход за пределы
            if (p.X >= field.GetLength(0) || p.X >= field.GetLength(1)) throw new ApplicationException("Выход за пределы поля");

            //Преграда
            if (this.field[p.X, p.Y] != '\0') throw new ApplicationException("Преграда");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="size">Размер поля</param>
        /// <param name="Z">Змея которая на поле</param>
        public Map(Zmeya z,int size = 10)
        {
            this.field = new Char[size, size];
            this.zmeya = z;
            z.OnMove += OnZmeyMove;
        }

        public char this[int x,int y]
        {
            get { return this.field[x, y]; }
            set { this.field[x, y] = value; }
        }

        public void print()
        {

            Console.Write(new string('#',field.GetLength(0) +2));
            //string border = "";
            //border = border.PadLeft(field.GetLength(0) * 2,'#');

            //Строки
            for (int i = 0; i < field.GetLength(0); i++)
            {
                Console.Write("\n#");
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    //Если в текущей клетке змея нарисуем её
                    if(zmeya.exist(j,i))
                    { Console.Write("*"); }
                    else
                        Console.Write(field[i, j]);
                }

                Console.Write("#");
            }
            Console.WriteLine();
            Console.Write(new string('#', field.GetLength(0) +2));
            Console.WriteLine();
        }

    }
}
