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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // обработка события
            settingsControl.ObjectParameterChanged += SettingsControl_ObjectParameterChanged;
            // номер выбранного объекта
            objectComboBox.SelectedIndex = 0;
        }

        private void SettingsControl_ObjectParameterChanged(object sender, ObjectParametersEventArgs e)
        {
            // обновление параметров объекта из элементов управления
            animationControl.ObjectSize = e.Size;
            animationControl.ObjectAngle = e.Angle;
            animationControl.ObjectX = e.X;
            animationControl.ObjectY = e.Y;
            // перерисовать элемент управления
            animationControl.Invalidate();
        }

        private void ObjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // номер выбранного объекта
            animationControl.SelectedObject = objectComboBox.SelectedIndex;
        }
    }
}
