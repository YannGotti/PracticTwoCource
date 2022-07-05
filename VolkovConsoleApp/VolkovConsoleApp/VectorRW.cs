using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; // StreamWriter, StreamReader

namespace KozlovConsoleApp
{
    public class VectorRW : Vector, IRead, IWrite
    {
        public VectorRW(int n)
            : base(n)
        {

        }

        public bool Read(string fileName)
        {
            bool res = true;
            StreamReader reader = null;
            string str = string.Empty;
            try
            {
                reader = new StreamReader(fileName,
                    Encoding.Default);
                str = reader.ReadLine();
            }
            catch (Exception ex)
            {
                Console.Write("Ошибка при чтении файла: ");
                Console.WriteLine(ex.Message);
                res = false;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    reader.Dispose();
                    reader = null;
                }
            }

            if (res == false || string.IsNullOrEmpty(str))
                return res;
            // Получить значения вектора из строки
            char[] del = { ' ' };
            string[] sub = str.Split(del);
            // список для временного хранения значений
            List<double> values = new List<double>();
            double value;
            for (int i = 0; i < sub.Length; i++)
            {
                if (double.TryParse(sub[i], out value))
                {
                    values.Add(value);
                }
            }
            elements = values.ToArray();

            return res;
        }

        public bool Write(string fileName)
        {
            bool res = true;
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(fileName, false,
                    Encoding.Default);

                string str = ToString();
                writer.Write(str);
            }
            catch (Exception ex)
            {
                // обработка исключительной ситуации
                Console.Write("Ошибка при записи файла: ");
                Console.WriteLine(ex.Message);
                res = false;
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                    writer.Dispose();
                    writer = null;
                }
            }

            return res;
        }
    }
}
