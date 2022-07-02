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

        int x = 0;
        int y = 0;

        bool AnimationStart;

        LampObject Lamp = new LampObject("Лампа", 850, 469);
        TriangleObject Triangle = new TriangleObject("Треугольник", 720, 275);
        CubeObject Cube = new CubeObject("Куб", 250, 370);
        SpringboardObject Springboard = new SpringboardObject("Трамплин", 650, 375);


        public MainForm()
        {
            InitializeComponent();
            VisibleStripTools(false);

            objects = new List<Object>();
            objects.Add(Lamp);
            objects.Add(Triangle);
            objects.Add(Cube);
            objects.Add(Springboard);

            canvas1.Objects = objects;
            FillListBox();

        }

        protected void FillListBox()
        {
            ObjectsComboBox.Items.Clear();

            foreach (Object o in objects)
                ObjectsComboBox.Items.Add(o.Name);
        }

        private void deleteObject_Click(object sender, EventArgs e)
        {
            try
            {
                int index = ObjectsComboBox.SelectedIndex;
                Object Object = objects[index];
                
                DialogResult res = MessageBox.Show("Желаете удалить выбранный объект?", "Удаление объекта",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    objects.Remove(Object);
                    FillListBox();
                    canvas1.Invalidate();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Вы не выбрали объект!");
            }
            
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
                    if (Object.GetObjectType() == ObjectsTypes.Triangle)
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

                Object.X = x;
                Object.Y = y;


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

            TextBoxY.Text = Object.Y.ToString();
            TextBoxX.Text = Object.X.ToString();
            SizeTextBox.Text = Object.Size.ToString();
            RotateTextBox.Text = Object.Rotate.ToString();
            rTextBox.Text = Object.ColorR.ToString();
            gTextBox.Text = Object.ColorG.ToString();
            bTextBox.Text = Object.ColorB.ToString();


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
            XLabel.Visible = visible;
            YLabel.Visible = visible;
            TextBoxX.Visible = Visible;
            TextBoxY.Visible = Visible;
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

            if (!int.TryParse(TextBoxX.Text, out x))
            {
                MessageBox.Show("Данные введены не корректно!");
                return false;
            }

            if (!int.TryParse(TextBoxY.Text, out y))
            {
                MessageBox.Show("Данные введены не корректно!");
                return false;
            }

            return true;
        }

        private void StartAnimation(object sender, EventArgs e)
        {
            AnimationStart = true;

            foreach (Object Object in objects)
            {
                Object.Enabled = AnimationStart;
            }

            canvas1.Invalidate();
        }

        private void StopAnimation(object sender, EventArgs e)
        {
            AnimationStart = false;
            foreach (Object Object in objects)
            {
                Object.Enabled = AnimationStart;
            }

            canvas1.Invalidate();
        }

        string name_cube = "Куб_";
        int cube_id = 0;
        private void addCube_Click(object sender, EventArgs e)
        {
            string name = name_cube;
            Random rand = new Random();
            cube_id++;
            CubeObject cube_add = new CubeObject(name.Insert(4, cube_id.ToString()), 0, 0);
            if (AnimationStart)
                cube_add.Enabled = true;
            cube_add.ColorR = rand.Next(0, 255);
            cube_add.ColorG = rand.Next(0, 255);
            cube_add.ColorB = rand.Next(0, 255);

            objects.Add(cube_add);
            FillListBox();
            canvas1.Invalidate();
        }

        string name_triangle = "Треугольник_";
        int triangle_id = 0;
        private void addTriangle_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string name = name_triangle;
            triangle_id++;
            TriangleObject triangle_add = new TriangleObject(name.Insert(12, triangle_id.ToString()), 50, 0);
            if (AnimationStart)
                triangle_add.Enabled = true;

            triangle_add.ColorR = rand.Next(0, 255);
            triangle_add.ColorG = rand.Next(0, 255);
            triangle_add.ColorB = rand.Next(0, 255);

            objects.Add(triangle_add);
            FillListBox();
            canvas1.Invalidate();
        }

        private void saveObjects_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Текстовый файл *.txt|*.txt|Все файлы|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Сохранить файл
                Object.SaveData(dlg.FileName, objects);
            }
        }

        private void loadObjects_Click(object sender, EventArgs e)
        {
            triangle_id = 0;
            cube_id = 0;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Текстовый файл *.txt|*.txt|Все файлы|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Открыть файл
                if (Object.ReadData(dlg.FileName, objects))
                {
                    FillListBox();
                }
                // заполнить список
            }
            canvas1.Invalidate();
        }
    }
}
