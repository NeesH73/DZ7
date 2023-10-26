namespace zadacha
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Employee semyon = new Employee("Семён");
            Employee rashid = new Employee("Рашид");
            Employee ilham = new Employee("О Ильхам");
            Employee lucas = new Employee("Лукас");
            Employee orkadiy = new Employee("Оркадий");
            Employee volodya = new Employee("Володя");

            Employee ilshat = new Employee("Ильшат");
            Employee ivanych = new Employee("Иваныч");
            Employee ilya = new Employee("Илья");
            Employee vitya = new Employee("Витя");
            Employee zhenya = new Employee("Женя");

            Employee sergey = new Employee("Сергей");
            Employee lyaysan = new Employee("Ляйсан");
            Employee marat = new Employee("Марат");
            Employee dina = new Employee("Дина");
            Employee ildar = new Employee("Ильдар");
            Employee anton = new Employee("Антон");

            semyon.Subordinates.Add(rashid);
            semyon.Subordinates.Add(ilham);
            rashid.Subordinates.Add(lucas);
            ilham.Subordinates.Add(orkadiy);
            ilham.Subordinates.Add(volodya);
            orkadiy.Subordinates.Add(ilshat);
            ilshat.Subordinates.Add(ivanych);
            ivanych.Subordinates.Add(ilya);
            ivanych.Subordinates.Add(vitya);
            ivanych.Subordinates.Add(zhenya);
            orkadiy.Subordinates.Add(sergey);
            sergey.Subordinates.Add(lyaysan);
            lyaysan.Subordinates.Add(marat);
            lyaysan.Subordinates.Add(dina);
            lyaysan.Subordinates.Add(ildar);
            lyaysan.Subordinates.Add(anton);
            Console.Write("(1) Задача разработчикам: ");
            string taskName1 = Console.ReadLine();
            Console.Write("(2) Задача системщикам: ");
            string taskName2 = Console.ReadLine();
            Console.Write("(3) Задача начальству: ");
            string taskName3 = Console.ReadLine();
            Console.Write("введите, кому нужно назначить задачу (1-3) : ");
            bool choice = int.TryParse(Console.ReadLine(), out int choice1);
            if (choice)
            {
                switch (choice1)
                {
                    case 1:
                        Console.WriteLine($"Задачу дала {lyaysan} должны выполнить {lyaysan.Subordinates}  ");
                        break;
                    case 2:
                        Console.WriteLine($"Задачу дал {ivanych} должны выполнить {ivanych.Subordinates}  ");
                        break;
                    case 3:
                        Console.WriteLine($"Задачу дал {ilham} должны выполнить {ilham.Subordinates}  ");
                        break;
                    default:
                        Console.WriteLine("Введите от 1 до 3");
                        break;
                }
            }

        }


    }
}

