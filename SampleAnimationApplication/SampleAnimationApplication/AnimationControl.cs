using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleAnimationApplication
{
    public partial class AnimationControl : UserControl
    {
        int size;
        int angle;
        int x;
        int y;

        List<BaseGraphicObject> objects;
        int selected;

        int sceneSize;
        AffineMatrix viewMatrix;

        public AnimationControl()
        {
            InitializeComponent();
            // Двойная буферизация
            DoubleBuffered = true;

            // Объекты
            objects = new List<BaseGraphicObject>();
            // квадрат
            objects.Add(new Square());
            // кривая Безье
            objects.Add(new BezierCurve());

            // Номер выбранного объекта
            selected = 0;

            // размер сцены по оси X, по оси Y вычисляется
            sceneSize = 200;

            // матрица для преобразования из координат сцены в координаты экрана
            viewMatrix = new AffineMatrix();
        }

        public int ObjectSize
        {
            set { size = value; }
        }

        public int ObjectAngle
        {
            set { angle = value; }
        }

        public int ObjectX
        {
            set { x = value; }
        }

        public int ObjectY
        {
            set { y = value; }
        }

        public int SelectedObject
        {
            set
            {
                if (value < 0)
                    selected = 0;
                else if (value >= objects.Count)
                    selected = objects.Count - 1;
                else
                    selected = value;

                // перерисовка
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // рисование объектов
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
            // заполнение фона
            g.FillRectangle(Brushes.White, bound);

            // вывод текста
            string text = $"size = {size}, angle = {angle}, x = {x}, y = {y}";
            g.DrawString(text, Font, Brushes.Black, new PointF(10, 10));

            // вывод объекта, если есть выделенный объект
            if (selected >= 0)
            {
                // соотношение сторон экрана
                double a = (double)bound.Width / bound.Height;
                // высота сцены
                double sceneHeight = sceneSize / a;

                // матрица преобразования
                viewMatrix.Viewport(0, sceneSize, bound.Left, bound.Right,
                    0, sceneHeight, bound.Bottom, bound.Top);

                // Выделенный объект
                BaseGraphicObject obj = objects[selected];

                // новые параметры объекта
                obj.Angle = angle;
                obj.ScaleX = size;
                obj.ScaleY = size;
                obj.X = x;
                obj.Y = y;

                // Рисование объекта
                obj.Draw(g, viewMatrix);
            }
        }
    }
}
