using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VolkovConsoleApp
{
    public class OOP
    {
        public static void Task2()
        {
            // Задача 2. 
            // Создание экземпляров классов транспортных средств
            Vehicle v = new Vehicle("Транспортное средство", 20);
            AirVehicle a = new AirVehicle("Самолет", 10, 2);
            WaterVehicle w = new WaterVehicle("Корабль", 1000, 1800);
            LandVehicle l = new LandVehicle("Автомобиль", 10, 4);

            // Проверка типа транспортного средства
            TestVehicle(v);
            TestVehicle(a);
            TestVehicle(w);
            TestVehicle(l);
        }

        public static void TestVehicle(Vehicle v)
        {
            Console.Write(v.Name);
            Console.Write(": ");
            if (v is AirVehicle)
            {
                Console.WriteLine("Воздушный транспорт");
            }
            else if (v is WaterVehicle)
            {
                Console.WriteLine("Водный транспорт");
            }
            else if (v is LandVehicle)
            {
                Console.WriteLine("Наземный транспорт");
            }
            else
            {
                Console.WriteLine("Транспортное средство общего вида");
            }
        }

        public static void S1()
        {
            // Самостоятельная работа 1
            Console.WriteLine("Самостоятельная работа 1");
            // Количество элементов
            int n;
            if (!IO.ReadValue("количество коробок", out n, true))
                return;
            if (n <= 0)
            {
                Console.WriteLine("Количество коробок должно быть больше 0.");
                return;
            }
            // Массив коробок
            Box[] boxes = new Box[n];
            // Ввод исходных данных
            int number;
            double value;
            for (int i = 0; i < n; i++)
            {
                // экземпляр 
                boxes[i] = new Box();
                // номер
                if (!IO.ReadValue("номер коробки", out number, true))
                    number = 0;
                boxes[i].Number = number;
                // ширина
                if (!IO.ReadValue("ширину", out value, true))
                    value = 0;
                boxes[i].Width = value;
                // высота
                if (!IO.ReadValue("высоту", out value, true))
                    value = 0;
                boxes[i].Height = value;
                // глубина
                if (!IO.ReadValue("глубину", out value, true))
                    value = 0;
                boxes[i].Depth = value;
            }
            // вывод
            Console.WriteLine();
            Console.WriteLine("Расчет показателей");
            double s, v;
            for (int i = 0; i < n; i++)
            {
                // расчет площади
                s = boxes[i].GetSquare();
                // расчет объема
                v = boxes[i].GetVolume();
                // вывод информации о коробке
                Console.WriteLine(boxes[i]);
                // информация о площади
                Console.Write("Площадь: ");
                Console.WriteLine(s);
                // информация об объеме
                Console.Write("Объем: ");
                Console.WriteLine(v);
            }
        }
    }
}
