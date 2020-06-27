using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13_2
{
    class Point
    {
        //...
    }
    class Point2D<T>: Point where T: struct
    {
        public T X { get; set; }
        public T Y { get; set; }

        public  Point2D(T x, T y)
        {
            X = x;
            Y = y;
        }

        public Point2D()
        {
            X = default(T);
            Y = default(T);
        }
        public override string ToString()
        {
            return $"X: {X} Y: {Y}";
        }

        public virtual void M1(T n)
        {
            Console.WriteLine($"Point2D {n}" );
        }

    }

    class Point3D : Point2D<int> // явное указание типа обязательное
    {
        public int Z { get; set; }
        public Point3D(int x, int y, int z): base(x, y)
        {
            Z = z;
        }

        public override void M1(int n)
        {
            Console.WriteLine($"Point2D {n}");
        }

        public override string ToString()
        {
            return $"X: {X} Y: {Y} Z: {Z}";
        }

    }

    class Program
    {
        static void Swap <T>(ref T a, ref T b) where T: struct
        {
            T temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {

            /*
            Point2D<int> pointInt = new Point2D<int>();
            Point2D<int> pointInt2 = new Point2D<int>(45, 5);
            //Console.WriteLine(pointInt2.X);
            //Console.WriteLine(pointInt2.Y);
            Point2D<double> pointInt3 = new Point2D<double>(45.5, 75.64);
            Console.WriteLine(pointInt3);

            Point3D point3D = new Point3D(0, 45, 75);
            point3D.M1(123);
            Console.WriteLine(point3D );
            // Point2D<string> pointt2D = new Point2D<string>(); // -ошибка потому, что применяется ссылочный тип данных <string>. это не допускается
            */
            /*
            int n1 = 67, n2 = 59;
            Swap<int>(ref n1, ref n2);
            Console.WriteLine($"{n1} {n2}");

            double d1 = 12.12, d2 = 13.13;
            Swap(ref d1, ref d2);
            Console.WriteLine($"{d1} {d2}");
            */



        }
    }
}
