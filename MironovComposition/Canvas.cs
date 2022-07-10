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

        private void Canvas_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.Location.ToString());
        }
    }
}
