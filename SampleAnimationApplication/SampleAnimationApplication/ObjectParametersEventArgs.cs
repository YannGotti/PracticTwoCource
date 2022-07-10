using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAnimationApplication
{
    /// <summary>
    /// Релизует передачу параметров объекта 
    /// при обработке события ObjectParameterChanged
    /// </summary>
    public class ObjectParametersEventArgs
    {
        int size;
        int angle;
        int x;
        int y;

        public ObjectParametersEventArgs(int size, int angle, int x, int y)
        {
            this.size = size;
            this.angle = angle;
            this.x = x;
            this.y = y;
        }

        public int Size
        {
            get { return size; }
        }

        public int Angle
        {
            get { return angle; }
        }

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }
    }
}
