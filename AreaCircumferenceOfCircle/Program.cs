using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCircumferenceOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle. ");

            int r                = Int32.Parse(Console.ReadLine());
            double Circumference = 2 * Math.PI * r;
            double Area          =     Math.PI * r * r;

            Console.WriteLine($"The Circumference of the circle is {Circumference:F3}");
            Console.WriteLine($"The Area of the circle is {Area:F3}");
            Console.ReadLine();
        }
    }
}
