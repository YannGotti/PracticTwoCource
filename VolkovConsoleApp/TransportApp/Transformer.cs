using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportApp
{
    public class Transformer
    {
        double g, h;

        public Transformer()
        {
            g = 0;
            h = 0;
        }

        public void SetParametrs(double sourceMin, double sourceMax,
            double destMin, double destMax)
        {
            g = (destMax - destMin) / (sourceMax - sourceMin);
            h = destMin - g * sourceMin;
        }

        public double Transform(double z)
        {
            double Z = g * z + h;
            return Z;
        }

    }
}
 