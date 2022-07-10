using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SampleAnimationApplication
{
    class BezierCurve : BaseGraphicObject
    {
        public BezierCurve()
            : base()
        {
            // Точки квадрата
            source.Clear();
            source.Add(new PointF(0, 0));
            source.Add(new PointF(1, 0));
            source.Add(new PointF(1, 1));
            source.Add(new PointF(0, 1));

            // координаты центра
            xc = 0.5;
            yc = 0.5;
        }

        protected override void DrawObject(Graphics g)
        {
            // Нарисовать объект            
            // кривая Безье
            g.DrawBezier(Pens.DarkBlue, transformed[0], transformed[1],
                transformed[2], transformed[3]);

            // линии для кривой Безье
            g.DrawLine(Pens.LightBlue, transformed[0], transformed[1]);
            g.DrawLine(Pens.LightBlue, transformed[3], transformed[2]);

            // точки
            DrawPoint(g, Brushes.Orange, transformed[0], 10);
            DrawPoint(g, Brushes.Orange, transformed[1], 10);
            DrawPoint(g, Brushes.Orange, transformed[2], 10);
            DrawPoint(g, Brushes.Orange, transformed[3], 10);
        }
        protected void DrawPoint(Graphics g, Brush brush, PointF pt, float size)
        {
            g.FillEllipse(brush, pt.X - 0.5f * size, pt.Y - 0.5f * size, size, size);
        }
    }
}
