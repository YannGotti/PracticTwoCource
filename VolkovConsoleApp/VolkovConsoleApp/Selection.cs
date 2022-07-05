using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VolkovConsoleApp
{
    public class Selection
    {
        public static void Task1()
        {
            // Задача 1. Поиск наибольшего и наименьшего значения.
            Console.WriteLine("Задача 1. Поиск наибольшего и наименьшего значения.");
            // Ввод данных
            double x;
            Console.Write("Введите x: ");
            string str = Console.ReadLine();
            if (!double.TryParse(str, out x))
            {
                Console.WriteLine("Некорректное значение.");
                return;
            }
            double y;
            Console.Write("Введите y: ");
            str = Console.ReadLine();
            if (!double.TryParse(str, out y))
            {
                Console.WriteLine("Некорректное значение.");
                return;
            }
            // Вычисления 
            double max;
            double min;

            if (x > y)
            {
                max = x;
                min = y;
            }
            else
            {
                min = x;
                max = y;
            }

            // Вывод результата
            string format = "{0}({1}, {2}) = {3}";
            Console.WriteLine(string.Format(format, "max", x, y, max));
            Console.WriteLine(string.Format(format, "min", x, y, min));
        }

        public static void Task2()
        {
            // Задача 2. Наибольшее и наименьшее значение"
            Console.WriteLine("Задача 2. Наибольшее и наименьшее значение");
            // Ввод данных
            double x;
            if (!IO.ReadValue("x", out x, true))
                return;

            double y;
            if (!IO.ReadValue("y", out y, true))
                return;

            int digits;
            if (!IO.ReadValue(
                "число цифр после запятой", out digits, true))
                return;

            // Вычисления
            double s = 0.5 * (x + y);
            double p = 2 * x * y;

            if (x > y)
            {
                x = p;
                y = s;
            }
            else
            {
                x = s;
                y = p;
            }

            // Вывод результата
            IO.WriteLine("x", x, digits);
            IO.WriteLine("y", y, digits);
        }

        public static void Task3()
        {
            // Задача 3. Решение квадратного уравнения
            double a;// коэффициент уравнения
            double b;
            double c;
            double d;// дискриминант уравнения
            double x1, x2;// корни уравнения
            double eps; // малое число для сравнения

            // Ввод данных
            if (!IO.ReadValue("a", out a, true)) return;
            if (!IO.ReadValue("b", out b, true)) return;
            if (!IO.ReadValue("c", out c, true)) return;
            if (!IO.ReadValue("eps", out eps, true)) return;

            // Вычисления
            d = b * b - 4 * a * c;
            if (d > eps)
            {
                d = Math.Sqrt(d);

                x1 = 0.5 * (-b - d) / a;
                x2 = 0.5 * (-b + d) / a;

                // Вывод результата
                // два корня
                IO.WriteLine("x1", x1, 4);
                IO.WriteLine("x2", x2, 4);
            }
            else if (d < -eps)
            {
                // Вывод результата
                // действительных корней нет
                Console.WriteLine("Действительных корней нет.");
            }
            else
            {
                x1 = x2 = -0.5 * b / a;

                // Вывод результата
                // один корень
                IO.WriteLine("x1", x1, 4);
                IO.WriteLine("x2", x2, 4);
            }
        }


    }
}
