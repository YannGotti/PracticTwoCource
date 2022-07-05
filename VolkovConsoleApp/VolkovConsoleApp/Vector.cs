using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KozlovConsoleApp
{
    public class Vector
    {
        protected double[] elements;

        public Vector(int n)
        {
            elements = new double[n];
        }

        public int Size
        {
            get { return elements.Length; }
        }

        public double this[int index]
        {
            set { elements[index] = value; }
            get { return elements[index]; }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < elements.Length - 1; i++)
            {
                str.Append(elements[i]);
                str.Append(' ');
            }
            str.Append(elements[elements.Length - 1]);

            return str.ToString();
        }
    }
}
