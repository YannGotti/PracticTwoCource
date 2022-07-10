using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SampleAnimationApplication
{
    public class AffineMatrix
    {
        double[][] matrix;
        public AffineMatrix()
        {
            matrix = Create(3, 3);
        }

        public void Identity()
        {
            AffineMatrix.Identity(matrix);
        }

        public void Translate(double dx, double dy)
        {
            matrix[0][0] = 1;
            matrix[0][1] = 0;
            matrix[0][2] = dx;

            matrix[1][0] = 0;
            matrix[1][1] = 1;
            matrix[1][2] = dy;

            matrix[2][0] = 0;
            matrix[2][1] = 0;
            matrix[2][2] = 1;
        }

        public void Rotation(double alpha)
        {
            double c = Math.Cos(alpha);
            double s = Math.Sin(alpha);

            matrix[0][0] = c;
            matrix[0][1] = -s;
            matrix[0][2] = 0;

            matrix[1][0] = s;
            matrix[1][1] = c;
            matrix[1][2] = 0;

            matrix[2][0] = 0;
            matrix[2][1] = 0;
            matrix[2][2] = 1;
        }

        public void Scale(double sx, double sy)
        {
            matrix[0][0] = sx;
            matrix[0][1] = 0;
            matrix[0][2] = 0;

            matrix[1][0] = 0;
            matrix[1][1] = sy;
            matrix[1][2] = 0;

            matrix[2][0] = 0;
            matrix[2][1] = 0;
            matrix[2][2] = 1;
        }

        public void Viewport(double ax, double bx, double ay, double by)
        {
            matrix[0][0] = ax;
            matrix[0][1] = 0;
            matrix[0][2] = bx;

            matrix[1][0] = 0;
            matrix[1][1] = ay;
            matrix[1][2] = by;

            matrix[2][0] = 0;
            matrix[2][1] = 0;
            matrix[2][2] = 1;
        }

        public void Viewport(double slx, double srx,
            double dlx, double drx,
            double sly, double sry,
            double dly, double dry)
        {
            double ax = (drx - dlx) / (srx - slx);
            double bx = dlx - ax * slx;

            double ay = (dry - dly) / (sry - sly);
            double by = dly - ay * sly; ;

            matrix[0][0] = ax;
            matrix[0][1] = 0;
            matrix[0][2] = bx;

            matrix[1][0] = 0;
            matrix[1][1] = ay;
            matrix[1][2] = by;

            matrix[2][0] = 0;
            matrix[2][1] = 0;
            matrix[2][2] = 1;
        }

        public void AppendLeft(AffineMatrix m)
        {
            // Умножить слева M = m * M
            Mult3x3(m.matrix, matrix, TempMatrix);            

            // поменять местами
            double[][] t = matrix;
            matrix = temp;
            temp = t;
        }       

        public PointF Transform(PointF p)
        {
            PointF res = new PointF();
            res.X = (float)(matrix[0][0] * p.X + matrix[0][1] * p.Y + matrix[0][2]);
            res.Y = (float)(matrix[1][0] * p.X + matrix[1][1] * p.Y + matrix[1][2]);

            return res;
        }

        // вспомогательная переменная для хранения результата
        private static double[][] temp = null;

        public static double[][] TempMatrix
        {
            get
            {
                if (temp == null)
                    temp = Create(3, 3);

                return temp;
            }
        }

        public static double[][] Create(int rows, int cols)
        {
            double[][] matrix = new double[rows][];
            for (int i = 0; i < rows; i++)
                matrix[i] = new double[cols];

            return matrix;
        }
        public static void Identity(double[][] matrix, int n)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        matrix[i][j] = 1;
                    else
                        matrix[i][j] = 0;
                }
        }

        public static void Identity(double[][] matrix)
        {
            matrix[0][0] = 1;
            matrix[0][1] = 0;
            matrix[0][2] = 0;

            matrix[1][0] = 0;
            matrix[1][1] = 1;
            matrix[1][2] = 0;

            matrix[2][0] = 0;
            matrix[2][1] = 0;
            matrix[2][2] = 1;
        }        

        public static void Mult3x3(double[][] a, double[][] b, double[][] result)
        {
            result[0][0] = a[0][0] * b[0][0] + a[0][1] * b[1][0] + a[0][2] * b[2][0];
            result[0][1] = a[0][0] * b[0][1] + a[0][1] * b[1][1] + a[0][2] * b[2][1];
            result[0][2] = a[0][0] * b[0][2] + a[0][1] * b[1][2] + a[0][2] * b[2][2];

            result[1][0] = a[1][0] * b[0][0] + a[1][1] * b[1][0] + a[1][2] * b[2][0];
            result[1][1] = a[1][0] * b[0][1] + a[1][1] * b[1][1] + a[1][2] * b[2][1];
            result[1][2] = a[1][0] * b[0][2] + a[1][1] * b[1][2] + a[1][2] * b[2][2];

            result[2][0] = a[2][0] * b[0][0] + a[2][1] * b[1][0] + a[2][2] * b[2][0];
            result[2][1] = a[2][0] * b[0][1] + a[2][1] * b[1][1] + a[2][2] * b[2][1];
            result[2][2] = a[2][0] * b[0][2] + a[2][1] * b[1][2] + a[2][2] * b[2][2];
        }
    }
}
