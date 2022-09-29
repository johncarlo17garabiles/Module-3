using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        public class Circle
        {
            static void Main(string[] args)
            {
                double radius, area;
                double PI = 3.1415;
                Console.WriteLine("Enter the radius of the circle: ");
                radius = Convert.ToDouble(Console.ReadLine());
                area = PI * radius *radius;

                Console.WriteLine("Radius of circle is {0}, And", radius);
                Console.WriteLine("The area of circle with radius {0} is {1}", radius,area);
            }
        }
    }
}