using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 9.1");
            Account account3 = new Account(100, TypeOfBankAccount.DEPOSIT);
            account3.FullInfo();


            Console.ReadKey();
        }
    }
}
