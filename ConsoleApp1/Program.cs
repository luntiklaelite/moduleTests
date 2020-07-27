using FirstLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstClass fc = new FirstClass();
            Console.WriteLine((float)Math.Round(13.9619998931885, 3));
            Console.WriteLine(new test().round(40,40,1));
            Console.WriteLine(new test().areaTriangle(40, 40, 1));
            Console.WriteLine((float)new FirstClass().areaTriangle(40, 40, 1));
            Console.Read();
        }

        public interface ITest
        {
            float areaTriangle(double a, double b, double angle);
        }

        public class test : ITest
        {
            public float round(double a, double b, double angle)
            {
                return (float)Math.Round(a * b / 2 * Math.Sin(angle / 180d * Math.PI), 3);
            }
            public float areaTriangle(double a, double b, double angle)
            {
                return (float)Math.Round(a * b / 2 * Math.Sin(angle / 180d * Math.PI), 3);
            }
        }
    }
}
