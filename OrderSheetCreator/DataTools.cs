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
using NPOI.HSSF.UserModel;
using System.Collections;
using NPinyin;

namespace OrderSheetCreator
{
    public partial class DataTools : Form
    {
        Dictionary<string, int> gMaoYiShangDic = new Dictionary<string, int>();
        Dictionary<string, string> gGongChangDic = new Dictionary<string, string>();
        List<CainzFactory> FACTORYS = new List<CainzFactory>();


        public DataTools()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //using (var ctx = new entity.DB())
            //{
            //    foreach (var maoyi in gMaoYiShangDic)
            //    {
            //        string catename = maoyi.Key;
            //        CusCategory cusc = ctx.CusCategory.FirstOrDefault(item => item.CateName == catename);
            //        if (cusc == null)
            //        {
            //            CusCategory cc = new CusCategory();
            //            cc.ParentNum = "130817052630";
            //            cc.SnNum = DateTime.Now.ToString("yyMMddHHmmss");
            //            cc.CateName = maoyi.Key.ToString().Trim();
            //            cc.IsDelete = 0;
            //            cc.CreateTime = DateTime.Now;
            //            ctx.CusCategory.Add(cc);
            //            ctx.Entry(cc).State = System.Data.Entity.EntityState.Added;
            //            try
            //            {
            //                ctx.SaveChanges();
            //            }
            //            catch (Exception ee)
            //            {
            //                MessageBox.Show(ee.Message);
            //            }
            //            System.Threading.Thread.Sleep(1000);
            //        }
            //    }
            //}
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

        private void setCellStyle(IRow irow, int cellno, ICellStyle ics)
        {
            for (int i = 0; i < cellno; i++)
            {
                irow.GetCell(i).CellStyle = ics;
            }
        }

        string getCellString(int no, IRow row)
        {
            if (no < 0) return "";
            ICell cell = row.GetCell(no, MissingCellPolicy.CREATE_NULL_AS_BLANK);
            if (cell.CellType == CellType.Numeric)
            {
                return cell.NumericCellValue.ToString().Replace("/b", "");
            }
            else if (cell.CellType == CellType.String)
            {
                return cell.StringCellValue;

            }
            return "";
        }

        double getCellDouble(int no, IRow row)
        {
            if (no < 0) return 0;
            ICell cell = row.GetCell(no, MissingCellPolicy.CREATE_NULL_AS_BLANK);
            if (cell.CellType == CellType.Numeric)
            {
                return cell.NumericCellValue;
            }

            return 0;
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
                        if (irow.Cells.Count < 14) continue;

                        string traderName = irow.GetCell(11, MissingCellPolicy.RETURN_NULL_AND_BLANK).StringCellValue.Trim();
                        if (traderName.Length < 2) continue;
                        try
                        {
                            int keyno = gMaoYiShangDic[traderName];
                            gMaoYiShangDic[traderName]++;

                        }
                        catch (KeyNotFoundException ee)
                        {
                            gMaoYiShangDic.Add(traderName, 0);
                        }

                        string factoryName = getCellString(12, irow);
                        string factoryNameZip = stringZip(factoryName);

                        string add = getCellString(15, irow);
                        if (factoryName.Length < 2) continue;

                        //把工厂和贸易商联系起来的 一个冗余字典
                        if (gGongChangDic.ContainsKey(factoryName) == false)
                        {
                            gGongChangDic.Add(factoryName, traderName);

                            CainzFactory factory = new CainzFactory();
                            factory.FactoryName = factoryName;
                            //factory.FactoryNo = DateTime.Now.ToString("yyMMddHHmmss");
                            factory.FactoryAddress = getCellString(15, irow);
                            factory.Contact = getCellString(13, irow);
                            factory.ContactPhone = getCellString(14, irow);
                            FACTORYS.Add(factory);

                        }
                        if (gGongChangDic.ContainsKey(factoryNameZip) == false)
                        {
                            gGongChangDic.Add(factoryNameZip, traderName);
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
                foreach (var item in gMaoYiShangDic)
                {
                    writer.WriteLine(item.Key);
                }
                writer.Flush();
            }
        }

