﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class jingchendbEntities : DbContext
    {
        public jingchendbEntities()
            : base("name=jingchendbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BadProductLocal> BadProductLocal { get; set; }
        public DbSet<CheckProduct> CheckProduct { get; set; }
        public DbSet<CheckStorage> CheckStorage { get; set; }
        public DbSet<CheckStorageDetail> CheckStorageDetail { get; set; }
        public DbSet<Construction> Construction { get; set; }
        public DbSet<ConstructionDetail> ConstructionDetail { get; set; }
        public DbSet<CusAddress> CusAddress { get; set; }
        public DbSet<CusCategory> CusCategory { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<InStorage> InStorage { get; set; }
        public DbSet<InStorDetail> InStorDetail { get; set; }
        public DbSet<InStorSingleDetail> InStorSingleDetail { get; set; }
        public DbSet<Material> Material { get; set; }
        public DbSet<MaterialCategory> MaterialCategory { get; set; }
        public DbSet<MoveSingleDetail> MoveSingleDetail { get; set; }
        public DbSet<MoveStorage> MoveStorage { get; set; }
        public DbSet<MoveStorageDetail> MoveStorageDetail { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OutStoDetail> OutStoDetail { get; set; }
        public DbSet<OutStorage> OutStorage { get; set; }
        public DbSet<OutStorSingleDetail> OutStorSingleDetail { get; set; }
        public DbSet<ProBatch> ProBatch { get; set; }
        public DbSet<ProCategory> ProCategory { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProShatter> ProShatter { get; set; }
        public DbSet<ProShatterDetail> ProShatterDetail { get; set; }
        public DbSet<ProSingle> ProSingle { get; set; }
        public DbSet<ShatterSingleDetail> ShatterSingleDetail { get; set; }
        public DbSet<StoLocation> StoLocation { get; set; }
        public DbSet<StoProRelation> StoProRelation { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<SysAdmin> SysAdmin { get; set; }
        public DbSet<SysRelation> SysRelation { get; set; }
        public DbSet<SysResource> SysResource { get; set; }
        public DbSet<SysRole> SysRole { get; set; }
        public DbSet<T_Plan> T_Plan { get; set; }
        public DbSet<VnCity> VnCity { get; set; }
        public DbSet<VnProvince> VnProvince { get; set; }
        public DbSet<View_OutStorage_StoProInfoByBarcode> View_OutStorage_StoProInfoByBarcode { get; set; }
        public DbSet<tgc> tgcs { get; set; }
        public DbSet<tmyg> tmygs { get; set; }
    }
}
