namespace C__Demo
{
    internal class HypotenuseExample
    {
        public void FindHypotenuse()
        {
            Console.WriteLine("Enter the length of the first side: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of the second side: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            double hypotenuse = Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));
            Console.WriteLine("The length of the hypotenuse is: " + hypotenuse);
        }
    }
}
