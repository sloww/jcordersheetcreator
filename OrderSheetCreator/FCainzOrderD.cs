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
    public partial class FCainzOrderD : Form
    {
        public FCainzOrderD()
        {
            InitializeComponent();
        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FCainzOrderD_Load(object sender, EventArgs e)
        {
           
        }
    }
}
