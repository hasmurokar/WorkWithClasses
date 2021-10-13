using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    public class User
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string MiddleName { get; set; }
        public int Age { get; set; }
        public string Mail { get; set; }

        /// <summary>
        /// Коструктор с параметрами. 
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="middlename">Отчество</param>
        /// <param name="age">Возраст</param>
        /// <param name="mail">Почта</param>
        public User(string name, string surname, string middlename, int age, string mail)
        {
            Name = name;
            SurName = surname;
            MiddleName = middlename;
            Age = age;
            Mail = mail;
        }

        /// <summary>
        /// Переопределение метода ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Name} {SurName} {MiddleName} {Age} {Mail}";
        }

    }
}
