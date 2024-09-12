using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Demo
{
    internal class TypeCasting
    {
        static double a = 3.14;

        //or
        static int c = Convert.ToInt32(a);

        //convert int to string
        static string b = Convert.ToString(c);

        //convert string to int
        static int d = Convert.ToInt32(b);

    }
}