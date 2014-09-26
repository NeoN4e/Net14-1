using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank[] banks = new Bank[3];
            Console.WriteLine("Балансы филиалов");
            for (int i = 0; i < banks.Length; i++)
            {
                banks[i] = new Bank();
                Console.WriteLine("{0} филиал = {1}", i + 1, banks[i].CurrentBalance);
            }
            
            banks[1].GetMoney(10000);
            banks[2].SetMoney(40000);
            Bank.SetBalance(banks);
            Console.WriteLine(Bank.GetBalance());
                     
        }
    }
   
    class Bank
    {
        static double balance;
        double currentBalance;
   
        static Bank()
        {
            balance = 1000000;
        }

        public static double GetBalance()
        {
            return balance;
        }

        public static void SetBalance(Bank[] obj)
        {
            foreach (Bank b in obj)
            {
                balance += b.currentBalance;
            }

        }

        public static void SetBalance(double s)
        {
            balance -= s;
        }

        public Bank()
        {
            this.currentBalance = GetBalance() / 10;
            SetBalance(currentBalance);
        }

        public void GetMoney(double s)
        {
            if (currentBalance >= s)
            {
                currentBalance -= s;

            }
            else
            {
                Console.WriteLine("нет возможности выдать кредит");
            }
        }

        public void SetMoney(double s)
        {
            currentBalance += s;
        }

        public double CurrentBalance
        {
            get { return currentBalance; }
        }

        //public override string ToString()
        //{
        //    return base.ToString();
        //}

    }


}
