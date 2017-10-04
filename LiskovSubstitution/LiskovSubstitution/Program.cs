using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class Program
    {
        public static int Area(Rectangle r) => r.Width * r.Height;

        static void Main(string[] args)
        {
            Rectangle rc = new Rectangle(5,5);
            Console.WriteLine($"{rc} has area {Area(rc)}");

            Rectangle square = new Square();
            square.Width = 4;
            Console.WriteLine($"{square} has area {Area(square)}");
        }
    }
}
