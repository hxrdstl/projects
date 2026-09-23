using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pd1
{
    public class Program
    {
        public static void Main()
        {
            double a, b, c, p, pole_trojkata;
            Console.WriteLine("Program obliczający pole trójkąta.");
            Console.WriteLine("Podaj wartość a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartość b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartość c: ");
            c = double.Parse(Console.ReadLine());
            p = (a + b + c) / 2;
            pole_trojkata = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Pole trójkąta wynosi: " + pole_trojkata);
            Console.ReadKey();
        }
    }
}
