using System;
using System.Collections.Generic;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<User>(); // Создание списка User
            for (int i = 0; i < 2; i++) // Цикл для добавления
            {
                list.Add(Input());
            }
            Output(list);

        }


        /// <summary>
        /// Метод для вывода
        /// </summary>
        /// <param name="list"></param>
        private static void Output(List<User> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        /// <summary>
        /// Метод для ввода данных.Возращает конструктор класса User.
        /// </summary>
        /// <returns></returns>
        private static User Input()
        {
            string name, surname, middlename, mail;
            int age;

            Console.WriteLine("Введите имя:");
            name = InputValidNull();
            Console.WriteLine("Введите фамилию:");
            surname = InputValidNull();
            Console.WriteLine("Введите отчество:");
            middlename = InputValidNull();
            Console.WriteLine("Введите возраст:");
            age = InputValidInt();
            Console.WriteLine("Введите почту:");
            mail = InputValidNull();
            return new User(name, surname, middlename, age, mail);

        }

        /// <summary>
        /// Метод проверки на целое число
        /// </summary>
        /// <returns></returns>
        private static int InputValidInt()
        {
            string age;
            while (true)
            {
                age = Console.ReadLine();
                if (int.TryParse(age, out int ag))
                {
                    return ag;
                }
                else
                {
                    Console.WriteLine("Не верный формат. Повторите попытку.");
                }
            }         
        }

        /// <summary>
        /// Метод проверки строки на пустоту (Null)
        /// </summary>
        /// <returns></returns>
        private static string InputValidNull()
        {
            string text;
            while (true)
            {
                text = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(text))
                {
                    Console.WriteLine("Данная строка не может быть пустой. Повторите попытку.");
                }
                else
                {
                    return text;
                }
            }
        }
    }
}
