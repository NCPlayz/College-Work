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

            if (one > two && one > three)
            {
                Output(one + " is biggest");
            }
            else if (two > one && two > three)
            {
                Output(two + " is biggest");
            }
            else if (three > one && three > two)
            {
                Output(three + " is biggest");
            }
            else
            {
                Output("All the numbers are the same.");
            }
        }

        static void Output(string value)
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
