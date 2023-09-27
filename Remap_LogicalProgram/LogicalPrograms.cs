using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_LogicalProgram
{
    internal class LogicalPrograms
    {
        public void FriendsName(string a, string b, string c, string d, string e)
        {
            Console.WriteLine("friends name : {0} {1} {2} {3} {4}", a, b, c, d, e);

        }
        public void SquareOfTwoNumbers(float x, float y)
        {
            //int sum = 0;
            float squareOfSum = 0;
            float squareOfDifference = 0;
            squareOfSum = ((x + y) * (x + y));
            Console.WriteLine("Square of sum of two numbers is : {0}", squareOfSum);
            squareOfDifference = ((x - y) * (x - y));
            Console.WriteLine("Square of difference of two numbers is : {0}", squareOfDifference);
        }
        public void UpperCaseLowerCase(string placeToVisit)
        {

        }
        public void TenTimesPrintString(string num)
        {
            if (int.TryParse(num, out int number))
            {
                for (int i = 1; i <= 10; i++)
                {
                    string result = num.ToString();
                    Console.WriteLine(i + " times the number is: {0}", result);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        public static void PersonFullName()
        {
            Console.WriteLine("Enter a person's full name:");
            string fullName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(fullName))
            {
                Console.WriteLine("Please enter a valid name.");

            }
            string[] parts = fullName.Split(' ');
            int partsCount = parts.Length;

            Console.WriteLine("Number of parts in the name: " + partsCount);
        }
        public static void RandomNumbers()
        {

            Random random = new Random();
            int[] numbers = new int[5];
            double sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(10, 51);
                Console.Write(numbers[i] + " ");
                sum += numbers[i];
            }

            double average = sum / numbers.Length;
            Console.WriteLine("\nAvarage of 5 random numbers is : {0}", average);
        }
        public static void AreaAndPerimeterOfCircle(double diameter)
        {

            double radius = diameter / 2;
            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("Perimeter of the circle: {0} ", perimeter);
            Console.WriteLine("Area of the circle: {0} ", area);
        }

        public static void  GetNextDay(int y, int m, int d)
        {
            if(m <1 || m>12)
            {
                Console.WriteLine("Invalid month");
                return;
            }
            if(m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
            {
                if (d < 1 || d > 31)
                {
                    Console.WriteLine("Invalid date");
                    return;
                }

                d = d + 1;
                if(d > 31)
                {
                    d = 1; m = m + 1;
                    if(m>12)
                    {
                        m = 1; y = y + 1;
                        
                    }
                    
                }
                Console.WriteLine("Next day is : {0} {1} {2}", d, m, y);
                return;
            }
            if (m == 4 || m == 6 || m == 9 || m == 11)
            {
                if (d < 1 || d > 30)
                {
                    Console.WriteLine("Invalid date");
                    return;
                }
                d = d + 1;
                if (d > 30)
                {
                    d = 1; m = m + 1;
                    if (m > 12)
                    {
                        m = 1; y = y + 1;

                    }
                }
                Console.WriteLine("Next day is : {0} {1} {2}", d, m, y);
                return;
            }
            if(m == 2)
            {
                if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
                {
                    if(d < 1 || d > 29)
                    {

                        Console.WriteLine("Invalid date");
                        return;
                    }
                    d = d + 1;
                    if (d > 29)
                    {
                        d = 1; m = m + 1;
                        if (m > 12)
                        {
                            m = 1; y = y + 1;

                        }
                    }
                    Console.WriteLine("Next day is : {0} {1} {2}", d, m, y);
                    return;
                }

                else if(d < 1 || d > 28)
                {
                    Console.WriteLine("Invalid date");
                    return;
                }
                d = d + 1;
                if (d > 28)
                {
                    d = 1; m = m + 1;
                    if (m > 12)
                    {
                        m = 1; y = y + 1;

                    }
                }
                Console.WriteLine("Next day is : {0} {1} {2}", d, m, y);
                return;
            }
        }
        //public static void GetNextDay_1(int d, int m, int y)
        //{
        //    int[] daysOfAMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        //}
        public static void TimeElapseCalulation()
        {
            Console.WriteLine("please enter any key to start stopwatch");
            Console.ReadLine();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("stopwatch start");

            Console.WriteLine("\nplease enter any key to print series");
            Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("please enter any key to stop stopwatch");
            Console.ReadLine();

            stopwatch.Stop();

            TimeSpan Elapsed = stopwatch.Elapsed;
            Console.WriteLine("stopwatch stoped");

            Console.WriteLine("Time elapded: {0}", Elapsed.TotalMilliseconds);
            Console.ReadLine();
        }
        public static void NumberDivisibleBySeven()
        {
            string result = " ";
            for (int i = 2000;  i <=3200 ; i++)
            {
                
                if(i % 7 == 0 && i % 5 != 0)
                {
                    result += i + ",";
                   
                }

            }
            Console.WriteLine("num is  divisible by 7 are : {0}", result);
        }
        public static void FactorialNumber(int num)
        {
            int factorial = 1;
            
            for(int i = 1; i <= num; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("Factorial of number {0}: is {1}",num, factorial);
        }

        static int n = 1;
        public static void PrintSeriesWithoutUsingLoop()
        {
            Console.WriteLine(n);
            n++;

            if(n<=100)
            {
                PrintSeriesWithoutUsingLoop();
               // Console.WriteLine(n);
            }
           
        }
        public static void RootOfQuadraticEquation()
        {
            double a, b, c;
            double discriminant, root1, root2, realPart, imagPart;

            Console.WriteLine("Enter coefficients a, b and c:");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());

            discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("root1 = {0} and root2 = {1}", root1, root2);
            }
            else if (discriminant == 0)
            {
                root1 = root2 = -b / (2 * a);
                Console.WriteLine("root1 = root2 = {0};", root1);
            }
            else
            {
                realPart = -b / (2 * a);
                imagPart = Math.Sqrt(-discriminant) / (2 * a);
                Console.WriteLine("root1 = {0}+{1}i and root2 = {0}-{1}i", realPart, imagPart);
            }
        }

        public static void NumbersFactorOutputInString(int num)
        {
            if (num % 7 == 0 )
                Console.Write("Plong");

            if (num % 5 == 0 )
                Console.Write("Plang");

            if (num % 3 == 0 )
                Console.Write("Pling");

            //else if(num % 3 == 0 && num % 5 == 0)
            //Console.WriteLine("The number has 3 and 5 as the factor so the output is : PlingPlang");

            //else if (num % 3 == 0 && num % 7 == 0)
            //    Console.WriteLine("The number has 3 and 7 as the factor so the output is : PlingPlong");

            //else if(num % 5 == 0 && num % 7 == 0)
            //    Console.WriteLine("The number has 5 and 7 as the factor so the output is : PlangPlong");

            //else if (num % 3 == 0 && num % 5 == 0 && num % 7 == 0)
            //    Console.WriteLine("The number has 5 and 7 as the factor so the output is : PlangPlongPling");

            if(num % 7 != 0 && num % 5 != 0 && num % 3 != 0)
                Console.WriteLine(num);


        }
        public static void LetterPresenrOrAbsent()
        {
            Console.WriteLine("Enter any string");
            string input = Console.ReadLine();

            bool isPresent = (input.Contains("a") && input.Contains("e") && input.Contains("p"));
            bool isAnyOnePresent = (input.Contains("a") || input.Contains("e") || input.Contains("p"));

            if (isPresent)
                Console.WriteLine("All present");

            else if (isAnyOnePresent)
                Console.WriteLine("One or more present");

            else
                Console.WriteLine("None present");
        }
        public static void PrimeNumberByArray()
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the elements of the array:");

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            //Console.WriteLine("Prime numbers in the array:\n");

            for (int i = 0; i < n; i++)
            {
                if (IsPrime(arr[i]))
                {
                    Console.Write("Prime numbers in the array: " + arr[i] + " ");
                }
            }
        }

        static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)  
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
            //  int[] arr = new int[5]; // 2,4,5,6,7

            //  int factorCount = 0;
            //  for (int i = 0; i < arr.Length; i++)
            //  {

            //      if (a  == 0)
            //      {
            //          factorCount++;
            //      }

            //  }
            //if(factorCount == 2)
            //  {
            //      Console.WriteLine("{0} is prime number", arr[num]);
            //  }


        }
        public static void ShiftAllZeroInArray()
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the elements of the array:");

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            //int[] newArr = new int[n]; //0000000

            //int j = 0;
            int countOfNonZerosElement = 0;
            for(int i = 0; i < n; i++)
            {
                if (arr[i] != 0)
                {
                    Console.Write(arr[i] + " ");
                    countOfNonZerosElement++;
                    //newArr[j] = arr[i]; //14004002
                    //j = j + 1;
                }
            }
            for(int j =0; j < n-countOfNonZerosElement; j++)
            {
                Console.Write("0 ");
            }
           //for(int i = 0; i < n;i++)
           // {
           //     Console.WriteLine(newArr[i]);
           // }
        }
        public static void FirstRepeatedElementOfArray()
        {
            int[] arr = ReadUserInputForArray();
            int n = arr.Length;
            for(int i =0; i < n; i++)
            {
                for(int j = i+1; j<n; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        Console.Write("\nFirst repeated number is: " + arr[i]);
                        return;
                    }
                }
            }
        }
        public static int[] ReadUserInputForArray()
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the elements of the array:");

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
    }
}
    

