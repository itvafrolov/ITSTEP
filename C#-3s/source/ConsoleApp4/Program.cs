using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp4
{

    interface IInterface
    {

    }

   

    class Program
    {
        static void Main(string[] args)
        {
            /* Dimension dimensions = new Dimension();
             dimensions.Height = 34;
             dimensions.Show();

             Dimension dimensions1 = new Dimension(31.21, 34.52);
             dimensions1.Show();

             MessageBox.Show("Hello!");
            */

            // стандартные структуры
            //    DateTime dateTime = new DateTime(2000, 12, 30);
            //    Console.WriteLine(dateTime.Month);
            //    Console.WriteLine(dateTime.AddDays(3));
            //    Console.ReadKey();
            //

            string str = "alks123 lskdj456 ldksjf654 kdjfh";
            string str1=null, num=null;
           // int LL = str.Length;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    num += str[i];
                }
                else
                {
                    str1 += str[i];
                }
            }

            Console.WriteLine(num);
            Console.WriteLine(str1);
            Console.WriteLine(str1+num);

        }
    }
}
