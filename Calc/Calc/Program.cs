using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[,] priorityArr = { 
            //                        {"(","0"},
            //                        {")","1"},
            //                        {"+","2"},
            //                        {"-","2"},
            //                        {"*","3"},
            //                        {"/","3"},
            //                        };

            //string[,] priorityArr = {   {"(",")","+","-","*","/"},
            //                            {"0","1","2","2","3","3"}
            //                        };

            string operationSymbols = "()+-*/";

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("HELLOW THIS IS A STRING CALC :)");
            Console.ResetColor();

            string inputStr;
            Console.WriteLine();
            //Console.Write("10+(20-5)*2+1");
            inputStr = Console.ReadLine();

            string[] inputArr;
            int curentStecIndex=0,curentArrIndex=0;
            inputArr=new string[inputStr.Length];//Необходима оптимизация

            string tmp = "";
            foreach (char item in inputStr)
            {
                if (operationSymbols.Contains(item))
                {
                    if (tmp != "") { inputArr[curentStecIndex] = tmp; curentStecIndex++; }
                    tmp = "";
                    inputArr[curentStecIndex] = ""+item; 
                    curentStecIndex++;
                }
                else tmp += item;
            }
            //Последний символ
            inputArr[curentStecIndex] = tmp; 
            curentStecIndex++;


            //Переводим в Обратную польскую запись (Дейкстpа)
            //http://algolist.manual.ru/syntax/revpn.php

            string[] stecArr=new string[curentStecIndex];
            string[] outArr = new string[curentStecIndex];

            int curOperationPriority=0;

            curentStecIndex=0;
            curentArrIndex=0;
            foreach (string item in inputArr)
            {
                if (item == null) break;
                if (operationSymbols.Contains(item))
                {
                    //а) если стек пуст, то опеpация из входной стpоки пеpеписывается в стек;
                    //в) если очеpедной символ из исходной стpоки есть откpывающая скобка, то он пpоталкивается в стек;
                    if (curentStecIndex == 0 || item == "(")
                    {
                        //stecArr[curentStecIndex++] = item;
                    }
                    else
                    {
                        //г) закpывающая кpуглая скобка выталкивает все опеpации из стека до ближайшей откpывающей скобки, сами скобки в выходную стpоку не пеpеписываются, а уничтожают дpуг дpуга. 
                        if (item == ")")
                        {
                            for (int i = curentStecIndex - 1; i >= 0; i--)
                            {
                                if (stecArr[i] == "(") { curentStecIndex=i; break; }// до ближайшей откpывающей скобки
                                
                                outArr[curentArrIndex++] = stecArr[i];
                                curentStecIndex--;
                            }

                        }
                        else
                        {
                            //б) опеpация выталкивает из стека все опеpации с большим или pавным пpиоpитетом в выходную стpоку;

                            curOperationPriority = Program.GetSymbolPriority(item);
                            //operationPriority = Program.GetSymbolPriority(stecArr[curentStecIndex-1]);

                            for (int i = curentStecIndex - 1; i >= 0 && curOperationPriority <= Program.GetSymbolPriority(stecArr[i]); i--)
                            {
                                outArr[curentArrIndex++] = stecArr[i];
                                curentStecIndex--;

                                //operationPriority = Program.GetSymbolPriority(stecArr[i-1]);
                            }
                        }
                    }

                    //Записываем опперацию в стек
                    if(item !=")" ) stecArr[curentStecIndex++] = item;
                }
                else
                {
                    //Операнд в выходной массив
                    outArr[curentArrIndex] = item;
                    curentArrIndex++;
                }
            }
            //Запишем все стоковые команды в выходную строку
            for (int i = curentStecIndex - 1; i >= 0 ; i--)
            {
                outArr[curentArrIndex++] = stecArr[i];
                curentStecIndex--;

            }


            //Распечатаем Обратную польскую запись
            Console.WriteLine();
            foreach (string item in outArr)
            {
                Console.Write("\t" + item);
            }

            //Произведем вычисления
            curentArrIndex = 0;
            double arg1=0, arg2=0;
            foreach (string item in outArr)
            {
                if (item == null)
                {
                    break;
                }
                if (operationSymbols.Contains(item))
                {
                    for (int i = curentArrIndex - 1; i >= 0; i--)
                    {
                        if (outArr[i].Trim() != "") 
                        {
                            arg1 = Convert.ToDouble(outArr[i]);
                            outArr[i] = "";
                            break; 
                        }
                    }

                    for (int i = curentArrIndex - 1; i >= 0; i--)
                    {
                        if (outArr[i].Trim() != "")
                        {
                            arg2 = Convert.ToDouble(outArr[i]);
                            outArr[i] = "";
                            break;
                        }
                    }
                

                    double rezalt=0;
                    switch (item)
                    {
                        case "+": rezalt = arg1 + arg2; break;
                        case "-": rezalt = arg2 - arg1; break;
                        case "*": rezalt = arg2 * arg1; break;
                        case "/": rezalt = arg2 / arg1; break;
                    }

                    //Запишем результат
                    outArr[curentArrIndex] = rezalt.ToString();
                    
                }
                curentArrIndex++;
            }
            Console.WriteLine("\nRezalt=" + outArr[curentArrIndex - 1]);
        }

        static int GetSymbolPriority(string Symbol)
        {
            string[,] priorityArr = {   {"(",")","+","-","*","/"},
                                        {"0","1","2","2","3","3"}
                                    };

            int position = 0;
            for (int i = 0; i < priorityArr.GetLength(1); i++)
            {
                if (Symbol == priorityArr[0, i])
                {
                    position = i;
                    break;
                }
            }
            return Convert.ToInt32(priorityArr[1,position]);
        }
    }
}
