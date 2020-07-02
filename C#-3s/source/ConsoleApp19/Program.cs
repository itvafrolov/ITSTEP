using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    interface ISome
    {
        void M();
    }
    public enum Professions { Doctor, Programmer, Tester, Engineer, Teacher }
    class Student : ISome
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsMarried { get; set; }
        public Professions Profession { get; set; }
        public byte[] Marks { get; set; }


        public decimal GetAverage()
        {
            double aver = 0;
            foreach (var v in Marks)
                aver += v;
            return (decimal)aver / Marks.Length;
        }



        public override string ToString()
        {
            return $"Name: {Name}, age: {Age}, profession: {Profession}, isMarried: {IsMarried}, marksAverage: {Math.Round(GetAverage(), 2)}";
        }



        public void M()
        {
            Console.WriteLine("Hello");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student{ Name = "Nastya", Age = 30, IsMarried = true, Profession = Professions.Teacher, Marks = new byte[]{10,8,7,11,3,8,11,12}},
                new Student{ Name = "Nastya", Age = 23, IsMarried = false, Profession = Professions.Engineer, Marks = new byte[]{10,5,7,11,3,8,9,6}},
                new Student {Name = "Ira", Age = 18, IsMarried = false, Profession = Professions.Doctor, Marks = new byte[]{6,8,7,2,3,8,6,3}},
                new Student { Name = "Dima", Age = 34, IsMarried = true, Profession = Professions.Programmer, Marks = new byte[]{10,12,12,11,12,12,11,12}},
                new Student { Name = "Timur", Age = 25, IsMarried = false, Profession = Professions.Tester, Marks = new byte[]{7,8,7,7,7,8,7,7}},
                new Student { Name = "Kolya", Age = 23, IsMarried = true, Profession = Professions.Doctor, Marks = new byte[]{5,5,5,3,3,5,5,5}},
                new Student { Name = "Oleg", Age = 31, IsMarried = true, Profession = Professions.Tester, Marks = new byte[]{9,9,9,7,9,8,9,9}},
                new Student { Name = "Sergey", Age = 29, IsMarried = true, Profession = Professions.Programmer, Marks = new byte[]{11,11,11,11,11,8,11,11}}
            };


            List<Student> students1 = new List<Student>
            {
                new Student{ Name = "Roma", Age = 30, IsMarried = true, Profession = Professions.Teacher, Marks = new byte[]{10,8,7,11,3,8,11,12}},
                new Student {Name = "Garic", Age = 18, IsMarried = false, Profession = Professions.Doctor, Marks = new byte[]{6,8,7,2,3,8,6,3}},
                new Student { Name = "Lyosha", Age = 34, IsMarried = true, Profession = Professions.Programmer, Marks = new byte[]{10,12,12,11,12,12,11,12}},
                 new Student { Name = "Timur", Age = 25, IsMarried = false, Profession = Professions.Tester, Marks = new byte[]{7,8,7,7,7,8,7,7}},
                  new Student { Name = "Tom", Age = 23, IsMarried = true, Profession = Professions.Doctor, Marks = new byte[]{5,5,5,3,3,5,5,5}},
                  new Student { Name = "Oleg", Age = 31, IsMarried = true, Profession = Professions.Tester, Marks = new byte[]{9,9,9,7,9,8,9,9}},
                  new Student { Name = "Sergey", Age = 29, IsMarried = true, Profession = Professions.Programmer, Marks = new byte[]{11,11,11,11,11,8,11,11}}
            };


            //foreach (var item in students)
            //{
            //    Console.WriteLine(item);
            //}

            //var query = students.FindAll(s => s.Age => 24 && students.Age <=30);
            //var query = students.Where(p =>p.Profession == Professions.Tester && p.Marks.All(m=>m >= 7)).OrderByDescending(p => p.Name);
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}
            //  All() - проверка, удовлетворяют ли все элементы коллекции заданному условию
            //  Console.WriteLine(students.All(s => s.Name == "Dima"));
            //  Any() - проверка, удовлетворяет ли хоть один єлемент коллекции заданному условию
            //  Console.WriteLine(students.Any(s => s.Name == "Dima"));
            //

            //преобразование коллекции к IEnumerable<>
            //IEnumerable<ISome> somes = students.Cast<ISome>();
            //foreach (var item in somes)
            //{
            //    item.M();
            //}
            //var concat = students.Concat(students1);
            //foreach (var item in concat)
            //{
            //    Console.WriteLine(item);
            //}

            // количество записей
            //Console.WriteLine(concat.Count()); 

            //  А теперь на радость 
            //Console.WriteLine(concat.Count(s => s.IsMarried)); //количество женатых

            //убираем повтояющиеся записи
            //IEqualityComparer<Student> comparer = new StudentComparer();
            //var distinct = concat.Distinct();
            //foreach (var item in distinct)
            //{
            //    Console.WriteLine(item);
            //}

            //Except() возвращает все элементы первой последовательности, которых нету во второй
            /*
            var query = students.Except(students1, new StudentComparer());
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n---------------------------------------------------------\n");
            var query1 = students.Intersect(students1, new StudentComparer());
            foreach (var item in query1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n---------------------------------------------------------\n");
            */
            //элемент по указанному индексу
            /*
             Console.WriteLine(students.ElementAt(2));
             Console.WriteLine("\n---------------------------------------------------------\n");
             Student st = students.ElementAtOrDefault(4);
             if (st!=null)
             {
                 Console.WriteLine(st);
             }
             Console.WriteLine("\n---------------------------------------------------------\n");
             */
            //Console.WriteLine(students.First(s=>s.Age == 69));
            //для исключительных ситуаций
            /*
            Student st1 = students.FirstOrDefault(s => s.Age == 29);
            if (st1 != null)
            {
                Console.WriteLine(st1);
            }
            Console.WriteLine("\n---------------------------------------------------------\n");
            */
            //возвращает элементы сгруппированные по заданному значению
            var query = students.GroupBy(s => s.Profession);
            foreach (var group in query)
            {
                Console.WriteLine($"Key: {group.Key}   {group.Count()}");
                foreach (var item in group)
                {
                    Console.WriteLine($"\t{item}");
                }
            }
            Console.WriteLine("\n---------------------------------------------------------\n");

            //
            Console.ReadKey();
        }
        
    }
}
