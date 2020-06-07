using System;
using System.Drawing;
using System.Globalization;
using System.Threading;

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
            /********** начало задачи 2 ***********/
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




            /**************  ЗАДАЧА 3 **************************/
            /*
             * 3. В массиве хранится информация о количестве жильцов каждой квартиры пятиэтажного дома 
             (4 подъезда, на каждом этаже по 2 квартиры).
            - по выбранному номеру квартиры определить количество жильцов, а также их соседей проживающих на одном этаже;
            - определить суммарное количество жильцов для каждого подъезда;
            - определить номера квартир, где живут многодетные семьи. 
            Условно будем считать таковыми, у которых количество членов семьи превышает пять человек.*/
            /********** начало задачи 2 ***********/

            //*******  РЕШЕНИЕ:  
            //Количество квартир в подъезде = 5 х 2 = 10  =>  х 4(подъезда)  = 40 (всего)
            // Нумерация квартир - 1,2,3,4 и тд. тоесть в массивe это (index + 1)
            //соседние квартиры - это младшее нечетное и старшее четное  ( 1 и 2 )  (10 и 9)  
            // а в массиве это младшее четное и старшее нечетное (10 и 11)
            //-----------------------------------------------------------------------------------
            //делаем массив и рандомим туда количество жителей от 1 до 9
            // ***** начало задачи 3 
            /*

            int count = 40;
            int[] home = new int[count];
            for (int i = 0; i < count; i++)
            {
                home[i] = random.Next(1, 9);
            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("{0} -> {1}", i+1, home[i]);
            }

            // задаем номер квартиры
            Console.Write("Apartment number:  "); 
            int number = Convert.ToInt32(Console.ReadLine());
            if (((number-1)%2)==0)
            {
                Console.Write("Residents:  ");
                Console.WriteLine("{0} -> {1}", number, home[number-1]);
                Console.Write("Neighbors:  ");
                Console.WriteLine("{0} -> {1}", number+1, home[number]);
            }
            else
            {
                Console.Write("Residents:  ");
                Console.WriteLine("{0} -> {1}", number, home[number - 1]);
                Console.Write("Neighbors:  ");
                Console.WriteLine("{0} -> {1}", number-1, home[number-2]);
            }

            //считаем количество жильцов для каждого подъезда 10 на каджый
            int countResidents = 0;
            for (int i = 0; i < 40; i++)
            {
                countResidents = countResidents + home[i];
                if (((i+1)%10)==0)
                {
                    Console.Write("Front door number:  ");
                    Console.WriteLine("{0} Residents -> {1}", (i + 1) / 10, countResidents);
                   // Console.Write(" ");
                   // Console.WriteLine(countResidents);
                    //Console.WriteLine("{0} -> {1}", , countResidents);
                    countResidents = 0;
                }
            }
            //выводим квартиры с численностью жильцов от 5
            for (int i = 0; i < 40; i++)
            {                
                if (home[i] > 5 )
                {                 
                    Console.WriteLine("{0} Residents -> {1}", i + 1, home[i]);
                }
            }
            */  //конец задачи 3

            //---------------------------------

            Console.ReadKey();
        }
    }
}
