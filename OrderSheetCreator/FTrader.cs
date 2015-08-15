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
    public partial class FTrader : Form
    {
        public static entity.CainzTrader TRADER = new entity.CainzTrader();
        public FTrader(string sheet)
        {
            InitializeComponent();
            //txbBarcode.Text = barcode;
            txbSheet.Text = sheet;
            txbSearch.Text = sheet;
            //txbMaterial.Text = material;
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            using (var db = PublicDB.getDB())
            {
                cainzTraderBindingSource.DataSource = (from a in db.CainzTrader
                                                       where a.TraderName.Contains(txbSearch.Text)
                                                       select a).ToList();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cainzTraderBindingSource.Current != null)
            {
                FTrader.TRADER = (entity.CainzTrader)cainzTraderBindingSource.Current;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }
    }
}
