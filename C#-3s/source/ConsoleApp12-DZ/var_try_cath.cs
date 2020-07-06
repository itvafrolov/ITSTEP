using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
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


/*
 Вопрос об вероятности аварии: трак состоит из 100 пунктов. шаг от 1 до 4 пунктов - в среднем 50 шагов на один авто. 
 вероятность поломки 5 % это обозначает что ломается один авто из 20-ти 
ИТОГО:

20 * 50 = 1000  -- тоесть один раз на 1000 шагов 
тогда имеем расчет вероятности  RAND.NEXT(1, 1000)<5 
 
 */

namespace ConsoleApp12_DZ
{

    //исключение напишем свое 

    public class MyException : ApplicationException
    {
        public int _pologEx;
        public int _numEx;
        public MyException(int polog, int num)
        {
            _pologEx = polog;
            _numEx = num;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(polog, 12 + num * 2);
            Console.Write($":(XX):");
            //запись в турнирную таблицу
            Console.SetCursorPosition(30, 3 + num);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Авто выбыл из гонки!");
        }
        public void DrawCrashAvto()
        {

        }
    }


    class Total // буду использовать для написания сюда самых общих везде используемых функций, например переключатель цвета
    {
        public void SetColor(int key_color) // переключатель цвета вывода текста в консоль
        {
            switch (key_color)
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
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
            }
        }
        //отрисовка одного трека
        public void DrawTrack(int y)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(0, y);
            for (int i = 0; i < 104; i++)
            {
                Console.Write(".");
            }
        }


    }

    class Avto : Total
    {
        public int _color;
        public int _num;
        public int _polog;
        public bool _crash;
        public Avto(int num)
        {
            _num = num;
            _polog = 0;
            _color = num;
            _crash = false; // изначально авто исправное
        }
        public void DrawAvto()
        {
            int y = 12 + _num * 2;  //положение по высоте
            if (_crash == false)
            {
                SetColor(0);
                DrawTrack(y);
                SetColor(_num);
                Console.SetCursorPosition(_polog, y);
                Console.Write($":(%%):");
                //запись в турнирную таблицу
                Console.SetCursorPosition(0, 3 + _color);
                Console.Write($"Avto: {_color}  position: {_polog}     ");
            }
        }

        public static int Step(Avto avto)
        {
            Random rand = new Random();
            int d = 1;
            if (rand.Next(1, 200) < 5) d = 0;
            int res = rand.Next(d, 4);
            if (res == 0) avto._crash = true;
            if (avto._crash == true)
            {
                throw new MyException(avto._polog, avto._num);
            }
            return res;
        }

        public static Avto operator ++(Avto avto)
        {

            if (avto._crash == false)
            {
                avto._polog += Step(avto);
            }
            else
            {
                avto._polog += 0;
                //throw;
            }
            return avto;
        }
    }



    class Totalizator : Total
    {
        Avto[] arrAvto;
        public int _count;
        // положения для авто
        public Totalizator(int count)
        {
            _count = count;

            arrAvto = new Avto[_count];
            for (int i = 0; i < _count; i++)
            {
                arrAvto[i] = new Avto(i + 1);
            }
        }

        public void DrawTracks()
        {
            for (int i = 0; i < _count; i++)
            {
                arrAvto[i].DrawAvto();
            }
        }
        public void Move(int win)
        {
            int x = 0;
            int _win = 0;
            SetColor(0);
            while (x < 100)
            {

                for (int i = 0; i < _count; i++)
                {
                    try
                    {
                        if (arrAvto[i]._crash == false)
                            arrAvto[i]++;
                        arrAvto[i].DrawAvto();
                        if (arrAvto[i]._polog >= x)  // проверяем положение авто на треке если дошел - останавливаем гонку
                        {
                            x = arrAvto[i]._polog;
                            _win = i;
                        }
                    }
                    catch (MyException)
                    {
                        //   throw;
                    }

                }
                System.Threading.Thread.Sleep(20);
            }

            //Результаты турнира 
            SetColor(0);
            Console.SetCursorPosition(0, 4 + _count);
            Console.Write($"PEЗУЛЬТАТ:  Победил авто ==>>  ");
            SetColor(_win + 1);
            Console.Write($"N {_win + 1} c результатом: {x}");
            Console.SetCursorPosition(54, 2);
            if (_win + 1 == win)
            {
                SetColor(1);
                Console.Write(" ==>> ВЫ ПОБЕДИЛИ!  ПРИМИТЕ ПОЗДРАВЛЕНИЯ!");
            }
            else
            {
                SetColor(5);
                Console.Write(" ==>> ВЫ ПРОИГРАЛИ!");
            }
            SetColor(0);
            Console.SetCursorPosition(0, 13 + _count * 2);
        }
    }

    class Program
    {

        static int Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(25, 1);
            Console.WriteLine("ТУРНИР ДНЯ:  Автомобильные гонки!");
            Console.SetCursorPosition(2, 2);
            Console.Write($"ЗАДАЙТЕ КОЛИЧЕСТВО АВТО: ");
            int count = Convert.ToInt32(Console.ReadLine());
            if (count < 2 || count > 7)
            {
                Console.WriteLine("Error!!!  Неверное количество автомобилей!");
                return 0;
            }
            Totalizator totalizator = new Totalizator(count);
            Console.SetCursorPosition(2, 3);
            Console.Write($"СДЕЛАЙТЕ ВАШУ СТАВКУ: ");
            int win_num = Convert.ToInt32(Console.ReadLine());
            if (win_num < 1 || win_num > count)
            {
                Console.WriteLine("Error!!!  Неверная ставка!");
                return 0;
            }


            Console.SetCursorPosition(2, 2);
            Console.Write($"КОЛИЧЕСТВО АВТО: ");

            Console.Write(count);
            Console.Write("    ВЫ ПОСТАВИЛИ НА АВТО: ");
            totalizator.SetColor(win_num);
            Console.Write($"=>> N {win_num}");
            totalizator.SetColor(0);

            Console.SetCursorPosition(0, 3);
            Console.WriteLine($"ТУРНИРНАЯ ТАБЛИЦА:                    ");

            Console.SetCursorPosition(57, 2);
            Console.WriteLine($"ДЛЯ НАЧАЛА НАЖМИТЕ ВВОД");
            totalizator.DrawTracks();
            Console.ReadKey();
            Console.SetCursorPosition(57, 2);
            Console.WriteLine($"                       ");



            totalizator.Move(win_num);
            //
            Console.ReadKey();
            return 0;
        }
    }
}