using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KozlovConsoleApp
{
    public class Arrays
    {
        public static void FindMax(int[] a, out int max, out int imax)
        {
            max = int.MinValue;
            imax = -1;

            if (a == null)
                return;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    imax = i;
                }
            }
        }

        public static void FindMin(int[] a, out int min, out int imin)
        {
            min = int.MaxValue;
            imin = -1;

            if (a == null)
                return;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                    imin = i;
                }
            }
        }

        public static void FindMaxMin(int[] a, out int max, out int imax,
            out int min, out int imin)
        {
            max = int.MinValue;
            imax = -1;
            min = int.MaxValue;
            imin = -1;

            if (a == null)
                return;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    imax = i;
                }
                if (a[i] < min)
                {
                    min = a[i];
                    imin = i;
                }
            }
        }

        public static int Sum(int[] a)
        {
            int s = 0;
            if (a == null)
                return s;

            for (int i = 0; i < a.Length; i++)
                s += a[i];

            return s;
        }

        public static bool Input(string name,
            out int[] a)
        {
            a = null;

            int n;
            if (!IO.ReadValue("количество элементов", out n))
                return false;
            if (n < 0)
                return false;

            int[] temp = new int[n];
            bool success = true;
            string str;
            for (int i = 0; i < n; i++)
            {
                str = string.Format("{0}[{1}]", name, i);
                if (!IO.ReadValue(str, out temp[i]))
                {
                    success = false;
                    break;
                }
            }
            if (success)
                a = temp;

            return success;
        }

        public static void Task1()
        {
            Console.WriteLine("Ввод массива");
            int[] a = null;
            if (!Input("a", out a))
                return;
            int max;
            int imax;
            FindMax(a, out max, out imax);

            int min;
            int imin;
            FindMin(a, out min, out imin);

            int sum = Sum(a);


            IO.WriteValue("Максимальное значение", max);
            IO.WriteValue("Номер максимального значения", imax);
            IO.WriteValue("Минимальное значение", min);
            IO.WriteValue("Номер минимального значения", imin);
            IO.WriteValue("Сумма элементов массива", sum);
            // Одновременный поиск минимума и максимума
            Console.WriteLine("+++ Минимальное и максимальное значение +++");
            FindMaxMin(a, out max, out imax, out min, out imin);
            IO.WriteValue("Максимальное значение", max);
            IO.WriteValue("Номер максимального значения", imax);
            IO.WriteValue("Минимальное значение", min);
            IO.WriteValue("Номер минимального значения", imin);
        }
    }
}
