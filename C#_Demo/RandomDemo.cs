using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Demo
{
    using System;

    class RandomDemo
    {
        public void GenerateRandomNumbers()
        {
            Random random = new Random();

            // Generate a random integer between 1 and 10
            int randomNumber = random.Next(1, 11);
            Console.WriteLine(randomNumber);

            //random decimal
            double randomDecimal = random.NextDouble();
            Console.WriteLine(randomDecimal);

            // Generate a random boolean value
            bool randomBoolean = random.Next(2) == 0;
            Console.WriteLine(randomBoolean);
        }
    }

}
