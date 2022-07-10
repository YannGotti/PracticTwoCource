﻿using System;
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
            source.Add(new PointF(x, y));
            source.Add(new PointF(x + 100, y));
            source.Add(new PointF(x + 100, y + 100));
            source.Add(new PointF(x, y + 100));

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
