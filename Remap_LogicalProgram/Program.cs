using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool execute = true;
            while (execute)

            {
                Console.WriteLine("Choose any program");
            Console.WriteLine("1. Name Of your friends\n" +
                "2.Sqaure of two numbers\n" +
                "3.Uppercase & Lowercase\n" +
                "4.10 Times Print String\n" +
                "5.Persons full name\n" +
                "6.Random numbers\n" +
                "7.Area & perimeter of circle\n" +
                "8. Date, month, year\n" +
                "9.Time elapse calculation\n" +
                "10.Number divisible by 7\n" +
                "11. Factorial number\n" +
                "12. Print 1 to 100 Without Using Loop\n" +
                "13. Root of quadratic equation\n" +
                "14. Number's factor on string output\n" +
                "15. Letter Presenr Or Absent\n" +
                "16.\n" +
                "17.\n" +
                "18. Fi9rst repeated element of array");
            int option = Convert.ToInt32(Console.ReadLine());
            
            
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter 1st Name");
                        string a = Console.ReadLine();
                        Console.WriteLine("Enter 2nd Name");
                        string b = Console.ReadLine();
                        Console.WriteLine("Enter 3rd Name");
                        string c = Console.ReadLine();
                        Console.WriteLine("Enter 4th Name");
                        string d = Console.ReadLine();
                        Console.WriteLine("Enter 5th Name");
                        string e = Console.ReadLine();
                        LogicalPrograms logicalPrograms = new LogicalPrograms();
                        logicalPrograms.FriendsName(a, b, c, d, e);
                        Console.WriteLine("\nWould you like to continue(1) or exit the program(0)");
                        int desicion = Convert.ToInt32(Console.ReadLine());
                        if(desicion == 0)
                        {
                            execute = false;
                        }

                        break;
                    case 2:
                        Console.WriteLine("Enter 1st Number");
                        float x = float.Parse(Console.ReadLine());
                        Console.WriteLine("Enter 2nd Number");
                        float y = float.Parse(Console.ReadLine());
                        LogicalPrograms logicalPrograms1 = new LogicalPrograms();
                        logicalPrograms1.SquareOfTwoNumbers(x, y);
                        Console.WriteLine("\nWould you like to continue(1) or exit the program(0)");
                        int desicion1 = Convert.ToInt32(Console.ReadLine());
                        if (desicion1 == 0)
                        {
                            execute = false;
                        }

                        break;
                    case 3:
                        Console.WriteLine("Enter name to visit");
                        string placeToVisit = Console.ReadLine();
                        string lowerCasePlace = placeToVisit.ToLower();
                        string upperCasePlace = placeToVisit.ToUpper();
                        LogicalPrograms logicalPrograms2 = new LogicalPrograms();
                        logicalPrograms2.UpperCaseLowerCase(placeToVisit);
                        Console.WriteLine("place to visit in lower case : {0}", lowerCasePlace);
                        Console.WriteLine("place to visit in upper case : {0}", upperCasePlace);
                        Console.WriteLine("\nWould you like to continue(1) or exit the program(0)");
                        int desicion2 = Convert.ToInt32(Console.ReadLine());
                        if (desicion2 == 0)
                        {
                            execute = false;
                        }

                        break;
                    case 4:
                        Console.WriteLine("Enter a number:");
                        string num = Console.ReadLine();
                        LogicalPrograms logicalPrograms3 = new LogicalPrograms();
                        logicalPrograms3.TenTimesPrintString(num);
                        Console.WriteLine("\nWould you like to continue(1) or exit the program(0)");
                        int desicion3 = Convert.ToInt32(Console.ReadLine());
                        if (desicion3 == 0)
                        {
                            execute = false;
                        }

                        break;
                    case 5:
                        LogicalPrograms.PersonFullName();
                        Console.WriteLine("\nWould you like to continue(1) or exit the program(0)");
                        int desicion4 = Convert.ToInt32(Console.ReadLine());
                        if (desicion4 == 0)
                        {
                            execute = false;
                        }

                        break;
                    case 6:
                        LogicalPrograms.RandomNumbers();
                        Console.WriteLine("\nWould you like to continue(1) or exit the program(0)");
                        int desicion5 = Convert.ToInt32(Console.ReadLine());
                        if (desicion5 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 7:
                        Console.Write("Enter Diameter: ");
                        double diameter = Convert.ToDouble(Console.ReadLine());
                        LogicalPrograms.AreaAndPerimeterOfCircle(diameter);
                        Console.WriteLine("\nWould you like to continue(1) or exit the program(0)");
                        int desicion6 = Convert.ToInt32(Console.ReadLine());
                        if (desicion6 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 8:
                        Console.Write("Input a year: ");
                        int year = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Input a month [1-12]: ");
                        int month = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Input a day [1-31]: ");
                        int day = Convert.ToInt32(Console.ReadLine());

                        LogicalPrograms.GetNextDay(year, month, day);
                        Console.WriteLine("\nWould you like to continue(1) or exit the program(0)");
                        int desicion7 = Convert.ToInt32(Console.ReadLine());
                        if (desicion7 == 0)
                        {
                            execute = false;
                        }
                        //DateTime nextDay = inputDate.AddDays(1);

                        //Console.WriteLine("The next date is [yyyy-MM-dd] " + nextDay.ToString("yyyy-MM-dd"));

                        break;
                    case 9:
                        LogicalPrograms.TimeElapseCalulation();
                        Console.WriteLine("\nWould you like to continue(1) or exit the program(0)");
                        int desicion8 = Convert.ToInt32(Console.ReadLine());
                        if (desicion8 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 10:
                        LogicalPrograms.NumberDivisibleBySeven();
                        Console.WriteLine("\nWould you like to continue(1) or exit the program(0)");
                        int desicion9 = Convert.ToInt32(Console.ReadLine());
                        if (desicion9 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 11:
                        Console.WriteLine("Enter any number of which factorial you want");
                        int number = Convert.ToInt32(Console.ReadLine());
                        LogicalPrograms.FactorialNumber(number);
                        Console.WriteLine("\nWould you like to continue(1) or exit the program(0)");
                        int desicion10 = Convert.ToInt32(Console.ReadLine());
                        if (desicion10 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 12:
                        LogicalPrograms.PrintSeriesWithoutUsingLoop();
                        Console.WriteLine("\nWould you like to continue(1) or exit the program(0)");
                        int desicion11 = Convert.ToInt32(Console.ReadLine());
                        if (desicion11 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 13:
                        LogicalPrograms.RootOfQuadraticEquation();
                        Console.WriteLine("\nWould you like to continue(1) or exit the program(0)");
                        int desicion12 = Convert.ToInt32(Console.ReadLine());
                        if (desicion12 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 14:
                        Console.WriteLine("Enter a number:");
                        int digit = Convert.ToInt32(Console.ReadLine());
                        LogicalPrograms.NumbersFactorOutputInString(digit);
                        Console.WriteLine("\nWould you like to continue(1) or exit the program(0)");
                        int desicion13 = Convert.ToInt32(Console.ReadLine());
                        if (desicion13 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 15:
                        LogicalPrograms.LetterPresenrOrAbsent();
                        Console.WriteLine("\nWould you like to continue(1) or exit the program(0)");
                        int desicion14 = Convert.ToInt32(Console.ReadLine());
                        if (desicion14 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 16:
                        LogicalPrograms.PrimeNumberByArray();
                        Console.WriteLine("\n\nWould you like to continue(1) or exit the program(0)");
                        int desicion15 = Convert.ToInt32(Console.ReadLine());
                        if (desicion15 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 17:
                        LogicalPrograms.ShiftAllZeroInArray();
                        Console.WriteLine("\n\nWould you like to continue(1) or exit the program(0)");
                        int desicion16 = Convert.ToInt32(Console.ReadLine());
                        if (desicion16 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 18:
                        LogicalPrograms.FirstRepeatedElementOfArray();
                        Console.WriteLine("\n\nWould you like to continue(1) or exit the program(0)");
                        int desicion17 = Convert.ToInt32(Console.ReadLine());
                        if (desicion17 == 0)
                        {
                            execute = false;
                        }
                        break;
                }
            }
            
            
        }
    }
}
