using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MironovProgressBar
{
    public partial class ProgressBar : UserControl
    {
        public ProgressBar()
        {
            InitializeComponent();
        }

        private void ProgressBar_Paint(object sender, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 3);
            int x = 0;
            int y = 0;
            int width = 200;
            int height = 245;
            e.Graphics.Clear(Color.Wheat);
            e.Graphics.DrawRectangle(blackPen, x, y, width, height);

        }

        public void ClearGraphics(Graphics g)
        {
            g = CreateGraphics();
            g.Clear(Color.Wheat);

            Pen blackPen = new Pen(Color.Black, 3);
            int x = 0;
            int y = 0;
            int width = 200;
            int height = 245;
            g.DrawRectangle(blackPen, x, y, width, height);
        }

        public void DrawCube(Graphics g, int x, int y, Brush brush , int percent)
        {
            g = CreateGraphics();

            Rectangle rect = new Rectangle(x, y, 40, 35);
            Rectangle rect2 = new Rectangle(x + 10, y - 10, 40, 35);


            PointF point1 = new PointF(x, y);
            PointF point2 = new PointF(x + 10, y - 10);

            PointF point5 = new PointF(x + 40, y + 35);
            PointF point6 = new PointF(x + 50, y + 25);

            PointF point7 = new PointF(x + 40, y);
            PointF point8 = new PointF(x + 50, y - 10);

            Pen Pen = new Pen(Color.Black, 3);
            Font Font = new Font("Arial", 16);
            SolidBrush textBrush = new SolidBrush(Color.White);
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;



            g.DrawRectangle(Pen, rect2);
            g.FillRectangle(brush, rect);
            g.DrawString(percent.ToString(), Font, textBrush, x + 40, y + 5, drawFormat);
            g.DrawRectangle(Pen, rect);
            g.DrawLine(Pen, point1, point2);
            g.DrawLine(Pen, point5, point6);
            g.DrawLine(Pen, point7, point8);




        }

    }
}
