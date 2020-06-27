using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class DisposeExample: IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("DisposeExample");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
