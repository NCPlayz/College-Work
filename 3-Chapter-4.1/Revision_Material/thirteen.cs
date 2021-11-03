using System;
using System.Collections.Generic;

namespace CSharpWork
{
    public class Thirteen
    {
        public Thirteen()
        {
            int[] one = Utils.IntPrompts(10);
            int[] two = Utils.IntPrompts(10);
            int notEqualCount = 0;

            for (int i = 0; i < 10; i++)
            {
                if (one[i] == two[i])
                {
                    notEqualCount++;
                }
            }

            Console.WriteLine(notEqualCount);


            List<int> oneList = IntListPrompt(10);
            List<int> twoList = IntListPrompt(10);

            notEqualCount = 0;

            for (int i = 0; i < 10; i++)
            {
                if (oneList[i] == twoList[i])
                {
                    notEqualCount++;
                }
            }

            Console.WriteLine(notEqualCount);
        }

        static List<int> IntListPrompt(int size = 5)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < size; i++)
            {
                list.Add(IntPrompt());
            }

            return list;
        }

        static int IntPrompt()
        {
            Console.WriteLine("Enter an integer:");
            return int.Parse(Console.ReadLine());
        }
    }
}
