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
            

        }

        public static void SetColumsAutoModeNone(DataGridView dgv)
        {
            foreach(DataGridViewColumn dgvc in dgv.Columns)
            {
                dgvc.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
        }

        public static void SaveColumnWidth(DataGridView dgv,string path)
        {
            using (StreamWriter w = new StreamWriter(path))
            {
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    if(col.Visible)
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
                    int colWidth=0;
                    if (readlinetmp.Length == 2 && int.TryParse(readlinetmp[1],out colWidth))
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
    }
}
