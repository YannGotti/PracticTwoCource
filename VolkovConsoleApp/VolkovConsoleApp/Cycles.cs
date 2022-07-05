using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VolkovConsoleApp
{
    public class Cycles
    {
        public static void Task1()
        {
            // Задача 1. Вычисление 2^n
            // Ввод данных
            int n;
            if (!IO.ReadValue("n", out n, true))
            {
                return;
            }
            if (n < 1)
            {
                Console.WriteLine("Число должно быть больше или равно 1.");
                return;
            }

            // Вычисление
            double y = 2;
            for (int i = 1; i <= n - 1; i++)
                y = y * 2;

            // Вывод результата
            IO.WriteLine("y", y, 0);
        }

        public static void Task2()
        {
            // Задача 2. Вычисление факториала n!
            // Ввод данных
            int n;
            if (!IO.ReadValue("n", out n, true))
            {
                return;
            }
            if (n < 1)
            {
                Console.WriteLine("Число должно быть больше или равно 1.");
                return;
            }
            // Вычисление
            double x = 1;
            for (int i = 2; i <= n; i++)
            {
                //x = x * i;
                x *= i;
            }

            // Вывод результата
            IO.WriteLine("n!", x, 0);
        }

        public static void Task3()
        {
            // Задача 3. Вычисление произведения
            Console.WriteLine("Задача 3. Вычисление произведения");
            // Ввод данных
            int n;
            if (!IO.ReadValue("n", out n, true))
            {
                return;
            }
            if (n < 1)
            {
                Console.WriteLine("Число должно быть больше или равно 1.");
                return;
            }
            // Вычисления
            double x = 1.0 + 1.0 / (1.0 * 1.0);
            for (int i = 2; i <= n; i++)
            {
                x *= 1.0 + 1.0 / (i * i);
            }

            // Вывод результата
            IO.WriteLine("x", x, 5);
        }

        public static void Task4()
        {
            Console.WriteLine("Задача 4. Вычисление n вложенных корней");

            // Ввод данных
            int n;
            if (!IO.ReadValue("n", out n, true))
                return;

            // Вычисление
            double x = Math.Sqrt(2);

            for (int i = 1; i <= n - 1; i++)
                x = Math.Sqrt(2 + x);

            // Вывод результата
            IO.WriteLine("x", x, 5);
        }

        public static void Task5()
        {
            // Задача 5. Вычисление частного произведений
            Console.WriteLine("Задача 5. Вычисление частного произведений");

            // Ввод исходных данных
            double x;
            if (!IO.ReadValue("x", out x, true))
                return;

            // Вычисление
            double m = 2;
            double z = x - m;
            double y = z / (z + 1);

            for (int k = 1; k <= 5; k++)
            {
                m *= 2;
                z = x - m;
                y *= z / (z + 1);
            }

            // Вывод результата
            IO.WriteLine("y", y, 5);
        }

        public static void Task6()
        {
            // "Задача 6. Вычисление элементов последовательности"
            Console.WriteLine("Задача 6. Вычисление элементов последовательности");

            // Ввод исходных данных
            int n;
            if (!IO.ReadValue("n", out n, true))
                return;
            if (n < 1)
            {
                Console.WriteLine("Значение должно быть больше или равно 1.");
                return;
            }

            // Вычисление
            int m = 1000000;
            double a = 1;
            DateTime start = DateTime.Now;// время начала
            for (int k = 1; k <= m; k++)
            {
                // решение задачи m раз
                a = 1;
                for (int i = 1; i <= n; i++)
                    a = i * a + 1.0 / i;
            }
            DateTime finish = DateTime.Now;// время завершения
            TimeSpan dif = finish - start;// продолжительность

            // Вывод результата an = ###.######
            string name = "a" + n.ToString();
            IO.WriteLine(name, a, 5);
            Console.Write("Время выполнения (мс): ");
            Console.Write(dif.TotalMilliseconds / m);
            Console.WriteLine();
        }

        public static void Task7()
        {
            // Задача 7. Вычисление суммы произведений
            int n;
            if (!IO.ReadValue("n", out n, true))
                return;
            if (n < 1)
            {
                Console.WriteLine("Значение должно быть больше 0.");
                return;
            }

            // Вычисление 
            double a = 1;
            double b = 1;
            double t;
            double s = a * b;

            for (int k = 2; k <= n; k++)
            {
                t = a;
                a = 0.5 * (Math.Sqrt(b) + 0.5 * Math.Sqrt(t));
                b = 2 * t * t + b;

                s += a * b;
            }

            // Вывод результата
            IO.WriteLine("s", s, 5);
        }

        public static void Task8()
        {
            // Задача 8. Вычисление суммы элементов

            // Ввод данных
            int n;
            if (!IO.ReadValue("n", out n, true))
                return;
            if (n < 1)
            {
                Console.WriteLine("Значение должно быть больше 0.");
                return;
            }

            // Вычисления
            double a = 1;
            double b = 1;
            double t;
            double v1 = 2;
            double v2 = 1;
            double v3 = 1 + a * a + b * b;
            double s = v1 / (v2 * v3);

            for (int k = 2; k <= n; k++)
            {
                t = a;
                a = 3 * b + 2 * t;
                b = 2 * t + b;
                v1 *= 2;
                v2 *= k;
                v3 = 1 + a * a + b * b;
                s += v1 / (v2 * v3);
            }

            // Вывод результата
            IO.WriteLine("s", s, 5);
        }

        public static void Task9()
        {
            // Задача 9. Вычисление элементов последовательности
            Console.WriteLine("Задача 9. Вычисление элементов последовательности");
            // Ввод данных
            double a;
            double x;
            double eps;
            if (!IO.ReadValue("a", out a, true))
                return;
            if (!IO.ReadValue("x", out x, true))
                return;
            if (!IO.ReadValue("eps", out eps, true))
                return;

            // Вычисление 
            double y0 = a;
            double y1;
            double z;
            int n = 0;
            do
            {
                y1 = 0.5 * (y0 + x / y0);
                z = Math.Abs(y1 * y1 - y0 * y0);
                y0 = y1;
                n++;
            } while (z >= eps);

            // Вывод результата
            string name = "y" + n.ToString();
            IO.WriteLine(name, y1, 5);
        }
    }
}
