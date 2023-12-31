﻿using System;
using System.IO;
using System.Linq;

namespace Tymakov8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упр 8.1: Добавить метод, который переводит деньги с одного счета на другой");
            Bank BankAccount = new Bank(Type.savings);
            Bank BankAccount1 = new Bank(Type.current);
            Console.WriteLine($"{BankAccount.AccountType} под номером {BankAccount.AccountNumber} содержит {BankAccount.AccountBalance}");
            Console.WriteLine($"{BankAccount1.AccountType} под номером {BankAccount1.AccountNumber} содержит {BankAccount1.AccountBalance}");
            BankAccount.DepositMoney(123213);
            BankAccount.WithdrawMoney(10000);
            Console.WriteLine($"{BankAccount.AccountType} под номером {BankAccount.AccountNumber} содержит {BankAccount.AccountBalance}");
            BankAccount.Transfer(BankAccount1, 1212);
            Console.WriteLine($"{BankAccount.AccountType} под номером {BankAccount.AccountNumber} содержит {BankAccount.AccountBalance}");
            Console.WriteLine($"{BankAccount1.AccountType} под номером {BankAccount1.AccountNumber} содержит {BankAccount1.AccountBalance}");


            Console.WriteLine("Упр 8.2: Реализовать метод - строка в обратном порядке");
            string str = "ЕМАЕ";
            char[] reverse = str.Reverse().ToArray();
            Console.WriteLine(reverse);

            Console.WriteLine("Упр 8.3: Преобразовать файл");
            Console.Write("Введите имя файла: ");
            string file = Console.ReadLine();
            if (!File.Exists(file))
            {
                Console.WriteLine("Файл не найден.");
            }
            string readfile = File.ReadAllText(file);
            string upreadfile = readfile.ToUpper();
            string newfile = "nefile.txt";
            File.WriteAllText(newfile, upreadfile);
            Console.WriteLine($"Новый файл выглядит так: {newfile}");

        }
    }
}
