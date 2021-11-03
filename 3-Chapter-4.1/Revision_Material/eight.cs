using System;
namespace CSharpWork
{
    public class Eight
    {
        public Eight()
        {
            int one = IntPrompt();
            int two = IntPrompt();

            for (int i = 0; i < 17; i++)
            {
                one += 13;
                two += 13;
            }

            if (one > two)
            {
                double total = Math.Pow(one, 3);
                Console.WriteLine(total);
            } else
            {
                double total = Math.Pow(one + two, 2);
                Console.WriteLine(total);
            }
        }

        static int IntPrompt()
        {
            Console.WriteLine("Enter an integer:");
            return int.Parse(Console.ReadLine());
        }
    }
}
