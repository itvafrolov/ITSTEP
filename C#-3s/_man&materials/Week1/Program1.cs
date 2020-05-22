using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            ////////***   МАССИВЫ   ***//////////////
                Random random = new Random();
            //объявление массива
            //тип_данных[] = new имя_массива[размер];
            //
            /*     Console.WriteLine("Input size: ");
                int size = int.Parse(Console.ReadLine());
                int[] arrInt = null;
                arrInt = new int[size];
                for (int i = 0; i < size; i++)
                {
                    arrInt[i] = random.Next(10, 79);
                    //Console.WriteLine(arrInt[i]);
                    //
                    //Console.WriteLine("{0} -> {1}",i, arrInt[i]);
                    Console.Write("{0} ", arrInt[i]);
                }
           */
            /*
            int[] arrInt1 = new int[5] { 1, 2, 3, 4, 5 };  // строгое! количество
            int[] arrInt2 = new int[] { 1, 2, 3, 4, 5 };   // варианты
            int[] arrInt3 =  { 112,1, 2, 3, 4, 5,6,111 };            //////////
            // размер массива
            Console.WriteLine(arrInt3.Length);
            Console.WriteLine(arrInt3.GetLength(0)); // 0- одномерный массив 1- двухмерный 2-трехмерный
            // метод IndexOf
            //Сортировка 
            Array.Sort(arrInt3);
            Array.Reverse(arrInt3);
            for (int i = 0; i < arrInt3.Length; i++)
            {
                Console.WriteLine(arrInt3[i]);
            }

            Array.Resize(ref arrInt3, arrInt3.Length + 2); // 2 - число на которое увеличиваем массив
            arrInt3[arrInt3.Length - 1] = 56;
            
            int n = 0;
            foreach (var item in arrInt3) //item - каждый текущий элемент (по очереди) коллекции (массива)
            {
                //изменять значеия коллекции НЕЛЬЗЯ  
                // item = 34;  -->  ошибка
                //Console.WriteLine("{0}", item);
                Console.WriteLine("{0} -> {1}", n, item);
                n++;
            }
            */

            ///////***    ДВУМЕРНЫЕ МАССИВЫ     ***/////////
            //float[,] // [,] - двумерный [,,] - трехмерный и т.д.
            /*
                        float[,] floatArr = new float[2, 3];
                        Console.WriteLine(floatArr.Length);
                        Console.WriteLine(floatArr.GetLength(0)); //2 строки
                        Console.WriteLine(floatArr.GetLength(1)); //3 столбцы

                        for (int f = 0; f < floatArr.GetLength(0); f++)
                        {
                            for (int j = 0; j < floatArr.GetLength(1); j++)
                            {
                                //floatArr[f, j] = Convert.ToSingle(random.NextDouble() * 3.2);
                                //floatArr[f, j] = (float)(random.NextDouble() * 3.2);
                                floatArr[f, j] = (float)random.NextDouble() * 3.2f;
                                //Console.Write("{0} ", floatArr[f, j]);
                                //Console.Write("{0, 10} ", floatArr[f, j]);
                                //Console.Write("{0, -10} ", floatArr[f, j]);
                                //Console.Write("{0, -1:F} ", floatArr[f, j]);
                                //Console.Write("{0, -10:F4} ", floatArr[f, j]);
                                Console.Write("{0, -1:E} ", floatArr[f, j]);
                                //описание  
                                //


                            }
                            Console.WriteLine();
                        }
                        /////*****  варианты объявления

                        int[,] arr1 = new int[2, 3] { { 1, 2, 3 }, { 6, 7, 8 } };
                        int[,] arr2 = new int[, ] { { 1, 2, 3 }, { 6, 7, 8 } };
                        int[,] arr3 = { { 1, 2, 3 }, { 6, 7, 8 } };

                        /////// 3-х мерный
                        int[,,] arr4 = new int[,,]
                        {
                        {{ 1,2,3}, {1,3,4 } },
                        {{ 11,12,13}, {11,13,14 } },
                        {{ 21,32,33}, {31,33,34 } }
                        };
                        Console.WriteLine(arr4.Length);
                        Console.WriteLine(arr4.GetLength(0));
                        Console.WriteLine(arr4.GetLength(1));
                        Console.WriteLine(arr4.GetLength(2));

                        foreach (var item in arr4)
                        {
                            Console.Write(item + " ");
                        }
            */
            //// --------  ЗУБЧАТЫЕ МАССИВЫ  ------------ 

            /*   int row = 2;
               int[][] intJaged = new int[row][];
               intJaged[0] = new int[] { 1, 2, 3, 4 };
               intJaged[1] = new int[] { 31, 42 };
               Array.Resize(ref intJaged[1], intJaged[1].Length + 1);
               intJaged[1][intJaged[1].Length - 1] = 678;
               for (int i = 0; i < intJaged[1].Length; i++) //количество строк i
               {
                   for (int j = 0; j < intJaged[i].Length; j++)  //это элементы i-той строки
                   {
                       Console.Write("{0,-5}", intJaged[i][j]);
                   }
                   Console.WriteLine();
               }
            */
            /*int size = 5;
            double[][] arrDouble = new double[size][];
            for (int i = 0; i < arrDouble.Length; i++)
            {
                arrDouble[i] = new double[random.Next(4, 9)];
                for (int j = 0; j < arrDouble[i].Length; j++)
                {
                    arrDouble[i][j] = random.NextDouble() * 2.6;
                    Console.Write("{0,-10:F3}", arrDouble[i][j]);
                }
                Console.WriteLine();
            }
            */

            /* Даны 2 массива размерности M и N соответственно. 
             * Необходимо переписать в третий массив общие элементы первых двух массивов без повторений.
             */
            /*
                int[] arrInt1 = { 23, 24, 17, 2, 31, 24, 45, 46, 111 };
                int[] arrInt2 = { 24, 12, 3, 124, 45, 47 };
                int[] arrInt3 = new int[0];
                for (int i = 0; i < arrInt1.Length; i++)
                {
                    for (int j = 0; j < arrInt2.Length; j++)
                    {
                        if (arrInt1[i]==arrInt2[j])
                        {
                            Array.Resize(ref arrInt3, arrInt3.Length + 1);
                            arrInt3[arrInt3.Length - 1] = arrInt1[i];
                        }
                    }
                }

                for (int i = 0; i < arrInt3.Length; i++)
                {
                    Console.Write("{0} ", arrInt3[i]);
                }
            */
          
            int[] arrInt1 = { 23, 24, 17, 2, 31, 24, 45, 46, 111 };
            int[] arrInt2 = { 24, 12, 3, 124, 45, 47 };
            int[] arrInt3 = new int[0];
            for (int i = 0; i < arrInt1.Length; i++)
            {
                for (int j = 0; j < arrInt2.Length; j++)
                {
                    if (arrInt1[i] == arrInt2[j] && Array.IndexOf(arrInt3, arrInt1[i]) <0)
                    {
                        Array.Resize(ref arrInt3, arrInt3.Length + 1);
                        arrInt3[arrInt3.Length - 1] = arrInt1[i];
                    }
                }
            }

            for (int i = 0; i < arrInt3.Length; i++)
            {
                Console.Write("{0} ", arrInt3[i]);
            }


            //----------------------------------------------
            Console.ReadKey();
        }
    }
}
