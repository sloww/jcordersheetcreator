
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/30/2015 00:13:45
-- Generated from EDMX file: C:\Users\建伟\Documents\GitHub\jcordersheetcreator\entity\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [db001];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

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
IF OBJECT_ID(N'[dbo].[CusCategory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CusCategory];
GO
IF OBJECT_ID(N'[dbo].[Customer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customer];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

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
    [TraderNo] varchar(500)  NULL,
    [FactoryNameJP] varchar(500)  NULL
);
GO

-- Creating table 'CainzOrderDetail'
CREATE TABLE [dbo].[CainzOrderDetail] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [SnNum] nvarchar(200)  NOT NULL,
    [OrderNum] int  NOT NULL,
    [NitORI] nvarchar(200)  NOT NULL,
    [ProductCD] nvarchar(200)  NOT NULL,
    [ProductName] nvarchar(200)  NOT NULL,
    [CdFileName] nvarchar(200)  NULL,
    [PopDesignNo] nvarchar(200)  NULL,
    [PopSize] nvarchar(200)  NULL,
    [PaperKind] nvarchar(200)  NULL,
    [PopCate] nvarchar(200)  NULL,
    [PopCateName] nvarchar(200)  NULL,
    [Colour] nvarchar(200)  NULL,
    [POPNum] int  NULL,
    [RealNum] int  NULL,
    [UnitNum] int  NOT NULL,
    [UnitName] nvarchar(20)  NOT NULL,
    [ExpectDate] datetime  NULL,
    [Price] decimal(18,4)  NOT NULL,
    [ProbabilityDate] datetime  NOT NULL,
    [ETD] nvarchar(200)  NULL,
    [Reference] nvarchar(50)  NULL,
    [PrintMoney] decimal(18,4)  NOT NULL,
    [CheckMoney] decimal(18,4)  NOT NULL,
    [InvoiceMoney] decimal(18,4)  NOT NULL,
    [Sample] nvarchar(20)  NULL,
    [Status] int  NOT NULL,
    [IsDelete] int  NOT NULL,
    [CreateTime] datetime  NOT NULL,
    [Remark] nvarchar(200)  NULL,
    [BatchNum] nvarchar(200)  NULL,
    [RowNo] int  NULL
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

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

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

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------