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


        protected double maxVolume = 100;
        double minVolume = 0;
        protected double volume = 0;

        public double MaxVolume
        {
            set { maxVolume = value; }
            get { return maxVolume; }
        }

        public double Volume
        {
            set { volume = value; }
            get { return volume; }
        }

        private void ProgressBar_Paint(object sender, PaintEventArgs e)
        {
            int angle = 0;
            int size = 130;
            double section = (volume - minVolume) / maxVolume * 19;

            int R = 245;
            int G = 241;
            int B = 27;


            Pen pen2 = new Pen(Color.Black, 2);
            Point rotate = new Point(400, 200);

            Pen pen = new Pen(Color.Black,2);
            SolidBrush brush = new SolidBrush(Color.Yellow);
            Rectangle rect = new Rectangle(400 - size / 2, 200 - size / 2, size, size);


            Font Font = new Font("Arial", 16);
            SolidBrush textBrush = new SolidBrush(Color.Black);
            StringFormat drawFormat = new StringFormat();


            e.Graphics.FillEllipse(brush, rect);
            e.Graphics.DrawEllipse(pen, rect);




            for (int i = 0; i < section; i++)
            {

                if (R < 245)
                {
                    R += 20;
                }

                if (G > 27)
                {
                    G -= 10;
                }

                if (B > 27)
                {
                    B -= 20;
                }

                Matrix matrix = new Matrix();
                SolidBrush brush2 = new SolidBrush(Color.FromArgb(R, G, B));

                matrix.RotateAt(-angle, rotate);
                Point[] points = new Point[]
                {
                new Point(392, 272), new Point(410, 272),
                new Point(420, 340), new Point(380, 340),
                new Point(392, 272),
                };

                matrix.TransformPoints(points);

                e.Graphics.FillPolygon(brush2, points);
                e.Graphics.DrawLines(pen2, points);
                angle += 19;
            }
            e.Graphics.DrawString($"{volume} %", Font, textBrush, 372, 190, drawFormat);

        }

        private void ProgressBar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.Location.ToString());
        }
    }
}
