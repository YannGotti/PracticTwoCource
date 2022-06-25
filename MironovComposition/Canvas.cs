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

            float numFloat = 50 * (size / 100f);
            int side = (int)Math.Ceiling(numFloat);

            SolidBrush brush = new SolidBrush(Color.FromArgb(R, G, B));
            g.FillPolygon(brush, new Point[]
            {
            new Point(x,y),new Point(x + size, y),
            new Point(x + size, y),new Point(x + size,y + size),
            new Point(x + size, y + size),new Point(x, y + size),
            new Point(x, y + size),new Point(x,y)
            });
        }

    }
}