        //导入工厂数据
        private void button4_Click(object sender, EventArgs e)
        {
            //if (gMaoYiShangDic.Count == 0) return;
            //if (gGongChangDic.Count == 0) return;
            //List<Customer> ctlistforupdate = new List<Customer>();
            //List<Customer> ctlist = new List<Customer>();
            //using (var ctx = new entity.DB())
            //{
            //    var cainzCustomers = from item in ctx.Customer
            //                         where item.FirstNum == "130817052630"
            //                         select item;
            //    foreach (var cainzCus in cainzCustomers)
            //    {
            //        string FactoryName = cainzCus.CustomerName.Replace('C', ' ').Trim();

            //        string traderName = FindTraderByFactory(FactoryName, gGongChangDic);
            //        if (traderName != "")
            //        {

            //            var _maoyishang = ctx.CusCategory.SingleOrDefault(item => item.CateName == traderName);
            //            if (_maoyishang != null)
            //            {
            //                cainzCus.SecondNum = _maoyishang.SnNum;
            //                ctlistforupdate.Add(cainzCus);
            //            }

            //        }
            //        else
            //        {
            //            using (StreamWriter w = new StreamWriter("log2.txt", true))
            //            {
            //                w.WriteLine(FactoryName + "," + stringZip(FactoryName));
            //            }
            //        }
            //    }

            //    ctlist = cainzCustomers.ToList();

            //    customerBindingSource.DataSource = ctlist;

            //}

            ////修改动作
            //using (var ctx = new entity.DB())
            //{
            //    foreach (var item in ctlistforupdate)
            //    {
            //        ctx.Customer.Attach(item);
            //        ctx.Entry(item).State = System.Data.Entity.EntityState.Modified;
            //        ctx.SaveChanges();

            //    }
            //}
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
            string[] removeStrings = { "常熟", "桐乡", "台州", "新昌", "温州", "南宁", "曹县", "有限", "公司", "包装", "材料", "上海", "文教", "礼品", "金属", "制品", "南通", "金属", "体育", "用品", "毛绒", "制造", "不锈钢", "山东", "经贸", "防滑垫", "金属", "中日", "合资", "自行车", "机电", "进出口", "（河源）", "（河源）", "（青岛）", "市", "厂", "工业", "橡胶", "技术开发区", "皮件", "劳保", "国际", "股份", "集团", "贸易", "贸易", "旅游", "汽车", "（深圳）", "家饰", "家居", "食品", "县", "省", "科技", "电子", "针织", "服饰", "炭业", "浙江", "广州", "福州", "泰州", "海陵区", "塑业", "上虞", "海陵区", "昆山", "皓源", "宁波", "经济", "昭源", "广西", "南宁", "进出口" };
            //   
            foreach (var item in removeStrings)
            {
                s1 = s1.Replace(item, "");
            }
            return s1.Replace(" ", "");
        }

        //查找一个公司名称是否近似有对应的贸易公司名称

        private string FindTraderByFactory(string s1, Dictionary<string, string> d1)
        {
            if (d1.ContainsKey(s1)) return d1[s1];
            string s1zip = stringZip(s1);
            if (d1.ContainsKey(s1zip)) return d1[s1zip];
            foreach (var item in d1)
            {
                if (nameEqual(stringZip(item.Key), s1zip)) return item.Value;
            }
            return "";
        }

        private CainzTrader GetTradeByTraderName(string name)
        {
            if (name == "") return null;
            using (var db = new entity.DB())
            {
                var c = (from item in db.CainzTrader
                         where item.TraderName.Contains(name)
                         select item).FirstOrDefault();
                if (c != null)
                    return c;
                else
                    return null;
            }
        }

        private CainzTrader GetTrderByFactoryName(string name)
        {
            return GetTradeByTraderName(FindTraderByFactory(name, this.gGongChangDic));
        }

        private CainzFactory GetFactoryByName(string name)
        {
            name = stringZip(name);
            CainzFactory cc = null;
            using (var db = new entity.DB())
            {
                var c = (from item in db.CainzFactory
                         where item.FactoryName.Contains(name)
                         select item).FirstOrDefault();
                if (c != null)
                    cc = c;
            }
            return cc;
        }

        //查找一个非规范的公司名称是否正确

