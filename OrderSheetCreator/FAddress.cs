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
    public partial class FAddress : Form
    {
        public static string add = "";

        entity.CainzFactory ccFactory = new entity.CainzFactory();
        BindingList<entity.CainzAddress> ccAddList = new BindingList<entity.CainzAddress>();
        public FAddress(entity.CainzFactory factory)
        {
            InitializeComponent();
            ccFactory = factory;
            cainzFactoryBindingSource.DataSource = ccFactory;
            cainzAddressBindingSource.DataSource = ccAddList;
            PublicTools.IniDatagridview(dataGridView1);
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void FAddress_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("工厂 {0} 的地址管理", ccFactory.FactoryName);
            SelectAdd();

        }

        private void SelectAdd()
        {
            using (var db = PublicDB.getDB())
            {
                var q = db.CainzAddress.Where(a => a.FactroyID.Equals(ccFactory.FactoryID)&&a.IsDelete==0);
                if (q != null)
                {
                    ccAddList.Clear();
                    List<entity.CainzAddress> qList = q.ToList();
                    foreach(var item in qList)
                    {
                        ccAddList.Add(item);
                    }

                }
            }

            PublicTools.RecountRowsNum(dataGridView1);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            string _stringAddress = txbAdd.Text.Trim();
            if (_stringAddress.Length > 4)
            {
                entity.CainzAddress _cainzAdd = new entity.CainzAddress();
                _cainzAdd.FactroyID = ccFactory.FactoryID;
                _cainzAdd.AddressID = Guid.NewGuid();
                _cainzAdd.Address = _stringAddress;
                _cainzAdd.IsDelete = 0;
                _cainzAdd.CreateTime = DateTime.Now;

                using (var db = PublicDB.getDB())
                {
                    db.CainzAddress.Add(_cainzAdd);
                    try
                    {
                        db.SaveChanges();
                        txbAdd.Text = "";
                        this.SelectAdd();
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show("添加地址失败，错误原因："+ee.Message);

                    }

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            entity.CainzAddress _address = (entity.CainzAddress)cainzAddressBindingSource.Current;
            if(_address!=null)
            {
                using (var db = PublicDB.getDB())
                {
                    _address.IsDelete=1;
                    db.CainzAddress.Add(_address);
                    db.Entry(_address).State = System.Data.Entity.EntityState.Modified;
                    try
                    {
                        db.SaveChanges();
                        txbAdd.Text = "";
                        this.SelectAdd();
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show("添加删除失败，错误原因：" + ee.Message);

                    }

                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            entity.CainzAddress _address = (entity.CainzAddress)cainzAddressBindingSource.Current;
            if (_address != null)
            {
                using (var db = PublicDB.getDB())
                {
                    string _stringAddress = txbAdd.Text.Trim();
                    if (_stringAddress.Length > 4)
                    {
                        _address.Address = _stringAddress;
                        db.CainzAddress.Add(_address);
                        db.Entry(_address).State = System.Data.Entity.EntityState.Modified;
                        try
                        {
                            db.SaveChanges();
                            txbAdd.Text = "";
                            this.SelectAdd();
                        }
                        catch (Exception ee)
                        {
                            MessageBox.Show("添加修改失败，错误原因：" + ee.Message);

                        }
                    }
                    else
                    {
                        MessageBox.Show("地址长度不能小于4，请修改后操作");
                        txbAdd.SelectAll();

                    }

                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            entity.CainzAddress _address = (entity.CainzAddress)cainzAddressBindingSource.Current;
            if (_address != null)
            {
                FAddress.add = _address.Address;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

    }
}
