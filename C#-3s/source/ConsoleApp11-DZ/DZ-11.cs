using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Написать приложение «Праздничное небо».
В праздник в небе над городом можно наблюдать фейерверки, воздушные шары, группы парашютистов.


Эти объекты никак не связаны иерархией наследования, но все же ваше приложение должно реализовать объект «Праздничное небо», 
который является коллекцией «объектов праздничного неба» (подсказка – коллекцией/массивом интерфейсов).

В любой момент времени в небе можно наблюдать только один «объект праздничного неба», который пролетев по небу, 
исчезает и ему на смену приходит другой объект.

При старте приложения коллекция «Праздничное небо» заполняется случайным образом и случайным количеством «объектов праздничного неба».
После чего начинается шоу. 

Необходимо реализовать следующие виды фейерверков – крест, диагональный крест, цветок. 
Виды парашютистов – группа «треугольник», группа «ромб». 
Виды воздушных шаров – цветок, хаос. Продумать возможную иерархию родственных объектов.

Фейерверк ++ 
Парашютисты ++
воздушные шары ++ 
хаос тоже есть... ++
 */

namespace ConsoleApp11_DZ
{

    interface IMovable
    {
        void Move();
    }



    class Fireworks
    {
        public int Row;
        public int Col;

        public void WriteFire(int x, int y, int t)
        {
            //Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(Col + x, Row + y);
            Console.Write("*");
            System.Threading.Thread.Sleep(t);

            Console.SetCursorPosition(Col + x - 6, Row + y);
            Console.Write("*");
            Console.SetCursorPosition(Col + x + 6, Row + y);
            Console.Write("*");
            Console.SetCursorPosition(Col + x, Row + y - 3);
            Console.Write("*");
            Console.SetCursorPosition(Col + x, Row + y + 3);
            Console.Write("*");
            Console.SetCursorPosition(Col + x+5, Row + y - 2);
            Console.Write("*");
            Console.SetCursorPosition(Col + x-5, Row + y - 2);
            Console.Write("*");
            Console.SetCursorPosition(Col + x+5, Row + y + 2);
            Console.Write("*");
            Console.SetCursorPosition(Col + x-5, Row + y + 2);
            Console.Write("*");
            System.Threading.Thread.Sleep(t);

            Console.SetCursorPosition(Col + x - 12, Row + y);
            Console.Write("*");
            Console.SetCursorPosition(Col + x + 12, Row + y);
            Console.Write("*");
            Console.SetCursorPosition(Col + x, Row + y - 6);
            Console.Write("*");
            Console.SetCursorPosition(Col + x, Row + y + 6);
            Console.Write("*");
            Console.SetCursorPosition(Col + x + 10, Row + y - 4);
            Console.Write("*");
            Console.SetCursorPosition(Col + x - 10, Row + y - 4);
            Console.Write("*");
            Console.SetCursorPosition(Col + x + 10, Row + y + 4);
            Console.Write("*");
            Console.SetCursorPosition(Col + x - 10, Row + y + 4);
            Console.Write("*");
            System.Threading.Thread.Sleep(t);

            Console.SetCursorPosition(Col + x + 7, Row + y - 7);
            Console.Write("*");
            Console.SetCursorPosition(Col + x - 7, Row + y - 7);
            Console.Write("*");
            Console.SetCursorPosition(Col + x + 7, Row + y + 7);
            Console.Write("*");
            Console.SetCursorPosition(Col + x - 7, Row + y + 7);
            Console.Write("*");
            Console.SetCursorPosition(Col + x - 15, Row + y + 3);
            Console.Write("*");
            Console.SetCursorPosition(Col + x - 15, Row + y - 3);
            Console.Write("*");
            //System.Threading.Thread.Sleep(t);

            Console.SetCursorPosition(Col + x + 15, Row + y + 3);
            Console.Write("*");
            Console.SetCursorPosition(Col + x + 15, Row + y - 3);
            Console.Write("*");
            Console.SetCursorPosition(Col + x - 18, Row + y);
            Console.Write("*");
            Console.SetCursorPosition(Col + x + 18, Row + y);
            Console.Write("*");
            Console.SetCursorPosition(Col + x, Row + y - 9);
            Console.Write("*");
            Console.SetCursorPosition(Col + x, Row + y + 9);
            Console.Write("*");
            Console.SetCursorPosition(Col + x + 15, Row + y - 6);
            Console.Write("*");
            Console.SetCursorPosition(Col + x - 15, Row + y - 6);
            Console.Write("*");
            Console.SetCursorPosition(Col + x + 15, Row + y + 6);
            Console.Write("*");
            Console.SetCursorPosition(Col + x - 15, Row + y + 6);
            Console.Write("*");
            System.Threading.Thread.Sleep(t);
        }

