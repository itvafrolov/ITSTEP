
using System;
using System.Collections.Generic;
using static System.Console;

namespace SimpleProject
{
    public delegate void ExamDelegate(string t);

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public void Exam(string task)
        {
            WriteLine($"Студент {LastName} решил {task}");
        }
    }

    class Teacher
    {
        SortedList<int, ExamDelegate> _sortedEvents = new SortedList<int, ExamDelegate>();
        Random _rand = new Random();

        public event ExamDelegate examEvent
        {
            add
            {
                for (int key; ;)
                {
                    key = _rand.Next();
                    if (!_sortedEvents.ContainsKey(key))
                    {
                        _sortedEvents.Add(key, value);
                        break;
                    }
                }
            }
            remove
            {
                _sortedEvents.RemoveAt(_sortedEvents.IndexOfValue(value));
            }
        }

        public void Exam(string task)
        {
            foreach (int item in _sortedEvents.Keys)
            {
                if (_sortedEvents[item] != null)
                {
                    _sortedEvents[item](task);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> group = new List<Student> {
                new Student {
                    FirstName = "John",
                    LastName = "Miller",
                    BirthDate = new DateTime(1997,3,12)
                },
                new Student {
                    FirstName = "Candice",
                    LastName = "Leman",
                    BirthDate = new DateTime(1998,7,22)
                },
                new Student {
                    FirstName = "Joey",
                    LastName = "Finch",
                    BirthDate = new DateTime(1996,11,30)
                },
                new Student {
                    FirstName = "Nicole",
                    LastName = "Taylor",
                    BirthDate = new DateTime(1996,5,10)
                }
            };

            Teacher teacher = new Teacher();

            foreach (Student item in group)
            {
                teacher.examEvent += item.Exam;
            }

            Student student = new Student
            {
                FirstName = "John",
                LastName = "Doe",
                BirthDate = new DateTime(1998, 10, 12)
            };

            teacher.examEvent += student.Exam;

            teacher.Exam("Задача №1");

            WriteLine();

            teacher.examEvent -= student.Exam;

            teacher.Exam("Задача №2");
        }
    }
}

//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /*
         delegate (параметры) { // код };
         */
        delegate void VoidIntDelegate(int n);
delegate void VoidDelegate();
delegate double DoubleDelegate(double a, double b);

class Dispatcher
{
    public event VoidIntDelegate voidEvent;
    public void OnVoidEvent(int n = 0)
    {
        voidEvent?.Invoke(n);

        //if (voidEvent != null)
        //{
        //    voidEvent(n);
        //}
    }
}

static void Main(string[] args)
{
    Dispatcher dispatcher = new Dispatcher();

    int number = 22;

    dispatcher.voidEvent += delegate (int n)
    {
        Console.WriteLine($"{n} + {number} = {n + number}");
    };

    dispatcher.OnVoidEvent();
    dispatcher.OnVoidEvent(45);

    VoidDelegate voidDelegate = new VoidDelegate
        (
        delegate { Console.WriteLine("Hello"); }
        );
    voidDelegate += delegate { Console.WriteLine("Bye!"); };

    voidDelegate();

    DoubleDelegate doubleDelegate = new DoubleDelegate
        (
        delegate (double x, double y)
        {
            if (y != 0)
            {
                return x / y;
            }
            throw new DivideByZeroException();
        }
        );

    try
    {
        Console.WriteLine(doubleDelegate(3.56, 4.27));
    }
    catch { }

    Console.ReadLine();
}

//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /*     delegate (параметры)    { // код };  */

        /*              (параметры) => { // код }   */
        
        delegate void VoidIntDelegate(int n);
delegate void VoidDelegate();
delegate double DoubleDelegate(double a, double b);
delegate int IntDelegate(int n);

class Dispatcher
{
    public event VoidIntDelegate voidEvent;
    public void OnVoidEvent(int n = 0)
    {
        voidEvent?.Invoke(n);

        //if (voidEvent != null)
        //{
        //    voidEvent(n);
        //}
    }
}

static void Main(string[] args)
{
    Dispatcher dispatcher = new Dispatcher();

    int number = 22;

    dispatcher.voidEvent += (int n) =>
    {
        Console.WriteLine($"{n} + {number} = {n + number}");
    };

    dispatcher.OnVoidEvent();
    dispatcher.OnVoidEvent(45);

    //IntDelegate intDelegate = new IntDelegate
    //    (
    //    delegate (int n) { return n + number; }
    //    );
    //IntDelegate intDelegate = new IntDelegate
    //    (
    //    (int n) => { return n + number; }
    //    );
    IntDelegate intDelegate = new IntDelegate(n => n + number);

    Console.WriteLine(intDelegate(100));

    VoidDelegate voidDelegate = new VoidDelegate
        (
        () => { Console.WriteLine("Hello"); }
        );
    voidDelegate += () => Console.WriteLine("Bye!");

    voidDelegate();

    DoubleDelegate doubleDelegate = new DoubleDelegate
        (
        (double x, double y) =>
        {
            if (y != 0)
            {
                return x / y;
            }
            throw new DivideByZeroException();
        }
        );

    try
    {
        Console.WriteLine(doubleDelegate(3.56, 4.27));
    }
    catch { }

    Console.ReadLine();
}

//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public override string ToString()
    {
        return $"Фамилия: {LastName}, Имя: {FirstName}, Родился: {BirthDate.ToLongDateString()}";
    }
}

class Program
{
    static void Main(string[] args)
    {

        List<Student> group = new List<Student> {
                new Student {
                    FirstName = "John",
                    LastName = "Miller",
                    BirthDate = new DateTime(1997,3,12)
                },
                new Student {
                    FirstName = "Candice",
                    LastName = "Leman",
                    BirthDate = new DateTime(1998,7,22)
                },
                new Student {
                    FirstName = "Joey",
                    LastName = "Finch",
                    BirthDate = new DateTime(1996,11,30)
                },
                new Student {
                    FirstName = "Nicole",
                    LastName = "Taylor",
                    BirthDate = new DateTime(1996,5,10)
                }
            };
        Console.WriteLine("Рожденные весной:");

        //Predicate<Student> predicate = OnlySpring; // 1
        //List<Student> students = group.FindAll(predicate);
        //List<Student> students = group.FindAll(OnlySpring); // 2
        //List<Student> students = group.FindAll( // 3
        //    delegate (Student obj)
        //    {
        //        return obj.BirthDate.Month >= 3 && obj.BirthDate.Month <= 5;
        //    });
        //List<Student> students = group.FindAll( // 4
        //    (Student obj) =>
        //    {
        //        return obj.BirthDate.Month >= 3 && obj.BirthDate.Month <= 5;
        //    });
        // 5
        List<Student> students = group.FindAll(obj => obj.BirthDate.Month >= 3 && obj.BirthDate.Month <= 5);

        foreach (Student item in students)
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();
    }

    private static bool OnlySpring(Student obj)
    {
        return obj.BirthDate.Month >= 3 && obj.BirthDate.Month <= 5;
    }
}

+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
