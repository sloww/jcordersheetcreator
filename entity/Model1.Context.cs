﻿

//------------------------------------------------------------------------------
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


public partial class DB : DbContext
{
    public DB()
        : base("name=DB")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public DbSet<CainzFactory> CainzFactory { get; set; }

    public DbSet<CainzOrder> CainzOrder { get; set; }

    public DbSet<CainzOrderDetail> CainzOrderDetail { get; set; }

    public DbSet<CainzProduct> CainzProduct { get; set; }

    public DbSet<CainzTrader> CainzTrader { get; set; }

    public DbSet<PubCode> PubCode { get; set; }

    public DbSet<PubDgvSet> PubDgvSet { get; set; }

    public DbSet<CainzAddress> CainzAddress { get; set; }

}

}

