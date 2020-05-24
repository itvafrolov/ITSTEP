using System;
using System.Drawing;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            /**************  ЗАДАЧА 1 **************************/
            /* Написать программу, которая находит в массиве значения, повторяющиеся два и более раз, и показывает их на экран.*/
            /*
             int size = 40;
             int[] arr = new int[size];
             //заполняем массив
             for (int i = 0; i < size; i++)
             {
                 arr[i] = random.Next(1, 99);
                 Console.Write("{0} ", arr[i]);
             }
             Console.WriteLine();
             for (int i = 0; i < size-1; i++)
             {
                 if (Array.IndexOf(arr, arr[i], 0, i)<0)
                 {
                     if (Array.IndexOf(arr, arr[i], i+1, size-i-1) >= 0)
                     {
                         Console.Write("{0} ", arr[i]);
                     }
                 }               
             }
            */ /// конец задачи 1





            /**************  ЗАДАЧА 2 **************************/
            /*Дан двумерный массив размерностью 5х5, заполненный случайными числами из диапазона от 0 до 100.
            Переформировать массив таким образом, чтобы его столбцы располагались по убыванию их поэлементных сумм.*/
            /*
             int str = 5, col = 5;
             int[,] arr = new int[str, col];     //2-мерный массив
             int[,] tmp = new int[str, col];     //его копия
             int[] arrSum = new int[col];        //массив сумм
             int[] arrSumIndex = new int[col];   //массив индексов - порядковые номера стролбцов

             //заполняем массивы и считаем суммы -- для этого работаем сначала со столбцами 
             for (int i = 0; i < col; i++)
             {
                 arrSum[i] = 0;
                 for (int j = 0; j < str; j++)
                 {
                     tmp[j, i] = arr[j, i] = random.Next(0, 100);  //заполнение 2-мерного массива и его копии
                     arrSum[i] = arr[j, i] + arrSum[i];           //заполнение массива сумм
                 }
                 arrSumIndex[i] = i;  // массив индексов
             }


             //-------------- 

             for (int i = 0; i < col; i++)
             {
                 Console.Write("{0}\t", arrSumIndex[i]);
             }
             Console.WriteLine("\n");
             for (int i = 0; i < str; i++)
             {      
                 for (int j = 0; j < col; j++)
                 {
                       Console.Write("{0}\t", arr[i, j]);
                 }
                 Console.WriteLine();
             }
             Console.WriteLine(); 
             // выводим суммы
             for (int i = 0; i < col; i++)
             {
                 Console.Write("{0}\t", arrSum[i]);
             }
             Console.WriteLine();
             int[] arrSumSort = new int[col];
             Array.Copy(arrSum, arrSumSort,col);     //копируем массив сумм для сортировки
             Array.Sort(arrSumSort, arrSumIndex);    //сортируем массивы по суммам и по индексам

             /////-------------- ПОСЛЕ ПРОВЕРКИ НЕ НУЖНЫЙ КУСОК КОДА
             //////////КОНТРОЛЬ!!! вывод результатов сортировок
             ////////for (int i = 0; i < col; i++)
             ////////{
             ////////    Console.Write("{0}->{1} ",i, arrSum[i]);
             ////////    Console.Write("{0}->{1} ", i, arrSumSort[i]);
             ////////    Console.WriteLine("{0}->{1} ", i, arrSumIndex[i]);
             ////////}
             ////////Console.WriteLine();

             ////////for (int i = 0; i < str; i++)
             ////////{
             ////////    for (int j = 0; j < col; j++)
             ////////    {
             ////////        Console.Write("{0} ",tmp[i, j]);
             ////////    }
             ////////    Console.WriteLine();
             ////////}
             ////////Console.WriteLine("---------------------");
             ////////---------- КОНЕЦ НЕ НУЖНЫЙ КУСОК КОДА

             //выводим на экран новый порядок следования столбцов
             for (int i = 0; i < col; i++)
             {
                 Console.Write("{0}\t", arrSumIndex[i]);
             }
             //пересоздаем массив с новым порядком столбцов и и пересчитываем суммы заново
             Console.WriteLine();
             for (int i = 0; i < col; i++)
             {
                 arrSum[i] = 0;
                 for (int j = 0; j < str; j++)
                 {
                     arr[j, i] = tmp[j, arrSumIndex[i]];
                     arrSum[i] = arr[j, i] + arrSum[i];
                 }               
             }
             //обновленный массив на экран
             Console.WriteLine();
             for (int i = 0; i < str; i++)
             {
                 for (int j = 0; j < col; j++)
                 {
                     Console.Write("{0}\t", arr[i, j]);
                 }
                 Console.WriteLine();
             }
             Console.WriteLine();
             // выводим суммы
             for (int i = 0; i < col; i++)
             {
                 Console.Write("{0} \t", arrSum[i]);
             }

             */ // конец задачи 2




            //---------------------------------

            Console.ReadKey();
        }
    }
}
