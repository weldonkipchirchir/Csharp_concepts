using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Demo
{
    internal class StringMethods
    {
        public void StringMethodsDemo()
        {
            //assign a variable to areadline
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            //string concatenation
            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
            Console.WriteLine("Hello " + fullName);

            //to uppercase and lowercase
            string uppercase = fullName.ToUpper();
            Console.WriteLine(uppercase);
            string lowercase = fullName.ToLower();
            Console.WriteLine(lowercase);

            //string comparison
            string name1 = "John";
            string name2 = "john";
            if (name1 == name2)
            {
                Console.WriteLine("The names are the same.");
            }
            else
            {
                Console.WriteLine("The names are different.");
            }

            // replace
            string sentence = "Hello, World!";
            string newSentence = sentence.Replace("World", "C#");
            Console.WriteLine(newSentence);

            //insert
            string greeting = "Hello";
            string greetingWithSpace = greeting.Insert(5, "y");
            Console.WriteLine(greetingWithSpace);

            //substring
            string text = "Hello, World!";
            string subText = text.Substring(7, 5);
            Console.WriteLine(subText);
        }
    }
}
