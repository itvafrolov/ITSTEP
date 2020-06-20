using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10_DZ
{
    public class CountMantissa
    {
        double _x { get; set; }

        public CountMantissa() { }

        public CountMantissa(double x)
        {
            _x = x;
        }
       // string
        public int Count()
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

        public override string ToString()
        {
            return $"{_ch}/{_zn}";
        }

        // варианты перегрузки оператора  + 
        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            if (f1._zn == f2._zn)
            {
                return new Fraction()
                {
                    _ch = f1._ch + f2._ch,
                    _zn = f1._zn
                };
            }
            else
            {
                return new Fraction()
                {
                    _ch = f1._ch * f2._zn + f2._ch * f1._zn,
                    _zn = f1._zn * f2._zn
                };
            }
        }

        public static Fraction operator +(Fraction f1, int x)
        {
            return new Fraction()
            {
                _ch = f1._ch + x * f1._zn,
                _zn = f1._zn
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

        //public static double operator +(Fraction f1, double x)
        //{
        //    return (((double)f1._ch / (double)f1._zn) + x );
        //}
        //public static double operator +( double x, Fraction f1)
        //{
        //    return ((double)f1._ch / (double)f1._zn) + x;
        //}

        //пара глупых перезагрузок + 
        public static Fraction operator +(Fraction f1, double x)
        {
           CountMantissa b = new CountMantissa(x);  //класс для определения количества цыфр после запятой
           int s = b.Count();
           return new Fraction()
            {
                _ch = f1._ch  + (int)(x * Math.Pow(10, s)) * f1._zn,
                _zn = f1._zn 
            };
        }
        //public static Fraction operator +(double x, Fraction f1)
        //{
        //    return ((double)f1._ch / (double)f1._zn) + x;
        //}


        // варианты перегрузки оператора  -
        public static Fraction operator -(Fraction f1, Fraction f2)
    {
            if (f1._zn == f2._zn)
            {
                return new Fraction()
                {
                    _ch = f1._ch - f2._ch,
                    _zn = f1._zn
                };
            }
            else
            {
                return new Fraction()
                {
                    _ch = f1._ch * f2._zn - f2._ch * f1._zn,
                    _zn = f1._zn * f2._zn
                };
            }
        }
        
        public static Fraction operator -(Fraction f1, int x)
        {
            return new Fraction()
            {
                _ch = f1._ch - x * f1._zn,
                _zn = f1._zn
            };
        }
        public static Fraction operator -(int x, Fraction f1)
        {
            return new Fraction()
            {
                _ch = x * f1._zn - f1._ch,
                _zn = f1._zn
            };
        }

        public static double operator -(Fraction f1, double x)
        {
            return (f1._ch / f1._zn) - x;
        }
        public static double operator -(double x, Fraction f1)
        {
            return x-(f1._ch / f1._zn);
        }
        // варианты перегрузки оператора  * 
        public static Fraction operator *(Fraction f1, Fraction f2)
        {           
                return new Fraction()
                {
                    _ch = f1._ch * f2._ch,
                    _zn = f1._zn * f2._zn
                };
           
        }

        public static Fraction operator *(Fraction f1, int x)
        {
            return new Fraction()
            {
                _ch = f1._ch * x,
                _zn = f1._zn
            };
        }
        public static Fraction operator *(int x, Fraction f1)
        {
            return new Fraction()
            {
                _ch = f1._ch * x,
                _zn = f1._zn
            };
        }

        public static double operator *(Fraction f1, double x)
        {
            return (f1._ch / f1._zn) * x;
        }
        public static double operator *(double x, Fraction f1)
        {
            return (f1._ch / f1._zn) * x;
        }
        // варианты перегрузки оператора  / 
        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            return new Fraction()
            {
                _ch = f1._ch / f2._ch,
                _zn = f1._zn / f2._zn
            };

        }

        public static Fraction operator /(Fraction f1, int x)
        {
            return new Fraction()
            {
                _ch = f1._ch,
                _zn = f1._zn * x
            };
        }
        public static Fraction operator /(int x, Fraction f1)
        {
            return new Fraction()
            {
                _ch = f1._zn * x,
                _zn = f1._ch
            };
        }

        public static double operator /(Fraction f1, double x)
        {
            return (f1._ch / f1._zn) / x;
        }
        public static double operator /(double x, Fraction f1)
        {
            return  x / (f1._ch / f1._zn);
        }

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

        //для явного преобразования double в дробь

        public static implicit operator Fraction (double x) //implicit - пишется когда нет потери данных, explicit - когда потеря возможна
        {
            CountMantissa b = new CountMantissa(x);
            int s = b.Count();
            return new Fraction()
            {
                _ch = (int)(x * Math.Pow(10, s)),
                _zn = (int)Math.Pow(10, s)
            };           
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Fraction f1 = new Fraction(2, 3);
            //Fraction f2 = new Fraction(3, 4);

            //Fraction f3 = f1 + f2;
            //Console.WriteLine(f1 + f2);
            //Console.WriteLine(f2 - f1);

            //Console.WriteLine(f1 + 2);
            //Console.WriteLine(f1 + 2);

            // --------------------------------
            
            Fraction f = new Fraction(3, 4);
           // Console.WriteLine(f);
            int a = 10;
            Fraction f1 = f * a;
            
            //Console.WriteLine(f1);

            Fraction f2 = a * f;

            // Console.WriteLine(f2);

            double d = 1.5;
            //Console.WriteLine(f + d);
            //Console.WriteLine(d - f);

            Fraction f3 = f + d;

            Console.WriteLine(f3);

            Fraction f4 = f + (Fraction)d;
            Console.WriteLine(f4);
        }
    }
}
