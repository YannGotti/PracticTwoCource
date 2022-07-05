using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportApp
{
    public partial class TransportMapControl : UserControl
    {
        List<Vehicle> vehicles;
        Transformer tx, ty;

        public TransportMapControl()
        {
            InitializeComponent();
            // Двойная буферизация
            DoubleBuffered = true;
            // Список транспорт средств
            vehicles = null;
            // преобразование координат
            tx = new Transformer();
            ty = new Transformer();
        }

        public List<Vehicle> Vehicles
        {
            set { vehicles = value; }
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
            if (vehicles!=null && vehicles.Count > 0)
            {
                //  Вывод транспорт средств
                int m = 10;
                RectangleF rect = new RectangleF(bound.X+m, bound.Y+m,
                    bound.Width-(m << 1),
                    bound.Height - (m << 1));

                DrawVehicles(g, bound, vehicles);
                // Изображение сетки


            }
            else
            {
                // Вывод текста
                string text = "Карта расположения транспортных средств";
                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;

                RectangleF rect = new RectangleF(bound.X, bound.Y,
                    bound.Width, bound.Height);
                g.DrawString(text, Font, Brushes.Black, rect, format);
            }
            
        }

        protected void DrawVehicles(Graphics g, RectangleF bound,
            List<Vehicle> vehicles)
        {
            // поиск диапазонов изменений координат
            double minX, maxX, minY, maxY;
            FindMinMax(vehicles, out minX, out maxX,
                out minY, out maxY);

            double mX = (maxX - minX) + 0.1;
            double mY = (maxY - minY) + 0.1;

            // настройка преобразования

            tx.SetParametrs(minX - mX, maxX + mX,
                bound.Left, bound.Right);
            ty.SetParametrs(minY - mY, maxY + mY,
                bound.Top, bound.Bottom);

            float x, y;
            float d = 10;

            for (int i = 0; i < vehicles.Count; i++)
            {
                // Преобразование координат

                x = (float)tx.Transform(vehicles[i].X);
                y = (float)ty.Transform(vehicles[i].Y);

                // изобрадение транспорт средства

                g.FillEllipse(Brushes.Red, x - 0.5f * d, y - 0.5f * d, d, d);

            }





        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            // Перерисовать окно
            Invalidate();
        }

        protected void FindMinMax(List<Vehicle> vehicles, out double minX, out double maxX,
            out double minY, out double maxY)
        {
            minX = 0;
            maxX = 1;
            minY = 0;
            maxY = 1;

            if (vehicles == null || vehicles.Count == 0)
                return;

            double x, y;
            for (int i = 0; i < vehicles.Count; i++)
            {
                x = vehicles[i].X;
                y = vehicles[i].Y;

                if (minX > x)
                    minX = x;
                if (maxX < x)
                    maxX = x;

                if (minY > y)
                    minY = y;
                if (maxY < y)
                    maxY = y;
            }

            if (Math.Abs(maxX - minX) < 1e-6)
                maxX += 1;

            if (Math.Abs(maxY - minY) < 1e-6)
                maxY += 1;
        }
    }
}
