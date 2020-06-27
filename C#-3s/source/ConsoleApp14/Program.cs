using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    
    class Program
    {
        // объявление Делегата
        //[модификатор доступа] delegate тип_возврата Имя_Делегата(параметр1, параметр2, ....);
        //delegate int MyDelegate(double d); //можем поместить ссылки на методы и передать туда параметр [double] 
        delegate double CalcDelegate(double x, double y);

        class Calculator
        {
            public double Add(double x, double y)
            {
                return x + y;
            }
            public static double Sub(double x, double y)
            {
                return x - y;
            }
            public double Mult(double x, double y)
            {
                return x * y;
            }
            public static double Div(double x, double y)
            {
                if(y!= 0)
                {
                    return x / y;
                }
                throw new DivideByZeroException();
            }
        }

        static void Main(string[] args)
        {
             Calculator calc = new Calculator();
            /* Console.WriteLine("Input expression:");
             string expression = Console.ReadLine();
             char sign =' ';
             foreach(char item in expression)
             {
                 if (item == '+' || item == '-' || item == '*' || item== '/')
                 {
                     sign = item;
                     break;
                 }
             }
             try
             {
                 string[] numbres = expression.Split(sign);


                 //CalcDelegate calcDelegate = new CalcDelegate(); //в делегат передается ссылка на метод который принимает 2 дабла и возвращает дабл
                 CalcDelegate calcDelegate = null;
                 switch (sign)
                 {
                     case '+':
                         calcDelegate = new CalcDelegate(calc.Add);
                         break;
                     case '-':
                         calcDelegate = new CalcDelegate(Calculator.Sub); // если метод static
                         break;
                     case '*':
                         calcDelegate = calc.Mult; // групповое преобразование
                         break;
                     case '/':
                         calcDelegate = Calculator.Div; 
                         break;

                     default:
                         throw new InvalidOperationException();
                       //  break;  // - убираем за ненадобностью 
                 }

                 Console.WriteLine($"{double.Parse(numbres[0])} {sign} {double.Parse(numbres[1])} = " +
                     $"{calcDelegate(double.Parse(numbres[0]), double.Parse(numbres[1]))}"); // результат выдает ДЕЛЕГАТ!!!
             }

             catch (Exception ex)
             {
                 Console.WriteLine(ex.Message);
             }
            */
            //создаем коллекцию делегатов!!!!
            CalcDelegate calcDelegate = calc.Add;
            calcDelegate += Calculator.Div;
            calcDelegate += calc.Mult;
            calcDelegate += Calculator.Sub;
            // calcDelegate -= calc.Mult;

            double x = 26.78, y = 39.43;
            foreach (CalcDelegate item in calcDelegate.GetInvocationList())
            {
                Console.WriteLine($"Result: {item.Invoke(x, y)}");
            }
            Console.WriteLine($"Result: {calcDelegate(x, y)}");
            //calcDelegate.Invoke(x, y);

            //
            Console.ReadKey();
        }
    }
}
