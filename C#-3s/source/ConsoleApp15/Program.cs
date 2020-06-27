using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    //class ExamEventArgs
    //{

    //}
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return $"\t{LastName} {FirstName} {BirthDate}";
        }

        public void StudentExam(object sender ExamEventArgs e)
        {
            Console.WriteLine($"{LastName} -> {e.task}");
        }


        public void StudentExam(string task)
        {
            Console.WriteLine($"{LastName} -> {task}");
        }
    }
        //delegate void ExamDelegate(string t);
        delegate void  ExamDelegate(string t);

    class Teacher
    {
        // public event ExamDelegate examEvent;
        public event EventHandler<ExamEventArgs task>

        public void TeacherExam(string task)
        {
            if (examEvent!=null)
            {
                examEvent(task);
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
                teacher.examEvent += item.StudentExam;
            }

            teacher.examEvent.Invoke("Всем 2!");
            teacher.TeacherExam("Task#1");


            #region Action 
            ////Action<Student> action = new Action<Student>(FullName);
            //Action<Student> action = FullName;
            //group.ForEach(action);
            //group.ForEach(FullName);
            //------------------------------------------------------------------------------
            #endregion

            #region Func 
            //Func<Student, string> func = new Func<Student, string>(GetFullName);
            //IEnumerable<string> students = group.Select(func);

            //foreach(string item in students)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion 

            #region Predicate 
            //List<Student> students = group.FindAll(OnlySpring);

            //foreach (Student item in students)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Comparison

            //group.Sort(SortBirthDate);
            //foreach(Student item in group)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            Console.ReadKey();
        }
        #region Metods
        //private static int SortBirthDate(Student x, Student y)
        //{
        //    return x.BirthDate.CompareTo(y.BirthDate);
        //}

        //private static bool OnlySpring(Student obj)
        //{
        //    return obj.BirthDate.Month >= 3 && obj.BirthDate.Month <= 5;
        //}

        //private static void FullName(Student obj)
        //{
        //    Console.WriteLine($"\t{obj.LastName} {obj.FirstName}");
        //}
        //------------------------------------------------------------------------------
        //private static string GetFullName(Student arg)
        //{
        //    return $"\t{arg.LastName} {arg.FirstName}";
        //}
        #endregion


    }
}
