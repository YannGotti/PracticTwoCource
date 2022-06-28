using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MironovComposition
{
    public partial class MainForm : Form
    {
        List<Object> objects;
        int size = 0;
        double opacity = 0;
        int rotate = 0;
        int R = 0;
        int G = 0;
        int B = 0;

        LampObject Lamp = new LampObject("Лампа", 0, 0);
        TriangleObject triangle = new TriangleObject("Треугольник", 50, 100);
        CubeObject cube2 = new CubeObject("Куб", 250, 270);

        public MainForm()
        {
            InitializeComponent();
            VisibleStripTools(false);
            objects = new List<Object>();
            objects.Add(Lamp);
            objects.Add(triangle);
            objects.Add(cube2);


            canvas1.Objects = objects;
            FillListBox(objects);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        protected void FillListBox(List<Object> objects)
        {
            ObjectsComboBox.Items.Clear();

            foreach (Object o in objects)
                if (o.GetObjectType() != ObjectsTypes.Springboard)
                    ObjectsComboBox.Items.Add(o.Name);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int index = ObjectsComboBox.SelectedIndex;
            Object Object = objects[index];


            if (CheckData(Object))
            {
                if (Object.Size != size)
                {
                    if (Object.GetObjectType() == ObjectsTypes.Cube)
                    {
                        if (Object.Size < size)
                        {
                            Object.X -= size / 12;
                            Object.Y -= size / 12;
                        }
                        else
                        {
                            Object.X += size / 12;
                            Object.Y += size / 12;
                        }
                    }
                    else
                    {
                        if (Object.Size < size)
                        {
                            Object.Y -= size / 12;
                        }
                        else
                        {
                            Object.Y += size / 12;
                        }

                    }

                    Object.Size = size;
                }

                Object.Rotate = rotate;
                Object.Opacity = opacity;
                Object.ColorR = R;
                Object.ColorG = G;
                Object.ColorB = B;
                canvas1.Invalidate();
            }
        }

        private void ObjectsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            VisibleStripTools(true);
            int index = ObjectsComboBox.SelectedIndex;
            Object Object = objects[index];

            if (Object.GetObjectType() == ObjectsTypes.Lamp)
            {
                SizeTextBox.ReadOnly = true;
                rTextBox.ReadOnly = true;
                gTextBox.ReadOnly = true;
                bTextBox.ReadOnly = true;

                RotateTextBox.Text = 90.ToString();


            }
            else
            {
                SizeTextBox.ReadOnly = false;
                rTextBox.ReadOnly = false;
                gTextBox.ReadOnly = false;
                bTextBox.ReadOnly = false;
            }
        }

        public void VisibleStripTools(bool visible)
        {
            toolStripLabel2.Visible = visible;
            toolStripLabel3.Visible = visible;
            toolStripLabel4.Visible = visible;
            SizeTextBox.Visible = visible;
            RotateTextBox.Visible = visible;
            rTextBox.Visible = visible;
            gTextBox.Visible = visible;
            bTextBox.Visible = visible;
            submitButton.Visible = visible;
        }

        public bool CheckData(Object Object)
        {

            if (!int.TryParse(SizeTextBox.Text, out size))
            {
                MessageBox.Show("Данные введены не корректно!");
                return false;
            }

            

            if (!int.TryParse(RotateTextBox.Text, out rotate))
            {
                MessageBox.Show("Данные введены не корректно!");
                return false;
            }

            if (Object.GetObjectType() == ObjectsTypes.Lamp && int.Parse(RotateTextBox.Text) < 80)
            {
                MessageBox.Show("Угол лампы не может быть меньше 80 градусов");
                return false;
            }
                    
            if (Object.GetObjectType() == ObjectsTypes.Lamp &&  int.Parse(RotateTextBox.Text) > 120)
            {
                MessageBox.Show("Угол лампы не может быть больше 120 градусов");
                return false;
            }

            if (!int.TryParse(rTextBox.Text, out R))
            {
                MessageBox.Show("Данные введены не корректно!");
                return false;
            }

            if (!int.TryParse(gTextBox.Text, out G))
            {
                MessageBox.Show("Данные введены не корректно!");
                return false;
            }

            if (!int.TryParse(bTextBox.Text, out B))
            {
                MessageBox.Show("Данные введены не корректно!");
                return false;
            }

            return true;
        }

        private void StartAnimation(object sender, EventArgs e)
        {
            Lamp.Enabled = true;
            canvas1.Invalidate();
        }

        private void StopAnimation(object sender, EventArgs e)
        {
            Lamp.Enabled = false;
            canvas1.Invalidate();
        }
    }
}
