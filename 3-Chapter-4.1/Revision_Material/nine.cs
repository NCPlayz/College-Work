using System;
namespace CSharpWork
{
    public class Nine
    {
        public Nine()
        {
            string userString = Prompt();
            CompareLength(userString);
        }

        static void CompareLength(string str)
        {
            if (str.Length > 10)
            {
                Console.WriteLine(str + "...and I love ice cream");
            }
            else if (str.Length < 10)
            {
                Console.WriteLine(str + "...and I love chocolate brownies!");
            }
            else
            {
                Console.WriteLine("Goodbye");
            }
        }

        static string Prompt()
        {
            Console.WriteLine("Enter a phrase:");
            return Console.ReadLine();
        }
    }
}
