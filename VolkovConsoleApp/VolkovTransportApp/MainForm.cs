using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolkovTransportApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            // TODO Открыть файл
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            // TODO Сохранить файл
        }

        private void Close_Click(object sender, EventArgs e)
        {
            // TODO Закрыть приложение
            Close();
        }

        private void AddVehicle_Click(object sender, EventArgs e)
        {
            // TODO Добавить транспортное средство
            VehicleForm form = new VehicleForm();
            form.Text = "Добавить транспортное средство";
            if(form.ShowDialog()== DialogResult.OK)
            {

            }
        }

        private void EditVehicle_Click(object sender, EventArgs e)
        {
            // TODO Изменить транспортное средство
        }

        private void DeleteVehicle_Click(object sender, EventArgs e)
        {
            // TODO Удалить транспортное средство
        }

        private void SortAZ_Click(object sender, EventArgs e)
        {
            // TODO Сортировка транспортных средств по возрастанию
        }

        private void SortZA_Click(object sender, EventArgs e)
        {
            // TODO Сортировка транспортных средств по убыванию
        }

        private void SelectVehicle_Click(object sender, EventArgs e)
        {
            // TODO Отбор транспортных средств
        }

        private void Report_Click(object sender, EventArgs e)
        {
            // TODO Отчет по транспортным средствам
        }
    }
}
