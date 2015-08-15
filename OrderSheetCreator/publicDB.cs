using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using entity;

namespace OrderSheetCreator
{
    public static class PublicDB
    {

        public static DB getDB(int timeOut)
        {
            if (!System.IO.File.Exists("config.ini"))
            {
                FDatabase m = new FDatabase();
                m.ShowDialog();
            }

            var db = new DB();
            db.Database.Connection.ConnectionString = getIniConn("config.ini", timeOut);
            db.Configuration.EnsureTransactionsForFunctionsAndCommands = true;
            return db;
        }

        public static DB getDB()
        {
            return getDB(60);
        }

        public static bool TestDB(string connString)
        {
            bool r = false;
            using (var db = new DB())
            {
                db.Database.Connection.ConnectionString = connString;
                try
                {
                    db.Database.Connection.Open();
                    r = (db.Database.Connection.State == ConnectionState.Open);
                }
                catch (Exception ee)
                {
                    System.Windows.Forms.MessageBox.Show(ee.Message);
                    r = false;
                }
            }
            return r;
        }

        public static string getIniConn(string iniPath, int timeOut)
        {
            INIClass iniClass = new INIClass(iniPath);
            string connString = "";
            if (iniClass.ExistINIFile())
            {

                string Server = EncAndDec.Decode(iniClass.IniReadValue("Database", "server"));
                string dataBase = EncAndDec.Decode(iniClass.IniReadValue("Database", "database"));
                string user = EncAndDec.Decode(iniClass.IniReadValue("Database", "user"));
                string pwd = EncAndDec.Decode(iniClass.IniReadValue("Database", "password"));
                connString = string.Format("data source={0};initial catalog={1};persist security info=True;user id={2};password={3};MultipleActiveResultSets=True;App=EntityFramework;Connection Timeout={4};", Server, dataBase, user, pwd, timeOut);

            }
            return connString;
        }

        public static string getIniConnInfo(string iniPath)
        {
            INIClass iniClass = new INIClass(iniPath);
            string coninfo = "";
            if (iniClass.ExistINIFile())
            {

                string Server = EncAndDec.Decode(iniClass.IniReadValue("Database", "server"));
                string dataBase = EncAndDec.Decode(iniClass.IniReadValue("Database", "database"));
                coninfo = string.Format("{0} {1}", Server, dataBase, Server, dataBase);

            }
            return coninfo;
        }

        public static entity.CainzFactory GetFactoryByName(string factoryName)
        {
            entity.CainzFactory factory;
            using (var db = PublicDB.getDB())
            {
                factory = (from a in db.CainzFactory
                           where a.FactoryName.Equals(factoryName)
                           select a).FirstOrDefault();
            }
            return factory;
        }

        public static entity.CainzProduct GetProductByBarcode(string barcode)
        {
            entity.CainzProduct product;
            using (var db = PublicDB.getDB())
            {
                product = (from a in db.CainzProduct
                           where a.ProductBarcode.Equals(barcode)
                           select a).FirstOrDefault();
            }
            return product;

        }

        public static CainzTrader GetTraderByBarcode(string barcode)
        {
            CainzProduct product = null;
            CainzTrader trader = null;
            using (var db = PublicDB.getDB())
            {
                product = (from a in db.CainzProduct
                           where a.ProductBarcode.Equals(barcode)
                           select a).FirstOrDefault();
                if(product!=null)
                {
                    trader = (from a in db.CainzTrader
                              where a.TraderID == product.TraderID
                              select a).FirstOrDefault();
                }
                
                
            }
            return trader;

        }

    }
}
