using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrderSheetCreator
{
    public partial class FCainzOrder : Form
    {
        public FCainzOrder()
        {
            InitializeComponent();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            FCainzOrderD Dform = new FCainzOrderD();
            Dform.ShowDialog();
        }
    }
}
