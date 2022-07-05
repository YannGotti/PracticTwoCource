using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolkovFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            // Показать панель
            ShowPanel();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            // Результат закрытия формы
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Результат закрытия формы
            DialogResult = DialogResult.Cancel;
            Close();
        }

        protected void ShowPanel()
        {
            panel1.Visible = showPanelCheckBox.Checked;
        }

        private void ShowPanel_CheckedChanged(object sender, EventArgs e)
        {
            // Показать панель
            ShowPanel();
        }
    }
}
