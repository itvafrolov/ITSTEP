using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string str = "";
            str = "hello";
            string str1 = new string('%', 6);
            foreach(char item in str)
            {
                Console.WriteLine(item);
            }
            */
            /*char[] arr = {'t','o',' ','g','o' };
            string str2 = new string(arr);
            Console.WriteLine(str2);
            string path = "D:\\Temp\\Test.txt";

            // или так
            string path1 = @"D:\Temp\Test.txt";

            Console.WriteLine(path);
            Console.WriteLine(path1);*/

            /*string str = "Simple string";
            Console.WriteLine(str.Length);
            char[] arr = new char[6];
            str.CopyTo(3, arr, 0, 6);
            Console.WriteLine(arr);*/

            string str = "Simple string Next string Simple string Simple string Simple string Simple string Next ";
            string str1 = "Next string";
            string str2 = "str";
            /* Console.WriteLine(string.Concat(str, str1));
             Console.WriteLine(str + str1);
              */
            /*
                        Console.WriteLine(string.Compare(str, str1));  //статический потому начинать нужно с string.Метод
                        Console.WriteLine(str.CompareTo(str1));        //нестатический потому начинать нужно с переменная.Метод
                        Console.WriteLine(str.Equals(str1));
                        Console.WriteLine(str == str1);                //или так
                        Console.WriteLine(str.IndexOf(str2));
                        Console.WriteLine(str.IndexOf(""));
                        Console.WriteLine(str.Contains("str"));
            */
            /*
                if (str.EndsWith("ing", true, CultureInfo.CurrentCulture))
                {
                    Console.WriteLine("+");
                }

                if (!str.EndsWith("xx"))
                {
                    Console.WriteLine("+");
                }
            */

            //Console.WriteLine(str.ToLower());
            //Console.WriteLine(str.ToUpper());
            /*
                        string str3 = str.Replace('i', '@');
                        Console.WriteLine(str3);
                        Console.WriteLine(str3.Remove(2,4));
                        Console.WriteLine(str3.Insert(2, "QQQQQQQQQQ"));
            */

            /* Console.WriteLine(str.PadLeft(20, '+'));
             Console.WriteLine(str.PadRight(20, '#'));*/
            /*
            Console.WriteLine(str);

            Console.WriteLine(str.Trim(' '));
            string str4 = "%+++%%##  +#%Hello";
            Console.WriteLine(str4.TrimStart(new char[] { '+', '#', '%',' ' }));*/
            /*
            string[] arr = str.Split(' ');
            foreach (string item in arr)
            {
                Console.WriteLine(item);
            }
            */
            //Console.WriteLine(string.Join(str));
            //Console.WriteLine(string.Join("+++        ", arr));
            /*
            int n1 = 4, n2 = 5;

            string result = string.Format("{0} + {1} = {2}", n1, n2, n1 + n2);
            Console.WriteLine(result);
            */

            //интерполируемая строка
            // int n1 = 4, n2 = 5;
            //string result = $"{n1} + {n2} = {n1+n2}";
            //Console.WriteLine(result);

            //Console.WriteLine($"n1 {(n1>n2?">":"<")} n2");
            /*
            string result = $"{n1} + {n2} = {(n1+n2)*2.54646,-15:f4}";
            Console.WriteLine(result);*/
            /*
            string str5 = "Nuber";
            str2 = "Zero";
            str2 += "Count";
            Console.WriteLine(str2);
            StringBuilder builder = new StringBuilder();
            Console.WriteLine(builder.Capacity);
            builder.Append(Console.ReadLine());
            Console.WriteLine(builder.Length);
            Console.WriteLine(builder.Capacity);
            builder.AppendLine();
            int n1 = 4, n2 = 5;
            builder.AppendFormat("{0} + {1} = {2}", n1, n2, n1 + n2);
            builder.AppendLine("Hello");
            Console.WriteLine(builder);
            builder.Insert(4, "AAAAAAA");
            Console.WriteLine(builder);
            builder.Remove(7, 3);
            builder.Replace('A', '%');
            Console.WriteLine(builder.Length);
            Console.WriteLine(builder.Capacity);
            string str6 = builder.ToString();
            Console.WriteLine(str6);*/

            //1. Поменять местами соседние слова во введённом предложении.

            string[] arr = str.Split(' ');

           // Console.WriteLine(arr.Length);
            string tmp;
            for (int i = 0; i < arr.Length; i+=2)
            {
                tmp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = tmp;
            }

            string strNew = null;

            foreach (string item in arr)
            {
                strNew = strNew + " " + item;
            }
            Console.WriteLine(strNew);
            //
            Console.ReadKey();
        }
    }
}
