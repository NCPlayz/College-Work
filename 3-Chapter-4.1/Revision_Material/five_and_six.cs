using System;
namespace CSharpWork
{
    public class Five
    {
        public Five()
        {
            string one = Prompt();
            string two = Prompt();
            string three = Prompt();

            string value = Largest(one, two, three);
            Output(value);
        }

        private static string Largest(string one, string two, string three)
        {
            int one_len = one.Length;
            int two_len = two.Length;
            int three_len = three.Length;
            if (one_len > two_len && one_len > three_len)
            {
                return one;
            }
            else if (two_len > one_len && two_len > three_len)
            {
                return two;
            }
            else if (three_len > one_len && three_len > two_len)
            {
                return three;
            }
            else
            {
                return "";
            }
        }

        static void Output(string value)
        {
            Console.WriteLine(value);
        }

        static string Prompt()
        {
            Console.WriteLine("Enter a prompt:");
            return Console.ReadLine();
        }
    }
}
