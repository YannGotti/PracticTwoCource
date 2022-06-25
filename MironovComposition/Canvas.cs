using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MironovComposition
{
    public partial class Canvas : UserControl
    {
        List<Object> objectsList;
        int x;
        int y;
        int size;
        double opacity;
        int rotate;
        int R;
        int B;
        int G;

        public Canvas()
        {
            InitializeComponent();
            objectsList = null;
        }


        public List<Object> Objects
        {
            set { objectsList = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Заполнение фона
            e.Graphics.FillRectangle(Brushes.White, ClientRectangle);
            e.Graphics.DrawLine(new Pen(Color.Black, 6), new Point(ClientRectangle.Left, ClientRectangle.Bottom),
                new Point(ClientRectangle.Right, ClientRectangle.Bottom));
            // Вывод карты
            DrawMap(e.Graphics, ClientRectangle);
        }

        protected void DrawMap(Graphics g, Rectangle bound)
        {
            if (objectsList != null && objectsList.Count > 0)
            {
                for (int i = 0; i < objectsList.Count; i++)
                {
                    Object o = objectsList[i];
                    switch (o.GetObjectType())
                    {
                        case ObjectsTypes.Cube:
                            DrawCube(g, o, bound);
                            break;
                        case ObjectsTypes.Triangle:
                            DrawTriangle(g, o);
                            break;
                        case ObjectsTypes.Springboard:
                            break;
                        case ObjectsTypes.Lamp:
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                // Вывод текста
                string text = "Область анимации";
                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;

                RectangleF rect = new RectangleF(bound.X, bound.Y,
                    bound.Width, bound.Height);
                g.DrawString(text, Font, Brushes.Black, rect, format);
            }
        }
        protected void DrawCube(Graphics g, Object Object, Rectangle bound)
        {
            x = Object.X;
            y = Object.Y;
            size = Object.Size;
            opacity = Object.Opacity;
            rotate = Object.Rotate;
            R = Object.ColorR;
            B = Object.ColorB;
            G = Object.ColorG;

            SolidBrush brush = new SolidBrush(Color.FromArgb(R, G, B));
            SolidBrush brushShadow = new SolidBrush(Color.FromArgb(30,0, 0, 0));

            PointF[] ArrayCube =
            {
                new Point(x, y), new Point(x + size, y),
                new Point(x + size, y), new Point(x + size,y + size),
                new Point(x + size, y + size), new Point(x, y + size),
                new Point(x, y + size), new Point(x, y)
            };

            Matrix myMatrix = new Matrix();
            myMatrix.RotateAt(rotate, new PointF(x + size / 2, y + size / 2));


            if (rotate == 0 || rotate == 90 || rotate == 180 || rotate == 360)
            {
                PointF[] ArrayShadow =
                {
                    new Point(x, y), new Point(x + size, y),
                    new Point(x + size, y), new Point(x + size, bound.Bottom),
                    new Point(x + size, bound.Bottom - 3), new Point(x - 80, bound.Bottom - 3),
                    new Point(x - 80, bound.Bottom - 3), new Point(x, y)
                };

                g.FillPolygon(brushShadow, ArrayShadow);
            }
            
            g.Transform = myMatrix;
            g.FillPolygon(brush, ArrayCube);
        }

        protected void DrawTriangle(Graphics g, Object Object)
        {
            x = Object.X;
            y = Object.Y;
            size = Object.Size;
            opacity = Object.Opacity;
            rotate = Object.Rotate;
            R = Object.ColorR;
            B = Object.ColorB;
            G = Object.ColorG;

            SolidBrush brush = new SolidBrush(Color.FromArgb(R, G, B));
            PointF[] myArray =
            {
                new Point(x, y),new Point(x + size / 2, y + size),
                new Point(x + size / 2, y + size),new Point(x - size / 2, y + size),

            };

            Matrix myMatrix = new Matrix();
            myMatrix.RotateAt(rotate, new PointF(x, y + size / 2));
            g.Transform = myMatrix;

            g.FillPolygon(brush, myArray);
        }
    }
}
