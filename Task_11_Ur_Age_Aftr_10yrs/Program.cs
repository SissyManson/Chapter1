using System;

namespace Task_11_Ur_Age_Aftr_10yrs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine()); //int.Parse - for converting a string to number
            Console.WriteLine("Your age after 10 years will be {0}", age + 10);
        }
    }
}
