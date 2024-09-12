using System;

namespace C__Demo
{

    class EnumDemo
    {
        public void DisplayDays()
        {
            foreach (Days day in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine(day + " is number " + ((int)day + 1));
            }
        }
    }
    public enum Days
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
}