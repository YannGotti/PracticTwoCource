using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TransportApp
{
    // 
    public enum VehicleTypes
    {
        Unknown,
        AirVehicle,
        WaterVehicle,
        LandVehicle
    }

    public class Vehicle
    {
        string name;
        double volume;
        double maxVolume;

        double x;
        double y;

        public Vehicle()
        {
            name = string.Empty;
            volume = 0;
            maxVolume = 100;
            x = 0;
            y = 0;
        }

        public Vehicle(string name, double maxVolume)
        {
            this.name = name;
            this.maxVolume = maxVolume;
            x = 0;
            y = 0;
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public double Volume
        {
            set
            {
                if (value < 0)
                    volume = 0;
                else if (value > maxVolume)
                    volume = maxVolume;
                else
                    volume = value;
            }
            get
            {
                return volume;
            }
        }

        public double MaxVolume
        {
            set
            {
                if (value < 0)
                    maxVolume = 100;
                else
                    maxVolume = value;
            }
            get
            {
                return maxVolume;
            }
        }

        public double X
        {
            set {
                if (value < 0)
                    x = 0;
                else
                    x = value;
            }
            get { return x; }
        }

        public double Y
        {
            set {
                if (value < 0)
                    y = 0;
                else
                    y = value;
            }
            get { return y; }
        }

        public virtual void Move(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual VehicleTypes GetVehicleType()
        {
            return VehicleTypes.Unknown;
        }

        public override string ToString()
        {
            return name;
        }

        public virtual string GetDataString()
        {
            return string.Empty;

        }

        public static bool SaveData(string fileName, List<Vehicle> vehicles)
        {
            bool success = false;
            if (string.IsNullOrEmpty(fileName) ||
                string.IsNullOrWhiteSpace(fileName) ||
                vehicles == null || vehicles.Count == 0)
                return success;

            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(fileName, false, Encoding.Default);

                for(int i=0; i < vehicles.Count; i++)
                {
                    if (vehicles[i] != null)
                        writer.WriteLine(vehicles[i].GetDataString());
                }

                writer.Close();
                success = true;
            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    ex.Message, "Ошибка при сохранении");
            }
            finally
            {
                if (writer != null)
                    writer.Dispose();
            }

            return success;
        }

        public static bool ReadData (string fileName, List<Vehicle> vehicles)
        {
            bool success = false;
            StreamReader reader = null;

            if (string.IsNullOrEmpty(fileName) ||
                string.IsNullOrWhiteSpace(fileName))
                return success;

            // Очистить список
            vehicles.Clear();

            try
            {
                reader = new StreamReader(fileName, Encoding.Default);
                string str;

                Vehicle v = null;

                while (!reader.EndOfStream)
                {
                    // Прочитать строку
                    str = reader.ReadLine();
                    // Получить экземпляр из строки
                    v = FromString(str);
                    if (v != null)
                        vehicles.Add(v);
                }

                reader.Close();
                success = true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    ex.Message, "Ошибка при чтении");
            }
            finally
            {
                if (reader != null)
                    reader.Dispose();
            }
            return success;
        }

        public static Vehicle FromString(string str)
        {
            Vehicle v = null;
            if (string.IsNullOrEmpty(str) ||
                string.IsNullOrWhiteSpace(str))
                return v;

            char[] del = { ';' };
            string[] sub = str.Split(del);

            if (sub.Length < 7)
                return v;

            // Тип
            int type;
            
            // Наименование
            //string name;
            // Максимальный объём
            double maxVolume;
            // Объём
            double volume;
            // x
            double x;
            // y
            double y;
            // Характеристика
            double fValue = 0;
            int iValue = 0;

            if (!int.TryParse(sub[0], out type))
                return v;
            if (!double.TryParse(sub[2], out maxVolume))
                return v;
            if (!double.TryParse(sub[3], out volume))
                return v;
            if (!double.TryParse(sub[4], out x))
                return v;
            if (!double.TryParse(sub[5], out y))
                return v;


            bool res = false;
            switch (type)
            {
                case 0: res = int.TryParse(sub[6], out iValue); break;
                case 1: res = double.TryParse(sub[6], out fValue); break;
                case 2: res = int.TryParse(sub[6], out iValue); break;
            }
            if (!res)
                return v;
            // Создание экземпляра
            switch (type)
            {
                case 0: // воздушн
                    AirVehicle a = new AirVehicle(sub[1], maxVolume, iValue);
                    a.volume = volume;
                    a.x = x;
                    a.y = y;
                    v = a;
                    break;
                case 1: // водный
                    WaterVehicle w = new WaterVehicle(sub[1], maxVolume, iValue);
                    w.volume = volume;
                    w.x = x;
                    w.y = y;
                    v = w;
                    break;
                case 2: // наземный
                    LandVehicle l = new LandVehicle(sub[1], maxVolume, iValue);
                    l.volume = volume;
                    l.x = x;
                    l.y = y;
                    v = l;
                    break;
            }

            return v;
        }

        public static int CompareAZ(Vehicle a, Vehicle b)
        {
            return a.name.CompareTo(b.name);
        }

        public static int CompareZA(Vehicle a, Vehicle b)
        {
            return -a.name.CompareTo(b.name);
        }

        public static int VolumeSort(Vehicle a, Vehicle b)
        {
            if (a.Volume < b.Volume)
            {
                return 1;
            }
            else if (a.Volume > b.Volume)
            {
                return -1;
            }
            else return 0;
        }

        public static int MaxVolumeSort(Vehicle a, Vehicle b)
        {
            if (a.MaxVolume < b.MaxVolume)
            {
                return 1;
            }
            else if (a.MaxVolume > b.MaxVolume)
            {
                return -1;
            }
            else return 0;
        }

        public static int SortX(Vehicle a, Vehicle b)
        {
            if (a.X < b.X)
            {
                return 1;
            }
            else if (a.X > b.X)
            {
                return -1;
            }
            else return 0;
        }

        public static int SortY(Vehicle a, Vehicle b)
        {
            if (a.Y < b.Y)
            {
                return 1;
            }
            else if (a.Y > b.Y)
            {
                return -1;
            }
            else return 0;
        }

    }

    public class AirVehicle : Vehicle
    {
        int engines;

        public AirVehicle()
            : base()
        {
            engines = 1;
        }

        public AirVehicle(string name, double maxVolume, int engines)
            : base(name, maxVolume)
        {
            this.engines = engines;
        }

        public int Engines
        {
            set
            {
                if (engines < 1)
                    engines = 1;
                else
                    engines = value;
            }
            get { return engines; }
        }

        public void Fly(double x, double y)
        {            
            Move(x, y);
        }

        public override VehicleTypes GetVehicleType()
        {
            // воздушный транспорт
            return VehicleTypes.AirVehicle;
        }

        public override string GetDataString()
        {
            string format = "0;{0};{1};{2};{3};{4};{5}";
            string res = string.Format(format,
                Name, MaxVolume, Volume, X, Y, Engines);
            return res;
        }

    }

    public class WaterVehicle : Vehicle
    {
        double displacement;

        public WaterVehicle()
            : base()
        {
            displacement = 100;
        }

        public WaterVehicle(string name, double maxVolume, double displacement)
            : base(name, maxVolume)
        {
            this.displacement = displacement;
        }

        public double Displacement
        {
            set
            {
                if (value < 0)
                    displacement = 100;
                else
                    displacement = value;
            }
            get { return displacement; }
        }

        public void Sails(double x, double y)
        {            
            Move(x, y);
        }

        public override VehicleTypes GetVehicleType()
        {
            // водный транспорт
            return VehicleTypes.WaterVehicle;
        }

        public override string GetDataString()
        {
            string format = "1;{0};{1};{2};{3};{4};{5}";
            string res = string.Format(format,
                Name, MaxVolume, Volume, X, Y, Displacement);
            return res;
        }

    }

    public class LandVehicle : Vehicle
    {
        int wheels;

        public LandVehicle()
            : base()
        {
            wheels = 2;
        }

        public LandVehicle(string name, double maxVolume, int wheels)
            : base(name, maxVolume)
        {
            this.wheels = wheels;
        }

        public int Wheels
        {
            set
            {
                if (value < 1)
                    wheels = 1;
                else
                    wheels = value;
            }
            get { return wheels; }
        }

        public void Roll(double x, double y)
        {            
            Move(x, y);
        }

        public override VehicleTypes GetVehicleType()
        {
            // наземный транспорт
            return VehicleTypes.LandVehicle;
        }

        public override string GetDataString()
        {
            string format = "2;{0};{1};{2};{3};{4};{5}";
            string res = string.Format(format,
                Name, MaxVolume, Volume, X, Y, Wheels);
            return res;
        }
    }
}
