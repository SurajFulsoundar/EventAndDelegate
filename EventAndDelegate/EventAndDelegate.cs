using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegate
{
    public delegate void Mydelegate1();
    public class Student
    {
        public event Mydelegate1 Fail;
        public event Mydelegate1 Pass;
        public void AcceptPer(double per)
        {
            if (per < 50)
            {
                Fail();
            }
            else
            {
                Pass();
            }
        }
    }
    public class Message
    {
        public void SucessMSG()
        {
            Console.WriteLine("You are pass in the Exam");
        }
        public void FailMSG()
        {
            Console.WriteLine("You are fail in the Exam");
        }
    }
    internal class EventProgram
    {
        static void Main(string[] args)
        {
            try
            {
                Student s1 = new Student();
                Message m1 = new Message();
                s1.Fail += new Mydelegate1(m1.FailMSG);
                s1.Pass += new Mydelegate1(m1.SucessMSG);

                /*  //Anonymous Method with Delegate
                 *  s1.Fail += delegate () { Console.WriteLine("you are fail"); };
                  s1.Pass += delegate () { Console.WriteLine("You are pass"); };*/

                s1.AcceptPer(45);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
