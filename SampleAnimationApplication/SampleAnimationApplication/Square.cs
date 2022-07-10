using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SampleAnimationApplication
{
    class Square : BaseGraphicObject
    {
        public Square()
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
            g.DrawPolygon(Pens.DarkBlue, transformed.ToArray());
        }
    }
}
