using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VolkovConsoleApp
{
    public class Formula
    {
        public static void Task1()
        {
            // Задача 1. Площадь треугольника
            Console.WriteLine("Задача 1. Площадь треугольника");

            // Программа
            // Ввод данных
            double a = 5;// основание
            double b = 2;// высота

            // Процесс
            double s = 0.5 * a * b;

            // Вывод результата
            Console.Write("Площадь треугольника: ");
            Console.WriteLine(s);
        }

        public static void Task2()
        {
            // Задача 2. Площадь круга
            Console.WriteLine("Задача 2. Площадь круга");

            // Ввод данных
            double r = 5;

            // Процесс
            double s = Math.PI * r * r;

            // Вывод результата
            Console.Write("Площадь круга: ");
            Console.WriteLine(s);
        }

        public static void Task3()
        {
            // Задача 3
            Console.WriteLine("Задача 3. Среднее арифметическое и среднее геометрическое");
            // Ввод данных
            int a;
            int b;

            a = 5;
            b = 4;

            // Вычисление
            double c = 0.5 * (a + b);
            double d = Math.Sqrt(a * b);

            // Вывод результата
            Console.Write("Среднее арифметическое: ");
            Console.WriteLine(c);

            Console.Write("Среднее геометрическое: ");
            Console.WriteLine(d);
        }

        public static void Task4()
        {
            Console.WriteLine("Задача 4. Среднее арифметическое и среднее геометрическое");

            // Ввод данных
            double a = -5;
            double b = 3;

            // Вычисления
            double c = 0.5 * (a + b);
            double d = Math.Sqrt(Math.Abs(a) * Math.Abs(b));

            // Вывод результатов
            Console.Write("Среднее арифметическое: ");
            Console.WriteLine(c);

            Console.Write("Среднее геометрическое модулей: ");
            Console.WriteLine(d);
        }

        public static void Task5()
        {
            // Задача 5. Объем куба и площадь его боковой поверхности
            Console.WriteLine("Объем куба и площадь его боковой поверхности");

            // Ввод даннных
            double a = 3;

            // Вычисления
            double v = a * a * a;
            double s = 6 * a * a;

            // Вывод результата
            Console.Write("Ребро куба: ");
            Console.WriteLine(a);

            Console.Write("Объем куба: ");
            Console.WriteLine(v);

            Console.Write("Площадь боковой поверхности куба: ");
            Console.WriteLine(s);
        }

        public static void Task6()
        {
            // Задача 6. Время падения камня с высоты h
            Console.WriteLine("Время падения камня с высоты h");

            // Ввод данных
            double h = 100;
            double g = 9.81;

            // Вычисления
            double t = Math.Sqrt(2 * h / g);

            // Вывод результата
            Console.Write("Время падения камня с высоты ");
            Console.Write(h);
            Console.Write(" м составляет ");
            Console.Write(t);
            Console.WriteLine(" с.");

            string format = "Время падения камня с высоты {0:F2} м составляет {1:F4} с.";
            Console.WriteLine(string.Format(format, h, t));
        }

        public static void Task7()
        {
            // Задача 7. Площадь равнобокой трапеции
            Console.WriteLine("Задача 7. Площадь равнобокой трапеции");
            // Ввод данных
            double a;
            Console.Write("Введите большее основание: ");
            string str = Console.ReadLine();

            if (double.TryParse(str, out a) == false)
            {
                Console.WriteLine("Некорректное значение.");
                return;
            }
            if (a < 0)
            {
                Console.WriteLine("Число должно быть положительным.");
                return;
            }
            double b;
            Console.Write("Введите меньшее основание: ");
            str = Console.ReadLine();
            if (double.TryParse(str, out b) == false)
            {
                Console.WriteLine("Некорректное значение.");
                return;
            }
            if (a <= b)
            {
                Console.WriteLine("Некорректные параметры задачи.");
            }
            double alpha;
            Console.Write("Введите угол при большем основании: ");
            str = Console.ReadLine();
            if (double.TryParse(str, out alpha) == false)
            {
                Console.WriteLine("Некорректное значение");
                return;
            }
            if (alpha <= 0 || alpha >= 90)
            {
                Console.WriteLine("Угол должен быть в диапазоне 0 < alpha < 90.");
                return;
            }

            // Преобразование из градусов в радианы
            alpha = alpha * Math.PI / 180;

            // Вычисление площадь
            double s = 0.25 * (a * a - b * b) * Math.Tan(alpha);

            // Вывод результата
            string format = "Площадь равна {0:F3}.";
            Console.WriteLine(string.Format(format, s));            
        }

        public static void Task8()
        {
            // Задача 8. Вычислить значение выражения.
            Console.WriteLine("Задача 8. Вычислить значение выражения.");

            // Ввод данных
            double x;
            Console.Write("Введите x: ");
            string str = Console.ReadLine();
            if(!double.TryParse(str,out x))
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

            // Вычисление
            double z = Math.Abs(y - x);
            double a = 1 + z + 0.5 * z * z - z * z * z / 3.0;

            // Вывод результата
            string format = "a = {0:F3}";
            Console.WriteLine(string.Format(format, a));
        }

        public static void Task9()
        {
            // TODO Задача 9. Вычисление значения выражения.
            Console.WriteLine("Задача 9. Вычисление значения выражения.");
            // Ввод данных
            double x;
            Console.Write("Введите x: ");
            string str = Console.ReadLine();
            if (!double.TryParse(str, out x))
            {
                Console.WriteLine("Некорректное значение.");
                return;
            }

            // Вычисления
            double y = 2 * x - 3;
            y = y * x + 4;
            y = y * x - 5;
            y = y * x + 6;

            // Вывод результата
            string format = "y = {0:F4}";
            Console.WriteLine(string.Format(format, y));
        }

    }
}
