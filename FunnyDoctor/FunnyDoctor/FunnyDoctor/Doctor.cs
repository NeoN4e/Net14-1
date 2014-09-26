using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyDoctor
{

    class Doctor
    {
        /// <summary>элемент Журнала посещений</summary>
        struct JournalItem 
        {
            Patient P;
            string Diagnoz;

            public JournalItem (Patient p, string diagnoz)
            {
                this.P      = p;
                this.Diagnoz=diagnoz;
            }

            public override string ToString()
            {
                return String.Format("[{0} {1}]",this.P,this.Diagnoz); ;
            }

        }

        /// <summary>журнал посещений доктора</summary>
        List<JournalItem> Journal = new List<JournalItem>();

        /// <summary>Заполнение журнала посещений</summary>
        private void JournalAdd(Patient P, string Diagnoz)
        {
            this.Journal.Add(new JournalItem(P,Diagnoz));
        }

         ///<summary>Прописать таблетку</summary>
        private bool GiveTablet(Patient P)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(P.FIO + " Принял таблетку");
            Console.ResetColor();

            JournalAdd(P, "Температура");
            P["Температура"] = true;
            return true;
        }

        ///<summary>Прописать микстуру</summary>
        private bool GiveMixture(Patient P)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(P.FIO + " Выпил микстуру");
            Console.ResetColor();

            JournalAdd(P, "Живот");
            P["Живот"] = true;
            return true;
        }

        ///<summary>Наложить гипс</summary>
        private bool Gips(Patient P)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Наложил Гипс");
            Console.ResetColor();

            JournalAdd(P, "Перелом");
            P["Перелом"] = true;
            return true;
        }


        /// <summary>Осмотреть и назначить лечение</summary>
        /// <returns>Делегат все процедуры лечения</returns>
        public HealProcedure Osmotr(Patient P)
        {

            HealProcedure Heal = null;//пустой делегат

            foreach (var item in P)
            {
                if (item.Value == false)
                {
                    switch (item.Key)
                    {
                        case "Температура": Heal += GiveTablet; break;
                        case "Перелом": Heal += Gips; break;
                        case "Живот": Heal += GiveMixture; break;

                        default: Heal += null; break;
                    }
                }

            }

            return Heal;
        }

        public void PrintReport()
        {
            foreach(var item in this.Journal)
                Console.WriteLine(item);
        }

    }

}
