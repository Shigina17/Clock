using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworktm3
{
    class Program
    {
        enum Months
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 4.1");
            Console.WriteLine("Введите номер дня от 1 до 365: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int[] moths = { 31, 28, 31, 30, 31, 30, 31, 30, 31, 30, 31, 30 };
            while (num - moths[count] > 0)
            {
                num -= moths[count];
                count++;
            }
            Console.WriteLine(num + " " + (Months)count);



            Console.WriteLine("Упражнение 4.2");
            Console.WriteLine("Введите номер дня от 1 до 365: ");
            count = 0;
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 1 || num > 365)
                {
                    Console.WriteLine($"Число {num} не подходит, введите от 1 до 365");
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (FormatException error)
            {
                Console.WriteLine(error.Message);
            }
            while (num - moths[count] > 0)
            {
                num -= moths[count];
                count++;
            }
            Console.WriteLine(num + " " + (Months)count);
            Console.ReadKey();



            Console.WriteLine("Домашнее задание 4.1");
            Console.WriteLine("Введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0 && year % 400 != 0)
            {
                moths[2] += 1;
            }
            Console.WriteLine("Введите номер дня от 1 до 365: ");
            count = 0;
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 1 || num > 365)
                {
                    Console.WriteLine($"Число {num} не подходит, введите от 1 до 365");
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (FormatException error)
            {
                Console.WriteLine(error.Message);
            }
            while (num - moths[count] > 0)
            {
                num -= moths[count];
                count++;
            }
            Console.WriteLine(num + " " + (Months)count);
            Console.ReadKey();
        }
    }
}


        
    