        public void GoFire()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            WriteFire(25, 10, 300);
            Console.ForegroundColor = ConsoleColor.Yellow;
            WriteFire(70, 12, 300);
            Console.ForegroundColor = ConsoleColor.Red;
            WriteFire(35, 31, 300);
            Console.ForegroundColor = ConsoleColor.Blue;
            WriteFire(65, 35, 300);
        }

    }


    class Triangle : IMovable
    {
        public static int Row;
        public static int Col;

        public void WriteTriangle(string s, int x, int y)
        {           
            Console.SetCursorPosition(Col + x++, Row + y++);
            Console.Write($"{s} {s} {s} {s} {s} {s} {s} {s}");
            Console.SetCursorPosition(Col + x++, Row + y++);
            Console.Write($"{s}           {s}");
            Console.SetCursorPosition(Col + x++, Row + y++);
            Console.Write($"{s}         {s}");
            Console.SetCursorPosition(Col + x++, Row + y++);
            Console.Write($"{s}       {s}");
            Console.SetCursorPosition(Col + x++, Row + y++);
            Console.Write($"{s}     {s}");
            Console.SetCursorPosition(Col + x++, Row + y++);
            Console.Write($"{s}   {s}");
            Console.SetCursorPosition(Col + x++, Row + y++);
            Console.Write($"{s} {s}");
            Console.SetCursorPosition(Col + x++, Row + y++);
            Console.Write($"{s}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void Move()
        {
            int x = 10, y = 3;
            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                WriteTriangle("$", x, y);
                x = x + 5;
                y = y + 2;
                System.Threading.Thread.Sleep(300);
                Console.Clear();
            }
        }
    }



    class Square : IMovable
    {
        public static int Row;
        public static int Col;

        public void WriteSquare(string s, int x, int y)
        {            
            Console.SetCursorPosition(Col + x, Row + y++);
            Console.Write($"{s} {s} {s} {s} {s} {s}");
            Console.SetCursorPosition(Col + x, Row + y++);
            Console.Write($"{s}         {s}");
            Console.SetCursorPosition(Col + x, Row + y++);
            Console.Write($"{s}         {s}");
            Console.SetCursorPosition(Col + x, Row + y++);
            Console.Write($"{s}         {s}");
            Console.SetCursorPosition(Col + x, Row + y++);
            Console.Write($"{s}         {s}");
            Console.SetCursorPosition(Col + x, Row + y++);
            Console.Write($"{s} {s} {s} {s} {s} {s}");
        }

        public void Move()
        {
            int x = 25, y = 10;
            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                WriteSquare("S", x, y);
                x = x - 4;
                y = y - 2;
                System.Threading.Thread.Sleep(300);
                Console.Clear();
            }
        }
    }

    class SuperRomb : IMovable
    {
        public static int Row;
        public static int Col;

        public void WritesSr(int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(Col + x, Row + y++);
            Console.Write("    Q Q Q Q Q");
            Console.SetCursorPosition(Col + x, Row + y++);
            Console.Write("   Q    Q    Q ");
            Console.SetCursorPosition(Col + x, Row + y++);
            Console.Write("  Q     Q     Q ");
            Console.SetCursorPosition(Col + x, Row + y++);
            Console.Write(" Q Q Q Q Q Q Q Q");
            Console.SetCursorPosition(Col + x, Row + y++);
            Console.Write("  Q     Q     Q ");
            Console.SetCursorPosition(Col + x, Row + y++);
            Console.Write("   Q    Q    Q ");
            Console.SetCursorPosition(Col + x, Row + y++);
            Console.Write("    Q Q Q Q Q");
        }
        public void Move()
        {
            int x = 35, y = 35;
            for (int i = 0; i < 5; i++)
            {
                WritesSr(x, y);
                x = x - 4;
                y = y - 4;
                System.Threading.Thread.Sleep(300);
                Console.Clear();
            }
        }
    }

    class Chaos : IMovable
    {
        public static int Row;
        public static int Col;

        public void WritesCh(int x, int y)
        {
            Random random = new Random();
            for (int i = x; i < x + 30; i++)
            {
                for (int j = y; j < y + 20; j++)
                {
                    Console.SetCursorPosition(Col + i, Row + j);
                    Console.Write("O");                  
                    j = j + random.Next(1, 6);
                }               
            }        
        }

        public void Move() 
        {
           int x = 5, y = 5;
            WritesCh(x, y);
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                WritesCh(x, y);
                x = x + 4;
                y = y + 8;
                System.Threading.Thread.Sleep(300);                
            }
        }
    }

    class FestiveSky {

        static void Action(IMovable movable)
        {
            movable.Move();
        }
            //ВАРИАНТ 1
        public void WriteSky()
        {
           
            //1. Фейерверк

            Console.Clear();
            Fireworks f = new Fireworks();
            f.GoFire();
            Console.Clear();
            //Парашютисты
            Triangle tr = new Triangle();
            tr.Move();

            Square s = new Square();
            s.Move();
            
            //Шарики
            SuperRomb sr = new SuperRomb();
            sr.Move();
            
            Chaos ch = new Chaos();
            ch.Move();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("ПРАЗДНИК ОКОНЧЕН!!!");
        }

        //ВАРИАНТ 2 (через интерфейс)
        public void Festivale() 
        {
            Fireworks f = new Fireworks();
            f.GoFire();
            Console.Clear();

            Triangle tr = new Triangle();
            Square s = new Square();
            SuperRomb sr = new SuperRomb();
            Chaos ch = new Chaos();
            Action(tr);
            Action(s);
            Action(sr);
            Action(ch);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("ПРАЗДНИК ОКОНЧЕН!!!");

        }

    }


    class Program
    {

        static void Main(string[] args)
        {
            // Вариант 1 
            FestiveSky fs = new FestiveSky();
            //fs.WriteSky();
            //Console.ForegroundColor = ConsoleColor.DarkGray;
            //Console.ReadKey();


            // Вариант 2  -- через интерфейсы
            fs.Festivale();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.ReadKey();
        }
    }
}
    

