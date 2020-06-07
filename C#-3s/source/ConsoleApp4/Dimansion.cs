using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    struct Dimension
    {
        private double Width;
        public double Height;

        public Dimension(double w, double h)
        {
            Width = w;
            Height = h;
        }

        public void Show()
        {
            Console.WriteLine($"Width: {Width} Height: {Height}");
        }
    }
}
