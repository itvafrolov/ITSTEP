using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        //static void Main(string[] args)
        //{            

        //    Console.WriteLine("Сумма = " + Sum(new int[] { 1, 2, 3, 4, 5 }));

        //    private static int Sum(int[] arr)
        //    {
        //        int res = 0;
        //        foreach (int i in arr)
        //            res += i;
        //        return res;
        //    }

        //}
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        static void Main(string[] args)
        {
            Console.WriteLine("Сумма = " + Sum(1, 2, 3, 4, 5));
        }
        private static int Sum(params int[] arr)
        {
            int res = 0;
            foreach (int i in arr)
                res += i;
            return res;
        }


    }
}
