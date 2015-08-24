using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using NPOI.SS.UserModel;
using System.Reflection;
using System.Management;

namespace OrderSheetCreator
{
    public static class PublicTools
    {

        public static void RecoverFormSize(Form form)
        {
            //恢复保存的窗体大小
            if (Properties.Settings.Default.Maximised)
            {
                form.WindowState = FormWindowState.Maximized;
                form.Location = Properties.Settings.Default.Location;
                form.Size = Properties.Settings.Default.Size;

            }
            else if (Properties.Settings.Default.Minimised)
            {
                form.WindowState = FormWindowState.Minimized;
                form.Location = Properties.Settings.Default.Location;
                form.Size = Properties.Settings.Default.Size;
            }
            else
            {
                form.Location = Properties.Settings.Default.Location;
                form.Size = Properties.Settings.Default.Size;

            }
        }

        public static void SaveFormSize(Form form)
        {
            //保存窗体的设置
            if (form.WindowState == FormWindowState.Maximized)
            {
                Properties.Settings.Default.Location = form.RestoreBounds.Location;
                Properties.Settings.Default.Size = form.RestoreBounds.Size;
                Properties.Settings.Default.Maximised = true;
                Properties.Settings.Default.Minimised = false;
            }
            else if (form.WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.Location = form.Location;
                Properties.Settings.Default.Size = form.Size;
                Properties.Settings.Default.Maximised = false;
                Properties.Settings.Default.Minimised = false;
            }
            else
            {
                Properties.Settings.Default.Location = form.RestoreBounds.Location;
                Properties.Settings.Default.Size = form.RestoreBounds.Size;
                Properties.Settings.Default.Maximised = false;
                Properties.Settings.Default.Minimised = true;
            }
            Properties.Settings.Default.Save();
        }


        #region 程序集特性访问器

        public static string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public static string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public static string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public static string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public static string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public static string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion
        public static double GetCellNumic(ISheet sheet, char x, int y)
        {
            double _r = double.MinValue;

            ICell cell = sheet.GetRow(y - 1).GetCell(GetCellIntFromChar(x) - 1);
            if(cell!=null)
            switch (cell.CellType)
            {
                case CellType.String:
                    {
                        _r = double.Parse(cell.StringCellValue.Trim());

                    } break;
                case CellType.Numeric:
                    {
                        _r = cell.NumericCellValue;
                    } break;
                default:
                    {

                    } break;
            }

            return _r;

        }

        /// <summary>
        /// 保存grid列宽信息到字典
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="dic"></param>
        public static void saveWidthTmp(DataGridView dgv, Dictionary<string, int> dic)
        {
            dic.Clear();
            foreach (DataGridViewColumn dgvc in dgv.Columns)
            {
                dic.Add(dgvc.Name, dgvc.Width);
            }
        }

        /// <summary>
        /// 校验grid 列宽信息和字典是否一致
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="dic"></param>
        /// <returns></returns>
        public static bool isWidthChange(DataGridView dgv, Dictionary<string, int> dic)
        {
            bool r = false;
            foreach (DataGridViewColumn dgvc in dgv.Columns)
            {
                if (dic[dgvc.Name] != dgvc.Width)
                {
                    r = true;
                    break;
                }
            }
            return r;
        }

        public static double GetCellNumic(IRow row, char x, int y)
        {
            double _r = double.MinValue;

            ICell cell = row.Cells[y - 1];
            if (cell != null)
                switch (cell.CellType)
                {
                    case CellType.String:
                        {
                            _r = double.Parse(cell.StringCellValue.Trim());

                        }
                        break;
                    case CellType.Numeric:
                        {
                            _r = cell.NumericCellValue;
                        }
                        break;
                    default:
                        {

                        }
                        break;
                }

            return _r;

        }

        public static string GetCellString(ISheet sheet, char x, int y)
        {
            string _r = string.Empty;

            ICell cell = sheet.GetRow(y - 1).GetCell(GetCellIntFromChar(x) - 1,MissingCellPolicy.CREATE_NULL_AS_BLANK);
            switch (cell.CellType)
            {
                case CellType.String:
                    {
                        _r = cell.StringCellValue.Trim();

                    } break;
                case CellType.Numeric:
                    {
                        _r = cell.NumericCellValue.ToString();
                    } break;
                case CellType.Blank:
                    {
                        _r = string.Empty;
                    }
                    break;
                default:
                    {
                        _r = string.Empty;

                    } break;
            }

            return _r;

        }

