using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VolkovTransportApp
{
    public enum VehicleTypes
    {
        AirVehicle,
        WaterVehicle,
        LandVehicle,
        Unknown
    }



    public class Vehicle
    {
        double volume;

        protected double maxVolume;

        protected string name;

        double x;
        double y;

        double speed;

        public Vehicle()
        {
            name = string.Empty;
            maxVolume = 100;
            volume = 0;

            x = 0;
            y = 0;
            speed = 0;
        }

        public Vehicle(string name, double maxVolume)
        {
            this.name = name;
            this.maxVolume = maxVolume;
            volume = 0;
            x = 0;
            y = 0;
        }

        public virtual void Move(double x, double y)
        {
            this.x = x;
            this.y = y;
            
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public double X
        {
            get { return x; }
        }
        public double Y
        {
            get { return y; }
        }

        public double MaxVolume
        {
            get { return maxVolume; }
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

        public double Speed
        {
            set
            {
                speed = value;
            }
            get
            {
                return speed;
            }
        }

        public virtual VehicleTypes VehicleType
        {
            get { return VehicleTypes.Unknown; }
        }
        public override string ToString()
        {
            return name;
        }
        
    }

    public class AirVehicle : Vehicle
    {
        int engines;
        public AirVehicle()
            : base()
        {
            engines = 2;
        }

        public AirVehicle(string name, double maxVolume, int engines)
            : base(name, maxVolume)
        {
            // количество двигателей
            this.engines = engines;
        }
        public virtual void Fly(double x, double y)
        {
            Console.WriteLine("Fly");
            Move(x, y);
        }

        public int Engines
        {
            get { return engines; }
        }
        public override VehicleTypes VehicleType
        {
            get
            {
                return VehicleTypes.AirVehicle;
            }
        }
    }
    

    public class LandVehicle : Vehicle
    {
        int wheels;

        public LandVehicle()
            : base()
        {
            wheels = 4;
        }

        public LandVehicle(string name, double maxVolume, int wheels)
            : base(name, maxVolume)
        {
            this.wheels = wheels;
        }

        public virtual void Roll(double x, double y)
        {
            
            Move(x, y);
        }

        public int Wheels
        {
            get { return wheels; }
        }
        public override VehicleTypes VehicleType
        {
            get
            {
                return VehicleTypes.LandVehicle;
            }
        }
    }

    public class WaterVehicle : Vehicle
    {
        double displacement;
        public WaterVehicle()
            : base()
        {
            // водоизмещение
            displacement = 1000;
        }

        public WaterVehicle(string name, double maxVolume, double displacement)
            : base(name, maxVolume)
        {
            this.displacement = displacement;
        }

        public virtual void Sails(double x, double y)
        {
           
            Move(x, y);
        }

        public double Displacement
        {
            get { return displacement; }
        }
    }

    public class AirPlane : AirVehicle
    {
        public AirPlane()
            : base()
        {
        }
        public AirPlane(string name, double maxVolume, int engines)
            : base(name, maxVolume, engines)
        {

        }
        public override VehicleTypes VehicleType
        {
            get
            {
                return VehicleTypes.WaterVehicle;
            }
        }
    }

    public class Ship : WaterVehicle
    {
        public Ship()
            : base()
        {
        }
        public Ship(string name, double maxVolume, double displacement)
            : base(name, maxVolume, displacement)
        {

        }
    }

    public class Car : LandVehicle
    {
        public Car()
            : base()
        {
        }

        public Car(string name, double maxVolume, int wheels)
            : base(name, maxVolume, wheels)
        {

        }
    }

}
