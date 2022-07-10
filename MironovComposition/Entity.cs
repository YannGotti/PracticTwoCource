using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MironovComposition
{
    public class Square : Object
    {
        public Square()
        {

        }

        public Square(string name, int x, int y)
            : base(name, x, y)
        {
            // Точки квадрата
            source.Clear();
            source.Add(new PointF(0, 0));
            source.Add(new PointF(1, 0));
            source.Add(new PointF(1, 1));
            source.Add(new PointF(0, 1));

            sourceShadow.Clear();
            sourceShadow.Add(new PointF(0, -3));
            sourceShadow.Add(new PointF(1, 0));
            sourceShadow.Add(new PointF(1, 1));
            sourceShadow.Add(new PointF(0, 1));
            sourceShadow.Add(new PointF(-15, -3));

            // координаты центра
            xc = 0.5;
            yc = 0.5;
        }

        protected override void DrawObject(Graphics g)
        {
            // Нарисовать объект
            g.FillPolygon(new SolidBrush(Color.FromArgb(R, G, B)), transformed.ToArray());

            if (enable)
                g.FillPolygon(new SolidBrush(Color.FromArgb(30, 0, 0, 0)), transformedShadow.ToArray());
            else
            {
                g.DrawPolygon(Pens.DarkBlue, transformed.ToArray());
            }


        }

        public override ObjectsTypes GetObjectType()
        {
            // воздушный транспорт
            return ObjectsTypes.Square;
        }
    }

    public class Triangle : Object
    {
        public Triangle()
        {

        }

        public Triangle(string name, int x, int y)
            : base(name, x, y)
        {
            // Точки квадрата
            source.Clear();
            source.Add(new PointF(0, 0));
            source.Add(new PointF(1, 0));
            source.Add(new PointF(0.5f, 1));

            sourceShadow.Clear();
            sourceShadow.Add(new PointF(0, -3));
            sourceShadow.Add(new PointF(1, 0));
            sourceShadow.Add(new PointF(0.5f, 1));
            sourceShadow.Add(new PointF(-15, -3));

            // координаты центра
            xc = 0.5;
            yc = 0.5;
        }

        protected override void DrawObject(Graphics g)
        {
            // Нарисовать объект
            g.FillPolygon(new SolidBrush(Color.FromArgb(R, G, B)), transformed.ToArray());

            if (enable)
                g.FillPolygon(new SolidBrush(Color.FromArgb(30, 0, 0, 0)), transformedShadow.ToArray());
            else
            {
                g.DrawPolygon(Pens.DarkBlue, transformed.ToArray());
            }


        }

        public override ObjectsTypes GetObjectType()
        {
            // воздушный транспорт
            return ObjectsTypes.Triangle;
        }
    }

    public class Springboard : Object
    {
        public Springboard()
        {

        }

        public Springboard(string name, int x, int y)
            : base(name, x, y)
        {
            // Точки квадрата
            source.Clear();
            source.Add(new PointF(-3, 0));
            source.Add(new PointF(2, 0));
            source.Add(new PointF(2, 1));
            source.Add(new PointF(0, 1));

            // координаты центра
            xc = 0.5;
            yc = 0.5;
        }

        protected override void DrawObject(Graphics g)
        {
            // Нарисовать объект
            g.FillPolygon(new SolidBrush(Color.FromArgb(R, G, B)), transformed.ToArray());

            if (!enable)
                g.DrawPolygon(Pens.DarkBlue, transformed.ToArray());
        }

        public override ObjectsTypes GetObjectType()
        {
            // воздушный транспорт
            return ObjectsTypes.Triangle;
        }
    }

    public class Lamp : Object
    {
        public Lamp()
        {

        }

        public Lamp(string name, int x, int y)
            : base(name, x, y)
        {
            Angle = 110;
            Enabled = false;
        }

        protected override void DrawObject(Graphics g)
        {
            int cube = 80;
            Pen Pen = new Pen(Color.Black, 2);
            Pen PenEnable = new Pen(Color.Black, 2);
            Pen PenCircle = new Pen(Color.Black, 2);
            SolidBrush brushLight = new SolidBrush(Color.FromArgb(30, 255, 180, 63));


            Rectangle circle = new Rectangle(x + 180, y - 255, 60, 60);
            Rectangle circle2 = new Rectangle(x + 180 + 15, y - 255 + 15, 30, 30);
            Rectangle rect = new Rectangle(x + 210, y - 13, 50, 50);


            PointF[] LampBord =
            {
                new Point(x, y),new Point(x + 10, y - 10),
                new Point(x + 10, y - 10), new Point(x + 190, y - 10),
                new Point(x + 190, y - 10), new Point(x + 190 + 10, y),
            };

            PointF[] LampBord2 =
            {
                new Point(x + 25, y - 10),new Point(x + 40, y - 25),
                new Point(x + 40, y - 25), new Point(x + 190 - 25, y - 25),
                new Point(x + 190 - 25, y - 25), new Point(x + 190 - 15, y - 10),
            };

            PointF[] LampLines =
            {
                new Point(x + 15 + 104, y - 25),new Point(x + 9 + 180, y - 21 - 180),
                new Point(x + 10 + 183, y - 22 - 177), new Point(x + 15 + 110, y - 25)
            };

            PointF[] LampLines2 =
            {
                new Point(x + 30 + 104, y - 25),new Point(x + 20 + 180, y - 15 - 180),
                new Point(x + 25 + 180, y - 195),new Point(x + 30 + 110, y - 25)
            };

            PointF[] LampLines3 =
            {
                new Point(x + 35 + 104, y - 75),new Point(x + 9 + 180, y - 21 - 180),
                new Point(x + 10 + 183, y - 22 - 177), new Point(x + 35 + 110, y - 75)
            };

            PointF[] LampLines4 =
            {
                new Point(x + 50 + 104, y - 65),new Point(x + 20 + 180, y - 15 - 180),
                new Point(x + 25 + 180, y - 195),new Point(x + 50 + 110, y - 65)
            };


            PointF[] LampHead =
            {
                new Point(x + 180, y - 50), new Point(x + 200 - cube, y - 90),
                new Point(x + 90, y - 20), new Point(x + 150, y + 10),
                new Point(x + 180, y - 50), new Point(x + 271, y - 47),
                new Point(x + 202, y + 75), new Point(x + 150, y + 10),
            };


            PointF[] Light =
            {
                new Point(x + 202, y + 77),new Point(x + 273, y - 50),
                new Point(1400, 360), new Point(2000, 600),
                new Point(x + 273 + 2000, y + 2500), new Point(x + 202, y + 77),
            };

            PointF[] Enable =
            {
                new Point(x + 65, y - 26),new Point(x + 75, y - 36),
                new Point(x + 55, y - 36),
            };
            SolidBrush brushLightLamp;


            Matrix Matrix = new Matrix();
            Matrix.Rotate(0);
            g.Transform = Matrix;
            g.DrawPolygon(Pen, LampBord);
            g.DrawPolygon(Pen, LampBord2);
            g.DrawPolygon(Pen, LampLines);
            g.DrawLines(Pen, LampLines2);
            g.DrawEllipse(PenCircle, circle);
            g.DrawEllipse(PenCircle, circle2);

            if (enable)
            {
                brushLightLamp = new SolidBrush(Color.FromArgb(100, 255, 213, 100));
                g.DrawLine(PenEnable, Enable[0], Enable[2]);
            }
            else
            {
                brushLightLamp = new SolidBrush(Color.FromArgb(100, 120, 120, 100));
                g.DrawLine(PenEnable, Enable[0], Enable[1]);
            }


            Matrix.RotateAt((float)angle, new PointF(x + 180 + 30, y - 255 + 30));
            g.Transform = Matrix;

            if (enable)
            {
                g.FillPolygon(brushLight, Light);
            }
            g.FillPie(brushLightLamp, rect, 300, 180);
            g.DrawLines(Pen, LampLines3);
            g.DrawLines(Pen, LampLines4);
            g.DrawLines(Pen, LampHead);
        }

        public override ObjectsTypes GetObjectType()
        {
            // воздушный транспорт
            return ObjectsTypes.Lamp;
        }
    }



}
