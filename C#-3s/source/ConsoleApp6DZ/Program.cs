﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 	Разработать абстрактный класс «Геометрическая Фигура» с методами «Площадь Фигуры» и «Периметр Фигуры».
Разработать классы-наследники: Треугольник, Квадрат, Ромб, Прямоугольник, Параллелограмм, Круг
Triangle, Square, Rhombus, Rectangle, Parallelogram, Circle.
Реализовать конструкторы, которые однозначно определяют объекты данных классов.
Реализовать класс «Составная Фигура», который может состоять из любого количества «Геометрических Фигур».
Для данного класса определить методы нахождения площади и периметра фигуры.
 */

namespace ConsoleApp6DZ
{
    abstract class Figure
    {
        public abstract double SquareFigures();
        public abstract double PerimeterFigures();
    }


    //треугольник
    class Triangle : Figure
    {
        public double _lenght1 { get; set; }
        public double _lenght2 { get; set; }
        public double _lenght3 { get; set; }

        public Triangle(double lenght1, double lenght2, double lenght3)
        {
            _lenght1 = lenght1;
            _lenght2 = lenght2;
            _lenght3 = lenght3;
        }

        public override double SquareFigures()
        {
            double p = PerimeterFigures() / 2;
            return Math.Sqrt(p * (p - _lenght1) * (p - _lenght2) * (p - _lenght3)); // Формула Герона
        }
        public override double PerimeterFigures()
        {
            return _lenght1 + _lenght2 + _lenght3;
        }
        public override string ToString()
        {
            return $"Figure: Triangle\n------------------------------\n Triangle side1: {_lenght1}, Triangle side2: {_lenght2}, Triangle side3: {_lenght3}, \n Triangle area: {SquareFigures()}\n Triangle Perimeter: {PerimeterFigures()}";
        }
    }

    //квадрат
    class Square : Figure
    {
        public double _lenght { get; set; }

        public Square(double lenght)
        {
            _lenght = lenght;
        }

        public override double SquareFigures()
        {
            return _lenght * _lenght;
        }
        public override double PerimeterFigures()
        {
            return _lenght * 4;
        }
        public override string ToString()
        {
            return $"Figure: Square\n------------------------------\n Square side: {_lenght}\n Square area: {SquareFigures()}\n Square Perimeter: {PerimeterFigures()}";
        }
    }

    //ромб
    class Rhombus : Figure
    {
        public double _lenght { get; set; }
        public double _angle { get; set; }
        //public double _diag1{ get; set; }
        //public double _diag2 { get; set; }


        public Rhombus(double lenght, double angle)
        {
            _lenght = lenght;
            _angle = angle;           
        }

        public override double SquareFigures()
        {
            return _lenght * _lenght * Math.Sin(_angle);
        }
        public override double PerimeterFigures()
        {
            return _lenght * 4;
        }
        public override string ToString()
        {
            return $"Figure: Rhombus\n------------------------------\n Rhombus side: {_lenght}, Rhombus angle: {_angle} Radian \n Rhombus area: {SquareFigures()}\n Rhombus Perimeter: {PerimeterFigures()}";
        }
    }


    //прямоугольник
    class Rectangle : Figure
    {
        public double _lenght1 { get; set; }
        public double _lenght2 { get; set; }


        public Rectangle (double lenght1, double lenght2)
        {
            _lenght1 = lenght1;
            _lenght2 = lenght2;
        }
        public override double SquareFigures()
        {
            return _lenght1 * _lenght2;
        }
        public override double PerimeterFigures()
        {
            return (_lenght1 + _lenght2 )* 2;
        }
        public override string ToString()
        {
            return $"Figure: Rectangle\n------------------------------\n Rectangle side1: {_lenght1}, side2: {_lenght2} \n Rectangle area: {SquareFigures()}\n Rectangle Perimeter: {PerimeterFigures()}";
        }
    }

    //параллелограмм
    class Parallelogram : Figure
    {
        public double _lenght1 { get; set; }
        public double _lenght2 { get; set; }
        public double _angle { get; set; }


        public Parallelogram(double lenght1, double lenght2, double angle)
        {
            _lenght1 = lenght1;
            _lenght2 = lenght2;
            _angle = angle;
        }

        public override double SquareFigures()
        {
        return _lenght1 * _lenght2 * Math.Sin(_angle);
        }
        public override double PerimeterFigures()
        {
        return (_lenght1 + _lenght2) * 2;
        }
         public override string ToString()
         {
        return $"Figure: Parallelogram\n------------------------------\n Parallelogram side1: {_lenght1}, side2: {_lenght2}, Angle: {_angle} Radian \n Parallelogram area: {SquareFigures()}\n Parallelogram Perimeter: {PerimeterFigures()}";
         }
}

    //круг
    class Circle : Figure
    {
        public double _radius { get; set; }

        public Circle(double R)
        {
            _radius = R;
        }

        public override double SquareFigures()
        {
            return _radius * _radius * Math.PI;
        }
        public override double PerimeterFigures()
        {
            return _radius * Math.PI * 2;
        }
        public override string ToString()
        {
            return $"Figure: Circle\n------------------------------\n Circle radius: {_radius}\n Circle area: {SquareFigures()}\n Circle lenght: {PerimeterFigures()}";
        }
    }

    class CompositeFigure
    {

    }


    class Program
    {
        static void Main(string[] args)
        {
            Triangle tri = new Triangle(4, 3, 5);  // параметры для прямоугольного треугольника (для перепроверки правильности формулы площади)
            Console.WriteLine(tri);
            Console.WriteLine("\n---------------------------------------------\n");

            Square s = new Square (12.3);
            Console.WriteLine(s);
            Console.WriteLine("\n---------------------------------------------\n");

            Rhombus romb = new Rhombus(15.4, (3.1415926/4));  // 45 g
            Console.WriteLine(romb);
            Console.WriteLine("\n---------------------------------------------\n");

            Rectangle rec= new Rectangle(12.5, 26.4);
            Console.WriteLine(rec);
            Console.WriteLine("\n---------------------------------------------\n");

            Parallelogram pargr = new Parallelogram(12.2, 15, 0.75);
            Console.WriteLine(pargr);
            Console.WriteLine("\n---------------------------------------------\n");

            Circle c = new Circle(14.3);
            Console.WriteLine(c);
            Console.WriteLine("\n---------------------------------------------\n");




            //
            Console.ReadKey();
        }

    }
}
