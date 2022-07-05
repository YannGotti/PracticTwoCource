using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportApp
{
    public partial class SelectionForm : Form
    {

        List<Vehicle> vehicles;
        string result;
        double min;
        double max;

        public SelectionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            result = string.Empty;
            if (CheckData())
            {
                switch (SelectComboBox.SelectedIndex)
                {
                    case 0:
                        vehicles.Sort(Vehicle.MaxVolumeSort);

                        for (int i = 0; i < vehicles.Count; i++)
                        {
                            if (vehicles[i].MaxVolume >= double.Parse(MinTextBox.Text) && vehicles[i].MaxVolume <= double.Parse(MaxTextBox.Text))
                                result += vehicles[i].ToString() + "\n";
                        }
                        break;
                    case 1:
                        vehicles.Sort(Vehicle.VolumeSort);

                        for (int i = 0; i < vehicles.Count; i++)
                        {
                            if (vehicles[i].Volume >= double.Parse(MinTextBox.Text) && vehicles[i].Volume <= double.Parse(MaxTextBox.Text))
                                result += vehicles[i].ToString() + "\n";
                        }
                        break;
                    case 2:
                        vehicles.Sort(Vehicle.SortX);

                        for (int i = 0; i < vehicles.Count; i++)
                        {
                            if (vehicles[i].X >= double.Parse(MinTextBox.Text) && vehicles[i].X <= double.Parse(MaxTextBox.Text))
                                result += vehicles[i].ToString() + "\n";
                        }
                        break;
                    case 3:
                        vehicles.Sort(Vehicle.SortY);

                        for (int i = 0; i < vehicles.Count; i++)
                        {
                            if (vehicles[i].Y >= double.Parse(MinTextBox.Text) && vehicles[i].Y <= double.Parse(MaxTextBox.Text))
                                result += vehicles[i].ToString() + "\n";
                        }
                        break;
                }

                ResultForm form = new ResultForm();

                form.Show();

                form.ResultRichTexBox = result;
            }
            Close();
        }

        protected bool CheckData()
        {
            // максимальное значение
            if (MaxTextBox.Text == null)
            {
                MessageBox.Show(
                    "Некорректное значение максимального значение!",
                    "");
                return false;
            }

            if (!double.TryParse(MaxTextBox.Text, out max))
            {
                MessageBox.Show(
                    "Некорректное значение максимального значение!",
                    "");
                return false;
            }

            if (double.Parse(MaxTextBox.Text) < 0)
            {
                MessageBox.Show(
                    "Некорректное значение максимального значение!",
                    "");
                return false;
            }


            // Минимальное значение
            if (MinTextBox.Text == null)
            {
                MessageBox.Show(
                    "Некорректное значение максимального значение!",
                    "");
                return false;
            }

            if (!double.TryParse(MinTextBox.Text, out min))
            {
                MessageBox.Show(
                    "Некорректное значение максимального значение!",
                    "");
                return false;
            }

            if (double.Parse(MinTextBox.Text) < 0)
            {
                MessageBox.Show(
                    "Некорректное значение максимального значение!",
                    "");
                return false;
            }

            return true;

        }

        public string Result
        {
            set
            {
                result = value;
            }
            get { return result; }
        }

        public List<Vehicle> ListVehicles
        {
            set
            {
                vehicles = value;
            }
            get
            {
                return vehicles;
            }
        } 
    }
}
