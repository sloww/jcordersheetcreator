
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 07/24/2015 16:47:25
-- Generated from EDMX file: D:\DEV-CODE\jcordersheetcreator\entity\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [jingchendb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[BadProductLocal]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BadProductLocal];
GO
IF OBJECT_ID(N'[dbo].[CainzCustomer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CainzCustomer];
GO
IF OBJECT_ID(N'[dbo].[CainzOrderDetail]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CainzOrderDetail];
GO
IF OBJECT_ID(N'[dbo].[CainzOrders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CainzOrders];
GO
IF OBJECT_ID(N'[dbo].[CainzProduct]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CainzProduct];
GO
IF OBJECT_ID(N'[dbo].[CainzTrader]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CainzTrader];
GO
IF OBJECT_ID(N'[dbo].[CheckProduct]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CheckProduct];
GO
IF OBJECT_ID(N'[dbo].[CheckStorage]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CheckStorage];
GO
IF OBJECT_ID(N'[dbo].[CheckStorageDetail]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CheckStorageDetail];
GO
IF OBJECT_ID(N'[dbo].[Construction]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Construction];
GO
IF OBJECT_ID(N'[dbo].[ConstructionDetail]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ConstructionDetail];
GO
IF OBJECT_ID(N'[dbo].[CusAddress]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CusAddress];
GO
IF OBJECT_ID(N'[dbo].[CusCategory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CusCategory];
GO
IF OBJECT_ID(N'[dbo].[Customer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customer];
GO
IF OBJECT_ID(N'[dbo].[Equipment]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Equipment];
GO
IF OBJECT_ID(N'[dbo].[InStorage]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InStorage];
GO
IF OBJECT_ID(N'[dbo].[InStorDetail]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InStorDetail];
GO
IF OBJECT_ID(N'[dbo].[InStorSingleDetail]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InStorSingleDetail];
GO
IF OBJECT_ID(N'[dbo].[Material]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Material];
GO
IF OBJECT_ID(N'[dbo].[MaterialCategory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MaterialCategory];
GO
IF OBJECT_ID(N'[dbo].[MoveSingleDetail]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MoveSingleDetail];
GO
IF OBJECT_ID(N'[dbo].[MoveStorage]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MoveStorage];
GO
IF OBJECT_ID(N'[dbo].[MoveStorageDetail]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MoveStorageDetail];
GO
IF OBJECT_ID(N'[dbo].[OrderDetail]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OrderDetail];
GO
IF OBJECT_ID(N'[dbo].[Orders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Orders];
GO
IF OBJECT_ID(N'[dbo].[OutStoDetail]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OutStoDetail];
GO
IF OBJECT_ID(N'[dbo].[OutStorage]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OutStorage];
GO
IF OBJECT_ID(N'[dbo].[OutStorSingleDetail]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OutStorSingleDetail];
GO
IF OBJECT_ID(N'[dbo].[ProBatch]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProBatch];
GO
IF OBJECT_ID(N'[dbo].[ProCategory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProCategory];
GO
IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
GO
IF OBJECT_ID(N'[dbo].[ProShatter]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProShatter];
GO
IF OBJECT_ID(N'[dbo].[ProShatterDetail]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProShatterDetail];
GO
IF OBJECT_ID(N'[dbo].[ProSingle]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProSingle];
GO
IF OBJECT_ID(N'[dbo].[ShatterSingleDetail]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ShatterSingleDetail];
GO
IF OBJECT_ID(N'[dbo].[StoLocation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StoLocation];
GO
IF OBJECT_ID(N'[dbo].[StoProRelation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StoProRelation];
GO
IF OBJECT_ID(N'[dbo].[Supplier]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Supplier];
GO
IF OBJECT_ID(N'[dbo].[SysAdmin]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SysAdmin];
GO
IF OBJECT_ID(N'[dbo].[SysRelation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SysRelation];
GO
IF OBJECT_ID(N'[dbo].[SysResource]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SysResource];
GO
IF OBJECT_ID(N'[dbo].[SysRole]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SysRole];
GO
IF OBJECT_ID(N'[dbo].[VnCity]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VnCity];
GO
IF OBJECT_ID(N'[dbo].[VnProvince]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VnProvince];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'BadProductLocal'
CREATE TABLE [dbo].[BadProductLocal] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [BarCode] nvarchar(50)  NULL,
    [ProductNum] nvarchar(50)  NULL,
    [Num] int  NULL,
    [LocalNum] nvarchar(50)  NULL,
    [ProductType] int  NOT NULL,
    [CreateTime] datetime  NOT NULL,
    [BadLocal] nvarchar(50)  NULL
);
GO

-- Creating table 'CainzCustomer'
CREATE TABLE [dbo].[CainzCustomer] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [FactoryNo] varchar(50)  NOT NULL,
    [FactoryName] nvarchar(100)  NULL,
    [Phone] varchar(100)  NULL,
    [Contact] nvarchar(300)  NULL,
    [Address] nvarchar(200)  NULL,
    [Trader] nvarchar(200)  NULL,
    [SendAddress] nvarchar(200)  NULL,
    [Receiver] nvarchar(200)  NULL,
    [Telephone] varchar(200)  NULL,
    [Remark] varchar(200)  NULL,
    [FirstNum] varchar(500)  NULL,
    [TraderNo] varchar(500)  NULL
);
GO

-- Creating table 'CainzOrderDetail'
CREATE TABLE [dbo].[CainzOrderDetail] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [SnNum] varchar(50)  NOT NULL,
    [OrderNum] varchar(50)  NOT NULL,
    [NitORI] varchar(50)  NOT NULL,
    [ProductCD] varchar(50)  NOT NULL,
    [ProductName] nvarchar(100)  NOT NULL,
    [CdFileName] nvarchar(200)  NULL,
    [PopDesignNo] varchar(200)  NULL,
    [PopSize] varchar(400)  NULL,
    [PaperKind] nvarchar(200)  NULL,
    [PopCate] varchar(30)  NULL,
    [PopCateName] nvarchar(30)  NULL,
    [Colour] varchar(50)  NULL,
    [POPNum] int  NULL,
    [RealNum] int  NULL,
    [UnitNum] int  NOT NULL,
    [UnitName] nvarchar(20)  NOT NULL,
    [ExpectDate] datetime  NULL,
    [Price] decimal(18,4)  NOT NULL,
    [ProbabilityDate] datetime  NOT NULL,
    [ETD] nvarchar(50)  NULL,
    [Reference] nvarchar(50)  NULL,
    [PrintMoney] decimal(18,4)  NOT NULL,
    [CheckMoney] decimal(18,4)  NOT NULL,
    [InvoiceMoney] decimal(18,4)  NOT NULL,
    [Sample] nvarchar(20)  NULL,
    [Status] int  NOT NULL,
    [IsDelete] int  NOT NULL,
    [CreateTime] datetime  NOT NULL,
    [Remark] nvarchar(200)  NULL,
    [BatchNum] nvarchar(200)  NULL
);
GO

-- Creating table 'CainzOrders'
CREATE TABLE [dbo].[CainzOrders] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [OrderNum] varchar(50)  NOT NULL,
    [NitORI] varchar(200)  NOT NULL,
    [CustomerNum] varchar(200)  NOT NULL,
    [CustomerName] nvarchar(300)  NULL,
    [Phone] varchar(500)  NULL,
    [Contact] nvarchar(300)  NULL,
    [Address] nvarchar(400)  NULL,
    [Invoice] nvarchar(400)  NULL,
    [Company] nvarchar(500)  NULL,
    [SendAddress] nvarchar(200)  NULL,
    [Receiver] nvarchar(200)  NULL,
    [Telephone] varchar(400)  NULL,
    [Fax] varchar(500)  NULL,
    [FinanceContact] nvarchar(400)  NULL,
    [BankName] nvarchar(400)  NULL,
    [CardNum] varchar(400)  NULL,
    [Taxpayer] varchar(400)  NULL,
    [SendDate] datetime  NOT NULL,
    [Money] decimal(18,4)  NOT NULL,
    [IsDelete] int  NOT NULL,
    [Status] int  NOT NULL,
    [CreateUserNo] varchar(300)  NOT NULL,
    [CreateUserName] nvarchar(200)  NULL,
    [CreateTime] datetime  NOT NULL,
    [LastUpdate] datetime  NOT NULL,
    [Remark] nvarchar(400)  NULL,
    [FirstNum] varchar(500)  NULL,
    [SecondNum] varchar(500)  NULL,
    [Buyer] varchar(500)  NULL,
    [isDraft] int  NULL
);
GO

-- Creating table 'CainzProduct'
CREATE TABLE [dbo].[CainzProduct] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Barcode] nvarchar(200)  NOT NULL,
    [FactoryID] int  NOT NULL,
    [FactoryName] nvarchar(200)  NOT NULL,
    [Material] nvarchar(200)  NULL,
    [Size] nvarchar(200)  NULL,
    [Color] nvarchar(200)  NULL,
    [Price] decimal(19,4)  NULL,
    [CreateTime] datetime  NOT NULL
);
GO

-- Creating table 'CainzTrader'
CREATE TABLE [dbo].[CainzTrader] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [SnNum] varchar(100)  NOT NULL,
    [ParentNum] varchar(100)  NOT NULL,
    [CateName] nvarchar(100)  NULL,
    [IsDelete] int  NOT NULL,
    [CreateTime] datetime  NOT NULL,
    [Remark] nvarchar(400)  NULL
);
GO

-- Creating table 'CheckProduct'
CREATE TABLE [dbo].[CheckProduct] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [LocaNum] varchar(20)  NOT NULL,
    [LocaName] nvarchar(30)  NOT NULL,
    [ProductNum] varchar(50)  NOT NULL,
    [ProductName] nvarchar(100)  NOT NULL,
    [BarCode] varchar(50)  NOT NULL,
    [RealNum] int  NULL,
    [SouNum] int  NOT NULL,
    [ErrorValue] int  NULL,
    [Status] int  NOT NULL,
    [CreateTime] datetime  NULL
);
GO

-- Creating table 'CheckStorage'
CREATE TABLE [dbo].[CheckStorage] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [CheckNum] varchar(20)  NOT NULL,
    [CheckUser] nvarchar(20)  NULL,
    [CheckTime] datetime  NOT NULL,
    [Status] int  NOT NULL,
    [Time] varchar(20)  NOT NULL,
    [AuditUser] nvarchar(20)  NULL,
    [AuditeTime] datetime  NOT NULL,
    [Reason] nvarchar(400)  NULL,
    [Remark] nvarchar(400)  NULL
);
GO

-- Creating table 'CheckStorageDetail'
CREATE TABLE [dbo].[CheckStorageDetail] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [CheckNum] varchar(20)  NOT NULL,
    [LocaNum] varchar(20)  NOT NULL,
    [LocaName] nvarchar(30)  NOT NULL,
    [LocaBarCode] varchar(20)  NOT NULL,
    [RealProductName] nvarchar(100)  NOT NULL,
    [RealBarCode] varchar(50)  NOT NULL,
    [RealNum] int  NOT NULL,
    [SouProcutName] nvarchar(100)  NOT NULL,
    [SouBarCode] varchar(50)  NOT NULL,
    [SouNum] int  NOT NULL
);
GO

-- Creating table 'Construction'
CREATE TABLE [dbo].[Construction] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [OrderNum] nvarchar(200)  NOT NULL,
    [CompleteDate] datetime  NOT NULL,
    [SendDate] datetime  NOT NULL,
    [PrintNum] nvarchar(100)  NULL,
    [BeginDate] datetime  NOT NULL,
    [CusNum] nvarchar(200)  NULL,
    [CusName] nvarchar(500)  NULL,
    [Phone] varchar(500)  NULL,
    [Revevier] nvarchar(500)  NULL,
    [Address] nvarchar(500)  NULL,
    [Remark] nvarchar(500)  NULL,
    [HouDao] nvarchar(500)  NULL,
    [PrintRequire] nvarchar(500)  NULL,
    [GM] nvarchar(200)  NULL,
    [YM] nvarchar(200)  NULL,
    [PD] nvarchar(200)  NULL,
    [ZD] nvarchar(200)  NULL,
    [UV] nvarchar(200)  NULL,
    [DB] nvarchar(200)  NULL,
    [SG] nvarchar(200)  NULL,
    [ZY] nvarchar(200)  NULL,
    [YH] nvarchar(200)  NULL,
    [GMValue] nvarchar(200)  NULL,
    [YMValue] nvarchar(200)  NULL,
    [PDValue] nvarchar(200)  NULL,
    [ZDValue] nvarchar(200)  NULL,
    [UVValue] nvarchar(200)  NULL,
    [DBValue] nvarchar(200)  NULL,
    [SGValue] nvarchar(200)  NULL,
    [ZYValue] nvarchar(200)  NULL,
    [YHValue] nvarchar(200)  NULL,
    [TJ] nvarchar(200)  NULL,
    [TY] nvarchar(200)  NULL,
    [DH] nvarchar(200)  NULL,
    [AutoSG] nvarchar(200)  NULL,
    [ZDing] nvarchar(200)  NULL,
    [HH] nvarchar(200)  NULL,
    [MQ] nvarchar(200)  NULL,
    [YX] nvarchar(200)  NULL,
    [Other] nvarchar(200)  NULL,
    [TJValue] nvarchar(200)  NULL,
    [TYValue] nvarchar(200)  NULL,
    [DHValue] nvarchar(200)  NULL,
    [AutoSGValue] nvarchar(200)  NULL,
    [ZDingValue] nvarchar(200)  NULL,
    [HHValue] nvarchar(200)  NULL,
    [MQValue] nvarchar(200)  NULL,
    [YXValue] nvarchar(200)  NULL,
    [OtherValue] nvarchar(200)  NULL,
    [WordSize] nvarchar(400)  NULL,
    [WordCount] int  NULL,
    [CTPCount] int  NULL,
    [PSCount] int  NULL,
    [Kaiqie] nvarchar(200)  NULL,
    [CHouDAO] nvarchar(200)  NULL,
    [Qingdian] nvarchar(200)  NULL,
    [CreateUser] nvarchar(500)  NULL,
    [CreateTime] datetime  NULL,
    [IsPrint] int  NULL,
    [PrintTime] datetime  NOT NULL,
    [Status] int  NULL
);
GO

-- Creating table 'ConstructionDetail'
CREATE TABLE [dbo].[ConstructionDetail] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [SnNum] nvarchar(200)  NOT NULL,
    [OrderNum] nvarchar(200)  NOT NULL,
    [BarCode] nvarchar(200)  NULL,
    [ProductName] nvarchar(200)  NULL,
    [PopSize] nvarchar(500)  NULL,
    [PopNum] int  NULL,
    [RealNum] int  NULL,
    [ShenShu] int  NULL,
    [MinNum] int  NULL,
    [Size] nvarchar(500)  NULL,
    [Kshu] nvarchar(500)  NULL,
    [Color] nvarchar(500)  NULL,
    [Positive] int  NULL,
    [Back] int  NULL
);
GO

-- Creating table 'CusAddress'
CREATE TABLE [dbo].[CusAddress] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [AddNum] varchar(50)  NOT NULL,
    [CusNum] varchar(50)  NOT NULL,
    [Phone] varchar(50)  NULL,
    [Contact] nvarchar(50)  NULL,
    [Address] nvarchar(1000)  NULL,
    [IsDelete] int  NULL,
    [CreateTime] datetime  NOT NULL
);
GO

-- Creating table 'CusCategory'
CREATE TABLE [dbo].[CusCategory] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [SnNum] varchar(100)  NOT NULL,
    [ParentNum] varchar(100)  NOT NULL,
    [CateName] nvarchar(100)  NULL,
    [IsDelete] int  NOT NULL,
    [CreateTime] datetime  NOT NULL,
    [Remark] nvarchar(400)  NULL
);
GO

-- Creating table 'Customer'
CREATE TABLE [dbo].[Customer] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [CustomerNum] varchar(50)  NOT NULL,
    [CustomerName] nvarchar(100)  NULL,
    [Phone] varchar(100)  NULL,
    [Contact] nvarchar(300)  NULL,
    [Address] nvarchar(200)  NULL,
    [Invoice] nvarchar(200)  NULL,
    [Company] nvarchar(200)  NULL,
    [SendAddress] nvarchar(200)  NULL,
    [Receiver] nvarchar(200)  NULL,
    [Telephone] varchar(200)  NULL,
    [Fax] varchar(200)  NULL,
    [FinanceContact] nvarchar(200)  NULL,
    [BankName] nvarchar(300)  NULL,
    [CardNum] varchar(400)  NULL,
    [Taxpayer] varchar(200)  NULL,
    [Remark] varchar(200)  NULL,
    [FirstNum] varchar(500)  NULL,
    [SecondNum] varchar(500)  NULL
);
GO

-- Creating table 'Equipment'
CREATE TABLE [dbo].[Equipment] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [EquipmentNum] varchar(20)  NOT NULL,
    [EquipmentName] nvarchar(50)  NOT NULL,
    [EquipmentCode] varchar(20)  NOT NULL,
    [IsImpower] int  NOT NULL,
    [Flag] nvarchar(20)  NULL,
    [IsDelete] int  NOT NULL,
    [CreateTime] datetime  NOT NULL
);
GO

-- Creating table 'InStorage'
CREATE TABLE [dbo].[InStorage] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [InStorNum] varchar(200)  NOT NULL,
    [UserName] nvarchar(200)  NULL,
    [SupNum] varchar(200)  NOT NULL,
    [SupName] varchar(300)  NOT NULL,
    [Status] int  NOT NULL,
    [IsDelete] int  NOT NULL,
    [CreateTime] datetime  NOT NULL,
    [AuditUser] nvarchar(100)  NULL,
    [AuditeTime] datetime  NOT NULL,
    [Reason] nvarchar(400)  NULL,
    [EquipmentNum] varchar(200)  NOT NULL,
    [EquipmentCode] varchar(200)  NOT NULL,
    [InType] int  NOT NULL,
    [ContractOrder] varchar(500)  NOT NULL,
    [Remark] nvarchar(400)  NULL
);
GO

-- Creating table 'InStorDetail'
CREATE TABLE [dbo].[InStorDetail] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [InStorNum] varchar(200)  NOT NULL,
    [ProductName] nvarchar(100)  NOT NULL,
    [BarCode] varchar(500)  NOT NULL,
    [BatchNum] nvarchar(200)  NOT NULL,
    [Num] int  NOT NULL,
    [InPrice] decimal(18,2)  NOT NULL,
    [LocaNum] varchar(100)  NOT NULL
);
GO

-- Creating table 'InStorSingleDetail'
CREATE TABLE [dbo].[InStorSingleDetail] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [InStorDetailID] int  NOT NULL,
    [SingleNum] varchar(50)  NOT NULL,
    [InStorNum] varchar(20)  NOT NULL,
    [ProductName] nvarchar(100)  NOT NULL,
    [BarCode] varchar(50)  NOT NULL,
    [BatchNum] nvarchar(20)  NOT NULL,
    [UserName] nvarchar(20)  NULL,
    [CreateTime] datetime  NOT NULL
);
GO

-- Creating table 'Material'
CREATE TABLE [dbo].[Material] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ProductName] nvarchar(100)  NOT NULL,
    [BarCode] varchar(50)  NOT NULL,
    [ProductNum] varchar(50)  NOT NULL,
    [CdFileName] nvarchar(200)  NULL,
    [PopDesign] nvarchar(200)  NULL,
    [PopSize] nvarchar(200)  NULL,
    [PagerKind] nvarchar(200)  NULL,
    [Colour] nvarchar(200)  NULL,
    [InitNum] int  NOT NULL,
    [Num] int  NOT NULL,
    [WarnNum] int  NOT NULL,
    [Unit] int  NOT NULL,
    [UnitName] varchar(20)  NOT NULL,
    [CategoryNum] varchar(20)  NOT NULL,
    [ProSpec] nvarchar(20)  NOT NULL,
    [Description] varchar(max)  NULL,
    [InPrice] decimal(18,2)  NOT NULL,
    [Price] decimal(18,2)  NOT NULL,
    [IsDelete] int  NOT NULL,
    [CreateTime] datetime  NOT NULL,
    [DefaultLocal] nvarchar(20)  NULL,
    [Status] int  NOT NULL,
    [CusNum] varchar(30)  NULL,
    [CusName] nvarchar(50)  NULL,
    [Remark] nvarchar(max)  NULL
);
GO

-- Creating table 'MaterialCategory'
CREATE TABLE [dbo].[MaterialCategory] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [CategoryNum] varchar(20)  NOT NULL,
    [CategoryName] nvarchar(35)  NOT NULL,
    [IsDelete] int  NOT NULL,
    [CreateTime] datetime  NOT NULL
);
GO

-- Creating table 'MoveSingleDetail'
CREATE TABLE [dbo].[MoveSingleDetail] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [MoveDetailID] int  NOT NULL,
    [SingleNum] varchar(50)  NOT NULL,
    [MoveNum] varchar(20)  NOT NULL,
    [ProductName] nvarchar(100)  NOT NULL,
    [BarCode] varchar(50)  NOT NULL,
    [BatchNum] nvarchar(20)  NOT NULL,
    [UserName] nvarchar(20)  NULL,
    [CreateTime] datetime  NOT NULL
);
GO

-- Creating table 'MoveStorage'
CREATE TABLE [dbo].[MoveStorage] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [MoveNum] varchar(20)  NOT NULL,
    [MoveType] int  NOT NULL,
    [IsDelete] int  NOT NULL,
    [CreateTime] datetime  NOT NULL,
    [Status] int  NOT NULL,
    [UserName] nvarchar(20)  NULL,
    [AuditUser] nvarchar(20)  NULL,
    [AuditeTime] datetime  NOT NULL,
    [Reason] nvarchar(200)  NULL,
    [Remark] nvarchar(400)  NULL
);
GO

-- Creating table 'MoveStorageDetail'
CREATE TABLE [dbo].[MoveStorageDetail] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [MoveNum] varchar(20)  NOT NULL,
    [ProductName] varchar(20)  NOT NULL,
    [BarCode] varchar(50)  NOT NULL,
    [Num] int  NOT NULL,
    [FromNum] varchar(20)  NOT NULL,
    [FromName] nvarchar(30)  NULL,
    [ToNum] varchar(20)  NULL,
    [ToName] nvarchar(30)  NULL,
    [BatchNum] varchar(20)  NULL
);
GO

-- Creating table 'OrderDetail'
CREATE TABLE [dbo].[OrderDetail] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [SnNum] varchar(50)  NOT NULL,
    [OrderNum] varchar(50)  NOT NULL,
    [NitORI] varchar(50)  NOT NULL,
    [ProductCD] varchar(50)  NOT NULL,
    [ProductName] nvarchar(100)  NOT NULL,
    [CdFileName] nvarchar(200)  NULL,
    [PopDesignNo] varchar(200)  NULL,
    [PopSize] varchar(400)  NULL,
    [PaperKind] nvarchar(200)  NULL,
    [PopCate] varchar(30)  NULL,
    [PopCateName] nvarchar(30)  NULL,
    [Colour] varchar(50)  NULL,
    [POPNum] int  NULL,
    [RealNum] int  NULL,
    [UnitNum] int  NOT NULL,
    [UnitName] nvarchar(20)  NOT NULL,
    [ExpectDate] datetime  NULL,
    [Price] decimal(18,4)  NOT NULL,
    [ProbabilityDate] datetime  NOT NULL,
    [ETD] nvarchar(50)  NULL,
    [Reference] nvarchar(50)  NULL,
    [PrintMoney] decimal(18,4)  NOT NULL,
    [CheckMoney] decimal(18,4)  NOT NULL,
    [InvoiceMoney] decimal(18,4)  NOT NULL,
    [Sample] nvarchar(20)  NULL,
    [Status] int  NOT NULL,
    [IsDelete] int  NOT NULL,
    [CreateTime] datetime  NOT NULL,
    [Remark] nvarchar(200)  NULL,
    [BatchNum] nvarchar(200)  NULL
);
GO

-- Creating table 'Orders'
CREATE TABLE [dbo].[Orders] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [OrderNum] varchar(50)  NOT NULL,
    [NitORI] varchar(200)  NOT NULL,
    [CustomerNum] varchar(200)  NOT NULL,
    [CustomerName] nvarchar(300)  NULL,
    [Phone] varchar(500)  NULL,
    [Contact] nvarchar(300)  NULL,
    [Address] nvarchar(400)  NULL,
    [Invoice] nvarchar(400)  NULL,
    [Company] nvarchar(500)  NULL,
    [SendAddress] nvarchar(200)  NULL,
    [Receiver] nvarchar(200)  NULL,
    [Telephone] varchar(400)  NULL,
    [Fax] varchar(500)  NULL,
    [FinanceContact] nvarchar(400)  NULL,
    [BankName] nvarchar(400)  NULL,
    [CardNum] varchar(400)  NULL,
    [Taxpayer] varchar(400)  NULL,
    [SendDate] datetime  NOT NULL,
    [Money] decimal(18,4)  NOT NULL,
    [IsDelete] int  NOT NULL,
    [Status] int  NOT NULL,
    [CreateUserNo] varchar(300)  NOT NULL,
    [CreateUserName] nvarchar(200)  NULL,
    [CreateTime] datetime  NOT NULL,
    [LastUpdate] datetime  NOT NULL,
    [Remark] nvarchar(400)  NULL,
    [FirstNum] varchar(500)  NULL,
    [SecondNum] varchar(500)  NULL,
    [Buyer] varchar(500)  NULL
);
GO

-- Creating table 'OutStoDetail'
CREATE TABLE [dbo].[OutStoDetail] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [OrderNum] varchar(200)  NOT NULL,
    [ProductName] nvarchar(300)  NOT NULL,
    [BarCode] varchar(300)  NOT NULL,
    [Num] int  NOT NULL,
    [TotalPrice] decimal(19,4)  NOT NULL,
    [RealPrice] decimal(19,4)  NOT NULL,
    [LocaNum] varchar(200)  NOT NULL,
    [BatchNum] varchar(200)  NOT NULL
);
GO

-- Creating table 'OutStorage'
CREATE TABLE [dbo].[OutStorage] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [OrderNum] varchar(200)  NOT NULL,
    [CusNum] varchar(200)  NULL,
    [CusName] nvarchar(200)  NOT NULL,
    [Mobile] varchar(150)  NULL,
    [Phone] varchar(200)  NULL,
    [PCode] varchar(100)  NULL,
    [CCode] varchar(100)  NULL,
    [Address] nvarchar(500)  NULL,
    [IsDelete] int  NOT NULL,
    [CreateTime] datetime  NOT NULL,
    [UserName] nvarchar(200)  NULL,
    [Status] int  NOT NULL,
    [AuditUser] nvarchar(200)  NULL,
    [AuditeTime] datetime  NOT NULL,
    [Reason] nvarchar(400)  NULL,
    [EquipmentNum] varchar(200)  NOT NULL,
    [EquipmentCode] varchar(200)  NOT NULL,
    [OutType] int  NOT NULL,
    [ContractOrder] varchar(500)  NULL,
    [Remark] nvarchar(400)  NULL
);
GO

-- Creating table 'OutStorSingleDetail'
CREATE TABLE [dbo].[OutStorSingleDetail] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [OutStorDetailID] int  NOT NULL,
    [SingleNum] varchar(50)  NOT NULL,
    [OrderNum] varchar(20)  NOT NULL,
    [ProductName] nvarchar(100)  NOT NULL,
    [BarCode] varchar(50)  NOT NULL,
    [BatchNum] nvarchar(20)  NOT NULL,
    [UserName] nvarchar(20)  NULL,
    [CreateTime] datetime  NOT NULL
);
GO

-- Creating table 'ProBatch'
CREATE TABLE [dbo].[ProBatch] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [BarCode] varchar(50)  NOT NULL,
    [ProductName] nvarchar(50)  NULL,
    [BatchNum] varchar(20)  NOT NULL,
    [Num] int  NOT NULL,
    [CreateTime] datetime  NOT NULL,
    [UserName] nvarchar(20)  NULL
);
GO

-- Creating table 'ProCategory'
CREATE TABLE [dbo].[ProCategory] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [CategoryNum] varchar(200)  NOT NULL,
    [CategoryName] nvarchar(200)  NOT NULL,
    [IsDelete] int  NOT NULL,
    [CreateTime] datetime  NOT NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ProductName] nvarchar(200)  NOT NULL,
    [BarCode] varchar(100)  NOT NULL,
    [ProductNum] varchar(100)  NOT NULL,
    [CdFileName] nvarchar(200)  NULL,
    [PopDesign] nvarchar(200)  NULL,
    [PopSize] nvarchar(200)  NULL,
    [PagerKind] nvarchar(200)  NULL,
    [Colour] nvarchar(200)  NULL,
    [InitNum] int  NOT NULL,
    [Num] int  NOT NULL,
    [WarnNum] int  NOT NULL,
    [Unit] int  NOT NULL,
    [UnitName] varchar(200)  NOT NULL,
    [CategoryNum] varchar(200)  NOT NULL,
    [ProSpec] nvarchar(200)  NOT NULL,
    [Description] varchar(max)  NULL,
    [InPrice] decimal(18,3)  NOT NULL,
    [Price] decimal(18,3)  NOT NULL,
    [IsDelete] int  NOT NULL,
    [CreateTime] datetime  NOT NULL,
    [DefaultLocal] nvarchar(200)  NULL,
    [Status] int  NOT NULL,
    [CusNum] varchar(300)  NULL,
    [CusName] nvarchar(500)  NULL,
    [Remark] nvarchar(max)  NULL
);
GO

-- Creating table 'ProShatter'
CREATE TABLE [dbo].[ProShatter] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [OrderNum] varchar(20)  NOT NULL,
    [UserName] nvarchar(20)  NULL,
    [Reason] nvarchar(400)  NULL,
    [IsDelete] int  NOT NULL,
    [CreateTime] datetime  NOT NULL,
    [AuditUser] nvarchar(20)  NULL,
    [AuditTime] datetime  NOT NULL,
    [Status] int  NOT NULL,
    [IsMoveLoca] int  NOT NULL,
    [MoveLocaNum] varchar(20)  NULL,
    [Remark] nvarchar(400)  NULL
);
GO

-- Creating table 'ProShatterDetail'
CREATE TABLE [dbo].[ProShatterDetail] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [OrderNum] varchar(20)  NOT NULL,
    [Barcode] varchar(20)  NOT NULL,
    [ProductName] nvarchar(100)  NOT NULL,
    [Num] int  NOT NULL,
    [LocaNum] varchar(20)  NOT NULL,
    [LocaName] nvarchar(30)  NOT NULL,
    [BatchNum] varchar(20)  NULL
);
GO

-- Creating table 'ProSingle'
CREATE TABLE [dbo].[ProSingle] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [BarCode] varchar(50)  NOT NULL,
    [ProductName] nvarchar(50)  NULL,
    [BatchNum] varchar(20)  NOT NULL,
    [SingleNum] varchar(50)  NOT NULL,
    [IsDelete] int  NOT NULL,
    [CreateTime] datetime  NOT NULL
);
GO

-- Creating table 'ShatterSingleDetail'
CREATE TABLE [dbo].[ShatterSingleDetail] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ProShatterDetailID] int  NOT NULL,
    [SingleNum] varchar(50)  NOT NULL,
    [OrderNum] varchar(20)  NOT NULL,
    [ProductName] nvarchar(100)  NOT NULL,
    [BarCode] varchar(50)  NOT NULL,
    [BatchNum] nvarchar(20)  NOT NULL,
    [UserName] nvarchar(20)  NULL,
    [CreateTime] datetime  NOT NULL
);
GO

-- Creating table 'StoLocation'
CREATE TABLE [dbo].[StoLocation] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [LocaNum] varchar(20)  NOT NULL,
    [LocaName] nvarchar(30)  NOT NULL,
    [LocaBarCode] varchar(20)  NOT NULL,
    [Space] varchar(20)  NULL,
    [Unit] int  NOT NULL,
    [UnitName] varchar(20)  NOT NULL,
    [Remark] nvarchar(4000)  NULL,
    [Status] int  NOT NULL,
    [IsDelete] int  NOT NULL,
    [CreateTime] datetime  NOT NULL
);
GO

-- Creating table 'StoProRelation'
CREATE TABLE [dbo].[StoProRelation] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [LocaNum] varchar(20)  NOT NULL,
    [BarCode] varchar(50)  NOT NULL,
    [BatchNum] varchar(20)  NOT NULL,
    [Num] int  NOT NULL
);
GO

-- Creating table 'Supplier'
CREATE TABLE [dbo].[Supplier] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [SupNum] varchar(20)  NOT NULL,
    [SupName] nvarchar(35)  NOT NULL,
    [Company] nvarchar(30)  NULL,
    [Phone] varchar(20)  NULL,
    [Mobile] varchar(20)  NULL,
    [Fax] varchar(20)  NULL,
    [Email] varchar(30)  NULL,
    [ContactName] nvarchar(20)  NULL,
    [PCode] varchar(10)  NULL,
    [CCode] varchar(10)  NULL,
    [Address] nvarchar(100)  NULL,
    [BankName] nvarchar(20)  NULL,
    [BankCard] varchar(30)  NULL,
    [Description] varchar(max)  NULL,
    [IsDelete] int  NOT NULL,
    [CreateTime] datetime  NOT NULL
);
GO

-- Creating table 'SysAdmin'
CREATE TABLE [dbo].[SysAdmin] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [UserName] varchar(20)  NOT NULL,
    [PassWord] varchar(50)  NOT NULL,
    [UserCode] varchar(40)  NOT NULL,
    [RealName] nvarchar(20)  NOT NULL,
    [Email] varchar(30)  NULL,
    [Mobile] char(11)  NULL,
    [CreateTime] datetime  NOT NULL,
    [LoginCount] int  NOT NULL,
    [IsDelete] int  NOT NULL,
    [RoleID] int  NOT NULL,
    [Remark] nvarchar(20)  NULL
);
GO

