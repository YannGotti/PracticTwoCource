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
    public partial class MainForm : Form
    {
        Graphics g;
        List<Brick> Bricks;
        List<Brick> Count;
        int value;
        int x, y;
        double opacity = 0;

        int R = 50;
        int G = 50;
        int B = 50;

        public MainForm()
        {
            InitializeComponent();
            Bricks = new List<Brick>();
            Count = new List<Brick>();
            value = 0;
            label4.Text = "Скорость прогресса: " + timer1.Interval.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            value = 0;
            x = 0;
            y = 210;
            Bricks.Clear();
            Count.Clear();
            R = 150;
            G = 50;
            B = 50;
            progressBar1.ClearGraphics(g);
            timer1.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            value = 0;
            x = 0;
            y = 210;
            Count.Clear();
            Bricks.Clear();
            R = 50;
            G = 50;
            B = 50;
            progressBar1.ClearGraphics(g);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string interval = textBox.Text;
            int Interval = 0;
            if (int.TryParse(interval, out Interval) && int.Parse(interval) != 0)
                timer1.Interval = Interval;
            else MessageBox.Show("Введено некорректное значение!");
            label4.Text = "Скорость прогресса: " + timer1.Interval.ToString();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (value < 100)
            {
                label1.Text = "Готово на: " + value.ToString();

                if (R < 50)
                    R += 3;
                else if (R > 50)
                    R -= 3;

                if (G < 168)
                    G += 3;
                else if (G > 50)
                    G -= 3;

                if (B < 82)
                    B += 3;
                else if (B > 50)
                    B -= 3;

                Brick brick = new Brick(x, y, opacity);
                value = Count.Count * 3;


                if (Bricks.Count < 5)
                {
                    SolidBrush Brush = new SolidBrush(Color.FromArgb(R, G, B));
                    Bricks.Add(brick);
                    Count.Add(brick);
                    if (value > 100)
                    {
                        value = 100;

                    }
                    progressBar1.DrawCube(g, x, y, Brush, value);
                    x += 40;
                }
                else
                {
                    Bricks.Clear();
                    y -= 35;
                    x = 0;
                }
            }

            else
            {
                timer1.Enabled = false;
                label1.Text = "Завершено";
            }
        }
    }
}
