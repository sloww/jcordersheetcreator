﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrderSheetCreator
{
    public partial class FDateTime : Form
    {
        public static DateTime DateTimeSelect;
        public FDateTime()
        {
            InitializeComponent();
        }

        private void FDateTime_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            dateTimePicker1.Focus();
            SendKeys.Send("{f4}");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            FDateTime.DateTimeSelect = dateTimePicker1.Value;
            this.Close();
        }
    }
}
