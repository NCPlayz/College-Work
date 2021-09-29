using System;

namespace CSharpWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task1Challenge();
            //Task2();
            //Task2Challenge();
            //Task3();
        }

        static void Task1()
        {
            int var1 = IntPrompt();
            int var2 = IntPrompt();
            int var3 = IntPrompt();
            int var4 = IntPrompt();
            int var5 = IntPrompt();

            int m = var1 * var2 * var3 * var4 * var5;
            Console.WriteLine("The total is: " + m.ToString());
        }

        static void Task1Challenge()
        {
            for (int i = 100; i < 1000; i++)
            {
                double sum = 0;

                String iAsStr = i.ToString();
                foreach (char s in iAsStr)
                {
                    sum += Math.Pow(int.Parse(s.ToString()), 3);
                }

                if (sum == i)
                {
                    Console.WriteLine(iAsStr + " is an Armstrong number.");
                }
            }
        }

        static void Task2()
        {
            int year = IntPrompt("Enter a year: ");
            String _insert = IsLeap(year) ? "" : "not";
            Console.WriteLine(year.ToString() + " is " + _insert + "a leap year");
        }

        static void Task2Challenge()
        {
            int units = IntPrompt("Enter electricity units: ");
            double cost = CalculateCost(units);
            Console.WriteLine(cost.ToString());
        }

        static void Task3()
        {
            int var1 = IntPrompt();
            int var2 = IntPrompt();
            int var3 = IntPrompt();

            if (var1 < var2 && var1 < var3)
            {
                while (var1 <= var2 || var1 <= var3)
                {
                    var1++;
                }

                Console.WriteLine(var1.ToString() + " is now the biggest of the three: " + var1.ToString() + ", " + var2.ToString() + ", " + var3.ToString());
            }
            else if (var3 < var1 && var3 < var2)
            {
                while (var3 <= var1 || var3 <= var2)
                {
                    var3++;
                }

                Console.WriteLine(var3.ToString() + " is now the biggest of the three: " + var1.ToString() + ", " + var2.ToString() + ", " + var3.ToString());
            }
        }

        static double CalculateCost(int units)
        {
            double cost = 0;

            if (units > 50)
            {
                units -= 50;
                cost += 50 * 0.5;
            }
            else
            {
                return units * 0.5;
            }

            if (units > 100)
            {
                units -= 100;
                cost += 100 * .75;
            }
            else
            {
                return cost + units * .75;
            }

            if (units > 100)
            {
                units -= 100;
                cost += 100 * 1.2;
            }
            else
            {
                return cost + units * 1.2;
            }

            if (units > 0)
            {
                cost += units * 1.5;
            }

            return cost;
        }

        static bool IsLeap(int year)
        {
            return year % 4 == 0;
        }

        static int IntPrompt(string prompt = "Enter an integer: ")
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            return int.Parse(input);
        }
    }
}
