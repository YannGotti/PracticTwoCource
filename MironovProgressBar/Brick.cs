using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MironovProgressBar
{
    public class Brick
    {

        int x;
        int y;
        double opacity;

        public Brick()
        {
            
        }

        public Brick(int x, int y, double opacity)
        {
            this.x = x;
            this.y = y;
            this.opacity = opacity;
        }


        public int X
        {
            set
            {
                if (value < 0)
                    x = 0;
                else
                    x = value;
            }
            get
            {
                return x;
            }
        }

        public int Y
        {
            set
            {
                if (value < 0)
                    y = 0;
                else
                    y = value;
            }
            get
            {
                return y;
            }
        }

        public double Opacity
        {
            set
            {
                if (value < 0)
                    opacity = 0;
                else
                    opacity = value;
            }
            get
            {
                return opacity;
            }
        }

    }
}
