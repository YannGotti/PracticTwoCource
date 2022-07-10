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
        int size = 0;
        int R = 0;
        int B = 0;
        int G = 0;
        double angle = 0;

        int sceneSize;
        MatrixObject viewMatrix;

        public Canvas()
        {
            InitializeComponent();
            objectsList = null;
            DoubleBuffered = true;

            sceneSize = 1100;
            viewMatrix = new MatrixObject();

        }

        public List<Object> Objects
        {
            set { objectsList = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            // Вывод карты
            Draw(e.Graphics, ClientRectangle);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            // перерисовка при изменении размеров экрана (элемента управления)
            Invalidate();
        }

        protected void Draw(Graphics g, Rectangle bound)
        {
            g.FillRectangle(Brushes.White, ClientRectangle);
            g.DrawLine(new Pen(Color.Black, 6), new Point(ClientRectangle.Left, ClientRectangle.Bottom),
                new Point(ClientRectangle.Right, ClientRectangle.Bottom));

            


            if (objectsList != null && objectsList.Count > 0)
            {
                for (int i = 0; i < objectsList.Count; i++)
                {
                    double a = (double)bound.Width / bound.Height;
                    double sceneHeight = sceneSize / a;

                    viewMatrix.Viewport(0, sceneSize, bound.Left, bound.Right,
                        0, sceneHeight, bound.Bottom, bound.Top);

                    Object o = objectsList[i];
                    switch (o.GetObjectType())
                    {
                        case ObjectsTypes.Lamp:
                            DrawLamp(g, o, bound);
                            break;
                    }

                    o.Draw(g, viewMatrix);
                }

            }
            else
            {
                // Вывод текста
                string text1 = "Область анимации";
                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;

                RectangleF rect = new RectangleF(bound.X, bound.Y,
                    bound.Width, bound.Height);
                g.DrawString(text1, Font, Brushes.Black, rect, format);
            }
        }

        protected void DrawLamp(Graphics g, Object Object, Rectangle bound)
        {
            x = Object.X;
            y = Object.Y;

            R = Object.ColorR;
            B = Object.ColorB;
            G = Object.ColorG;
            angle = Object.Angle;
            bool enable = Object.Enabled;

            int cube = 80;
            Pen Pen = new Pen(Color.Black, 3);
            Pen PenEnable = new Pen(Color.Black, 4);
            Pen PenCircle = new Pen(Color.Black, 3);
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

        private void Canvas_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.Location.ToString());
        }
    }
}
