using System;
namespace CSharpWork
{
    public class Four
    {
        public Four()
        {
            int one = IntPrompt();
            int two = IntPrompt();
            int three = IntPrompt();

            int value = Largest(one, two, three);
            Output(value);
        }

        private static int Largest(int one, int two, int three)
        {
            if (one > two && one > three)
            {
                return one;
            }
            else if (two > one && two > three)
            {
                return two;
            }
            else if (three > one && three > two)
            {
                return three;
            }
            else
            {
                return 0;
            }
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
