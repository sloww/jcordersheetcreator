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
    public partial class FAdd : Form
    {
        public FAdd()
        {
            InitializeComponent();
        }

        private void txbBarcode_TextChanged(object sender, EventArgs e)
        {
            if (txbBarcode.Text.Length > 1)
            {
                using (var db = new entity.jingchendbEntities())
                {
                    var productQuery = from a in db.Products
                                       where a.BarCode.Contains(txbBarcode.Text)
                                       select a;
                    productsBindingSource.DataSource = productQuery.Take(10).ToList();
                }
            }
            else
            {
                productsBindingSource.DataSource = null;
            }
        }
    }
}
