using System;
using System.Globalization;
using System.Threading;

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
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            //Task10();
            Task10Challenge();
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

        static void Task4()
        {
            int x = IntPrompt(), y = IntPrompt(), z = IntPrompt();

            if (x > y && x > z)
            {
                Console.WriteLine(x.ToString() + " is the largest.");
            }
            else if (y > x && y > z)
            {
                Console.WriteLine(y.ToString() + " is the largest.");
            }
            else if (z > x && z > y)
            {
                Console.WriteLine(z.ToString() + " is the largest.");
            }
        }

        static void Task5()
        {
            int x = IntPrompt(), y = IntPrompt(), z = IntPrompt();

            if (x > y)
            {
                if (x > z)
                {
                    Console.WriteLine(x.ToString() + " is the largest.");
                }
            }

            if (y > z)
            {
                if (y > x)
                {
                    Console.WriteLine(y.ToString() + " is the largest.");
                }
            }

            if (z > x)
            {
                if (z > y)
                {
                    Console.WriteLine(z.ToString() + " is the largest.");
                }
            }
        }

        static void Task6()
        {
            string x = "The barber cut my hair far too short!";
            Console.WriteLine(x.IndexOf("u"));
            Console.WriteLine(x.Replace("hair", "toenails"));

            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            Console.WriteLine(textInfo.ToTitleCase(x));

            string y = "The baby was born yesterday.";
            Console.WriteLine(y.Contains("The baby"));
            string z = "Mariah went to the Royal Opera House on Friday.";
            Console.WriteLine(z.ToLower());
        }

        static void Task7()
        {
            int shapeType = IntPrompt("Enter the shape type: ");
            double area = CalculateArea(shapeType);
            Console.WriteLine("The area is: " + area.ToString());
        }

        static void Task10()
        {
            int startValue = IntPrompt("Enter a start value: ");
            double sum = 0;
            for (int i = 1; i < 10; i += 2)
            {
                sum += Math.Pow(startValue, i);
            }
            Console.WriteLine("Sum = " + sum);
        }

        static void Task10Challenge()
        {
            int startValue = IntPrompt("Enter a start value: ");
            int loopLimit = IntPrompt("Enter a loop value");
            int exponent = 1;
            double sum = 0;
            for (int i = 0; i < loopLimit; i++)
            {
                sum += Math.Pow(startValue, exponent);
                exponent += 2;
            }
            Console.WriteLine("Sum = " + sum);
        }

        static double CalculateArea(int shapeType)
        {
            switch (shapeType)
            {
                case 1:
                    double squareLength = DoublePrompt("Enter the length of the square: ");
                    return squareLength * squareLength;
                case 2:
                    double rectLength = DoublePrompt("Enter the length of the rectangle: ");
                    double rectWidth = DoublePrompt("Enter the width of the rectangle: ");
                    return rectLength * rectWidth;
                case 3:
                    double triLength = DoublePrompt("Enter the length of the triangle: ");
                    double triHeight = DoublePrompt("Enter the height of the triangle: ");
                    return triLength * triHeight / 2;
                case 4:
                    double radius = DoublePrompt("Enter the radius of the circle: ");
                    return Math.PI * Math.Pow(radius, 2);
                default:
                    Console.WriteLine("Invalid Shape Type!");
                    throw new Exception();
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

        static double DoublePrompt(string prompt = "Enter an integer: ")
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            return double.Parse(input);
        }
    }
}
