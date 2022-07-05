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
    public partial class MainForm : Form
    {
        List<Vehicle> vehicles;
        public MainForm()
        {
            InitializeComponent();
            // Список транспортных средств
            vehicles = new List<Vehicle>();
            transportMapControl.Vehicles = vehicles;
            // Обновление строки состояния
            UpdateStatusBar();
        }

        private void OpenFileMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Текстовый файл *.txt|*.txt|Все файлы|*.*";
            if(dlg.ShowDialog()== DialogResult.OK)
            {
                // Открыть файл
                if (Vehicle.ReadData(dlg.FileName, vehicles))
                {
                    FillListBox(vehicles, vehiclesListBox);
                    // Обновление строки состояния
                    UpdateStatusBar();
                }
                // заполнить список
            }
            transportMapControl.Invalidate();
        }


        protected void FillListBox(List<Vehicle> vehicles, ListBox listBox)
        {
            //Очистить список
            listBox.Items.Clear();

            // Добавить

            foreach(Vehicle v in vehicles)
                if (!v.Name.Contains("#"))
                    listBox.Items.Add(v);
        }

        private void SaveFileMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Текстовый файл *.txt|*.txt|Все файлы|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Сохранить файл
                Vehicle.SaveData(dlg.FileName, vehicles);
            }
        }

        private void CloseMenuItem_Click(object sender, EventArgs e)
        {
            // Закрыть форму
            Close();
        }

        private void AddVehicleMenuItem_Click(object sender, EventArgs e)
        {
            // Добавление транспортного средства
            VehicleForm form = new VehicleForm();
            form.Text = "Добавление нового транспортного средства";
            if (form.ShowDialog() == DialogResult.OK)
            {
                Vehicle v = null;

                switch (form.VehicleType)
                {
                    case VehicleTypes.AirVehicle:// воздушный
                        v = new AirVehicle(
                        form.VehicleName,
                        form.MaxVolume, 
                        form.IntegerValue);
                        v.Volume = form.Volume;

                        // Добавление координат
                        v.X = form.X;
                        v.Y = form.Y;

                        break;
                    case VehicleTypes.WaterVehicle:// водный
                        v = new WaterVehicle(
                        form.VehicleName,
                        form.MaxVolume, 
                        form.DoubleValue);
                        v.Volume = form.Volume;

                        // Добавление координат
                        v.X = form.X;
                        v.Y = form.Y;
                        break;
                    case VehicleTypes.LandVehicle:// наземный
                        v = new LandVehicle(
                        form.VehicleName,
                        form.MaxVolume,
                        form.IntegerValue);
                        v.Volume = form.Volume;

                        // Добавление координат
                        v.X = form.X;
                        v.Y = form.Y;
                        break;
                }
                // добавить в список
                if (v != null)
                {
                    vehicles.Add(v);
                    vehiclesListBox.Items.Add(v);
                }

                // Обновление строки состояния
                UpdateStatusBar();
                transportMapControl.Invalidate();


            }
        }

        private void EditVehicleMenuItem_Click(object sender, EventArgs e)
        {
            if (vehiclesListBox.SelectedIndex >= 0)
            {
                // Изменение транспортного средства
                VehicleForm form = new VehicleForm();
                // Режим редактирования
                form.EditMode = true;
                form.Text = "Изменение транспортного средства";
                Vehicle v = vehicles[vehiclesListBox.SelectedIndex];

                // Изменение координат
                form.X = v.X;
                form.Y = v.Y;

                form.VehicleName = v.Name;
                form.VehicleType = v.GetVehicleType();
                form.MaxVolume = v.MaxVolume;
                form.Volume = v.Volume;
                // характеристика
                switch(v.GetVehicleType())
                {
                    case VehicleTypes.AirVehicle:
                        // преобразование вниз
                        form.IntegerValue = ((AirVehicle)v).Engines;
                        break;
                    case VehicleTypes.WaterVehicle:
                        form.DoubleValue= ((WaterVehicle)v).Displacement;
                        break;
                    case VehicleTypes.LandVehicle:
                        form.IntegerValue = ((LandVehicle)v).Wheels;
                        break;
                }

                if (form.ShowDialog() == DialogResult.OK)
                {
                    // новые значения полей
                    v.Name = form.VehicleName;
                    v.Volume = form.Volume;
                    v.X = form.X;
                    v.Y = form.Y;

                    // обновить список
                    vehiclesListBox.Items[
                        vehiclesListBox.SelectedIndex] = v;
                }

                // Обновление строки состояния
                UpdateStatusBar();
                transportMapControl.Invalidate();

            }
        }

        private void DeleteVehicleMenuItem_Click(object sender, EventArgs e)
        {
            if (vehiclesListBox.SelectedIndex >= 0)
            {
                Vehicle v = vehiclesListBox.SelectedItem as Vehicle;
                if (v != null)
                {
                    string question =
                        "Желаете удалить транспортное средство " +
                        v.Name + "?";
                    DialogResult res =
                        MessageBox.Show(question,
                        "Удаление транспортного средства",
                        MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        vehiclesListBox.Items.Remove(v);
                        vehicles.Remove(v);
                        // Обновление строки состояния
                        UpdateStatusBar();
                        transportMapControl.Invalidate();

                    }
                }
            }
        }

        private void SortAZMenuItem_Click(object sender, EventArgs e)
        {
            // Сортировка элементов
            if (vehicles.Count > 0)
            {
                // Сортировка
                vehicles.Sort(Vehicle.CompareAZ);

                // Обновление
                FillListBox(vehicles, vehiclesListBox);
            }
        }

        private void SortZAMenuItem_Click(object sender, EventArgs e)
        {
            // Сортировка элементов
            if (vehicles.Count > 0)
            {
                // Сортировка
                vehicles.Sort(Vehicle.CompareZA);

                // Обновление
                FillListBox(vehicles, vehiclesListBox);
            }
        }

        private void SelectionMenuItem_Click(object sender, EventArgs e)
        {
            SelectionForm form = new SelectionForm();
            form.Show();
            form.ListVehicles = vehicles;
            FillListBox(vehicles, vehiclesListBox);
        }

        private void ReportMenuItem_Click(object sender, EventArgs e)
        {
            int allTransport = 0;
            int AirVehicleCount = 0;
            int WaterVehicleCount = 0;
            int LandVehicleCount = 0;
            double VolumeAirVehicle = 0;
            double VolumeWaterVehicle = 0;
            double VolumeLandVehicle = 0;
            double allVolume = 0;
            for (int i = 0; i < vehicles.Count; i++)
            {
                Vehicle v = vehicles[i];
                switch (v.GetVehicleType())
                {
                    case VehicleTypes.AirVehicle:
                        AirVehicleCount++;
                        VolumeAirVehicle += v.Volume;
                        break;
                    case VehicleTypes.WaterVehicle:
                        WaterVehicleCount++;
                        VolumeWaterVehicle += v.Volume;
                        break;
                    case VehicleTypes.LandVehicle:
                        LandVehicleCount++;
                        VolumeLandVehicle += v.Volume;
                        break;
                }
                allVolume += v.Volume;
                allTransport++;
            }
            string result = $"Всего транспорта: {allTransport} Общий объем: {allVolume}\n" +
                $"Количество водного транспорта: {WaterVehicleCount} Объем: {VolumeAirVehicle} \n" +
                $"Количество наземного транспорта: {LandVehicleCount} Объем: {VolumeWaterVehicle} \n" +
                $"Количество воздушного транспорта: { AirVehicleCount} Объем: {VolumeLandVehicle} \n";
            ReportForm form = new ReportForm();
            form.Show();
            form.ReportRichTextBox = result;

        }

        protected void UpdateStatusBar()
        {
            infoLabel.Text = "Количество транспортных средств: " +
                vehicles.Count.ToString();
        }
    }
}