-- Creating table 'SysRelation'
CREATE TABLE [dbo].[SysRelation] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [RoleID] int  NOT NULL,
    [MenuID] int  NOT NULL
);
GO

-- Creating table 'SysResource'
CREATE TABLE [dbo].[SysResource] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ResName] nvarchar(20)  NOT NULL,
    [ParentID] int  NOT NULL,
    [Sort] int  NOT NULL,
    [IsDelete] int  NOT NULL,
    [Url] varchar(200)  NOT NULL,
    [CssName] varchar(15)  NOT NULL,
    [CreateTime] datetime  NOT NULL,
    [Depart] int  NOT NULL,
    [ResType] int  NOT NULL,
    [Remark] nvarchar(200)  NULL
);
GO

-- Creating table 'SysRole'
CREATE TABLE [dbo].[SysRole] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [RoleName] nvarchar(20)  NOT NULL,
    [ParentID] int  NOT NULL,
    [CreateTime] datetime  NOT NULL,
    [Remark] nvarchar(200)  NULL
);
GO

-- Creating table 'VnCity'
CREATE TABLE [dbo].[VnCity] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Code] varchar(10)  NOT NULL,
    [CName] nvarchar(15)  NOT NULL,
    [CNameEn] varchar(30)  NULL,
    [PCode] varchar(10)  NOT NULL
);
GO

