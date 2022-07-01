using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MironovComposition
{
    public enum ObjectsTypes
    {
        Unknown,
        Cube,
        Triangle,
        Springboard,
        Lamp
    }

    public class Object
    {
        string name;
        int x;
        int y;
        int size;
        double opacity;
        int rotate;
        int R;
        int B;
        int G;

        bool enable;

        PointF[] newPoints;
        PointF[] resultPoints;

        public Object()
        {
            name = string.Empty;
            x = 0;
            y = 0;
            size = 100;
            rotate = 0;
            R = 255;
            G = 255;
            B = 255;
        }

        public Object(string name, int x, int y)
        {
            this.name = name;
            this.x = x;
            this.y = y;

            size = 100;

            rotate = 0;
            R = 252;
            G = 252;
            B = 252;
            enable = false;
        }

        public Matrix Matrix()
        {
            Matrix Matrix = new Matrix();
            Matrix.RotateAt(Rotate, new PointF(x + Size / 2, y + Size / 2));

            return Matrix;
        }


        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public PointF[] NewPoints
        {
            set
            {
                newPoints = value;
            }
            get { return newPoints; }
        }

        public PointF[] ResultPoints
        {
            set { resultPoints = value; }
            get { return resultPoints; }
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
            get { return x; }
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
            get { return y; }
        }


        public int Size
        {
            set
            {
                if (value < 0)
                    size = 0;
                if (value > 200)
                    size = 200;
                else
                    size = value;
            }
            get
            {
                return size;
            }
        }

        public int Rotate
        {
            set
            {
                if (value < 0)
                    rotate = 0;
                if (value > 360)
                    rotate = 360;
                else
                    rotate = value;
            }
            get
            {
                return rotate;
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

        public int ColorR
        {
            set
            {
                if (value < 0)
                    R = 0;
                if (value > 255)
                    R = 255;
                else
                    R = value;
            }
            get
            {
                return R;
            }
        }

        public int ColorG
        {
            set
            {
                if (value < 0)
                    G = 0;
                if (value > 255)
                    G = 255;
                else
                    G = value;
            }
            get
            {
                return G;
            }
        }

        public int ColorB
        {
            set
            {
                if (value < 0)
                    B = 0;
                if (value > 255)
                    B = 255;
                else
                    B = value;
            }
            get
            {
                return B;
            }
        }

        public bool Enabled
        {
            set
            {
                enable = value;
            }
            get
            {
                return enable;
            }
        }

        


        public virtual ObjectsTypes GetObjectType()
        {
            return ObjectsTypes.Unknown;
        }

        public override string ToString()
        {
            return name;
        }

    }

    public class CubeObject : Object
    {
        public CubeObject()
            : base()
        {
        }

        public CubeObject(string name, int x, int y)
            : base(name, x, y)
        {
            NewPoints = new PointF[]
            {
                new Point(x, y), new Point(x + Size, y),
                new Point(x + Size, y), new Point(x + Size,y + Size),
                new Point(x + Size, y + Size), new Point(x, y + Size),
                new Point(x, y + Size), new Point(x, y)
            };
        }

        public override ObjectsTypes GetObjectType()
        {
            // воздушный транспорт
            return ObjectsTypes.Cube;
        }

    }


    public class TriangleObject : Object
    {

        public TriangleObject()
            : base()
        {

        }

        public TriangleObject(string name, int x, int y)
            : base(name, x, y)
        {
            NewPoints = new PointF[]
            {
                new Point(x, y),new Point(x + Size / 2, y + Size),
                new Point(x + Size / 2, y + Size),new Point(x - Size / 2, y + Size),
            };
        }


        public override ObjectsTypes GetObjectType()
        {
            // воздушный транспорт
            return ObjectsTypes.Triangle;
        }

    }


    public class SpringboardObject : Object
    {
        public SpringboardObject()
            : base()
        {

        }

        public SpringboardObject(string name, int x, int y)
            : base(name, x, y)
        {
            NewPoints = new PointF[]
            {
                new Point(x, y),new Point(x + 150, y),
                new Point(x + 150, 470),new Point(x - 250, 470)
            };
        }

        public override ObjectsTypes GetObjectType()
        {
            // воздушный транспорт
            return ObjectsTypes.Springboard;
        }

    }

    public class LampObject : Object
    {
        bool enable;

        public LampObject()
            : base()
        {

        }

        public LampObject(string name, int x, int y)
            : base(name, x, y)
        {
            Rotate = 110;
            enable = false;
        }
        

        public override ObjectsTypes GetObjectType()
        {
            // воздушный транспорт
            return ObjectsTypes.Lamp;
        }

    }


}
