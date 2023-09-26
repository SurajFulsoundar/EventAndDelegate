using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User u1 = new User();
            Mydelegate mydelegate = new Mydelegate(u1.AccpetName);
            mydelegate += new Mydelegate(u1.ConvertLower);
            Delegate[] list = mydelegate.GetInvocationList();
            foreach (Delegate d in list)
            {
                Console.WriteLine(d.Method);
                string result = Convert.ToString(d.DynamicInvoke("sUrAj"));
                Console.WriteLine(result);
            }
        }
    }
}
