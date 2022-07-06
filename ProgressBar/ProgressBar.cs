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

namespace MakarovProgressBar
{
    public partial class ProgressBar : UserControl
    {
        public ProgressBar()
        {
            InitializeComponent();
        }

        Graphics g;

        private void ProgressBar_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            Pen pen = new Pen(Color.Black,2);
            SolidBrush brush = new SolidBrush(Color.Yellow);
            int size = 130;
            Rectangle rect = new Rectangle(400 - size / 2, 200 - size / 2, size, size);

            g.FillEllipse(brush, rect);
            g.DrawEllipse(pen, rect);

        }

        public void DrawBeam(int angle, SolidBrush brush, double value)
        {
            g = CreateGraphics();
            Pen pen = new Pen(Color.Black, 2);

            Matrix matrix = new Matrix();

            Point rotate = new Point(400, 200);

            matrix.RotateAt(-angle, rotate);


            PointF[] points = new PointF[]
            {
                new Point(392, 272), new Point(410, 272),
                new Point(420, 340), new Point(380, 340),
                new Point(392, 272),
            };

            g.Transform = matrix;

            g.FillPolygon(brush, points);
            g.DrawLines(pen, points);

        }



        private void ProgressBar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.Location.ToString());
        }
    }
}
