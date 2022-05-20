using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkfromtm
{
    public enum bank_account { current_account, saving_account, another_card = 1 }
    struct credit
    {
        public string number;
        public string type;
        public string balance;
        public void DisplayInfo()
        {
            Console.WriteLine($"Number: {number}, Type: {type}, Balanct: {balance}");
        }
    }       
    enum university { KGU, KAI, KHTI}
    struct employee
    {
        public string name;
        public string university;
        public void DisplayInfo()
        {
        Console.WriteLine($"Name: {name}, University: {university}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 3.1");
            bank_account credit = bank_account.current_account;
            Console.WriteLine(credit);


            Console.WriteLine("Упражнение 3.2");
            credit myaccount = new credit();
            myaccount.type = "Сберегательный";
            myaccount.number = "3270000";
            myaccount.balance = "1255000";
            Console.WriteLine($"Банковский аккаунт:\n Тип: {myaccount.type}\n Номер: {myaccount.number}\n Баланс: {myaccount.balance}");


            Console.WriteLine("Упражнение 3.3");
            employee user = new employee();
            user.name = "Mike";
            user.university = "KGU";
            Console.WriteLine($"Информация о работнике:\n Имя: {user.name}\n ВУЗ: {user.university}");
            Console.ReadLine();
        }
    }
}

