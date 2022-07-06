using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakarovProgressBar
{
    public partial class Form1 : Form
    {
        int maxValue = 100;
        double value;
        int angle = 0;
        int interval = 0;

        int R = 245;
        int G = 241;
        int B = 27;


        public Form1()
        {
            InitializeComponent();
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            if (R < 245)
                R++;

            if (G > 27)
            {
                G--;
                G--;
            }

            if (B < 27)
            {
                B++;
                B++;
            }



            SolidBrush brush = new SolidBrush(Color.FromArgb(R,G,B));

            if (value < maxValue)
            {
                value++;
                valueLabel.Text = $"Текущее значение: {value}";
                labelPercent.Text = $"{value}%";

                if (value > interval)
                {
                    progressBar1.DrawBeam(angle, brush, value);
                    interval += maxValue / 20;
                    angle += 19;
                }
            }
            else
            {
                timer1.Enabled = false;
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(maxValueTextBox.Text, out maxValue))
            {
                MessageBox.Show("Не верно введенны значения");
            }

            if (!double.TryParse(minValueTextBox.Text, out value))
            {
                MessageBox.Show("Не верно введенны значения");
            }

            angle = 0;
            R = 245;
            G = 241;
            B = 27;

            interval = maxValue / 20;
            timer1.Enabled = true;
            progressBar1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maxValue = 100;
            value = 0;
            angle = 0;
            R = 245;
            G = 241;
            B = 27;

            interval = 0;
            timer1.Enabled = false;
            progressBar1.Invalidate();
        }
    }
}
