using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //                                                         TASK 1
            //Console.Write("Enter num(1-100): ");
            //int num = 0;
            //Int32.TryParse(Console.ReadLine(), out num);
            //if (num > 100 || num < 1)
            //{
            //    Console.WriteLine("Erorr!!!");
            //}
            //else
            //{
            //    if (num % 3 == 0) 
            //    {
            //        Console.Write("Fizz ");
            //    }
            //    if (num % 5 == 0) 
            //    {
            //        Console.Write("Buzz");
            //    }
            //    if(num % 3 != 0 && num % 5 != 0) 
            //    {
            //        Console.Write(num);
            //    }
            //    Console.WriteLine();
            //}
            //                                                         TASK 2
            //Console.Write("Enter num: ");
            //int num = 0;
            //Int32.TryParse(Console.ReadLine(), out num);
            //Console.Write("Enter percent: ");
            //double percent = 0;
            //Double.TryParse(Console.ReadLine(), out percent);
            //Console.WriteLine("Answer: " + num * (percent/100));
            //                                                         TASK 3
            //string num = "";
            //for (int i = 1; i <= 4; i++) 
            //{
            //    Console.Write($"Enter {i}-th num: ");
            //    num += Console.ReadLine();
            //}
            //Console.WriteLine("Total number: " + num);
            //                                                         TASK 4
            //string num = "";
            //Console.Write("Enter a six-digit number: ");
            //num = Console.ReadLine();
            //StringBuilder sb = new StringBuilder(num);
            //if(num.Length != 6) 
            //{
            //    Console.WriteLine("Error");
            //}
            //else 
            //{
            //    int pos1 = 0;
            //    int pos2 = 0;
            //    Console.Write("Enter the position from which to replace: ");
            //    Int32.TryParse(Console.ReadLine(), out pos1);
            //    Console.Write("Enter the position to replace with: ");
            //    Int32.TryParse(Console.ReadLine(), out pos2);
            //    char temp = num[pos1-1];
            //    sb[pos1-1] = num[pos2-1];
            //    sb[pos2-1] = temp;
            //    Console.WriteLine("Answer: " + sb);
            //}
            //                                                         TASK 5
            //Console.Write("Enter date in format dd.MM.yyyy: ");
            //DateTime date;
            //if (DateTime.TryParse(Console.ReadLine(), out date))
            //{
            //    string season = GetSeason(date.Month);
            //    string dayOfWeek = date.DayOfWeek.ToString();
            //    Console.WriteLine($"{season} {dayOfWeek}");
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect format of date.");
            //}
            //                                                         TASK 6            
            //Console.WriteLine("1. Convert temperature from Fahrenheit to Celsius");
            //Console.WriteLine("2. Convert temperature from Celsius to Fahrenheit");
            //Console.Write("Your choise:");
            //int choice = 0;
            //Int32.TryParse(Console.ReadLine(), out choice);

            //if (choice == 1)
            //{
            //    Console.Write("Enter temperature in degrees Fahrenheit: ");
            //    double fahrenheit = double.Parse(Console.ReadLine());
            //    double celsius = (fahrenheit - 32) * 5 / 9;
            //    Console.WriteLine($"Temperature in degrees Celsius: {celsius}");
            //}
            //else if (choice == 2)
            //{
            //    Console.Write("Enter temperature in degrees Celsius: ");
            //    double celsius = double.Parse(Console.ReadLine());
            //    double fahrenheit = celsius * 9 / 5 + 32;
            //    Console.WriteLine($"Temperature in degrees Fahrenheit: {fahrenheit}");
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect choise.");
            //}
            //                                                         TASK 7
            //int num1 = 0;
            //int num2 = 0;
            //Console.Write("Enter the start diapozone: ");
            //Int32.TryParse(Console.ReadLine(), out num1);
            //Console.Write("Enter the end diapozone: ");
            //Int32.TryParse(Console.ReadLine(), out num2);

            //int start = Math.Min(num1, num2);
            //int end = Math.Max(num1, num2);

            //Console.Write($"Четные числа в диапазоне от {start} до {end}: ");
            //for (int i = start; i <= end; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}
            //Console.WriteLine();
        }
        //static string GetSeason(int month)
        //{
        //    if (month == 12 || month <= 2)
        //    {
        //        return "Winter";
        //    }
        //    else if (month >= 3 && month <= 5)
        //    {
        //        return "Spring";
        //    }
        //    else if (month >= 6 && month <= 8)
        //    {
        //        return "Summer";
        //    }
        //    else
        //    {
        //        return "Autumn";
        //    }
        //}
    }
}
