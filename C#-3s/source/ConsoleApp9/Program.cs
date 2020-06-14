using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        class Point
        {
            public int? X {get; set;}
            public int? Y {get; set;}

        public static bool operator true(Point p)
            {
            return p.X != null && p.Y != null; 
            }
        public static bool operator false(Point p)
            {
                return p.X == null || p.Y == null;
            }

        }

        abstract class Figure
        {
            public abstract void Draw();
        }

        abstract class Quadrangle : Figure  {  }
        class Rectangle : Quadrangle
        {
            public int Width { get; set; }
            public int Height { get; set; }
            public override void Draw()
            {
                //Draw;
            }
            public override string ToString()
            {
                return $"Width: {Width} Height: {Height}";
            }   
            public static implicit operator Rectangle(Square s) //implicit ВАЖНО - пишется когда нет потери данных
            {
                return new Rectangle { Width = s.Lenght, Height = s.Lenght };
            }

            public static explicit operator Square(Rectangle rect)
            {
                return new Square
                {
                    Lenght = rect.Height < rect.Width ? rect.Height : rect.Width
                };
            }
        }
        class Square : Quadrangle
        {
            public int Lenght { get; set; }
            public override void Draw()
            {
                //
            }
            public override string ToString()
            {
                return $"Lenght: {Lenght}";
            }
            public static explicit operator int(Square s)
            {
                return s.Lenght;
            }
            public static implicit operator Square(int s)
            {
                return new Square { Lenght = s};
            }
        }

        class Laptop
        {
            public string Vendor { get; set; }
            public double Price { get; set; }

            public override string ToString()
            {
                return $"{Vendor} {Price}";
            }
        }
        enum Vendors  {Asus, Sumsung, LG };
        class Shop
        {
            private Laptop[] _laptops;  // потому что тут private  потому нужно писать индексатор

            public Shop(int size)
            {
                _laptops = new Laptop[size];
            }
            public int Lenght { get { return _laptops.Length; } }
            public Laptop this[int index]   // вся ниже следующая конструкция называется индексатор
            {
                get
                {
                    if (index >= 0 && index < Lenght) return _laptops[index];
                    throw new IndexOutOfRangeException();
                }

                set
                {
                    if (index >= 0 && index < Lenght)
                        _laptops[index] = value;
                }
            }
            //перегрузка индексатора
            public Laptop this[string name]
            {
                get
                {
                    if (Enum.IsDefined(typeof(Vendors), name))
                    {
                        int index = (int)Enum.Parse(typeof(Vendors), name);
                        return _laptops[index];
                    }
                    throw new Exception(";)");
                }

                set 
                {
                if (Enum.IsDefined(typeof(Vendors), name))
                    {
                        _laptops[(int)Enum.Parse(typeof(Vendors), name)] = value;
                    }
                }
            }

            private int FindByPrice(double price)
            {
                for(int i = 0; i<Lenght; i++)
                {
                    if(_laptops[i].Price == price)
                    {
                        return i;
                    }
                }
                return -1;
            }


            public Laptop this[double price]
            {
                get
                {
                    int index = FindByPrice(price);
                    if (index >= 0)
                    {
                        return this[index];  //this (это метод - индексатор) используется потому что мы обращаемся к своему уже написанному индексатору
                    }
                    //можно записать так:
                    // return this[FindByPrice(price)];
                    throw new Exception("Недопустимая стоимость!");
                }

                set
                {
                    int index = FindByPrice(price);
                    if (index>=0)
                    {
                        this[index] = value;  //this используется потому что мы обращаемся к своему уже написанному индексатору
                    }
                }
            }

        }

        static void Main(string[] args)
        {


            //Point p1 = new Point { X = 5, Y = 12 };
            //Point p2 = new Point { X = null, Y = 3 };
            //----------------------------------------------------------
            /*
            double d = 23.123;
            // int n = d;  - такая запись - ошибка, а вот так можно:
            int n = (int)d;
            double d1 = n;  // целое к вещественному ошибку не выдает!
            Rectangle rec = new Rectangle { Width = 10, Height = 6 };
            Square explisSqu = (Square)rec;

            Square sque2 = new Square { Lenght = 10 };
            Rectangle rec2 = sque2;
            Console.WriteLine(rec2);
            Console.WriteLine(explisSqu);
            int number = 34;
            Square intSqu2 = number;
            int n1 = (int)intSqu2;
            */
            //-----------------   индексатор   ---------------------------
            Shop shop1 = new Shop(3);
            shop1[0] = new Laptop { Vendor = "Asus", Price = 15354.14 };
            shop1[1] = new Laptop { Vendor = "Sumsung", Price = 17354.14 };
            shop1[2] = new Laptop { Vendor = "Lg", Price = 11354.14 };

            for (int i =0; i<shop1.Lenght; i++)
            {
                Console.WriteLine(shop1[i]);
            }

            try
            {
                shop1[7] = new Laptop { Vendor = "Lg", Price = 11354.14 };
                Console.WriteLine(shop1[7]);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(shop1["Asus"]);
            shop1["Asus"] = new Laptop { Vendor = "HP", Price = 9354.14 };
            Console.WriteLine(shop1["Asus"]);

            //
            Console.ReadKey();
            
        }
    }
}