        private string findgcm(string s1, Dictionary<string, string> d1)
        {
            if (d1.ContainsKey(s1)) return s1;
            string s1zip = stringZip(s1);
            if (d1.ContainsKey(s1zip)) return s1zip;
            foreach (var item in d1)
            {
                if (nameEqual(stringZip(item.Key), s1zip)) return item.Key;
            }
            return "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = ".xls";
            openFileDialog1.Filter = "xls file|*.xls";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ReadProducts(openFileDialog1.FileName);

            }

        }

        private void btnFactory_Click(object sender, EventArgs e)
        {

        }

        //导入 到新表 Trader 
        private void btnCainzMaoyis_Click(object sender, EventArgs e)
        {
            using (var db = new entity.DB())
            {
                //遍历贸易商表列表,通过名称查找，如果不存在则添加
                foreach (var Trader in gMaoYiShangDic)
                {
                    string traderName = Trader.Key;
                    CainzTrader cusc = db.CainzTrader.FirstOrDefault(item => item.TraderName == traderName);
                    if (cusc == null)
                    {
                        CainzTrader cc = new CainzTrader();
                        cc.TraderID = Guid.NewGuid();
                        cc.TraderName = Trader.Key.ToString().Trim();
                        cc.TraderShortName = PublicTools.stringZip(cc.TraderName);
                        cc.CreateTime = DateTime.Now;
                        cc.IsDelete = 0;
                        db.CainzTrader.Add(cc);
                    }
                }
                db.SaveChanges();

            }
        }

        private void btnImportFactory_Click(object sender, EventArgs e)
        {

            using (var db = new entity.DB())
            {
                foreach (var f in this.FACTORYS)
                {
                    string FactoryName = f.FactoryName;
                    entity.CainzFactory factory = db.CainzFactory.FirstOrDefault(item => item.FactoryName == FactoryName);
                    if (factory == null)
                    {
                        entity.CainzFactory _factory =new CainzFactory();
                        _factory.FactoryID=Guid.NewGuid();
                        _factory.FactoryName = FactoryName;
                        _factory.FactoryNameJP = Pinyin.GetInitials(f.FactoryName);
                        _factory.Deleted = 0;
                        _factory.CreateTime = DateTime.Now;

                        entity.CainzTrader ct = GetTraaterByFactoryName(_factory.FactoryName);


                        if (ct != null)
                        {
                            _factory.CainzTraderTraderID = ct.TraderID;
                            _factory.TraderID = ct.TraderID;
                            _factory.TraderName = ct.TraderName;
                            db.CainzFactory.Add(_factory);
                        }
                    }
                }
                db.SaveChanges();
            }
        }

        private entity.CainzTrader GetTraaterByFactoryName(string factoryName)
        {
            factoryName = factoryName.Replace('C', ' ').Trim();
            CainzTrader trader = new CainzTrader();

            string traderName = FindTraderByFactory(factoryName, gGongChangDic);
            using (var db = new DB())
            {
                if (traderName != "")
                {

                    trader = db.CainzTrader.SingleOrDefault(item => item.TraderName == traderName);

                }
                else
                {
                    trader = null;
                    using (StreamWriter w = new StreamWriter("log3.txt", true))
                    {
                        w.WriteLine(factoryName + "," + stringZip(factoryName));
                    }
                }
            }

            return trader;
        }

        private void btnBlind_Click(object sender, EventArgs e)
        {
            if (gMaoYiShangDic.Count == 0) return;
            if (gGongChangDic.Count == 0) return;
            List<CainzFactory> ctlistforupdate = new List<CainzFactory>();
            List<CainzFactory> ctlist = new List<CainzFactory>();
            using (var db = new entity.DB())
            {
                var factorys = from item in db.CainzFactory
                               select item;
                foreach (var factory in factorys)
                {
                    string factoryName = factory.FactoryName.Replace('C', ' ').Trim();

                    string traderName = FindTraderByFactory(factoryName, gGongChangDic);

                    if (traderName != "")
                    {

                        var _maoyishang = db.CainzTrader.SingleOrDefault(item => item.TraderName == traderName);

                        if (_maoyishang != null)
                        {
                            factory.TraderName = _maoyishang.TraderName;
                            factory.TraderID = _maoyishang.TraderID;
                            ctlistforupdate.Add(factory);
                        }

                    }
                    else
                    {
                        using (StreamWriter w = new StreamWriter("log3.txt", true))
                        {
                            w.WriteLine(factoryName + "," + stringZip(factoryName));
                        }
                    }
                }

                ctlist = factorys.ToList();

                customerBindingSource.DataSource = ctlist;

            }

            //修改动作
            using (var ctx = new entity.DB())
            {
                foreach (var item in ctlistforupdate)
                {
                    ctx.CainzFactory.Attach(item);
                    ctx.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    ctx.SaveChanges();

                }
            }
        }

