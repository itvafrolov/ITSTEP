using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10_DZ
{
    // по хорошему он конечно не нужен, но хотел попробовать использование классов для расчетов внутри моего класса
    public class CountMantissa
    {
        double _x { get; set; }

        public CountMantissa() { }

        public CountMantissa(double x)
        {
            _x = x;
        }
        // string
        public int CountOne()  // не буду использовать - выдает не то, что я вижу на экране. Понимаю почему, но потому и не подходит
        {
            double a = _x - (int)_x;
            int b;
            if (a != 0) b = 1;
            else b = 0;
            for (int i = 0; i < b; i++)
            {
                a = a * 10 % 10;
                if (a != 0) b++;
            }
            return --b;
        }

        // Такой вариант более управляемый. 
        //предположим, что дальше 6-го знака мы не пойдем - уверен, что уже достаточная точность!
        public int Count()
        {
            double a = Math.Round((_x * 10E5), 0);
            int count = 6;
            for (int i = 6; i > 0; i--)
            {
                if (a % 10 == 0) count--;
                a = a / 10 - a % 10;
            }
            return count;
        }
    }
    class Fraction
    {
        int _ch { get; set; }
        int _zn { get; set; }
        public Fraction () { }
        public Fraction (int ch, int zn)
        {
            _ch = ch;
            _zn = zn;
        }

        // парочка нужных функций 
        // наибольший общий делитель для сокращения дробей
        private static int NOD (int x, int y)
        {
            while (x != y)
            {
                if (x > y)
                    x = x - y;
                else
                    y = y - x;
            }
            return x;
        }

        //количество цифр после запятой для double чисел  - считаем, что 6-ти вполне достаточно для достижения суперточности 
        // и потому округляем число с плавающей точкой до 6-го знака и дальше преобразовываем именно его
        private static int CountMant(double x)
        {
            double a = Math.Round((x * 10E5), 0);
            int count = 6;
            for (int i = 6; i > 0; i--)
            {
                if (a % 10 == 0) count--;
                a = a / 10 - a % 10;
            }
            return count;  // отдает реальное количество значимых цифр после запятой, но не больше 6-ти
        }
        
        //   для явного преобразования double в дробь -- 
        //-- а это работаем с дополнительным классом и одновременно тренируем явное приведение типов
        public static implicit operator Fraction(double x) //implicit - пишется когда нет потери данных, explicit - когда потеря возможна
        {
            x = Math.Round(x, 6);  
            CountMantissa b = new CountMantissa(x);
            int s = b.Count();
            int ch = (int)(x * Math.Pow(10, s));
            int zn = (int)Math.Pow(10, s);

            return new Fraction()
            {
                _ch = ch / NOD(ch, zn),
                _zn = zn / NOD(ch, zn)
            };
        }

        // вывод дроби на экран
        public override string ToString()
        {
            return $"{_ch}/{_zn}";
        }

        // варианты перегрузки оператора  + 
        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            int ch;
            int zn;

            if (f1._zn == f2._zn)
            {
               ch = f1._ch + f2._ch;
               zn = f1._zn;
            }
            else
            {
                ch = f1._ch * f2._zn + f2._ch * f1._zn;
                zn = f1._zn * f2._zn;
            }
            return new Fraction()
            {
                _ch = ch / NOD(ch, zn),
                _zn = zn / NOD(ch, zn)
            };
        }

        public static Fraction operator +(Fraction f1, int x)
        {
            int ch = f1._ch + x * f1._zn;
            int zn = f1._zn;

            return new Fraction()
            {
                _ch = ch / NOD(ch, zn),
                _zn = zn / NOD(ch, zn)
            };
        }
        public static Fraction operator +(int x, Fraction f1)
        {
            return new Fraction()
            {
                _ch = f1._ch + x * f1._zn,
                _zn = f1._zn
            };
        }

       
        public static Fraction operator +(Fraction f1, double x)
        {
            // вариант напрямую
            x = Math.Round(x, 6); // на всякий случай
            int s = CountMant(x);
            int ch = f1._ch * (int)Math.Pow(10, s) + (int)(x * Math.Pow(10, s)) * f1._zn;
            int zn = f1._zn * (int)Math.Pow(10, s);

            //вариант через явное приведение (работает и то и другое но напрямую короче)

            //int ch;
            //int zn;
            //int ch2 = ((Fraction)x)._ch;
            //int zn2 = ((Fraction)x)._zn;

            //if (f1._zn == zn2)
            //{
            //    ch = f1._ch + ch2;
            //    zn = f1._zn;
            //}
            //else
            //{
            //    ch = f1._ch * zn2 + ch2 * f1._zn;
            //    zn = f1._zn * zn2;
            //}

            return new Fraction()
            {
               _ch = ch / NOD(ch, zn),
               _zn = zn / NOD(ch, zn)
           };
        }
        public static Fraction operator +(double x, Fraction f1)
        {
            x = Math.Round(x, 6);
            int s = CountMant(x);
            int ch = f1._ch * (int)Math.Pow(10, s) + (int)(x * Math.Pow(10, s)) * f1._zn;
            int zn = f1._zn * (int)Math.Pow(10, s);        

            return new Fraction()
            {
                _ch = ch / NOD(ch, zn),
                _zn = zn / NOD(ch, zn)
            };
        }
        // варианты перегрузки оператора  -
        public static Fraction operator -(Fraction f1, Fraction f2)
    {
            int ch, zn;
            if (f1._zn == f2._zn)
            {
                ch = f1._ch - f2._ch;
                zn = f1._zn;
            }
            else
            {
                ch = f1._ch * f2._zn - f2._ch * f1._zn;
                zn = f1._zn * f2._zn;                
            }
            return new Fraction()
            {
                _ch = ch / NOD(ch, zn),
                _zn = zn / NOD(ch, zn)
            };
        }

        public static Fraction operator -(Fraction f1, int x)
        {
            int ch = f1._ch - x * f1._zn;
            int zn = f1._zn;
            
            return new Fraction()
            {
                _ch = ch / NOD(ch, zn),
                _zn = zn / NOD(ch, zn)
            };

        }
        public static Fraction operator -(int x, Fraction f1)
        {

            int ch = x * f1._zn - f1._ch;
            int zn = f1._zn;

            return new Fraction()
            {
                _ch = ch / NOD(ch, zn),
                _zn = zn / NOD(ch, zn)
            };
        }

        public static Fraction operator -(Fraction f1, double x)
        {
            x = Math.Round(x, 6);
            int s = CountMant(x);
            int ch = f1._ch * (int)Math.Pow(10, s) - (int)(x * Math.Pow(10, s)) * f1._zn;
            int zn = f1._zn * (int)Math.Pow(10, s);

            return new Fraction()
            {
                _ch = ch / NOD(ch, zn),
                _zn = zn / NOD(ch, zn)
            };

        }
        public static Fraction operator -(double x, Fraction f1)
        {
            x = Math.Round(x, 6);
            int s = CountMant(x);
            int ch = (int)(x * Math.Pow(10, s)) * f1._zn - f1._ch * (int)Math.Pow(10, s) ;
            int zn = f1._zn * (int)Math.Pow(10, s);

            return new Fraction()
            {
                _ch = ch / NOD(ch, zn),
                _zn = zn / NOD(ch, zn)
            };
        }
        // варианты перегрузки оператора  * 
        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            int ch = f1._ch * f2._ch;
            int zn = f1._zn * f2._zn;
            return new Fraction()           
            {
                 _ch = ch / NOD(ch, zn),
                 _zn = zn / NOD(ch, zn)
            };
        }

        public static Fraction operator *(Fraction f1, int x)
        {
            int ch = f1._ch * x;
            int zn = f1._zn;

            return new Fraction()
            {
                _ch = ch / NOD(ch, zn),
                _zn = zn / NOD(ch, zn)
            };
        }
        public static Fraction operator *(int x, Fraction f1)
        {
            int ch = f1._ch * x;
            int zn = f1._zn;

            return new Fraction()
            {
                _ch = ch / NOD(ch, zn),
                _zn = zn / NOD(ch, zn)
            };
        }

        public static Fraction operator *(Fraction f1, double x)
        {
            // на этом месте писать расчетную часть для х меня уже достало и дальше 
            // использую приведение и вуаля.... все работает. 
            // Смущает, что немного медленнее, чем если напрямую, но на то и технологии

            int ch = f1._ch * ((Fraction)x)._ch;
            int zn = f1._zn * ((Fraction)x)._zn;
            return new Fraction()
            {
                _ch = ch / NOD(ch, zn),
                _zn = zn / NOD(ch, zn)
            };
            // ничего так... компактненько >>> проверил ->> РАБОТАЕТ ПРАВИЛЬНО!
        }

        public static Fraction operator *(double x, Fraction f1)
        {
            int ch = f1._ch * ((Fraction)x)._ch;
            int zn = f1._zn * ((Fraction)x)._zn;
            return new Fraction()
            {
                _ch = ch / NOD(ch, zn),
                _zn = zn / NOD(ch, zn)
            };
        }

        // варианты перегрузки оператора  / 
        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            // умножаем на перевернутую f2
            int ch = f1._ch * f2._zn;
            int zn = f1._zn * f2._ch;

            return new Fraction()
            {
                _ch = ch / NOD(ch, zn),
                _zn = zn / NOD(ch, zn)
            };
        }

        public static Fraction operator /(Fraction f1, int x)
        {

            int ch = f1._ch;
            int zn = f1._zn * x;
            return new Fraction()
            {
                _ch = ch / NOD(ch, zn),
                _zn = zn / NOD(ch, zn)
            };


        }
        public static Fraction operator /(int x, Fraction f1)
        {
            int ch = f1._zn * x;
            int zn = f1._ch;
            return new Fraction()
            {
                _ch = ch / NOD(ch, zn),
                _zn = zn / NOD(ch, zn)
            };

        }

        public static Fraction operator /(Fraction f1, double x)
        {
            // и вот она сила явного приведения!!!!  на сколько все же короче код!

            int ch = f1._ch * ((Fraction)x)._zn;
            int zn = f1._zn * ((Fraction)x)._ch;
            return new Fraction()
            {
                _ch = ch / NOD(ch, zn),
                _zn = zn / NOD(ch, zn)
            };

        }
        public static Fraction operator /(double x, Fraction f1)
        {
            int ch = f1._zn * ((Fraction)x)._ch;
            int zn = f1._ch * ((Fraction)x)._zn;
            return new Fraction()
            {
                _ch = ch / NOD(ch, zn),
                _zn = zn / NOD(ch, zn)
            };
        }

        //можно конечно не заморачиватья и написать один раз приведение int -го числа и потом просто подставлять как это сделано в double


        public static bool operator ==(Fraction f1, Fraction f2)
        {
            if (f1._ch * f2._zn == f2._ch * f1._zn) return true;
            else return false;
        }
        public static bool operator !=(Fraction f1, Fraction f2)
        {
            if (f1._ch * f2._zn != f2._ch * f1._zn) return true;
            else return false;
        }
        public static bool operator >(Fraction f1, Fraction f2)
        {
            if (f1._ch * f2._zn > f2._ch * f1._zn) return true;
            else return false;
        }
        public static bool operator <(Fraction f1, Fraction f2)
        {
            if (f1._ch * f2._zn < f2._ch * f1._zn) return true;
            else return false;
        }

        public static bool operator true (Fraction f1)
        {
            if (f1._ch / f1._zn < 1) return true;
            else return false;
        }
        public static bool operator false(Fraction f1)
        {
            if (f1._ch / f1._zn > 1) return true;
            else return false;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Fraction f11 = new Fraction(2, 3);
            //Fraction f12 = new Fraction(3, 4);

            //Fraction f3 = f1 + f2;
            //Console.WriteLine(f11 + f12);
            //Console.WriteLine(f12 - f11);

            //Console.WriteLine(f1 + 2);
            //Console.WriteLine(f1 + 2);

            // --------------------------------

            Fraction f = new Fraction(3, 4);
            Console.WriteLine(f);
            int a = 10;
            Fraction f1 = f * a;

            Console.WriteLine(f1);

            Fraction f2 = a * f;

            Console.WriteLine(f2);

            double d = 1.35;
            Console.WriteLine(f + d);
            Console.WriteLine(d - f);

            Fraction f3 = f + d;
            Fraction f5 = d - f;

            Console.WriteLine(f3);

            Fraction f4 = f + d;
            Console.WriteLine(f4);
            Console.WriteLine(f * d);
            // Console.WriteLine(f + (Fraction)d2);
            // //Console.WriteLine(f- (Fraction)d2);

            // ну вобщем все работает. 
            // только не стал заморачиваться проверкой размера больших чисел для явного приведения из double в дробь 
            // потому, что при вводе большого числа с большой целой частью будет потеря данных даже для long. 
            // в реальной жизни заморочился бы посеръезнее такими возможностями, но для учебной задачки, думаю, достаточно будет.            
        }
    }
}
