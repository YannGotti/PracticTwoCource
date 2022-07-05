using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KozlovConsoleApp
{
    public class Sphere
    {
        double x;
        double y;
        double radius;

        public Sphere()
        {
            x = 0;
            y = 0;
            radius = 0;
        }

        public Sphere(double x, double y, double radius)
        {
            // инициализация параметров
            this.x = x;
            this.y = y;

            Radius = radius;
        }

        public double X
        {
            set { x = value; }
            get { return x; }
        }

        public double Y
        {
            set { y = value; }
            get { return y; }
        }

        public double Radius
        {
            set
            {
                if (value < 0)
                    radius = 0;
                else
                    radius = value;
            }
        }

        public double GetVolume()
        {
            double v = 4.0 * Math.PI * radius * radius * radius / 3.0;
            return v;
        }

        public double GetSquare()
        {
            double s = 4 * Math.PI * radius * radius;
            return s;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("x = ");
            str.Append(x);
            str.Append(", y = ");
            str.Append(y);
            str.Append(", radius = ");
            str.Append(radius);
            return str.ToString();
        }
    }
}