        private void btnImportProductData_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = ".xls";
            openFileDialog1.Filter = "xls file|*.xls";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ReadProductsAndInsert(openFileDialog1.FileName);

            }

        }

        private void ReadProducts(string path)
        {
            IWorkbook wb = WorkbookFactory.Create(path);

            int count = 0;

            int sheetNo = 0;

            //循环 sheet
            for (int i = 1; i < wb.NumberOfSheets; i++)
            {

                ISheet ist = wb.GetSheetAt(i);
                if (ist.SheetName.Contains("heet")) continue;



                int rowofPage = ist.LastRowNum + 1;

                int titleRowNo = -1;
                int cdNo = -1;
                int caizhiNo = -1;
                int caizhiEXNo = -1;
                int chicunNo = -1;
                int danjiaNo = -1;
                int gongchangNo = -1;
                int wuliaoNo = -1;
                int yanseNo = -1;
                string gudinggcm = "";

                //查找各个位置
                foreach (IRow row in ist)
                {
                    int cellCount = row.Cells.Count;
                    for (int cNo = 0; cNo < cellCount; cNo++)
                    {
                        ICell icell = row.GetCell(cNo, MissingCellPolicy.CREATE_NULL_AS_BLANK);
                        if (icell.CellType == CellType.String)
                        {
                            string title = icell.StringCellValue.Trim().Replace("（元/个）", "").Replace("mm", "").Replace(" ", "").Trim();
                            switch (title)
                            {
                                case "CD":
                                    {
                                        cdNo = icell.ColumnIndex;
                                    } break;
                                case "材质":
                                    {
                                        caizhiNo = icell.ColumnIndex;
                                    } break;
                                case "材质说明":
                                    {
                                        caizhiEXNo = icell.ColumnIndex;
                                    } break;
                                case "颜色":
                                    {
                                        yanseNo = icell.ColumnIndex;
                                    } break;
                                case "单价":
                                    {
                                        danjiaNo = icell.ColumnIndex;
                                    } break;
                                case "尺寸":
                                    {
                                        chicunNo = icell.ColumnIndex;
                                    } break;
                                case "厂商名":
                                case "工厂名":
                                case "厂商名称":
                                    {
                                        gongchangNo = icell.ColumnIndex;
                                    } break;
                                case "物料编号":
                                case "物料名称":
                                    {
                                        wuliaoNo = icell.ColumnIndex;
                                    } break;
                            }
                        }
                    }

                    if (cdNo != -1)
                    {
                        titleRowNo = row.RowNum;

                        if (gongchangNo == -1)
                        {
                            gudinggcm = findgcm(ist.SheetName, gGongChangDic);
                        }

                        break;
                    }

                }

                //生成excel

                IWorkbook iwb = new HSSFWorkbook();
                ISheet nist = iwb.CreateSheet();
                nist.CreateRow(0);
                IRow TitleRow = nist.GetRow(0);
                TitleRow.CreateCell(0).SetCellValue("序号");
                TitleRow.CreateCell(1).SetCellValue("订购工厂");
                TitleRow.CreateCell(2).SetCellValue("商品条形码/CD");
                TitleRow.CreateCell(3).SetCellValue("物料名称");
                TitleRow.CreateCell(4).SetCellValue("尺寸（mm）");
                TitleRow.CreateCell(5).SetCellValue("颜色");
                TitleRow.CreateCell(6).SetCellValue("材质");
                TitleRow.CreateCell(7).SetCellValue("材质说明");
                TitleRow.CreateCell(8).SetCellValue("单价");

                ICellStyle ics = iwb.CreateCellStyle();
                ics.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                ics.ShrinkToFit = true;
                ics.BorderBottom = ics.BorderLeft = ics.BorderRight = ics.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;

                this.setCellStyle(TitleRow, 0, ics);

                nist.SetColumnWidth(0, 3 * 512);
                nist.SetColumnWidth(1, 8 * 512);
                nist.SetColumnWidth(2, 10 * 512);
                nist.SetColumnWidth(3, 8 * 512);
                nist.SetColumnWidth(4, 6 * 512);
                nist.SetColumnWidth(5, 6 * 512);
                nist.SetColumnWidth(6, 12 * 512);
                nist.SetColumnWidth(7, 6 * 512);
                nist.SetColumnWidth(8, 4 * 512);
                int rouNum = 1;

                Hashtable productHT = new Hashtable();

                for (int j = titleRowNo + 1; j < rowofPage; j++)
                {
                    count++;
                    IRow irow = ist.GetRow(j);

                    if (irow == null) continue;

                    string cdString = getCellString(cdNo, irow);
                    string caizhiString = getCellString(caizhiNo, irow);
                    string chicunString = getCellString(chicunNo, irow);
                    string danjiaString = getCellString(danjiaNo, irow);
                    string yanseString = getCellString(yanseNo, irow);
                    string caizhiEXString = getCellString(caizhiEXNo, irow);
                    string gongchangString = getCellString(gongchangNo, irow);
                    string wuliaoString = getCellString(wuliaoNo, irow);
                    string com = cdString + caizhiString + chicunString + danjiaString + yanseString + caizhiEXString + wuliaoString + gongchangString;
                    double danjiaDouble = getCellDouble(danjiaNo, irow);

                    if (com.Length < 6) continue;
                    if (false == productHT.ContainsKey(com))
                    {

                        IRow irowc = nist.CreateRow(rouNum);
                        irowc.CreateCell(0).SetCellValue(rouNum.ToString());
                        irowc.CreateCell(1).SetCellValue(gongchangString);
                        irowc.CreateCell(2).SetCellValue(cdString);
                        irowc.CreateCell(3).SetCellValue(wuliaoString);
                        irowc.CreateCell(4).SetCellValue(chicunString);
                        irowc.CreateCell(5).SetCellValue(yanseString);
                        irowc.CreateCell(6).SetCellValue(caizhiString);
                        irowc.CreateCell(7).SetCellValue(caizhiEXString);
                        irowc.CreateCell(8).SetCellValue(danjiaDouble);
                        irowc.GetCell(8).SetCellType(CellType.Numeric);

                        setCellStyle(irowc, 9, ics);

                        rouNum++;
                        productHT.Add(com, null);

                    }

                }

                sheetNo++;
                string excelName = string.Format("NO.{0:D2} {1} (共 {2}种).xls", sheetNo, ist.SheetName, productHT.Count);

                using (FileStream fs = new FileStream(excelName, FileMode.Create))
                {
                    iwb.Write(fs);
                }
            }
        }

        private void ReadProductsAndInsert(string path)
        {
            IWorkbook wb = WorkbookFactory.Create(path);

            int count = 0;

            //循环 sheet
            for (int i = 1; i < wb.NumberOfSheets; i++)
            {

                ISheet ist = wb.GetSheetAt(i);
                if (ist.SheetName.Contains("heet")) continue;

                int rowofPage = ist.LastRowNum + 1;

                int titleRowNo = -1;
                int cdNo = -1;
                int caizhiNo = -1;
                int caizhiEXNo = -1;
                int chicunNo = -1;
                int danjiaNo = -1;
                int gongchangNo = -1;
                int wuliaoNo = -1;
                int yanseNo = -1;
                string gudinggcm = "";

                //查找各个位置
                foreach (IRow row in ist)
                {
                    int cellCount = row.Cells.Count;
                    for (int cNo = 0; cNo < cellCount; cNo++)
                    {
                        ICell icell = row.GetCell(cNo, MissingCellPolicy.CREATE_NULL_AS_BLANK);
                        if (icell.CellType == CellType.String)
                        {
                            string title = icell.StringCellValue.Trim().Replace("（元/个）", "").Replace("mm", "").Replace(" ", "").Trim();
                            switch (title)
                            {
                                case "CD":
                                    {
                                        cdNo = icell.ColumnIndex;
                                    } break;
                                case "材质":
                                    {
                                        caizhiNo = icell.ColumnIndex;
                                    } break;
                                case "材质说明":
                                    {
                                        caizhiEXNo = icell.ColumnIndex;
                                    } break;
                                case "颜色":
                                    {
                                        yanseNo = icell.ColumnIndex;
                                    } break;
                                case "单价":
                                    {
                                        danjiaNo = icell.ColumnIndex;
                                    } break;
                                case "尺寸":
                                    {
                                        chicunNo = icell.ColumnIndex;
                                    } break;
                                case "厂商名":
                                case "工厂名":
                                case "厂商名称":
                                    {
                                        gongchangNo = icell.ColumnIndex;
                                    } break;
                                case "物料编号":
                                case "物料名称":
                                    {
                                        wuliaoNo = icell.ColumnIndex;
                                    } break;
                            }
                        }
                    }

                    if (cdNo != -1)
                    {
                        titleRowNo = row.RowNum;

                        if (gongchangNo == -1)
                        {
                            gudinggcm = findgcm(ist.SheetName, gGongChangDic);
                        }

                        break;
                    }

                }


                Hashtable productHT = new Hashtable();

                for (int j = titleRowNo + 1; j < rowofPage; j++)
                {
                    count++;
                    IRow irow = ist.GetRow(j);

                    if (irow == null) continue;

                    string cdString = getCellString(cdNo, irow);
                    if (cdString == "") continue;
                    string caizhiString = getCellString(caizhiNo, irow);
                    string chicunString = getCellString(chicunNo, irow);
                    string danjiaString = getCellString(danjiaNo, irow);
                    string yanseString = getCellString(yanseNo, irow);
                    string caizhiEXString = getCellString(caizhiEXNo, irow);
                    string gongchangString = getCellString(gongchangNo, irow);
                    string wuliaoString = getCellString(wuliaoNo, irow);

                    if (gongchangString == "常熟市帝网织造有限公司")
                    {
                        i++;
                    }
                    Guid factoryID;
                    if (gongchangString == "")
                    {
                        gongchangString = ist.SheetName.Trim();
                    }

                    CainzFactory cc = this.GetFactoryByName(gongchangString);
                    if (cc == null)
                    {
                        cc = this.GetFactoryByName(ist.SheetName.Trim());
                    }

                    if (cc != null)
                    {
                        factoryID = cc.FactoryID;
                        gongchangString = cc.FactoryName;
                    }

                    string com = cdString + caizhiString + chicunString + danjiaString + yanseString + caizhiEXString + wuliaoString + gongchangString;
                    double price = getCellDouble(danjiaNo, irow);

                    if (com.Length < 6) continue;
                    if (false == productHT.ContainsKey(com))
                    {
                        using (var db = new entity.DB())
                        {
                            CainzProduct p = new CainzProduct();
                            p.ProductBarcode = cdString;
                            p.ProductColor = yanseString;
                            p.ProductMaterial = caizhiString;
                            p.ProductSize = chicunString;
                            p.ProductPrice = (System.Decimal)price;
                            p.CreateTime = DateTime.Now;
                            db.CainzProduct.Add(p);
                            db.Entry(p).State = System.Data.Entity.EntityState.Added;
                            db.SaveChanges();
                        }

                        productHT.Add(com, null);
                    }
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (var db = new entity.DB())
            {
                var result = from p in db.CainzFactory
                             select p;
                foreach (var p in result)
                {
                    p.FactoryNameJP = Pinyin.GetInitials(p.FactoryName);
                }
                db.SaveChanges();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }


        //批量导入
        private void button7_Click(object sender, EventArgs e)
        {
            DirectoryInfo TheFolder = new DirectoryInfo("D://excel/");
            foreach (FileInfo NextFile in TheFolder.GetFiles())
            {
                ReadExcelProductsAndInsert(NextFile.FullName,NextFile.Name.Replace(".xls","").Split(' ')[1]);
            }
        }

        //添加

        private void ReadExcelProductsAndInsert(string path,string name)
        {
            IWorkbook wb = WorkbookFactory.Create(path);

            int count = 0;

            //循环 sheet


            ISheet ist = wb.GetSheetAt(0);

            Guid traderID = Guid.Empty;
            string traderName = "";
            CainzTrader cc = this.GetTrderByFactoryName(name);

            if (cc == null)
            {
                FTrader m = new FTrader(name);
                if (m.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    traderID = FTrader.TRADER.TraderID;
                    traderName = FTrader.TRADER.TraderName;
                }
            }
            else
            {
                traderID = cc.TraderID;
                traderName = cc.TraderName;
            }

            if (traderID == Guid.Empty) return;

            int rowofPage = ist.LastRowNum + 1;

            int titleRowNo = -1;
            int cdNo = -1;
            int caizhiNo = -1;
            int caizhiEXNo = -1;
            int chicunNo = -1;
            int danjiaNo = -1;
            int gongchangNo = -1;
            int wuliaoNo = -1;
            int yanseNo = -1;
            string gudinggcm = "";

            //查找各个位置
            foreach (IRow row in ist)
            {


                int cellCount = row.Cells.Count;
                for (int cNo = 0; cNo < cellCount; cNo++)
                {
                    ICell icell = row.GetCell(cNo, MissingCellPolicy.CREATE_NULL_AS_BLANK);
                    if (icell.CellType == CellType.String)
                    {
                        string title = icell.StringCellValue.Trim().Replace("（元/个）", "").Replace("mm", "").Replace(" ", "").Trim();
                        switch (title)
                        {
                            case "商品条形码/CD":
                                {
                                    cdNo = icell.ColumnIndex;
                                } break;
                            case "材质":
                                {
                                    caizhiNo = icell.ColumnIndex;
                                } break;
                            case "材质说明":
                                {
                                    caizhiEXNo = icell.ColumnIndex;
                                } break;
                            case "颜色":
                                {
                                    yanseNo = icell.ColumnIndex;
                                } break;
                            case "单价":
                                {
                                    danjiaNo = icell.ColumnIndex;
                                } break;
                            case "尺寸":
                                {
                                    chicunNo = icell.ColumnIndex;
                                } break;
                            case "厂商名":
                            case "订购工厂":
                            case "厂商名称":
                                {
                                    gongchangNo = icell.ColumnIndex;
                                } break;
                            case "物料编号":
                            case "物料名称":
                                {
                                    wuliaoNo = icell.ColumnIndex;
                                } break;
                        }
                    }
                }

                if (cdNo != -1)
                {
                    titleRowNo = row.RowNum;

                    if (gongchangNo == -1)
                    {
                        gudinggcm = findgcm(ist.SheetName, gGongChangDic);
                    }

                    break;
                }

            }


            Hashtable productHT = new Hashtable();
            using (var db = new entity.DB())
            {

            for (int j = titleRowNo + 1; j < rowofPage; j++)
            {
                count++;
                IRow irow = ist.GetRow(j);

                if (irow == null) continue;

                string cdString = getCellString(cdNo, irow);
                if (cdString == "") continue;
                string caizhiString = getCellString(caizhiNo, irow);
                string chicunString = getCellString(chicunNo, irow);
                string danjiaString = getCellString(danjiaNo, irow);
                string yanseString = getCellString(yanseNo, irow);
                string caizhiEXString = getCellString(caizhiEXNo, irow);
                string gongchangString = getCellString(gongchangNo, irow);
                string wuliaoString = getCellString(wuliaoNo, irow);



                string com = cdString + caizhiString + chicunString + danjiaString + yanseString + caizhiEXString + wuliaoString + gongchangString;
                double danjiaDouble = getCellDouble(danjiaNo, irow);

                if (com.Length < 6) continue;
                if (false == productHT.ContainsKey(com))
                {

                        CainzProduct p = new CainzProduct();
                        p.ProductID = Guid.NewGuid();
                        p.ProductBarcode = cdString;
                        p.ProductSize = yanseString;
                        p.ProductMaterial = caizhiString;
                        p.ProductSize = chicunString;
                        p.ProductPrice = (System.Decimal)danjiaDouble;
                        p.TraderID = traderID;
                        p.TraderName = traderName;
                        p.CainzTraderTraderID = traderID;
                        p.Deleted = 0;
                        p.CreateTime = DateTime.Now;
                        p.ModifyTime = DateTime.Now;
                        p.Modified = 0;
                        if (traderID != Guid.Empty)
                        {
                            db.CainzProduct.Add(p);
                            db.Entry(p).State = System.Data.Entity.EntityState.Added;
                        }
                        productHT.Add(com, null);
                    }
                

                }

            db.SaveChanges();

            }


        }

        private void btnGetAllProduct_Click(object sender, EventArgs e)
        {

        }

    }
}
