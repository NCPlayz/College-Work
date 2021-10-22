using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpWork
{
    public class Utils
    {
        public static double CalculateArea(int shapeType)
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

        public static double CalculateCost(int units)
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

        public static bool IsLeap(int year)
        {
            return year % 4 == 0;
        }

        public static bool IsPalindrome(string text)
        {
            // check if text is a palindrome
            return text.Equals(new string(text.Reverse().ToArray()));
        }

        public static string[] Prompts(int size = 5)
        {
            string[] arr = new string[size];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter a string: ");
                arr[i] = Console.ReadLine();
            }

            return arr;
        }

        public static int IntPrompt(string prompt = "Enter an integer: ")
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            return int.Parse(input);
        }

        public static int[] IntPrompts(int size = 5)
        {
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = IntPrompt();
            }

            return arr;
        }

        public static int BoundIntPrompt(int min, int max)
        {
            int val;

            while (true)
            {
                val = IntPrompt("Enter an integer within " + min + "and " + max + ":");
                if (val > min && val < max)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, try again.");
                }
            }

            return val;
        }

        public static double DoublePrompt(string prompt = "Enter an integer: ")
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            return double.Parse(input);
        }

        public static string StringPrompt(string prompt = "Enter your name: ")
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        public static int RandInt(int min, int max)
        {
            Random rnd = new Random();

            return rnd.Next(min, max);
        }

        public static string LengthSum(string input1, string input2, string input3, string input4, string input5)
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

        public static int LengthCalculate(string input)
        {
            int size = 0;
            for (int i = 0; i < input.Length; i++)
            {
                size += input.Length;
            }

            return size;
        }

        public static string Repeat(string text, int times)
        {
            string result = "";
            for (int i = 0; i < times; i++)
            {
                result += text;
            }
            return result;
        }

        public static List<int> GetDivisors(int number)
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

        public static bool CheckPerfect(int number)
        {
            List<int> divisors = GetDivisors(number);

            int sum = divisors.Sum();

            return sum == number;
        }

        public static int GetStepsForCollatzConjecture(decimal number)
        {
            int steps = 0;
            while (number != 1)
            {
                number = CalculateCollatzConjecture(number);
                steps++;
            }
            return steps;
        }

        public static decimal CalculateCollatzConjecture(decimal number)
        {
            if (number % 2 == 0)
            {
                return number / 2;
            }
            else
            {
                return number * 3 + 1;
            }
        }

        public static bool ValidatePassword(string password)
        {
            if (password.Length < 6 || password.Length > 24)
            {
                return false;
            }

            if (password.Where(char.IsUpper).ToArray().Length < 1)
            {
                return false;
            }

            if (password.Where(char.IsLower).ToArray().Length < 1)
            {
                return false;
            }

            if (password.Where(char.IsNumber).ToArray().Length < 1)
            {
                return false;
            }

            return true;
        }

        public static string GetInput()
        {
            Console.WriteLine("Enter some text:");
            return Console.ReadLine();
        }

        public static int GetLength(string s)
        {
            return s.Length;
        }

        public static int NumberLength(int n)
        {
            int i = 0;
            int l = 0;
            // TODO: think about this
            double length = Math.Ceiling(Math.Log10(n)) + 1;

            while (i != n)
            {
                Console.WriteLine(i + " " + l);

                if (i == l * 10)
                {
                    l++;
                }
                i++;
            }

            return l;
        }

        public static double CalculateBasedOnLength(int len)
        {
            if (len % 2 == 0 && len > 78)
            {
                return Math.Pow(len, 3);
            }
            else if (len % 2 != 0 && len < 56)
            {
                return Math.Pow(len, 2);
            }
            else
            {
                return 0;
            }
        }

        public static double GetAverageOf10Integers(double var1, double var2, double var3, double var4, double var5, double var6, double var7, double var8, double var9, double var10)
        {
            return (var1 + var2 + var3 + var4 + var5 + var6 + var7 + var8 + var9 + var10) / 10;
        }


        public static int GetAverageOfIntArray(int[] arr)
        {
            return arr.Sum() / arr.Length;
        }

        public static double GetAverageOfDoubleArray(double[] arr)
        {
            return arr.Sum() / arr.Length;
        }

        public static void CheckIfWon(int userInput, int randInt)
        {
            int terminate = 0;

            for (int i = 0; i < 31; i++)
            {
                if (i == randInt)
                {
                    terminate = i;
                    break;
                }
            }

            if (terminate == userInput)
            {
                Console.WriteLine("You won!");
            }
            else
            {
                Console.WriteLine("Sorry, you lost!");
            }
        }

        public static int[] MergeArrays(int[] arr1, int[] arr2)
        {
            int[] mergedArr = new int[5];

            int i = 0;
            while (i < mergedArr.Length)
            {
                mergedArr[i] = arr1[i] + arr2[i];

                i++;
            }

            return mergedArr;
        }

        public static bool IsFirstOrderIsogram(string s)
        {
            char[] distinctChars = s.Distinct().ToArray();
            return distinctChars.Length == s.Length;
        }

        public static int[,] IntPrompt2d(int rows, int cols)
        {
            int[,] nums = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    nums[i, j] = Utils.IntPrompt();
                }
            }

            return nums;
        }

        public static int[,] PrintGrid(int rows, int cols)
        {
            int[,] array = new int[rows, cols];

            int num = 0;
            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    array[i, j] = num;
                    num++;
                }
            }

            return array;
        }

        public static bool IsMagic(int[][] array)
        {
            int[] horizontalSums = new int[array.Length];
            int[] verticalSums = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                horizontalSums[i] = array[i].Sum();
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    verticalSums[j] += array[i][j];
                }
            }

            if (horizontalSums != verticalSums)
            {
                return false;
            }
        }
    }
}
