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
        public double maxValue = 0;
        public double minValue = 0;
        public double currentValue = 0;

        double section = 0;
        int bricksForStroke = 0;

        int R = 250;
        int G = 0;
        int B = 50;

        Label label;


        public ProgressBar()
        {
            InitializeComponent();

        }

        public double MaxValue
        {
            set { maxValue = value; }
            get { return maxValue; }
        }

        public double MinValue
        {
            set { minValue = value; }
            get { return minValue; }
        }

        public double Value
        {
            set { currentValue = value; }
            get { return currentValue; }
        }

        private void ProgressBar_Paint(object sender, PaintEventArgs e)
        {

            Pen blackPen = new Pen(Color.Black, 3);
            int x = 0;
            bricksForStroke = 0;
            int y = 0;
            int width = 200;
            int height = 211;

            R = 250;
            G = 0;
            B = 50;

            e.Graphics.DrawRectangle(blackPen, x, y, width, height);
            section = (currentValue - minValue) / maxValue * 30;
            DrawCube(e.Graphics, 0, 176, section);
        }
        

        public void DrawCube(Graphics g, int x, int y, double section)
        {
            for (int i = 1; i < section + 1; i++)
            {
                if (R < 50)
                    R += 3;
                else if (R > 50)
                    R -= 3;

                if (G < 168)
                    G += 10;
                else if (G > 50)
                    G -= 3;

                if (B < 82)
                    B += 3;
                else if (B > 50)
                    B -= 3;

                SolidBrush Brush = new SolidBrush(Color.FromArgb(R, G, B));

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
                g.FillRectangle(Brush, rect);
                g.DrawString(i.ToString(), Font, textBrush, x + 40, y + 5, drawFormat);
                g.DrawRectangle(Pen, rect);
                g.DrawLine(Pen, point1, point2);
                g.DrawLine(Pen, point5, point6);
                g.DrawLine(Pen, point7, point8);

            
                if (bricksForStroke < 4)
                {
                    bricksForStroke++;
                    x += 40;
                }
                else
                {
                    bricksForStroke = 0;
                    y -= 35;
                    x = 0;
                }
            }
        }

    }
}
