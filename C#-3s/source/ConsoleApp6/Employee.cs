
using System;

namespace SimpleProject
{
    class Employee
    {
        string _firstName;
        public string FirstName
        {
            get { return _firstName != null ? _firstName : "Не задано"; }
            set { _firstName = value.ToUpper(); }
        }

        string _lastName;
        public string LastName
        {
            get { return _lastName != null ? _lastName : "Не задано"; ; }
            set { _lastName = value.ToUpper(); }
        }

        int _age;
        public int Age
        {
            get { return _age; }
            set { _age = (value > 115 || value < 1) ? 0 : value; }
        }

        float _wage;
        public float Wage
        {
            get { return _wage; }
            set { _wage = value < 0 ? 0 : value; }
        }

        public string Print()
        {
            return $"Имя: {FirstName}\nФамилия: {LastName}\nВозраст: {Age}\nЗарплата: {Wage}\n";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee { FirstName = "Дмитрий", LastName = "Сикорский", Age = 19, Wage = 4800f };
            Employee emp2 = new Employee();
            emp2.FirstName = "Денис";
            // свойство LastName не установлено
            // попытка присвоить невозможный возраст
            emp2.Age = 120;
            //попытка задать зарплату со знаком минус
            emp2.Wage = -1000;
            Employee emp3 = new Employee { FirstName = "Наталья", LastName = "Борисова", Age = 29, Wage = 2500f };
            Console.WriteLine(emp1.Print());
            Console.WriteLine(emp2.Print());
            Console.WriteLine(emp3.Print());
        }
    }
}