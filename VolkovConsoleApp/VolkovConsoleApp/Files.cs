using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace VolkovConsoleApp
{
    public class Files
    {
        public static void Task1()
        {
            // Задача 1. Запись строк в файл
            Console.WriteLine("Задача 1. Запись строк в файл");
            // Ввод имени файла
            string fileName;
            Console.Write("Введите имя файла: ");
            fileName = Console.ReadLine();
            // 1. Открытие файла для записи
            bool append = false;
            StreamWriter writer = new StreamWriter(fileName,
                append, Encoding.Default);

            // Ввод количества строк
            int n;
            if (!IO.ReadValue("количество строк", out n, true))
                return;

            // 2. Вывод данных в файл
            string str;
            for (int i = 0; i < n; i++)
            {
                // ввод строки
                Console.Write("Введите строку: ");
                str = Console.ReadLine();
                // вывод строки в файл
                writer.WriteLine(str);
            }

            // 3. Закрытие файла
            writer.Close();
        }

        public static void Task2()
        {
            // Задача 2. Чтение данных из файла
            Console.WriteLine("Задача 2. Чтение данных из файла");

            // Ввод имени файла
            string fileName;
            Console.Write("Введите имя файла: ");
            fileName = Console.ReadLine();

            // 1. Открытие файла
            StreamReader reader = new StreamReader(fileName, Encoding.Default);

            // 2. Ввод данных из файла
            string str;
            while (!reader.EndOfStream)
            {
                // Ввод строки из файла
                str = reader.ReadLine();

                // Вывод строки в консоль
                Console.WriteLine(str);
            }

            // 3. Закрытие файла
            reader.Close();
        }

        public static void Task3()
        {
            // Задача 3. Ввод матрицы из файла
            Console.WriteLine("Задача 3. Ввод матрицы из файла");

            // Ввод имени файла
            string fileName;
            Console.Write("Введите имя файла: ");
            fileName = Console.ReadLine();

            // 1. Открытие файла
            StreamReader reader = new StreamReader(fileName, Encoding.Default);

            // 2. Ввод данных из файла
            // размерность матрицы 
            string str = reader.ReadLine();
            char[] del = { ' ' };
            string[] sub = str.Split(del);
            int m = int.Parse(sub[0]);// число строк
            int n = int.Parse(sub[1]);// число столбцов
            // выделение памяти для матрицы
            double[][] a = new double[m][];
            for (int i = 0; i < m; i++)
                a[i] = new double[n];

            // ввод значений матрицы из файла
            for (int i = 0; i < m; i++)
            {
                // чтение строки
                str = reader.ReadLine();
                // разделение строки на подстроки по символу разделителя
                sub = str.Split(del);
                // получение значений
                for (int j = 0; j < n; j++)
                    a[i][j] = double.Parse(sub[j]);
            }

            // 3. Закрытие файла
            reader.Close();

            // Вывод матрицы в консоль
            IO.WriteMatrix(a);
        }
    }
}
