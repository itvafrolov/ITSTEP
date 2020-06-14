using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 интерфейсы - это специальная конструкция, (стандартные интерфейсы вообще их много) - содержащая в себе набор методов, 
не методов реализации а описательная как прототип в С++ класс, в который включен интерфейс должен реализовать все методы этого интерфейса
 */

namespace ConsoleApp10
{
    interface IFly
    {
        //нельзя указывать модификаторы доступа
        void Fly();
    }
    interface ISwim
    {
        void Swim();
    }
    interface IRun
    {
        void Run(int speed);
    }
    abstract class Bird
    {
        //  public abstract void Fly();
    }
    class Duck : Bird, IFly
    {
        //....
        //public override void Fly()
        //{
        //    Console.WriteLine("Duck fly");
        //}
        //public void Swit()
        //{
        //    Console.WriteLine("Duck swit");
        //}
        public void Fly()
        {
            Console.WriteLine("Duck fly");
        }
    }
    class Ostrin : Bird, IRun
    {
        public void Run(int speed)
        {
            Console.WriteLine($"Ostrin run {speed} km/ch");
        }
    }
    class Penguin : Bird, ISwim
    {
        public void Fly()
        {
            // Console.WriteLine("Penguin swit");
        }

        public void Swim()
        {
            Console.WriteLine("Penguin swit");
        }


    }
    /*
     ВОПРОСЫ:
        в одном файле сколько интерфейсов? один или много?
     */

    abstract class Insect //насекомые
    {

    }

    class Butterfly : Insect, IFly
    {
        public void Fly()
        {
            Console.WriteLine("Butterfly fly");
        }

        public void Ex()
        {
            //
        }
    }

    class Plane : IFly
    {
        public void Fly()
        {
            Console.WriteLine("Plane fly");
        }
    }


    abstract class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public override string ToString()
        {
            return $"\nФамилия: {LastName} Имя: {FirstName} Дата рождения: {BirthDate.ToLongDateString()}";
        }
    }
    abstract class Employee : Human
    {
        public string Position { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"\nДолжность: {Position} Заработная плата: {Salary} $";
        }
    }

    interface IWorker
    {
        bool IsWorking { get; }
        string Work();
    }

    interface IManager
    {
        IWorker[] ListOfWorkers { get; set; }
        void Organize();
        void Contol();
        void MakeBudget();

    }

    class Director : Employee, IManager
    {
        public IWorker[] ListOfWorkers { get; set; }

        public void Contol()
        {
            Console.WriteLine("Contol");
        }

        public void MakeBudget()
        {
            Console.WriteLine("MakeBudget");
        }

        public void Organize()
        {
            Console.WriteLine("Organize");
        }
    }

    class Cashier : Employee, IWorker
    {
        public bool IsWorking { get; set; } // исходя из реализации данного интерфейса get обязателен set - опционально можно так, можно и без
        //public bool IsWorking => throw new NotImplementedException();

        public string Work()
        {
            return "Cashier works";
        }
    }


    class Loader : Employee, IWorker
    {
        public bool IsWorking { get; }

        public string Work()
        {
            return "Loader works";
        }
    }

    // наследование интерфейсов
    interface IA
    {
        //void A1(int n);
        //int A2(double b);
        void show();
    }

    interface IB
    {
        //void b1();
        void show();
    }

    interface IC : IA, IB
    {
        //bool C1(char s);

    }

    class Example1 //: IC
    {
        public void A1(int n)
        {
            throw new NotImplementedException();
        }

        public int A2(double b)
        {
            throw new NotImplementedException();
        }

        public void b1()
        {
            throw new NotImplementedException();
        }

        public bool C1(char s)
        {
            throw new NotImplementedException();
        }
    }
    class Example2 : IA, IB
    {
        public void show()
        {
            Console.WriteLine("Example2");
        }
    }



    class StudentCard
    {
        public int Number { get; set; }
        public string Series { get; set; }

        public override string ToString()
        {
            return $"Студенческий билет: {Series} {Number}";
        }
    }

    class Student : IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public StudentCard StudentCard { get; set; }

        public int CompareTo(object obj)
        {
            if (obj is Student)
            {
                return LastName.CompareTo((obj as Student).LastName);
            }
            throw new ArgumentException();
           // return LastName.CompareTo(obj);
        }

        public override string ToString()
        {
            return $"Фамилия: {LastName}, Имя: {FirstName}, Родился: {BirthDate.ToLongDateString()}, {StudentCard}";
        }
    }

    class Auditory : IEnumerable
    {
        private Student[] _students =
            {
        new Student {
            FirstName ="John",
            LastName ="Miller",
            BirthDate =new DateTime(1997,3,12),
            StudentCard =new StudentCard { Number=189356, Series="AB" }
        },
        new Student {
            FirstName ="Candice",
            LastName ="Leman",
            BirthDate =new DateTime(1998,7,22),
            StudentCard =new StudentCard { Number=345185, Series="XA" }
        },
        new Student {
            FirstName ="Joey",
            LastName ="Finch",
            BirthDate =new DateTime(1996,11,30),
            StudentCard =new StudentCard { Number=258322, Series="AA" }
        },
        new Student {
            FirstName ="Nicole",
            LastName ="Taylor",
            BirthDate =new DateTime(1996,5,10),
            StudentCard =new StudentCard { Number=513484, Series="AA" }
        }
    };

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _students.GetEnumerator();
        }
        public void Sort()
        {
            Array.Sort(_students);
        }

    }
    

    class Program
    {
        static void Main(string[] args)
        {
            Auditory auditory = new Auditory();
            foreach(Student item in auditory)
            {
                Console.WriteLine(item);
            }

            auditory.Sort();
        ////    // IFly fly = new IFly();  // - ошибка экземпляр интерфейса создать нельзя!
        ////    // IFly fly = new Duck();   // можно


        ////    Bird[] birds = { new Penguin(), new Duck(), new Ostrin() };

        ////    //foreach (Bird item in birds)
        ////    //{
        ////    //    try
        ////    //    {
        ////    //        ((IFly)item).Fly();
        ////    //    }
        ////    //    catch { }
        ////    //    // ----- 2 ----------
        ////    //    IFly fly = item as IFly;
        ////    //    if (fly != null)
        ////    //    {
        ////    //        fly.Fly();
        ////    //    }
        ////    //    //----- 3 --------
        ////    //    if (item is IFly)
        ////    //    {
        ////    //        (item as IFly).Fly();
        ////    //    }
        ////    //}

        ////    IFly[] flies = { new Butterfly(), new Duck(), new Plane() };

        ////    foreach (IFly item in flies)
        ////    {
        ////        item.Fly(); // полиморфизм
        ////    }


        ////    //---------------------------------------------------------------
        ////    //Director director = new Director();
        ////    // director.ListOfWorkers[0] = new Cashier(); // ошибка ListOfWorkers - свойство которе не выделяет память под этот массив
        ////  /*
        ////   * director.ListOfWorkers = new IWorker[] { new Cashier(), new Loader() }; // можно так
        ////    foreach(IWorker item in director.ListOfWorkers)
        ////    {
        ////        if (item.IsWorking)
        ////        {
        ////            Console.WriteLine(item.Work());
        ////        }
        ////    }
        ////    */

            //
            Console.ReadKey();
        }
    }
}
