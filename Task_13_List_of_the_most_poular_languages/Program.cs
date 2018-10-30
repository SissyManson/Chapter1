using System;

namespace Task_13_List_of_the_most_poular_languages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here's a list of the most popular programming languages (and their differences with) and C# ");
            //tons of info in the interner. I'll do it short as heck (:

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Java");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Java is an Object-Oriented, general-purpose programming language and class-based. Developers can use the principal – “write once, run anywhere” with Java.");
            Console.ResetColor();




            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Python");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Python is an open - source, general - purpose programming language that powers websites such as YouTube, Reddit, Pinterest, and Instagram." + Environment.NewLine + "Python was one of the first technology stacks Google used to develop its search engine with.It's one of the most popular languages today, which finds excellent use in recent development trends such as machine learning.");
            Console.ResetColor();



            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("C++");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("C++ programmers generally focus on applications that work directly with hardware or that need better performance than other languages can offer. C++ programs include server-side applications, networking, gaming, and even device drivers for your PC. C# is generally used for web, mobile and desktop applications.");
            Console.ResetColor();
        }
    }
}
