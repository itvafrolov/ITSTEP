using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp8
{
    //перегрузка операторов   
        public class Point
        {
            public int x { get; set; }
            public int y { get; set; }

        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString(); //работает только когда метод ToString() переопределен
        }

        //унарные
        public static Point operator ++(Point p)
            {
                p.x++;
                p.y++;
                return p;
            }
            public static Point operator --(Point p)
            {
                p.x--;
                p.y--;
                return p;
            }
            public static Point operator -(Point p)
            {
                return new Point { x = -p.x, y = -p.y };
                /*
                p.x*=-1;
                p.y *= -1;
                return p;
                */
            }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
                //base.GetHashCode();
        }

        public static bool operator ==(Point p1, Point p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2);
        }

        public override string ToString()
            {
                return $"Point: X = {x}, Y = {y}";
            }
        }


        public class Vector
        {
        public int x { get; set; }
        public int y { get; set; }

        public Vector() { }

        public Vector(Point begin, Point end)
        {
            x = end.x - begin.x;
            y = end.y - begin.y;
        }
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector()
            {
                x = v1.x + v2.x,
                y = v1.y + v2.y
            };
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector()
            {
                x = v1.x - v2.x,
                y = v1.y - v2.y
            };
        }

        public static Vector operator *(Vector v, int n)
        {
            v.x *= n;
            v.y *= n;

            return v;
        }
        public override string ToString()
        {
            return $"Vector: X = {x}, Y = {y}";
        }
    }
    class Program
        {
        static void Main(string[] args)
        {
            //Point point = new Point { x = 10, y = 10 };
            //Console.WriteLine(point++);
            //Console.WriteLine(++point);
            //Console.WriteLine(point--);
            //Console.WriteLine(--point);
            //Console.WriteLine(-point);     

            //Point p1 = new Point { x = 5, y = 8 };
            //Point p2 = new Point { x = 10, y = 3 };
            //Vector v1 = new Vector(p1, p2);
            //Vector v2 = new Vector
            //{
            //    x = 7,
            //    y = 9
            //};

            //Console.WriteLine(v1 + v2);
            //Console.WriteLine(v1 - v2);
            //int n = 5;
            //v1 *= n;
            //Console.WriteLine(v1);

            int number = 45;
            object obj = number; //  упаковка  -- создается ссылка
            // int n1 = obj; // err
            int n1 = (int)obj;  // явное преобразование типов -- распаковка
                       

            //
            Console.ReadKey();
        }
    }
}
