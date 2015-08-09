using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace OrderSheetCreator
{
    public static class PublicTools
    {
        public static string FormatDate(DateTime dt)
        {
            return dt.ToString("yyyyMMdd");
        }
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
            dgv.BorderStyle = BorderStyle.None;
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgv.DefaultCellStyle.Padding = new Padding(2);


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

        public static void RecoverColumnWidth(DataGridView dgv, string path)
        {
            if (File.Exists(path) == false) return;
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
}
