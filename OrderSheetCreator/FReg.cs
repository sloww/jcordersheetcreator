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
    public partial class FReg : Form
    {
         INIClass ini = new INIClass("config.ini");
        public FReg()
        {
            InitializeComponent();
        }

        private void FReg_Load(object sender, EventArgs e)
        {
            

            string _createNo =EncAndDec.toDigital(GetSourceNo());
            txbCreate.Text = _createNo;

            if(ini.ExistINIFile())
            {
                txbReg.Text = ini.IniReadValue("Security", "Serial number");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string reg = EncAndDec.toDigitalKey(txbCreate.Text);
            if (reg.Equals(txbReg.Text.Trim()))
            {
                ini.IniWriteValue("Security", "Serial number", reg);
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("注册成功!");
                this.Close();

            }
            else
            {
                MessageBox.Show("序列号不正确，请重新填写");
                txbReg.Focus();
                txbReg.SelectAll();
            }
        }

        private string GetSourceNo()
        {
            Hardware hd = new Hardware();
            string _cpuInfo = hd.GetCpuInfo();
            string _diskInfo = hd.GetDiskID();
            return EncAndDec.Encode(_cpuInfo + _diskInfo);

        }

        public static  bool isReg()
        {
            bool r = false;
            INIClass _ini = new INIClass("config.ini");
            if (_ini.ExistINIFile())
            {
                Hardware hd = new Hardware();
                string _cpuInfo = hd.GetCpuInfo();
                string _diskInfo = hd.GetDiskID();
                string _createNo = EncAndDec.toDigital(EncAndDec.Encode(_cpuInfo + _diskInfo));
                string _reg  = _ini.IniReadValue("Security", "Serial number");
                if(_reg!=null&&_reg!="")
                {
                    if(_reg.Equals(EncAndDec.toDigitalKey(_createNo)))
                    {
                        r = true;
                    }
                }

            }
            return r;
        }
    }
}
