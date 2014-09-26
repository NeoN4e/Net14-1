using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyDoctor
{
    delegate bool HealProcedure(Patient P);

    class Program
    {
        static void Main(string[] args)
        {

            HealProcedure Heal;//Делегат, рекомендации доктора по лечению недуга

            //инициализация докторов
            Doctor House = new Doctor();
            Doctor Aibolit = new Doctor();
                //инициализация друга(студента медика)
                Friend Lobanov = new Friend();

            //инициализация пациентов
            Patient p1 = new Patient() { FIO="Иванов"};
            Patient p2 = new Patient() { FIO="Петров"};

            //Коллекция пациентов
            List<Patient> pList = new List<Patient>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(new Patient() { FIO = "Сидоров" });
            pList.Add(new Patient() { FIO = "Васьев" });

            #region переберем пациентов
                foreach (var item in pList)
                {
                    //На экран состояние больного
                    item.PrintStatus();

                    //Если еть проблеммы со здовьем идем к доктору
                    if (item.isBed() == true)
                    {
                        //Выбираем к кому обратиться к Другу или Врачу
                        if (BoolRandom.GenRandStatus())
                        {
                            
                            //идем к 1-му из 2-х докторов
                            if (BoolRandom.GenRandStatus())
                            {
                                Console.WriteLine("\nИдем на осмотр к доктору Хаусу");
                                Heal = House.Osmotr(item);
                            }
                            else
                            {
                                Console.WriteLine("\nИдем на осмотр к доктору Айболиту");
                                Heal = Aibolit.Osmotr(item);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Идем на осмотр к другу");
                            Heal = Lobanov.Osmotr(item);
                        }
                        //Выполняем предписания доктора
                        Heal(item);

                        //Посмотрим результат
                        
                        Console.WriteLine("\n<Состояние после лечения>");
                        item.PrintStatus();
                     
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Абсолютно здоров");
                        Console.ResetColor();
                    }


                    //Разделитель
                    Console.WriteLine("---------------------------\n\n");

                }
                 #endregion
        
            #region Отчеты докторов
                Console.WriteLine("\n\nОтчет доктора Хауса:");
                House.PrintReport();

                Console.WriteLine("\n\nОтчет доктора Айболита:");
                Aibolit.PrintReport();
            #endregion
        }
    }


}
