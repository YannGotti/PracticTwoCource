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
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
            ResultRichTextBox.ReadOnly = true;
        }

        public string ResultRichTexBox
        {
            set{ ResultRichTextBox.Text = value; }
            get{ return ResultRichTextBox.Text; }
        }

        private void CancelButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
