using System;

/*
 	Необходимо создать класс Student.
Реализовать в нем следующую функциональность:
 - массив оценок по трем предметам (jagged);
 - метод выставления оценок;
 - метод показа оценок по определенному предмету;
 - метод вывода информации о студенте.
 */

namespace ConsoleApp3
{
    //struct learning
    //{
    //    int[] mathematics;
    //    int[] physics;
    //    int[] geography;
    //}

    class Student
    {
        string name;
        int[][] estimate = new int[3][];
        public Student(string n)
        {   
            //Random random = new Random();
            name = n;        
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
