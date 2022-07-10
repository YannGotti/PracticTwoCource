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
    public partial class SettingsControl : UserControl
    {
        public event EventHandler<ObjectParametersEventArgs> ObjectParameterChanged;
        Dictionary<TrackBar, TextBox> textBoxes;

        public SettingsControl()
        {
            InitializeComponent();

            // элементы управления
            textBoxes = new Dictionary<TrackBar, TextBox>();
            textBoxes.Add(sizeTrackBar, sizeTextBox);
            textBoxes.Add(angleTrackBar, angleTextBox);
            textBoxes.Add(xTrackBar, xTextBox);
            textBoxes.Add(yTrackBar, yTextBox);

            // границы значений параметров
            sizeTrackBar.Minimum = 1;
            sizeTrackBar.Maximum = 40;

            angleTrackBar.Minimum = 0;
            angleTrackBar.Maximum = 360;

            xTrackBar.Minimum = 0;
            xTrackBar.Maximum = 200;

            yTrackBar.Minimum = 0;
            yTrackBar.Maximum = 200;

        }
        protected void Parameter_Changed(object sender, EventArgs e)
        {
            TrackBar bar = sender as TrackBar;
            if (bar != null)
            {
                TextBox box;
                if (textBoxes.TryGetValue(bar, out box))
                {
                    box.Text = bar.Value.ToString();
                }
            }

            if (ObjectParameterChanged != null)
            {
                EventHandler<ObjectParametersEventArgs> temp = ObjectParameterChanged;

                ObjectParametersEventArgs ea = new ObjectParametersEventArgs(
                    sizeTrackBar.Value, angleTrackBar.Value,
                    xTrackBar.Value, yTrackBar.Value);
                temp(this, ea);
            }
        }
    }
}
