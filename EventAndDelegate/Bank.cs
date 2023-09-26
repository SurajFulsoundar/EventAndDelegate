using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegate
{
    public delegate void Bankdelegate();
    public class Bank
    {
        public event Bankdelegate insuf;
        public event Bankdelegate LowBal;
        public event Bankdelegate ZeroBal;
        private double balance;
        // private double defaultbalance;

        public Bank(double balance)
        {

            this.balance = balance;

        }
        public void credit(double CAmt)
        {
            balance = balance + CAmt;

        }
        public void Debit(double DAmt)
        {
            balance = balance - DAmt;
            if (balance < DAmt)
            {
                insuf();
            }
            else if (balance < 3000)
            {
                LowBal();
            }
            else if (balance == 0)
            {
                ZeroBal();
            }
        }


    }
    public class BankRun
    {
        static void Main(string[] args)
        {
            try
            {
                Bank b = new Bank(2000);
                b.insuf += delegate { Console.WriteLine("your balance is insufficient"); };
                b.ZeroBal += delegate { Console.WriteLine("you have zero balance"); };
                b.LowBal += delegate { Console.WriteLine("you have low balance"); };
                b.credit(100);
                b.Debit(10000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}