using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using entity;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.SS.Util;

namespace OrderSheetCreator
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> maoyishang = new Dictionary<string, int>();
        Dictionary<string, string> gongchang = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ctx = new entity.jingchendbEntities())
            {
                foreach (var maoyi in maoyishang)
                {
                    CusCategory cusc = ctx.CusCategory.FirstOrDefault(item => item.CateName.Equals(maoyi.Key));
                    if (cusc == null)
                    {
                        CusCategory cc = new CusCategory();
                        cc.ParentNum = "130817052630";
                        cc.SnNum = DateTime.Now.ToString("yyMMddHHmmss");
                        cc.CateName = maoyi.Key.ToString().Trim();
                        cc.IsDelete = 0;
                        cc.CreateTime = DateTime.Now;
                        ctx.CusCategory.Add(cc);
                        ctx.SaveChanges();
                        System.Threading.Thread.Sleep(1000);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            openFileDialog1.DefaultExt = ".xls";
            openFileDialog1.Filter = "xls file|*.xls";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Readjc(openFileDialog1.FileName);
            }
        }


        private void Readjc(string path)
        {
            IWorkbook wb = WorkbookFactory.Create(path);

            int count = 0;

            //循环 sheet
            for (int i = 0; i < wb.NumberOfSheets; i++)
            {
                //只处理第一个 sheet
                if (i == 0)
                {
                    ISheet ist = wb.GetSheetAt(i);
                    int rowofPage = ist.LastRowNum + 1;

                    for (int j = 3; j < rowofPage; j++)
                    {
                        count++;
                        IRow irow = ist.GetRow(j);

                        if (irow == null) continue;
                        if (irow.Cells.Count < 4) continue;

                        string mysmc = irow.GetCell(11, MissingCellPolicy.RETURN_NULL_AND_BLANK).StringCellValue.Trim();
                        if (mysmc.Length < 2) continue;
                        try
                        {
                            int keyno = maoyishang[mysmc];
                            maoyishang[mysmc]++;

                        }
                        catch (KeyNotFoundException ee)
                        {
                            maoyishang.Add(mysmc, 0);
                        }

                        string gcmc = irow.GetCell(12, MissingCellPolicy.RETURN_NULL_AND_BLANK).StringCellValue.Trim();
                        string gcmczip = stringZip(gcmc);
                        if (gcmc.Length < 2) continue;
                        if (gongchang.ContainsKey(gcmc) == false)
                        {
                            gongchang.Add(gcmc, mysmc);
                        }
                        if (gongchang.ContainsKey(gcmczip) == false)
                        {
                            gongchang.Add(gcmczip, mysmc);
                        }

                    }

                }
            }

        }

        //生成txt
        private void button3_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("maoyishang.txt"))
            {
                foreach (var item in maoyishang)
                {
                    writer.WriteLine(item.Key);
                }
                writer.Flush();
            }
        }


        //导入工厂数据
        private void button4_Click(object sender, EventArgs e)
        {
            if (maoyishang.Count == 0) return;
            if(gongchang.Count ==0) return;
            List<Customer> ctlistforupdate = new List<Customer>();
            List<Customer> ctlist = new List<Customer>();
            using (var ctx = new entity.jingchendbEntities())
            {
                var cainzCustomers = from item in ctx.Customer
                               where item.FirstNum == "130817052630"
                               select item;
                foreach (var cainzCus in cainzCustomers)
                {
                    string gcmc = cainzCus.CustomerName.Replace('C', ' ').Trim();

                    string mysmc = findMys(gcmc, gongchang);
                    if (mysmc != "")
                    {

                        var _maoyishang = ctx.CusCategory.SingleOrDefault(item => item.CateName == mysmc);
                        if (_maoyishang != null)
                        {
                            cainzCus.SecondNum = _maoyishang.SnNum;
                            ctlistforupdate.Add(cainzCus);
                        }

                    }
                    else
                    {
                        using (StreamWriter w = new StreamWriter("log2.txt", true))
                        {
                            w.WriteLine(gcmc + "," + stringZip(gcmc));
                        }
                    }

                    //如果在工厂数据和工厂本地字典中同时有工厂的信息，则试图查询他的贸易商字段
                    /*
                    if (gongchang.ContainsKey(gcmc))
                    {
                        try
                        {
                            string mysmc = gongchang[gcmc];
                            var _maoyishang = ctx.CusCategory.SingleOrDefault(item => item.CateName == mysmc);

                            //存在所属贸易商
                            if (_maoyishang != null)
                            {
                                cainzCus.SecondNum = _maoyishang.SnNum;
                                ctlistforupdate.Add(cainzCus);
                            }
                            //不存在贸易商
                            else
                            {
                                using (StreamWriter w = new StreamWriter("log1.txt", true))
                                {
                                    w.WriteLine(gcmc);
                                }
                            }
                        }
                        catch (Exception ee)
                        {

                            MessageBox.Show(ee.Message);
                        }
                    }
                    else
                    {
                        using (StreamWriter w = new StreamWriter("log2.txt", true))
                        {
                            w.WriteLine(gcmc);
                        }
                    }*/
                }
                     


                ctlist = cainzCustomers.ToList();

                customerBindingSource.DataSource = ctlist;

            }

            //修改动作
            using (var ctx = new entity.jingchendbEntities())
            {
                foreach (var item in ctlistforupdate)
                {
                    ctx.Customer.Attach(item);
                    ctx.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    ctx.SaveChanges();

                }
            }

 


        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private bool nameEqual(string s1, string s2)
        {
            s1 = stringZip(s1);
            s2 = stringZip(s2);


            return s1.Contains(s2) || s2.Contains(s1);
        }

        private string stringZip(string s1)
        {
            string[] removeStrings = { "有限", "公司", "包装", "材料", "上海", "文教", "礼品", "金属", "制品", "南通", "金属", "体育", "用品", "毛绒", "制造", "不锈钢", "山东", "经贸", "防滑垫", "金属", "中日", "合资", "自行车", "机电", "进出口", "（河源）", "（河源）", "（青岛）", "市", "厂", "工业", "橡胶", "技术开发区", "皮件", "劳保", "国际", "股份", "集团", "贸易", "贸易", "旅游", "汽车", "（深圳）", "家饰", "家居", "食品", "县", "省", "科技", "电子", "针织", "服饰", "炭业", "浙江", "广州", "福州", "泰州", "海陵区", "塑业", "上虞", "海陵区", "昆山", "皓源", "宁波" , "经济", "昭源"};
            //   
            foreach (var item in removeStrings)
            {
                s1 = s1.Replace(item, "");
            }
            return s1.Replace(" ", "");
        }

        //查找一个公司名称是否近似有对应的贸易公司名称

        private string findMys(string s1,Dictionary<string,string> d1)
        {
            if (d1.ContainsKey(s1)) return d1[s1];
            string s1zip = stringZip(s1);
            if (d1.ContainsKey(s1zip)) return d1[s1zip];
            foreach (var item in d1)
            {
                if (nameEqual( stringZip(item.Key), s1zip)) return item.Value;
            }
            return "";
        }

    }
}
