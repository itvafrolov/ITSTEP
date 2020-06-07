using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ConsoleApp7
{

    class Human
    {
        protected string firstName;
        protected /*internal*/ string lastName;  //слишком много откуда доступ получается

        protected internal DateTime BirsthDay { get; set; }
        public Human()
        {
            BirsthDay = new DateTime(1977, 02, 01);
        }

        public Human(string fName, string lName) : this()  // конструкция : this()  говорит о том, что будет браться значение из конструктора по умолчанию
        {
            firstName = fName;
            lastName = lName;
        }
        //

        public virtual void Print()
        {
            Console.WriteLine($"{firstName} {lastName}");
        }
    }

    class Employee : Human
    {
        private double _salary;
        public Employee(string fName, string lName, double salo) : base(fName, lName)  //передача данны из конструктора базового класса
        {
            //firstName = fName;  //- при конструкции : base(fName, lName)  - эти поля не нужны!
            //lastName = lName;   //- при конструкции : base(fName, lName)  - эти поля не нужны!
            _salary = salo;
        }

        public void AddSalary(double salo)
        {
            _salary = salo;
        }
        public override void Print() //ключевое слово new  должно использоваться если одинаковые имена методов в базовом классе и наследнике
        {
            base.Print();  // в такой конструкции вызова метода базово класса
            Console.WriteLine($"{"Salary:  "} {_salary}");  // в базовом классе нужно указывать "protected"
        }
                //связка virtual -- override реализуте механизм полиморфизма -- примитиный пример

    }

    //чтобы пректраить цепочку наследований применяется ключевое слово sealed
    sealed class Curator //запечатанный класс
    {

    }

    /*class Teacher: Curator //  ERROR:  Curator -не может иметь наследников
    {

    }*/

    class Program
    {
        static void Main(string[] args)
        {
            //////Employee employee = new Employee("Join", "Li", 26.459);
            ////////employee.lastName = "XXX";
            ////////employee.BirsthDay = new DateTime();
            //////employee.Print();

            Human human = new Employee("Jack", "Daniels", 4293.12);
            human.Print();

            // обработка исключительных ситуаций
            ////////try
            ////////{
            ////////    ((Employee)human).AddSalary(789);  //приведение к типу Employee явным образом
            ////////}
            ////////catch { }

            ////////// as  - ключевое слово 
            ////////Employee empl = human as Employee;
            ////////if (empl != null)
            ////////{
            ////////    empl.AddSalary(789.87);
            ////////    empl.Print();
            ////////}

            //////////is - проверяет можно ли привести ссылку к булевскому значению
            ////////if (human is Employee)
            ////////{
            ////////    (human as Employee).AddSalary(1234.21);
            ////////    human.Print();
            ////////    ((Employee)human).Print();
            ////////    (human as Employee).Print();
            ////////}


            //
            Console.ReadKey();

        }
    }
    //----------------------------------------------------------------------------------------------

    ////public class Human
    ////{
    ////    string _firstName;
    ////    string _lastName;
    ////    DateTime _birthDate;

    ////    public Human(string fName, string lName)
    ////    {
    ////        _firstName = fName;
    ////        _lastName = lName;
    ////    }

    ////    public Human(string fName, string lName, DateTime date)
    ////    {
    ////        _firstName = fName;
    ////        _lastName = lName;
    ////        _birthDate = date;
    ////    }

    ////    public void Show()
    ////    {
    ////        WriteLine($"\nФамилия: {_lastName}\nИмя: {_firstName}\nДата рождения: {_birthDate.ToShortDateString()}");
    ////    }
    ////}

    ////public class Employee : Human
    ////{
    ////    double _salary;
    ////    public Employee(string fName, string lName) : base(fName, lName) { }

    ////    public Employee(string fName, string lName, double salary)
    ////        : base(fName, lName)
    ////    {
    ////        _salary = salary;
    ////    }
    ////    public Employee(string fName, string lName, DateTime date, double salary) : base(fName, lName, date)
    ////    {
    ////        _salary = salary;
    ////    }

    ////    public void Print()
    ////    {
    ////        Show();
    ////        WriteLine($"Заработная плата: {_salary} $");
    ////    }
    ////}
    ////class Manager : Employee
    ////{
    ////    string _fieldActivity;

    ////    public Manager(string fName, string lName, DateTime date, double salary, string activity) : base(fName, lName, date, salary)
    ////    {
    ////        _fieldActivity = activity;
    ////    }

    ////    public void ShowManager()
    ////    {
    ////        WriteLine($"Менеджер. Сфера деятельности: {_fieldActivity}");
    ////    }
    ////}
    ////class Scientist : Employee
    ////{
    ////    string _scientificDirection;
    ////    public Scientist(string fName, string lName, DateTime date, double salary, string direction) : base(fName, lName, date, salary)
    ////    {
    ////        _scientificDirection = direction;
    ////    }
    ////    public void ShowScientist()
    ////    {
    ////        WriteLine($"Ученый. Научное направление: {_scientificDirection}");
    ////    }
    ////}
    ////class Specialist : Employee
    ////{
    ////    string _qualification;
    ////    public Specialist(string fName, string lName, DateTime date, double salary, string qualification) : base(fName, lName, date, salary)
    ////    {
    ////        _qualification = qualification;
    ////    }
    ////    public void ShowSpecialist()
    ////    {
    ////        WriteLine($"Специалист. Квалификация: {_qualification}");
    ////    }
    ////}

    ////class Program
    ////{
    ////    static void Main(string[] args)
    ////    {
    ////        Employee manager = new Manager("John", "Doe", new DateTime(1995, 7, 23), 3500, "продукты питания");

    ////        Employee[] employees = {
    ////          manager,
    ////          new Scientist("Jim", "Beam", new DateTime(1956,3,15), 4253, "история"),
    ////          new Specialist("Jack", "Smith", new DateTime(1996,11,5), 2587.43,"физика")
    ////        };

    ////        foreach (Employee item in employees)
    ////        {
    ////            item.Print();
    ////            //item.ShowScientist(); Error

    ////            try
    ////            {
    ////                ((Specialist)item).ShowSpecialist(); // Способ №1
    ////            }
    ////            catch
    ////            {
    ////            }

    ////            Scientist scientist = item as Scientist; // Способ №2

    ////            if (scientist != null)
    ////            {
    ////                scientist.ShowScientist();
    ////            }

    ////            if (item is Manager) // Способ №3
    ////            {
    ////                (item as Manager).ShowManager();
    ////            }
    ////        }
    ////    }
    ////}


}
