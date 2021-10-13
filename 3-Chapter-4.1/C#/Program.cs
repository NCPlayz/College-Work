using System;
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
            //Task14();
            //Task15();
            //Task16();
            //Task16Improved();
            //Task17();
            //Task18();
            //Task19();
            //Task20();
            //Task20Challenge();
            //Task21();
            //Task22();
            Task23();
            Task24();
        }

        static void Task1()
        {
            int var1 = Utils.IntPrompt();
            int var2 = Utils.IntPrompt();
            int var3 = Utils.IntPrompt();
            int var4 = Utils.IntPrompt();
            int var5 = Utils.IntPrompt();

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
            int year = Utils.IntPrompt("Enter a year: ");
            String _insert = Utils.IsLeap(year) ? "" : "not";
            Console.WriteLine(year.ToString() + " is " + _insert + "a leap year");
        }

        static void Task2Challenge()
        {
            int units = Utils.IntPrompt("Enter electricity units: ");
            double cost = Utils.CalculateCost(units);
            Console.WriteLine(cost.ToString());
        }

        static void Task3()
        {
            int var1 = Utils.IntPrompt();
            int var2 = Utils.IntPrompt();
            int var3 = Utils.IntPrompt();

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
            int x = Utils.IntPrompt(), y = Utils.IntPrompt(), z = Utils.IntPrompt();

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
            int x = Utils.IntPrompt(), y = Utils.IntPrompt(), z = Utils.IntPrompt();

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
            int shapeType = Utils.IntPrompt("Enter the shape type: ");
            double area = Utils.CalculateArea(shapeType);
            Console.WriteLine("The area is: " + area.ToString());
        }

        static void Task10()
        {
            int startValue = Utils.IntPrompt("Enter a start value: ");
            double sum = 0;
            for (int i = 1; i < 10; i += 2)
            {
                sum += Math.Pow(startValue, i);
            }
            Console.WriteLine("Sum = " + sum);
        }

        static void Task10Challenge()
        {
            int startValue = Utils.IntPrompt("Enter a start value: ");
            int loopLimit = Utils.IntPrompt("Enter a loop value");
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

            string sum = Utils.LengthSum(input1, input2, input3, input4, input5);
            Console.WriteLine(sum);
        }

        static void Task12()
        {
            string name = Utils.StringPrompt();
            string longString = Utils.Repeat(name, 10);
            Console.WriteLine(longString);
        }

        static void Task13()
        {
            string text = Utils.StringPrompt();
            string isPalindrome = Utils.IsPalindrome(text) ? "is" : "is not";
            Console.WriteLine(text + " " + isPalindrome + " a palindrome.");
        }

        static void Task14()
        {
            int var1 = Utils.IntPrompt();
            int var2 = Utils.IntPrompt();
            Console.WriteLine(Utils.CheckPerfect(var1));
            Console.WriteLine(Utils.CheckPerfect(var2));
        }

        static void Task15()
        {
            int var1 = Utils.IntPrompt();
            Console.WriteLine(Utils.GetStepsForCollatzConjecture(var1));
        }

        static void Task16()
        {
            string var1 = Utils.GetInput();
            string var2 = Utils.GetInput();
            string var3 = Utils.GetInput();
            string var4 = Utils.GetInput();
            string var5 = Utils.GetInput();
            string var6 = Utils.GetInput();
            string var7 = Utils.GetInput();
            string var8 = Utils.GetInput();
            string var9 = Utils.GetInput();
            string var10 = Utils.GetInput();

            int var1Length = Utils.GetLength(var1);
            int var2Length = Utils.GetLength(var2);
            int var3Length = Utils.GetLength(var3);
            int var4Length = Utils.GetLength(var4);
            int var5Length = Utils.GetLength(var5);
            int var6Length = Utils.GetLength(var6);
            int var7Length = Utils.GetLength(var7);
            int var8Length = Utils.GetLength(var8);
            int var9Length = Utils.GetLength(var9);
            int var10Length = Utils.GetLength(var10);

            double var1LengthCalculation = Utils.CalculateBasedOnLength(var1Length);
            double var2LengthCalculation = Utils.CalculateBasedOnLength(var2Length);
            double var3LengthCalculation = Utils.CalculateBasedOnLength(var3Length);
            double var4LengthCalculation = Utils.CalculateBasedOnLength(var4Length);
            double var5LengthCalculation = Utils.CalculateBasedOnLength(var5Length);
            double var6LengthCalculation = Utils.CalculateBasedOnLength(var6Length);
            double var7LengthCalculation = Utils.CalculateBasedOnLength(var7Length);
            double var8LengthCalculation = Utils.CalculateBasedOnLength(var8Length);
            double var9LengthCalculation = Utils.CalculateBasedOnLength(var9Length);
            double var10LengthCalculation =  Utils.CalculateBasedOnLength(var10Length);

            double average = Utils.GetAverageOf10Integers(var1LengthCalculation, var2LengthCalculation, var3LengthCalculation, var4LengthCalculation, var5LengthCalculation, var6LengthCalculation, var7LengthCalculation, var8LengthCalculation, var9LengthCalculation, var10LengthCalculation);

            Console.WriteLine("The average of the length is: " + average.ToString());
        }

        static void Task16Improved()
        {
            string[] vars = new string[10];

            for (int i = 0; i < vars.Length; i++)
            {
                vars[i] = Utils.GetInput();
            }

            double[] varsAsDouble = new double[10];

            for (int i = 0; i < vars.Length; i++)
            {
                varsAsDouble[i] = Utils.CalculateBasedOnLength(Utils.GetLength(vars[i]));
            }

            double average = Utils.GetAverageOfDoubleArray(varsAsDouble);

            Console.WriteLine("The average of the length is: " + average.ToString());
        }

        static void Task17()
        {
            int userInput = Utils.BoundIntPrompt(0, 31);

            int randInt = Utils.RandInt(0, 31);

            Utils.CheckIfWon(userInput, randInt);
        }

        static void Task18()
        {
            int userInput = Utils.IntPrompt();

            Console.WriteLine(Utils.NumberLength(userInput));
        }

        static void Task19()
        {
            string[] animalNames = { "Cheetah", "Tiger", "Dalmatian", "Tubbycat", "Elephant", "Poodle", "Rat", "Guinea Pig", "Aardvark", "Hawk" };

            string[] arr = new string[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = animalNames[i];
            }

            Console.WriteLine(string.Join(", ", arr));
        }

        static void Task19Challenge()
        {
            string[] animalNames = { "Cheetah", "Tiger", "Dalmatian", "Tubbycat", "Elephant", "Poodle", "Rat", "Guinea Pig", "Aardvark", "Hawk" };

            int count = 0;

            foreach (string item in animalNames)
            {
                if (item == "Cheetah")
                {
                    count++;
                }
            }

            Console.WriteLine("'Cheetah' appears " + count);
        }

        static void Task19ChallengePart2()
        {
            string[] animalNames = { "Cheetah", "Tiger", "Dalmatian", "Tubbycat", "Elephant", "Poodle", "Rat", "Guinea Pig", "Aardvark", "Hawk" };

            Array.Sort(animalNames);

            Console.WriteLine("Enter a string: ");
            string userInputtedString = Console.ReadLine();

            int count = 0;

            foreach (string item in animalNames)
            {
                if (item == userInputtedString)
                {
                    count++;
                }
            }

            Console.WriteLine(userInputtedString + " appears " + count);
        }

        static void Task20()
        {
            int[] arr = new int[5];
            int[] arr2 = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Utils.IntPrompt();
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = Utils.IntPrompt();
            }

            int[] merged = Utils.MergeArrays(arr, arr2);

            Console.WriteLine(string.Join(", ", merged));
        }

        static void Task20Challenge()
        {
            int[] arr = { 93204, 2343243, 2, 32, 432423, 4, 234, 234, 234234234, 690435374 };

            Array.Sort(arr);
            Array.Reverse(arr);

            int[] dupesRemoved = arr.Distinct().ToArray();

            Console.WriteLine(arr[1]);
        }

        static void Task21()
        {
            int[] arr = new int[5];
            int[] arr2 = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Utils.IntPrompt();
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = Utils.IntPrompt();
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] - 1;
                arr2[i] = arr2[i] - 1;
            }

            Console.WriteLine(string.Join(", ", arr));
            Console.WriteLine(string.Join(", ", arr2));
        }

        static void Task22()
        {

        }

        static void Task23()
        {
            int[] arr = Utils.IntPrompts(10);

            int[] evenArr = arr.Where(i => i % 2 == 0).ToArray();
            int[] oddArr = arr.Where(i => i % 2 != 1).ToArray();

            Console.WriteLine("Even Number Average: " + Utils.GetAverageOfIntArray(evenArr));
            Console.WriteLine("Odd Number Average: " + Utils.GetAverageOfIntArray(oddArr));
        }

        static void Task24()
        {
            int arrLength = Utils.IntPrompt();
            Console.WriteLine("You will be prompted to enter " + arrLength + " strings.");
            string[] arr = Utils.Prompts(arrLength);

            int[] lengthsOfArrElements = arr.Select(s => s.Length).ToArray();

            int sum = lengthsOfArrElements.Sum();

            string isEven = sum % 2 == 0 ? "even" : "odd";

            Console.WriteLine("The total of the lengths of the phrases inputted is " + isEven + ".");
        }
    }
}
