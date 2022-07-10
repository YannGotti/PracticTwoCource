using System;
using System.Collections.Generic;
using System.Drawing;
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
            sourceShadow.Add(new PointF(-5, -3));

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
            sourceShadow.Add(new PointF(-5, -3));

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

}