        public static int GetCellIntFromChar(char x)
        {
            int offsetLower = ((int)'a') - 1;
            int offsetUpper = ((int)'A') - 1;
            
            if (Char.IsLower(x))
            {
                return ((int)x) - offsetLower;
            }
            
            if(Char.IsUpper(x))
            {
                return ((int)x) - offsetUpper;
            }

            return int.MinValue;
        }
        public static void  Message404(string con)
        {
            MessageBox.Show(con, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void SetFitCharFont(Font MaxFont, int TotolSpace, string StringCon, out Font FitFont, out int StartOffset)
        {
            FitFont = MaxFont;
            StartOffset = 1;
            while (true)
            {
                int StringWidth = TextRenderer.MeasureText(StringCon, FitFont).Width;
                if (StringWidth < TotolSpace - 2)
                {
                    break;
                }
                else
                {
                    FitFont = new Font(FitFont.FontFamily, FitFont.Size - 2, FitFont.Unit);
                }
            }

            StartOffset = (TotolSpace - TextRenderer.MeasureText(StringCon, FitFont).Width) / (int)(2 * 3.8);
        }

        /// <summary>
        /// yyyyMMdd
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string FormatDate(DateTime dt)
        {
            return dt.ToString("yyyyMMdd");
        }
        /// <summary>
        /// yyyy-MM-dd
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string FormatDateC(DateTime dt)
        {
            return dt.ToString("yyyy-MM-dd");
        }
        public static string stringZip(string s1)
        {
            string[] removeStrings = { "常熟", "桐乡", "台州", "新昌", "温州", "南宁", "曹县", "有限", "公司", "包装", "材料", "上海", "文教", "礼品", "金属", "制品", "南通", "金属", "体育", "用品", "毛绒", "制造", "不锈钢", "山东", "经贸", "防滑垫", "金属", "中日", "合资", "自行车", "机电", "进出口", "（河源）", "（河源）", "（青岛）", "市", "厂", "工业", "橡胶", "技术开发区", "皮件", "劳保", "国际", "股份", "集团", "贸易", "贸易", "旅游", "汽车", "（深圳）", "家饰", "家居", "食品", "县", "省", "科技", "电子", "针织", "服饰", "炭业", "浙江", "广州", "福州", "泰州", "海陵区", "塑业", "上虞", "海陵区", "昆山", "皓源", "宁波", "经济", "昭源", "广西", "南宁", "进出口" };
            //   
            foreach (var item in removeStrings)
            {
                s1 = s1.Replace(item, "");
            }
            return s1.Replace(" ", "");
        }

        //重新计算表格序号

        public static void RecountRowsNum(DataGridView dgv)
        {
            foreach (DataGridViewRow r in dgv.Rows)
            {
                r.Cells[0].Value = r.Index + 1;
            }
            dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Refresh();
        }

        public static void IniDatagridview(DataGridView dgv)
        {
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowDrop = false;
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.BackgroundColor = Color.FromKnownColor(KnownColor.Control);
            dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgv.DefaultCellStyle.Padding = new Padding(2);

            var dgvColumnHeaderStyle = new DataGridViewCellStyle();
            dgvColumnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle = dgvColumnHeaderStyle;


        }

        public static void SetColumsAutoModeNone(DataGridView dgv)
        {
            foreach (DataGridViewColumn dgvc in dgv.Columns)
            {
                dgvc.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
        }

        public static void SaveColumnWidth(DataGridView dgv, string path)
        {
            using (StreamWriter w = new StreamWriter(path))
            {
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    if (col.Visible)
                        w.WriteLine(string.Format("{0},{1}", col.HeaderText, col.Width));
                }
            }
        }

        public static void SaveColumnWidth(DataGridView dgv, string code,string appName,string formName)
        {
            List<entity.PubDgvSet> dgvColumns = new List<entity.PubDgvSet>();
            using (var db = PublicDB.getDB())
            {
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    if (col.Visible)
                    {
                        entity.PubDgvSet pds = new entity.PubDgvSet();
                        pds.RegCode = code;
                        pds.RegApp = appName;
                        pds.FormName = formName;
                        pds.DgvName = dgv.Name;
                        pds.ColumnName = col.Name;
                        pds.ColumnWidth = col.Width;
                        dgvColumns.Add(pds);
                    }
                }

                foreach (var item in dgvColumns)
                {
                    var q = db.PubDgvSet.Where(a => a.RegCode.Equals(item.RegCode) && a.RegApp.Equals(item.RegApp) && a.FormName.Equals(item.FormName) && a.DgvName.Equals(item.DgvName) && a.ColumnName.Equals(item.ColumnName)).FirstOrDefault();
                    if (q != null)
                    {
                        q.ColumnWidth = item.ColumnWidth;
                        db.Entry(q).State = System.Data.Entity.EntityState.Modified;
                    }
                    else
                    {
                        db.PubDgvSet.Add(item);
                        db.Entry(item).State = System.Data.Entity.EntityState.Added;

                    }
                }

                try
                {
                    db.SaveChanges();
                }
                catch (Exception ee)
                {
                }
            }
        }

        public static void RecoverColumnWidth(DataGridView dgv, string path)
        {
            if (File.Exists(path) == false)
            {

                return;
            }

            using (StreamReader w = new StreamReader(path))
            {
                while (!w.EndOfStream)
                {
                    string[] readlinetmp = w.ReadLine().Split(',');
                    int colWidth = 0;
                    if (readlinetmp.Length == 2 && int.TryParse(readlinetmp[1], out colWidth))
                    {
                        for (int i = 0; i < dgv.Columns.Count; i++)
                        {
                            if (dgv.Columns[i].HeaderText.Equals(readlinetmp[0]))
                            {
                                dgv.Columns[i].Width = colWidth;
                                dgv.Columns[i].MinimumWidth = 2;
                                break;
                            }
                        }
                    }
                }
            }
        }

        public static void RecoverColumnWidth(DataGridView dgv, string code, string appName, string formName)
        {

            using(var db =PublicDB.getDB())
            {
                List<entity.PubDgvSet> dgvColumns = db.PubDgvSet.Where(a => a.RegCode.Equals(code) &&a.RegApp.Equals(appName)&& a.FormName.Equals(formName) && a.DgvName.Equals(dgv.Name)).ToList();
                if(dgvColumns!=null)
                {
                   foreach(var item in dgvColumns)
                   {
                       foreach(DataGridViewColumn dgvc in dgv.Columns)
                       {
                           if(item.ColumnName.Equals(dgvc.Name))
                           {
                               dgvc.Width = item.ColumnWidth;
                               break;
                           }
                       }
                   }
                }


            }

        }

        public static void ReSizeTextbox(Control ctl)
        {

            float charCount = (float)ctl.Text.Length;
            float fontsize = ctl.Font.Size;
            float charlength = fontsize * charCount;
            float tbWidth = (float)ctl.Width;
            if (charlength > tbWidth)
            {
                ctl.Font = new Font(ctl.Font.FontFamily, ctl.Font.Size - 2);
                Point p = ctl.Location;
                ctl.Location = new Point(p.X, p.Y +2);
                ReSizeTextbox(ctl);

            }
        }

        public static Point local(Control c)
        {
            Point p = c.Location;

            if (c.Parent != null)
            {
                Point pp = local(c.Parent);
                p.X += pp.X + c.Padding.Left + c.Margin.Left;
                p.Y += pp.Y + c.Padding.Top + c.Margin.Left;
            }
            else
            {
                p.Y += 26;
            }

            return p;
        }
    }

