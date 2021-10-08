using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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
            //Task10Challenge();
            //Task11();
            //Task12();
            //Task13();
            Task14();
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

        static void Task11()
        {
            Console.WriteLine("Enter an integer: ");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();
            string input4 = Console.ReadLine();
            string input5 = Console.ReadLine();

            string sum = LengthSum(input1, input2, input3, input4, input5);
            Console.WriteLine(sum);
        }

        static void Task12()
        {
            string name = StringPrompt();
            string longString = Repeat(name, 10);
            Console.WriteLine(longString);
        }

        static void Task13()
        {
            string text = StringPrompt();
            string isPalindrome = IsPalindrome(text) ? "is" : "is not";
            Console.WriteLine(text + " " + isPalindrome + " a palindrome.");
        }

        static void Task14()
        {
            int var1 = IntPrompt();
            int var2 = IntPrompt();
            Console.WriteLine(CheckPerfect(var1));
            Console.WriteLine(CheckPerfect(var2));
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

        static bool IsPalindrome(string text)
        {
            // check if text is a palindrome
            return text.Equals(new string(text.Reverse().ToArray()));
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

        static string StringPrompt(string prompt = "Enter your name: ")
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        static string LengthSum(string input1, string input2, string input3, string input4, string input5)
        {
            int size1 = LengthCalculate(input1);
            int size2 = LengthCalculate(input2);
            int size3 = LengthCalculate(input3);
            int size4 = LengthCalculate(input4);
            int size5 = LengthCalculate(input5);

            int[] sizes = { size1, size2, size3, size4, size5 };
            int sum = 0;

            foreach (int size in sizes)
            {
                if (size > 100)
                {
                    sum += size;
                }
            }

            return sum.ToString();
        }

        static int LengthCalculate(string input)
        {
            int size = 0;
            for (int i = 0; i < input.Length; i++)
            {
                size += input.Length;
            }

            return size;
        }

        static string Repeat(string text, int times)
        {
            string result = "";
            for (int i = 0; i < times; i++)
            {
                result += text;
            }
            return result;
        }

        static List<int> GetDivisors(int number)
        {
            List<int> divisors = new List<int>();

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    divisors.Add(i);
                }
            }

            return divisors;
        }

        static bool CheckPerfect(int number)
        {
            List<int> divisors = GetDivisors(number);

            int sum = divisors.Sum();

            return sum == number;
        }
    }
}
