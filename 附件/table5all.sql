
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/08/2015 16:47:40
-- Generated from EDMX file: C:\Users\½¨Î°\Documents\GitHub\jcordersheetcreator\entity\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [db002];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CainzFactory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CainzFactory];
GO
IF OBJECT_ID(N'[dbo].[CainzOrder]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CainzOrder];
GO
IF OBJECT_ID(N'[dbo].[CainzOrderDetail]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CainzOrderDetail];
GO
IF OBJECT_ID(N'[dbo].[CainzProduct]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CainzProduct];
GO
IF OBJECT_ID(N'[dbo].[CainzTrader]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CainzTrader];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CainzFactory'
CREATE TABLE [dbo].[CainzFactory] (
    [FactoryID] uniqueidentifier  NOT NULL,
    [FactoryName] nvarchar(100)  NOT NULL,
    [FactoryNameJP] varchar(100)  NOT NULL,
    [FactoryAddress] nvarchar(200)  NULL,
    [TraderID] uniqueidentifier  NULL,
    [TraderName] nvarchar(200)  NULL,
    [Contact] nvarchar(300)  NULL,
    [ContactPhone] varchar(100)  NULL,
    [Receiver] nvarchar(200)  NULL,
    [ReceiverPhone] varchar(200)  NULL,
    [Remark] varchar(200)  NULL,
    [CreateTime] datetime  NOT NULL,
    [Deleted] int  NOT NULL,
    [CainzTraderTraderID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'CainzOrder'
CREATE TABLE [dbo].[CainzOrder] (
    [OrderID] uniqueidentifier  NOT NULL,
    [OrderNo] varchar(50)  NULL,
	[OrderExNo] varchar(50)  NULL,
    [FactoryID] uniqueidentifier  NULL,
    [TraderName] nvarchar(300)  NULL,
	[TraderID] uniqueidentifier  NULL,
    [FactoryName] nvarchar(300)  NULL,
    [Phone] varchar(500)  NULL,
    [Contact] nvarchar(300)  NULL,
    [Address] nvarchar(400)  NULL,
    [Receiver] nvarchar(200)  NULL,
    [SendDate] datetime  NULL,
    [Money] decimal(18,4)  NOT NULL,
    [Status] int  NULL,
    [CreatorID] uniqueidentifier  NULL,
    [Creator] nvarchar(200)  NULL,
    [LastUpdate] datetime  NULL,
    [Buyer] varchar(200)  NULL,
    [Remark] nvarchar(400)  NULL,
    [isDraft] int  NULL,
    [IsDelete] int  NOT NULL,
    [CreateTime] datetime  NOT NULL,
    [CainzFactoryFactoryID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'CainzOrderDetail'
CREATE TABLE [dbo].[CainzOrderDetail] (
    [OrderDetailID] uniqueidentifier  NOT NULL,
    [OrderID] uniqueidentifier  NOT NULL,
    [RowNo] int  NULL,
    [ProductID] uniqueidentifier  NOT NULL,
    [ProductBarcode] nvarchar(100)  NOT NULL,
    [ProductName] nvarchar(200)  NULL,
    [ProductMaterial] nvarchar(200)  NULL,
    [ProductSize] nvarchar(200)  NULL,
    [ProductColor] nvarchar(200)  NULL,
    [ProductPrice] decimal(19,4)  NULL,
    [POPNum] int  NULL,
    [UnitID] uniqueidentifier  NULL,
    [UnitName] nvarchar(20)  NULL,
    [ExpectDate] datetime  NULL,
    [ExpectDateFormat] nvarchar(200)  NULL,
    [TotalMoney] decimal(18,4)  NOT NULL,
    [Sample] nvarchar(20)  NULL,
    [Status] int  NOT NULL,
    [IsDelete] int  NOT NULL,
    [CreateTime] datetime  NOT NULL,
    [Remark] nvarchar(200)  NULL,
    [BatchNo] nvarchar(200)  NULL,
    [CainzOrderOrderID] uniqueidentifier  NOT NULL,
    [CainzProductProductID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'CainzProduct'
CREATE TABLE [dbo].[CainzProduct] (
    [ProductID] uniqueidentifier  NOT NULL,
    [ProductBarcode] nvarchar(100)  NOT NULL,
    [ProductName] nvarchar(200)  NULL,
    [ProductMaterial] nvarchar(200)  NULL,
    [ProductSize] nvarchar(200)  NULL,
    [ProductColor] nvarchar(200)  NULL,
    [ProductPrice] decimal(19,4)  NULL,
    [CreateTime] datetime  NOT NULL,
    [Deleted] int  NOT NULL,
    [ModifyTime] datetime  NOT NULL,
    [Modified] int  NOT NULL,
    [TraderID] uniqueidentifier  NULL,
    [TraderName] nvarchar(200)  NULL,
    [CainzTraderTraderID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'CainzTrader'
CREATE TABLE [dbo].[CainzTrader] (
    [TraderID] uniqueidentifier  NOT NULL,
    [TraderName] nvarchar(200)  NULL,
    [TraderShortName] nvarchar(200)  NULL,
    [IsDelete] int  NOT NULL,
    [CreateTime] datetime  NOT NULL,
    [Remark] nvarchar(400)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [FactoryID] in table 'CainzFactory'
ALTER TABLE [dbo].[CainzFactory]
ADD CONSTRAINT [PK_CainzFactory]
    PRIMARY KEY CLUSTERED ([FactoryID] ASC);
GO

-- Creating primary key on [OrderID] in table 'CainzOrder'
ALTER TABLE [dbo].[CainzOrder]
ADD CONSTRAINT [PK_CainzOrder]
    PRIMARY KEY CLUSTERED ([OrderID] ASC);
GO

-- Creating primary key on [OrderDetailID] in table 'CainzOrderDetail'
ALTER TABLE [dbo].[CainzOrderDetail]
ADD CONSTRAINT [PK_CainzOrderDetail]
    PRIMARY KEY CLUSTERED ([OrderDetailID] ASC);
GO

-- Creating primary key on [ProductID] in table 'CainzProduct'
ALTER TABLE [dbo].[CainzProduct]
ADD CONSTRAINT [PK_CainzProduct]
    PRIMARY KEY CLUSTERED ([ProductID] ASC);
GO

-- Creating primary key on [TraderID] in table 'CainzTrader'
ALTER TABLE [dbo].[CainzTrader]
ADD CONSTRAINT [PK_CainzTrader]
    PRIMARY KEY CLUSTERED ([TraderID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CainzTraderTraderID] in table 'CainzFactory'
ALTER TABLE [dbo].[CainzFactory]
ADD CONSTRAINT [FK_CainzTraderCainzFactory]
    FOREIGN KEY ([CainzTraderTraderID])
    REFERENCES [dbo].[CainzTrader]
        ([TraderID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CainzTraderCainzFactory'
CREATE INDEX [IX_FK_CainzTraderCainzFactory]
ON [dbo].[CainzFactory]
    ([CainzTraderTraderID]);
GO

-- Creating foreign key on [CainzFactoryFactoryID] in table 'CainzOrder'
ALTER TABLE [dbo].[CainzOrder]
ADD CONSTRAINT [FK_CainzFactoryCainzOrder]
    FOREIGN KEY ([CainzFactoryFactoryID])
    REFERENCES [dbo].[CainzFactory]
        ([FactoryID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CainzFactoryCainzOrder'
CREATE INDEX [IX_FK_CainzFactoryCainzOrder]
ON [dbo].[CainzOrder]
    ([CainzFactoryFactoryID]);
GO

-- Creating foreign key on [CainzOrderOrderID] in table 'CainzOrderDetail'
ALTER TABLE [dbo].[CainzOrderDetail]
ADD CONSTRAINT [FK_CainzOrderCainzOrderDetail]
    FOREIGN KEY ([CainzOrderOrderID])
    REFERENCES [dbo].[CainzOrder]
        ([OrderID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CainzOrderCainzOrderDetail'
CREATE INDEX [IX_FK_CainzOrderCainzOrderDetail]
ON [dbo].[CainzOrderDetail]
    ([CainzOrderOrderID]);
GO

-- Creating foreign key on [CainzProductProductID] in table 'CainzOrderDetail'
ALTER TABLE [dbo].[CainzOrderDetail]
ADD CONSTRAINT [FK_CainzOrderDetailCainzProduct]
    FOREIGN KEY ([CainzProductProductID])
    REFERENCES [dbo].[CainzProduct]
        ([ProductID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CainzOrderDetailCainzProduct'
CREATE INDEX [IX_FK_CainzOrderDetailCainzProduct]
ON [dbo].[CainzOrderDetail]
    ([CainzProductProductID]);
GO

-- Creating foreign key on [CainzTraderTraderID] in table 'CainzProduct'
ALTER TABLE [dbo].[CainzProduct]
ADD CONSTRAINT [FK_CainzProductCainzTrader]
    FOREIGN KEY ([CainzTraderTraderID])
    REFERENCES [dbo].[CainzTrader]
        ([TraderID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CainzProductCainzTrader'
CREATE INDEX [IX_FK_CainzProductCainzTrader]
ON [dbo].[CainzProduct]
    ([CainzTraderTraderID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------