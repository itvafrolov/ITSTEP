using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        //в этом классе можно создавать статические методы!!! 
        // ключевой слово public не обязательно!
        static void Example(int n)
        {
            n += 5;
           // Console.WriteLine(n);
        }
        /*class  MainExample
        {
            static void Main()  //второй Main() не допустим!!!
            {
                Console.WriteLine("MainExample");
            }
        }*/
        static void Main(string[] args)
        {
            //Program program = new Program();
            //Program.Example(56);
            Example(56);
            //Program.Main(new string[] { });  // -- получится рекурсия
            /* Student student = new Student( "Kharkiv" );
             student.Print();
             student.SetUniver("ХНУГХ");
             Console.WriteLine(Student.GetUniver());
             Console.WriteLine( student.Town);
             Student st1= new Student( "Kyiv");
             st1.SetUniver("ХПИ");
             Console.WriteLine(Student.GetUniver());
             Console.WriteLine(Student.Country);
             Console.WriteLine(st1.Town);
            */
            Console.WriteLine(n);
            //Student st2; // - это создание ссылки на класс Student, но не обЪЕкт значение его = null;  !!  потом нужно так st2 = new Student;
            // ссылка на область памяти где находится объект хранится в стеке, а сам объект в куче. То же самое и с массивами. а 
            // переменные типа int double и т д находятся в стеке
            /*
                        Console.WriteLine("Input date: ");
                        DateTime dt = DateTime.Parse(Console.ReadLine());
                        //st1.SetDateTime(dt);
                        Console.WriteLine(st1.GetDateTime().ToLongDateString());
                        //конструкторы - это специальные методы, для создание нашего объекта не возвращают никакие данные его имя совпадает с именем класса
                        //конструкторы могут быть перегруженные (с параметрами) ну это уже из С++ знаем их может быть много - нет ограничения на количество
                        //контруктор по умолчанию без параметров предоставляется автоматически, НО как только создаем конструктор с параметрами,
                        //то в этом случае контруктор по умолчанию без параметров НЕ предоставляется!!!
                        //можно например не использовать конструктор по умолчанию и использовать с параметрами
                        //или же написать свой конструктор без параметров
                        //еще есть такой зверь - статический конструктор
                        //внутри статического конструктора можно использовать ТОЛЬКО статический поля
                        //
                        Student st2;
                        st2 = new Student("Jeam", "Beam", "Odessa");
            */


            //
            Console.ReadKey();
        }
    }
}
