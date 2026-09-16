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
            double a, b, h, pole_trojkata;
            Console.WriteLine("Program obliczający pole trójkąta.");
            Console.WriteLine("Wzór na trójkąt dowolny, różnoboczny ta równoramienny są takie same, więc stosujemy jeden wzór dla trzech : (a*h)/2");
            Console.WriteLine("Podaj wartość a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartość h: ");
            h = double.Parse(Console.ReadLine());
            pole_trojkata = (a * h) / 2;
            Console.WriteLine("Pole tych trójkątów wynoszą: " + pole_trojkata);
            Console.WriteLine("Wzór na pole trójkąta prostokątnego: (a*b)/2");
            Console.WriteLine("Podaj wartość a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartość b: ");
            b = double.Parse(Console.ReadLine());
            pole_trojkata = (a * b) / 2;
            Console.WriteLine("Pole trójkąta prostokątnego wynosi: " + pole_trojkata);
            Console.WriteLine("Wzór na pole trójkąta równobocznego:  (a * a * Math.Sqrt(3)) / 4");
            Console.WriteLine("Podaj wartość a: ");
            a = double.Parse(Console.ReadLine());
            pole_trojkata = (a * a * Math.Sqrt(3)) / 4;
            Console.WriteLine("Pole trójkąta równobocznego wynosi: " + pole_trojkata);
            Console.ReadKey();
        }
    }
}
