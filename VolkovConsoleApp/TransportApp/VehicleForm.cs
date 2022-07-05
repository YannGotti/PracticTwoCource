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
    public partial class VehicleForm : Form
    {
        List<string> characteristicNames;
        List<int> valueTypes;
        bool editMode;
        double maxVolume;
        double volume;
        double x;
        double y;

        int iValue;
        double fValue;

        public VehicleForm()
        {
            InitializeComponent();

            // имена характеристик
            characteristicNames = new List<string>(3);
            characteristicNames.Add("Количество двигателей:");
            characteristicNames.Add("Водоизмещение:");
            characteristicNames.Add("Количество колес:");
            // типы зачений
            valueTypes = new List<int>();
            valueTypes.Add(0);
            valueTypes.Add(1);
            valueTypes.Add(0);
            // режим добавления
            editMode = false;
            // Максимальный объем
            MaxVolume = 1;
            // Характеристика
            IntegerValue = 1;
            // Volume
            Volume = 1;
            // x
            X = 0;
            // y
            Y = 0;
        }

        public string VehicleName
        {
            set { nameTextBox.Text = value; }
            get { return nameTextBox.Text; }
        }

        public VehicleTypes VehicleType
        {
            set
            {
                switch (value)
                {
                    case VehicleTypes.AirVehicle:// воздушный
                        typeComboBox.SelectedIndex = 0;
                        break;
                    case VehicleTypes.WaterVehicle:// водный
                        typeComboBox.SelectedIndex = 1;
                        break;
                    case VehicleTypes.LandVehicle:// наземный
                        typeComboBox.SelectedIndex = 2;
                        break;
                    default:
                        typeComboBox.SelectedIndex = -1;
                        break;
                }
                // задать имя характеристики
                SetCharacteristicName(typeComboBox.SelectedIndex);
            }
            get
            {
                VehicleTypes type = VehicleTypes.Unknown;
                switch (typeComboBox.SelectedIndex)
                {
                    case 0: type = VehicleTypes.AirVehicle; break;
                    case 1: type = VehicleTypes.WaterVehicle; break;
                    case 2: type = VehicleTypes.LandVehicle; break;
                }
                return type;
            }
        }

        public bool EditMode
        {
            set
            {
                editMode = value;
                // доступность полей
                typeComboBox.Enabled = !editMode;
                maxVolumeTextBox.Enabled = !editMode;
                charateristicTextBox.Enabled = !editMode;
            }
            get { return editMode; }
        }

        public double X
        {
            set
            {
                x = value;
                xTextBox.Text = value.ToString();
            }
            get
            {
                return x;
            }
        }

        public double Y
        {
            set
            {
                y = value;
                yTextBox.Text = value.ToString();
            }
            get
            {
                return y;
            }
        }


        public double MaxVolume
        {
            set
            {
                maxVolume = value;
                maxVolumeTextBox.Text = value.ToString();
            }
            get
            {
                return maxVolume;
            }
        }

        public double Volume
        {
            set
            {
                volume = value;
                volumeTextBox.Text = value.ToString();
            }
            get
            {
                return volume;
            }
        }

        public int IntegerValue
        {
            set
            {
                iValue = value;
                charateristicTextBox.Text = value.ToString();
            }
            get { return iValue; }
        }

        public double DoubleValue
        {
            set
            {
                fValue = value;
                charateristicTextBox.Text = value.ToString();
            }
            get { return fValue; }
        }

        protected bool CheckData()
        {
            // TODO проверка корректности введенных данных
            if (typeComboBox.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Не выбран тип транспортного средства!",
                    "");
                return false;
            }
            // название транспортного средства
            if (string.IsNullOrEmpty(nameTextBox.Text) ||
                string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show(
                    "Некорректное название транспортного средства!",
                    "");
                return false;
            }

            // Проверка на ;
            if (nameTextBox.Text.Contains(";"))
            {
                MessageBox.Show(
                    "Название транспортного средства не должно содержать  ';'",
                    "");
                return false;
            }


            // максимальный объем
            if (!double.TryParse(maxVolumeTextBox.Text,
                out maxVolume))
            {
                MessageBox.Show(
                    "Некорректное значение максимального объема!",
                    "");
                return false;
            }
            if (!double.TryParse(volumeTextBox.Text, out volume))
            {
                MessageBox.Show("Неккоректное значение объёма", "");
                return false;
            }

           
            if (!double.TryParse(xTextBox.Text, out x))
            {
                MessageBox.Show("Неккоректное значение X", "");
                return false;
            }


            if (!double.TryParse(yTextBox.Text, out y))
            {
                MessageBox.Show("Неккоректное значение Y", "");
                return false;
            }


            // характеристика (количество двигателей, водоизмещение
            bool b = false;
            // тип значения
            int iType = valueTypes[typeComboBox.SelectedIndex];
            switch(iType)
            {
                case 0: // целое число
                    b = int.TryParse(
                        charateristicTextBox.Text, out iValue);
                    break;
                case 1:// вещественное число
                    b = double.TryParse(
                        charateristicTextBox.Text, out fValue);
                    break;
            }
            if(!b)
            {
                string text = "Некорректное значение в поле " +
                    characteristicLabel.Text;
                MessageBox.Show(
                    text,
                    "");
                return false;
            }

            return true;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                // Данные введены корректно
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void VehicleType_Changed(object sender, EventArgs e)
        {
            // Установить название характеристики
            SetCharacteristicName(typeComboBox.SelectedIndex);
        }

        protected void SetCharacteristicName(int type)
        {
            if (type < 0)
                characteristicLabel.Text = "Характеристика";
            // установить название характеристики
            if (type >= 0 && type < 3)
                characteristicLabel.Text = characteristicNames[type];
        }

        
    }
}
