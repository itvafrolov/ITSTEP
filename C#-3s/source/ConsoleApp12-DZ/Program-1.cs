using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*			Написать приложение «Автомобильные гонки».

В гонке участвует от 2 до 7 автомобилей (количество задается пользователем перед началом каждой гонки).
Автомобили двигаются по экрану консоли от левого края к правому с переменной скоростью.
Победителем гонки считается автомобиль, который первым достиг правого края консоли.

Автомобили отображать в консоли с помощью символов псевдографики.

Для решения задачи необходимо реализовать класс «Автомобиль», который имеет цвет 
(красный, синий и т.д. – назначается автомобилю случайным образом в конструкторе),
номер (1, 2, и т.д. – задается программой). 

Для класса перегрузить оператор ++, 
который перемещает автомобиль вперед на случайное количество позиций в консоли (от 1 до 5).

Предусмотреть возможность поломки автомобиля во время гонок – вероятность поломки – 5%.
В случае поломки объект «Автомобиль» генерирует исключительную ситуацию, которая должна быть 
обработана в программе – поломанный автомобиль перестает двигаться,
но остается на экране (отображается на экране как поломанный), и выбывает из гонок.

Пользователь перед началом гонок может сделать ставку на один из автомобилей.
В случае, если побеждает автомобиль пользователя – программа сообщает «Вы выиграли», иначе – «Вы проиграли».

Программа должна иметь меню, предлагающее пользователю сделать ставку и начать новую гонку или выйти из программы.
*/

namespace ConsoleApp12_DZ
{
    class Totalizator
    {

        Avto[] arrAvto;
       public int _count;
       // положения для авто
        public Totalizator (int count)
        {
            _count = count;
         
            arrAvto = new Avto[_count];
            for (int i = 0; i < _count; i++)
            {       
                arrAvto[i] = new Avto(i+1);
            }
        }


        public void DrawTrack(int y)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(0, y);
            for (int i = 0; i < 100; i++)
            {
                Console.Write(".");
            }
        }
        public void DrawTracks()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(20, 1);
            Console.WriteLine("ТУРНИР ДНЯ:  Автомобильные гонки!");      
            Console.SetCursorPosition(2, 2);
            Console.WriteLine($"КОЛИЧЕСТВО АВТО: {_count}                    ");
            Console.SetCursorPosition(0, 3);
            Console.WriteLine($" ТУРНИРНАЯ ТАБЛИЦА:                    ");

            for (int i = 0; i < _count; i++)
            {
                DrawTrack(10 + i * 3);
            }
            Console.SetCursorPosition(18, 2);
            Console.ReadLine();
        }
        public void Move()
        {            
           Random rand = new Random();

           for (int i = 0; i < _count; i++)
            {
                arrAvto[i].DrawAvto(0, 10 + i * 3);
            }
            int x = 0;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            while (x<100)
            {
                for (int i = 0; i < _count; i++)
                {
                    DrawTrack(10 + i * 3);
                    arrAvto[i].MoveAvto(rand.Next(1,4), 10 + i * 3);                    
                    System.Threading.Thread.Sleep(20);
                    if (arrAvto[i]._polog >= x) x = arrAvto[i]._polog;
                }       
            }
            Console.WriteLine(x);


            for (int i = 0; i < _count; i++)
            {
                DrawTrack(10 + i * 3);
                arrAvto[i].DrawAvto(arrAvto[i]._polog, 10 + i * 3);
                Console.Write("  RESULT:  ");
                Console.Write(arrAvto[i]._polog);               
            }
        }


    }
    class Avto
    {
        int _color;
        int _num;
        public int _polog { get; set; }
        public Avto(int num)
        {
            _num = num;
            _polog = 0;
            //Random random = new Random();
            _color = num;           
            //          
        }
        public void DrawAvto(int x, int y)
        {
            switch (_color)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                default:
                    break;
            }
            Console.SetCursorPosition(x, y);
            Console.Write($":(%%):");
        }

        public void MoveAvto(int dx, int y) 
        {            
            _polog += dx;
            DrawAvto(_polog, y);            
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(25, 1);
            Console.WriteLine("ТУРНИР ДНЯ:  Автомобильные гонки!");
            Console.SetCursorPosition(2, 2);
            Console.Write($"ЗАДАЙТЕ КОЛИЧЕСТВО АВТО: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("ДЛЯ НАЧАЛА НАЖМИТЕ ВВОД");

            Totalizator totalizator = new Totalizator(x);
            totalizator.DrawTracks();
            totalizator.Move();
            //
            Console.ReadKey();
        }
    }
}
