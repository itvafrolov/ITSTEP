﻿using System;

using MMM = MyNamespace1.MyNamespace2.MyNamespace3;

namespace MyNamespace1
{
    namespace MyNamespace2
    {
        namespace MyNamespace3
        {
            class MyClass
            {

            }
        }
    }
}
namespace ConsoleCS
{
    internal class Student
    {
        MMM.MyClass m1 = new MMM.MyClass();
        MyClass m2 = new MyClass();

        public const string Country = "Ukraine";

        //public readonly string Town = "Kharkiv"; // 1
        //public readonly string Town; // 2
        public string Town { get; }

        public int StudentId { get; private set; } = DateTime.Now.Minute % 2 == 0 ? 1002 : 1001;

        //private int _studentId;
        //public int StudentId
        //{
        //    get { return _studentId; }
        //    set { _studentId = value; }
        //}

        //public int StudentId { get; set; }

        public string FirstName { get; set; } = "John";

        public string LastName { get; set; } = "Doe";

        private DateTime _birthDate;

        public DateTime BirthDate
        {
            get { return _birthDate; }
            set
            {
                if (value.Year > 2020)
                {
                    return;
                }
                _birthDate = value;
            }
        }

        private int _groupId;

        public int GroupId
        {
            get
            {
                int n = 59;
                n += 7;
                Console.WriteLine(n);
                //for (int i = 0; i < 12; i++)
                //{

                //}
                return _groupId;
            }

            set
            {
                //if (value<0)
                //{
                //    _groupId = 1001;
                //}
                //else
                //{
                //    _groupId = value;
                //}
                _groupId = value < 0 ? 1001 : value;
            }
        }

        public static string Univer { get; set; }

        static Student()
        {
            Univer = "Step";

            // _lastName = "fgf"; Error
        }

        public Student(string town)
        {
            Town = town; // 2
        }

        public void Print()
        {
            Console.WriteLine($"Id: {StudentId} first name: {FirstName} last name: {LastName} date of birth: {BirthDate.ToLongDateString()} group id: {GroupId} town: {Town}");
        }
    }

    class Program
    {
        private static void Example(int n, int[] arr)
        {
            n += 56; // +

            arr[0] = 235; // +

            arr = new int[] { 45, 77, 34 }; // -
        }

        private static void Example(ref int n, ref int[] arr)
        {
            n += 56; // +

            arr = new int[] { 45, 77, 34 }; // +

        }

        private static void ExampleOut(out int n, out int[] arr)
        {
            n = 4;
            n += 56; // -

            arr = new int[] { 45, 77, 34 }; // +

        }

        static void Main(string[] args)
        {
            //MyClass myClass = new MyClass();
            //myClass.M1();
            //myClass.M2();

            //Program program = new Program();
            //program.Example(23);

            //this.Example(23); Error

            //int[] arr = { 2, 7, 9, 4 };
            //int number = 23;
            ////Example(number, arr);
            //Example(ref number, ref arr);

            /*int[] arr;
            int number = 45;
            ExampleOut(out number, out arr);
            Console.WriteLine(number);

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }*/

            /*Console.Write("Enter number: ");

            //int n = int.Parse(Console.ReadLine());

            int n;

            int summ = 10;
            if (int.TryParse(Console.ReadLine(), out n))
            {
                summ += n;
            }

            Console.WriteLine(summ);*/


            Student student = new Student("Kharkiv");

            student.GroupId = -67; // set

            Console.WriteLine(student.GroupId); // get

            int id = student.GroupId; // get

            student.BirthDate = new DateTime(2021, 4, 6);

            Console.WriteLine(student.BirthDate);

            Student.Univer = "KhPI";

            Console.WriteLine(Student.Univer);

            Student st1 = new Student("Kharkiv")
            {
                LastName = "Daniels",
                FirstName = "Jack",
                GroupId = 45,
                BirthDate = DateTime.Today
            };

            st1.Print();

            Console.ReadKey();
        }
    }
}