-- Creating table 'VnProvince'
CREATE TABLE [dbo].[VnProvince] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Code] varchar(10)  NOT NULL,
    [PName] nvarchar(15)  NOT NULL,
    [PNameEn] varchar(30)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'BadProductLocal'
ALTER TABLE [dbo].[BadProductLocal]
ADD CONSTRAINT [PK_BadProductLocal]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'CainzCustomer'
ALTER TABLE [dbo].[CainzCustomer]
ADD CONSTRAINT [PK_CainzCustomer]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'CainzOrderDetail'
ALTER TABLE [dbo].[CainzOrderDetail]
ADD CONSTRAINT [PK_CainzOrderDetail]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'CainzOrders'
ALTER TABLE [dbo].[CainzOrders]
ADD CONSTRAINT [PK_CainzOrders]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'CainzProduct'
ALTER TABLE [dbo].[CainzProduct]
ADD CONSTRAINT [PK_CainzProduct]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'CainzTrader'
ALTER TABLE [dbo].[CainzTrader]
ADD CONSTRAINT [PK_CainzTrader]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'CheckProduct'
ALTER TABLE [dbo].[CheckProduct]
ADD CONSTRAINT [PK_CheckProduct]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'CheckStorage'
ALTER TABLE [dbo].[CheckStorage]
ADD CONSTRAINT [PK_CheckStorage]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'CheckStorageDetail'
ALTER TABLE [dbo].[CheckStorageDetail]
ADD CONSTRAINT [PK_CheckStorageDetail]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Construction'
ALTER TABLE [dbo].[Construction]
ADD CONSTRAINT [PK_Construction]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ConstructionDetail'
ALTER TABLE [dbo].[ConstructionDetail]
ADD CONSTRAINT [PK_ConstructionDetail]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'CusAddress'
ALTER TABLE [dbo].[CusAddress]
ADD CONSTRAINT [PK_CusAddress]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'CusCategory'
ALTER TABLE [dbo].[CusCategory]
ADD CONSTRAINT [PK_CusCategory]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Customer'
ALTER TABLE [dbo].[Customer]
ADD CONSTRAINT [PK_Customer]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Equipment'
ALTER TABLE [dbo].[Equipment]
ADD CONSTRAINT [PK_Equipment]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'InStorage'
ALTER TABLE [dbo].[InStorage]
ADD CONSTRAINT [PK_InStorage]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'InStorDetail'
ALTER TABLE [dbo].[InStorDetail]
ADD CONSTRAINT [PK_InStorDetail]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'InStorSingleDetail'
ALTER TABLE [dbo].[InStorSingleDetail]
ADD CONSTRAINT [PK_InStorSingleDetail]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Material'
ALTER TABLE [dbo].[Material]
ADD CONSTRAINT [PK_Material]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'MaterialCategory'
ALTER TABLE [dbo].[MaterialCategory]
ADD CONSTRAINT [PK_MaterialCategory]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'MoveSingleDetail'
ALTER TABLE [dbo].[MoveSingleDetail]
ADD CONSTRAINT [PK_MoveSingleDetail]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'MoveStorage'
ALTER TABLE [dbo].[MoveStorage]
ADD CONSTRAINT [PK_MoveStorage]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'MoveStorageDetail'
ALTER TABLE [dbo].[MoveStorageDetail]
ADD CONSTRAINT [PK_MoveStorageDetail]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'OrderDetail'
ALTER TABLE [dbo].[OrderDetail]
ADD CONSTRAINT [PK_OrderDetail]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [PK_Orders]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'OutStoDetail'
ALTER TABLE [dbo].[OutStoDetail]
ADD CONSTRAINT [PK_OutStoDetail]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'OutStorage'
ALTER TABLE [dbo].[OutStorage]
ADD CONSTRAINT [PK_OutStorage]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'OutStorSingleDetail'
ALTER TABLE [dbo].[OutStorSingleDetail]
ADD CONSTRAINT [PK_OutStorSingleDetail]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ProBatch'
ALTER TABLE [dbo].[ProBatch]
ADD CONSTRAINT [PK_ProBatch]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ProCategory'
ALTER TABLE [dbo].[ProCategory]
ADD CONSTRAINT [PK_ProCategory]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ProShatter'
ALTER TABLE [dbo].[ProShatter]
ADD CONSTRAINT [PK_ProShatter]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ProShatterDetail'
ALTER TABLE [dbo].[ProShatterDetail]
ADD CONSTRAINT [PK_ProShatterDetail]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ProSingle'
ALTER TABLE [dbo].[ProSingle]
ADD CONSTRAINT [PK_ProSingle]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ShatterSingleDetail'
ALTER TABLE [dbo].[ShatterSingleDetail]
ADD CONSTRAINT [PK_ShatterSingleDetail]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'StoLocation'
ALTER TABLE [dbo].[StoLocation]
ADD CONSTRAINT [PK_StoLocation]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'StoProRelation'
ALTER TABLE [dbo].[StoProRelation]
ADD CONSTRAINT [PK_StoProRelation]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Supplier'
ALTER TABLE [dbo].[Supplier]
ADD CONSTRAINT [PK_Supplier]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'SysAdmin'
ALTER TABLE [dbo].[SysAdmin]
ADD CONSTRAINT [PK_SysAdmin]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'SysRelation'
ALTER TABLE [dbo].[SysRelation]
ADD CONSTRAINT [PK_SysRelation]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'SysResource'
ALTER TABLE [dbo].[SysResource]
ADD CONSTRAINT [PK_SysResource]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'SysRole'
ALTER TABLE [dbo].[SysRole]
ADD CONSTRAINT [PK_SysRole]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'VnCity'
ALTER TABLE [dbo].[VnCity]
ADD CONSTRAINT [PK_VnCity]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'VnProvince'
ALTER TABLE [dbo].[VnProvince]
ADD CONSTRAINT [PK_VnProvince]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------