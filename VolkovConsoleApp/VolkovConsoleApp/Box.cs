using System;
using System.Collections.Generic;
using System.Text;

namespace VolkovConsoleApp
{
    class Box
    {
        int number;
        double width;
        double height;
        double depth;

        public Box()
        {
            number = 0;
            width = 0;
            height = 0;
            depth = 0;
        }

        public Box(int number, double width, double height,
            double depth)
        {
            // инициализация значений            
            Number = number;
            Width = width;
            Height = height;
            Depth = depth;
        }

        public int Number
        {
            set
            {
                if (value < 0)
                    number = 0;
                else
                    number = value;
            }
            get { return number; }
        }

        public double Width
        {
            set
            {
                if (value < 0)
                    width = value;
                else
                    width = value;
            }
            get { return width; }
        }

        public double Height
        {
            set
            {
                if (value < 0)
                    height = 0;
                else height = value;
            }
            get { return height; }
        }

        public double Depth
        {
            set
            {
                if (value < 0)
                    depth = 0;
                else
                    depth = value;
            }
            get { return depth; }
        }

        public double GetVolume()
        {
            return width * height * depth;
        }

        public double GetSquare()
        {
            double s = width * height + height * depth + width * depth;
            return 2 * s;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("Номер ");
            str.Append(number);
            str.Append(", Ширина ");
            str.Append(width);
            str.Append(", Высота ");
            str.Append(height);
            str.Append(", Глубина ");
            str.Append(depth);

            string s =
                string.Format("Номер {0}, Ширина {1}, Высота {2}, Глубина {3}",
                number, width, height, depth);

            return str.ToString();
        }

    }
}
