using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5DZ
{
    /*
     	Необходимо создать класс Student.

Реализовать в нем следующую функциональность:

 - массив оценок по трем предметам (jagged);
 - метод выставления оценок;
 - метод показа оценок по определенному предмету;
 - метод вывода информации о студенте. */
    //-----------------------------------------------------------------
    /*РЕАЛИЗАЦИЯ:
     1. В конструктор передаем имя студента 
     2. Вложенный цыкл: в первом контуре создаем пустой массив для зубчатого массива и рандомом задаем количество оценок
     2. во втором контуре добавляем элемент к массиву и так же рандомом задаем значение елемента (оценки)
     3. Вывод на экран метод Print то же вложенный цыкл
     */
    public class Student
    {
        string _name;
        int[][] _estimate = new int[3][];
        public Student(string n)
        {
            Random random = new Random();
            _name = n;
            int count;
            for (int e = 0; e < 3; e++)
            {
                _estimate[e] = new int[] { };
                count = random.Next(0, 30);
                for (int i = 0; i < count; i++)
                {
                    Array.Resize(ref _estimate[e], _estimate[e].Length + 1);
                    _estimate[e][i] = random.Next(2, 12);                   
                }
            }
        }
        public void Print()
        {
            Console.WriteLine("Студент: {0}", _name);
            for (int e = 0; e < 3; e++)
            {
                if (e == 0) Console.Write("Maтематика:... ");
                if (e == 1) Console.Write("Физика:....... ");
                if (e == 2) Console.Write("География:.... ");
                for (int i = 0; i < _estimate[e].Length; i++)
                {
                    Console.Write(_estimate[e][i]);
                    if (i< _estimate[e].Length-1)
                    Console.Write(", ");
                }
                Console.Write("\n");
            }
        }
    }
 
    class Program
    {
        static void Main(string[] args)
        {
            string nameStudent = "Viacheslav";
            Student Frolov = new Student(nameStudent);
            Frolov.Print();
            //
            Console.ReadKey();
        }
    }
}
