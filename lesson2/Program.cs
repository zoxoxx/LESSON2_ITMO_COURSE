using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1
            double L;
            while (true)
            {
                Console.Write("Введите длину окружности ");
                try
                {
                    L = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Длина введена в неправильном формате. Попробуйте снова.");
                }
            }
            double R = L / (2 * Math.PI);
            double S = (L / 2) * R;
            Console.WriteLine("Радиус окружности: " + Math.Round(R, 2));
            Console.WriteLine("Площадь круга: " + Math.Round(S, 2));
            //Задача 2
            double x1, x2, y1, y2;
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите вершины прямоугольника:");
                    Console.Write("X1: ");
                    x1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Y1: ");
                    y1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("X2: ");
                    x2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Y2: ");
                    y2 = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Неправильный формат ввода. Попробуйте снова.");
                }
            }
            double width = Math.Abs(x1 - x2);
            double length = Math.Abs(y1 - y2);
            double square = width * length;
            double perimeter = (2 * width) + (2 * length);
            Console.WriteLine("Площадь: " + Math.Round(square, 2));
            Console.WriteLine("Периметр: " + Math.Round(perimeter, 2));
            //Задача 3
            double x3, y3, a, b, c, p;
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите вершины треугольника:");
                    Console.Write("X1: ");
                    x1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Y1: ");
                    y1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("X2: ");
                    x2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Y2: ");
                    y2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("X3: ");
                    x3 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Y3: ");
                    y3 = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Неправильный формат ввода. Попробуйте снова.");
                }
            }
            a = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            b = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            c = Math.Sqrt(Math.Pow((x1 - x3), 2) + Math.Pow((y1 - y3), 2));
            p = (a + b + c) / 2;
            square = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            perimeter = a + b + c;
            Console.WriteLine("Площадь треугольника: " + Math.Round(square, 2));
            Console.Write("Периметр треугольника: " + Math.Round(perimeter, 2));
            Console.ReadKey();
        }
    }
}