    public class INIClass
    {
        public string inipath;
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="INIPath">文件路径</param>
        public INIClass(string INIPath)
        {
            inipath = AppDomain.CurrentDomain.BaseDirectory + INIPath;
        }
        /// <summary>
        /// 写入INI文件
        /// </summary>
        /// <param name="Section">项目名称(如 [TypeName] )</param>
        /// <param name="Key">键</param>
        /// <param name="Value">值</param>
        public void IniWriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, this.inipath);
        }
        /// <summary>
        /// 读出INI文件
        /// </summary>
        /// <param name="Section">项目名称(如 [TypeName] )</param>
        /// <param name="Key">键</param>
        public string IniReadValue(string Section, string Key)
        {
            if (ExistINIFile() == false) return "";
            StringBuilder temp = new StringBuilder(500);
            int i = GetPrivateProfileString(Section, Key, "", temp, 500, this.inipath);
            return temp.ToString();
        }
        /// <summary>
        /// 验证文件是否存在
        /// </summary>
        /// <returns>布尔值</returns>
        public bool ExistINIFile()
        {
            bool tmp = File.Exists(inipath);
            return tmp;
        }
    }

    public class EncAndDec
    {
        public static string toDigital(string data)
        {
            int d = 0;
            int lenth = data.Length;
            for(int i=0;i<lenth;i++)
            {
                d += ((int)data[i]) * (i+1)*(i+1);
            }

            return d.ToString();
        }

        public static string toDigitalKey(string data)
        {
            return toDigital(KEY_64+data);
        }
        //加密/解密钥匙
        const string KEY_64 = "tslinkcn";//注意了，是8个字符，64位    
        const string IV_64 = "ncknilst";//注意了，是8个字符，64位

        const string ClientLocal_KEY_64 = "12345678";
        const string ClientLocal_IV_64 = "12345679";

        /// <summary>
        /// 加密的方法，通过2个密匙进行加密
        /// </summary>
        /// <param name="data">加密的数据</param>
        /// <returns>返回加密后的字符串</returns>
        public static string Encode(string data)
        {
            EncAndDec ed = new EncAndDec();
            return ed.Encode(data, KEY_64, IV_64);
        }
        /// <summary>
        /// 解密的方法
        /// </summary>
        /// <param name="data">解密的数据</param>
        /// <returns>返回加密前的字符串</returns>
        public static string Decode(string data)
        {
            EncAndDec ed = new EncAndDec();
            return ed.Decode(data, KEY_64, IV_64);
        }

        /// <summary>
        /// 客户本地加密的方法，通过2个密匙进行加密
        /// </summary>
        /// <param name="data">加密的数据</param>
        /// <returns>返回加密后的字符串</returns>
        public static string EncodeClientLocal(string data)
        {
            EncAndDec ed = new EncAndDec();
            return ed.Encode(data, ClientLocal_KEY_64, ClientLocal_IV_64);
        }
        /// <summary>
        /// 客户本地解密的方法
        /// </summary>
        /// <param name="data">解密的数据</param>
        /// <returns>返回加密前的字符串</returns>
        public static string DecodeClientLocal(string data)
        {
            EncAndDec ed = new EncAndDec();
            return ed.Decode(data, ClientLocal_KEY_64, ClientLocal_IV_64);
        }

        #region DEC加密的方法
        /// <summary>
        /// 加密的方法，通过2个密匙进行加密
        /// </summary>
        /// <param name="data">通过Md5加密一次</param>
        /// <param name="KEY_64"></param>
        /// <param name="IV_64"></param>
        /// <returns></returns>
        private string Encode(string data, string KEY_64, string IV_64)
        {

            KEY_64 = ToMD5(KEY_64);
            IV_64 = ToMD5(IV_64);
            byte[] byKey = System.Text.ASCIIEncoding.ASCII.GetBytes(KEY_64);
            byte[] byIV = System.Text.ASCIIEncoding.ASCII.GetBytes(IV_64);

            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            int i = cryptoProvider.KeySize;
            MemoryStream ms = new MemoryStream();
            CryptoStream cst = new CryptoStream(ms, cryptoProvider.CreateEncryptor(byKey, byIV), CryptoStreamMode.Write);

            StreamWriter sw = new StreamWriter(cst);
            sw.Write(data);
            sw.Flush();
            cst.FlushFinalBlock();
            sw.Flush();
            return Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);

        }
        /// <summary>
        /// 解密的方法（）
        /// </summary>
        /// <param name="data"></param>
        /// <param name="KEY_64"></param>
        /// <param name="IV_64"></param>
        /// <returns></returns>
        private string Decode(string data, string KEY_64, string IV_64)
        {
            if (data == "") return "";
            KEY_64 = ToMD5(KEY_64);
            IV_64 = ToMD5(IV_64);
            byte[] byKey = System.Text.ASCIIEncoding.ASCII.GetBytes(KEY_64);
            byte[] byIV = System.Text.ASCIIEncoding.ASCII.GetBytes(IV_64);

            byte[] byEnc;
            try
            {
                byEnc = Convert.FromBase64String(data);
            }
            catch
            {
                return null;
            }

            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            MemoryStream ms = new MemoryStream(byEnc);
            CryptoStream cst = new CryptoStream(ms, cryptoProvider.CreateDecryptor(byKey, byIV), CryptoStreamMode.Read);
            StreamReader sr = new StreamReader(cst);
            return sr.ReadToEnd();
        }
        #endregion

        #region MD5加密
        /// <summary>
        /// 转换MD5密码
        /// </summary>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static string ToMD5(string KEY)
        {
            byte[] result = Encoding.Default.GetBytes(KEY);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);

            string KEY_64 = BitConverter.ToString(output).Replace("-", "").Substring(0, 8);
            return KEY_64;

        }
        #endregion

    }

    public class Hardware
    {

        //获取硬盘号
        public string GetDiskID()
        {
            try
            {
                //获取硬盘ID
                String HDid = "";
                ManagementClass mc = new ManagementClass("Win32_DiskDrive");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    HDid = (string)mo.Properties["Model"].Value;
                }
                moc = null;
                mc = null;
                return HDid;
            }
            catch
            {
                return "";
            }
            finally
            {
            }
        }
        //获取CPU信息
        public string GetCpuInfo()
        {
            try
            {
                string cpuInfo = "";//cpu序列号
                ManagementClass cimobject = new ManagementClass("Win32_Processor");
                ManagementObjectCollection moc = cimobject.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    cpuInfo = mo.Properties["ProcessorId"].Value.ToString();
                }
                return cpuInfo;
            }
            catch
            {
            }

            return "";
        }


    
    }
}
