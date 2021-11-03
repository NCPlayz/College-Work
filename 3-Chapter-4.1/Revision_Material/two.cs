using System;
namespace CSharpWork
{
    public class Three
    {
        public Three()
        {
            int one = IntPrompt();
            int two = IntPrompt();
            int three = IntPrompt();

            int four = Sum(one, two, three);

            Output(four);
        }

        static int Sum(int first, int second, int third)
        {
            return first + second + third;
        }

        static void Output(int value)
        {
            Console.WriteLine(value);
        }

        static int IntPrompt()
        {
            Console.WriteLine("Enter an integer:");
            return int.Parse(Console.ReadLine());
        }
    }
}
