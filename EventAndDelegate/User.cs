using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegate
{
    public delegate string Mydelegate(string name);
    internal class User
    {

        public string AccpetName(string name)
        {
            name = name.ToUpper();
            return name;
        }
        public string ConvertLower(string str)
        {
            str = str.ToLower();
            return str;
        }

    }
}