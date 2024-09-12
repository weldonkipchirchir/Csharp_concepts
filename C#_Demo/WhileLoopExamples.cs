using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Demo
{
    internal class WhileLoopExamples
    {
        public void WhileLoopExample()
        {
            Console.WriteLine("What is your name?");

            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name);

            while (name == "")
            {
                Console.WriteLine("What is your name?");
                name = Console.ReadLine();
                Console.WriteLine("Hello " + name);
            }
        }
    }
}
