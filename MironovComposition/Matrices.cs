using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MironovComposition
{
    public class Matrices
    {

        public static Point[] rotateMatrix(Point[] points, int rotate, int dx, int dy, int size)
        {
            Point[] pp = points;
            Matrix matrix = new Matrix();

            matrix.RotateAt(rotate, new PointF(dx + size / 2, dy + size / 2));
            matrix.TransformPoints(pp);

            return pp;
        }

    }

    


}
