﻿using System;
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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        public string ReportRichTextBox
        {
            set 
            { 
                ReportRichTextBox1.Text = value; 
            }
            get { return ReportRichTextBox1.Text; }
        }


    }
}
