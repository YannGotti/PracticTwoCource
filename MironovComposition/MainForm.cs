﻿using System;
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


        public MainForm()
        {
            InitializeComponent();
            VisibleStripTools(false);
            objects = new List<Object>();

            CubeObject cube = new CubeObject("Куб_1", 250, 250);

            objects.Add(cube);
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
                if (o.GetObjectType() != ObjectsTypes.Lamp && o.GetObjectType() != ObjectsTypes.Springboard)
                    ObjectsComboBox.Items.Add(o.Name);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int index = ObjectsComboBox.SelectedIndex;
            Object Object = objects[index];

            if (CheckData())
            {
                if (Object.Size != size)
                {
                    float numFloat = 50 * (size / 100f);
                    int side = (int)Math.Ceiling(numFloat);

                    if (Object.Size < size)
                    {
                        Object.X -= side / 4;
                        Object.Y -= side / 4;
                    }
                    else
                    {
                        Object.X += side / 4;
                        Object.Y += side / 4;
                    }
                    Object.Size = size;
                }

                if (Object.Rotate != rotate)
                {
                    double angleDouble = rotate * Math.PI / 180;
                    int angle = (int)Math.Ceiling(angleDouble);

                    if (Object.Rotate < rotate)
                    {
                        Object.X -= angle;
                        Object.Y -= angle;
                    }
                    else
                    {
                        Object.X += angle;
                        Object.Y += angle;
                    }
                    Object.Rotate = rotate;

                }


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

        public bool CheckData()
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


    }
}