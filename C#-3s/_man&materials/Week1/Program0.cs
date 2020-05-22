using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             float num;
             Console.WriteLine("Enter num:\n");
             string str = Console.ReadLine();
             //num = double.Parse(str);  // один способ - работает только со строкой
             num = Convert.ToSingle(str);  // работает с различными типами данных  -- ToSingle для преообразования в 
             Console.WriteLine(num);

             double? d1 = null;  // иначе не примет значение "null"
             int? nullInt = null;
             nullInt = nullInt ?? 50;
             string str2 = null;
            */
            /*
             Имена переменных
            -- Паскаль кейс -- первая большая буква Большая
            -- Кэмел кейсинг -- первая маленькая остальные в словах большие numberOneTwo
                название класса с большой название медода с большой

            --БОЛЬШИМИ все когда это общепринятые абревиатуры  CPU NATO и т д
             */

            /*ОПЕРАТОРЫ 
             * арифметические  + - * / % ( += -= *= /= %=)
             * унарные - ++ -- 
             * логические  > <  >= <=  != == 
             * &&,  &,  ||, |, !
             * побитовые  & | ^ >> << ~              
             * 
             * условные
             * if 
             */

            //int i = 0;
            //while (i<10)
            //{
            //    if (i == 5)
            //    {
            //        continue;  // получаем вечный цыкл  
            //    }
            //    Console.WriteLine(i);
            //    i++;
            //}

            /*
             * Найти все двузначные числа, которые делятся на n без остатка или содержат цифру n (вводится с клавиатуры).
             */

            int n;
            string str = Console.ReadLine();
            n = Convert.ToInt32(str);
           for (int i = 10; i < 100; i++)
            {
                if ((i % n == 0)|| ((i % 10) == n) || ((i / 10) == n))
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
