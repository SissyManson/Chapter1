using System;

namespace Task_10_First_100_parts_i_guess
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 103; i++)
            {
                if (i % 2 == 0) Console.WriteLine(i);
                else Console.Write("-{0}", i);
            }
        }
    }
}
