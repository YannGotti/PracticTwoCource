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
        int x = 0;
        int y = 0;
        double opacity = 0;
        int size = 0;
        int R = 0;
        int B = 0;
        int G = 0;
        int rotate = 0;
        bool enable = false;

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
                        case ObjectsTypes.Lamp:
                            DrawLamp(g, o, bound);
                            break;
                        case ObjectsTypes.Cube:
                            DrawCube(g, o, bound);
                            break;
                        case ObjectsTypes.Triangle:
                            DrawTriangle(g, o, bound);
                            break;
                        case ObjectsTypes.Springboard:
                            DrawSpringboard(g, o, bound);
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
            g = CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.FromArgb(R, G, B));
            SolidBrush brushShadow = new SolidBrush(Color.FromArgb(30, 0, 0, 0));
            List<Point[]> points = Object.DrawCube();
            enable = Object.Enabled;
            g.FillPolygon(brush, points[0]);

            if (enable)
                g.FillPolygon(brushShadow, points[1]);
            else
                g.DrawPolygon(new Pen(Color.Black, 2), points[0]);
        }

        protected void DrawTriangle(Graphics g, Object Object, Rectangle bound)
        {
            g = CreateGraphics();

            x = Object.X;
            y = Object.Y;
            size = Object.Size;
            opacity = Object.Opacity;
            rotate = Object.Rotate;
            R = Object.ColorR;
            B = Object.ColorB;
            G = Object.ColorG;

            bool enable = Object.Enabled;

            SolidBrush brush = new SolidBrush(Color.FromArgb(R, G, B));
            SolidBrush brushShadow = new SolidBrush(Color.FromArgb(30, 0, 0, 0));

            Point[] myArray =
            {
                new Point(x, y),new Point(x + size / 2, y + size),
                new Point(x + size / 2, y + size),new Point(x - size / 2, y + size),

            };

            Matrix myMatrix = new Matrix();
            myMatrix.RotateAt(-rotate, new Point(x, y + size / 2));
            myMatrix.TransformPoints(myArray);


            g.FillPolygon(brush, myArray);


            if (enable)
            {
                
                PointF[] ArrayShadow =
                {
                    myArray[0],myArray[1],
                    new Point(myArray[2].X - 30, bound.Bottom - 3),new Point(x - 400, bound.Bottom - 3),

                };

                g.FillPolygon(brushShadow, ArrayShadow);
            }
            else
            {
                g.DrawPolygon(new Pen(Color.Black, 2), myArray);
            }

        }


        protected void DrawSpringboard(Graphics g, Object Object, Rectangle bound)
        {
            g = CreateGraphics();

            

            x = Object.X;
            y = Object.Y;
            rotate = Object.Rotate;
            R = Object.ColorR;
            B = Object.ColorB;
            G = Object.ColorG;

            bool enable = Object.Enabled;

            int width = size = Object.Size;
            int height = width - 50;

            PointF[] myArray =
            {
                new Point(x, y),new Point(x + width, y),
                new Point(x + width, y + height - 5),new Point(x - 100 - width, y + height - 5),
            };

            Matrix myMatrix = new Matrix();
            myMatrix.RotateAt(rotate, new PointF(x + width / 2, y + height / 2));
            g.Transform = myMatrix;
            g.FillPolygon(new SolidBrush(Color.FromArgb(R, B, G)), myArray);

            if (!enable)
            {
                g.DrawPolygon(new Pen(Color.Black, 2), myArray);
            }


        }


        protected void DrawLamp(Graphics g, Object Object, Rectangle bound)
        {
            g = CreateGraphics();

            x = Object.X;
            y = Object.Y;

            opacity = Object.Opacity;
            R = Object.ColorR;
            B = Object.ColorB;
            G = Object.ColorG;
            rotate = Object.Rotate;
            bool enable = Object.Enabled;

            int cube = 80;
            Pen Pen = new Pen(Color.Black, 3);
            Pen PenEnable = new Pen(Color.Black, 4);
            Pen PenCircle = new Pen(Color.Black, 3);
            SolidBrush brushLight = new SolidBrush(Color.FromArgb(90, 255, 180, 63));


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
                new Point(1400, 360), new Point(2000, bound.Bottom),
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


            Matrix.RotateAt(rotate, new PointF(x + 180 + 30, y - 255 + 30));
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

        private void Canvas_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.Location.ToString());
        }
    }
}
