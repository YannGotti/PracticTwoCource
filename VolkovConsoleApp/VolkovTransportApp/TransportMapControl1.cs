using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolkovTransportApp
{
    public partial class TransportMapControl1 : UserControl
    {
        public TransportMapControl1()
        {
            InitializeComponent();

            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            DrawMap(e.Graphics, ClientRectangle);
        }
        protected void DrawMap(Graphics g, Rectangle bound)
        {
            // заполнить фон
            g.FillRectangle(Brushes.White, bound);
            // Текст
            string text = "Карта транспортных средств";
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            RectangleF textRect = new RectangleF(
                bound.X, bound.Y,
                bound.Width, bound.Height);
            g.DrawString(text, Font, Brushes.Black, textRect, format);
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            Invalidated
        }
    }
}
