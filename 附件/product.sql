USE [db002]
GO


/****** Object:  Table [dbo].[CainzProduct]    Script Date: 2015-08-08 12:28:26 ******/
DROP TABLE [dbo].[CainzProduct]
GO

/****** Object:  Table [dbo].[CainzProduct]    Script Date: 2015-08-08 12:28:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CainzProduct](
	[ProductID] [uniqueidentifier] NOT NULL,				--ID号码 *
	[ProductBarcode] [nvarchar](100) NOT NULL,				--条形码 *
	[ProductName] [nvarchar](200) NULL,						--产品名称
	[ProductMaterial] [nvarchar](200) NULL,					--产品材质
	[ProductSize] [nvarchar](200) NULL,						--产品尺寸
	[ProductColor] [nvarchar](200) NULL,					--产品颜色
	[ProductPrice] [money] NULL,							--产品单价
	[CreateTime] [datetime] default getdate() NOT NULL,		--创建时间
	[Deleted] [int] default 0 NOT NULL,						--是否删除 *
	[ModifyTime] [datetime] default getdate() NOT NULL,		--修改日期
	[Modified] [int] default 0 NOT NULL,					--是否修改
	[TraderID] [uniqueidentifier] NULL,						--贸易商编号
	[TraderName] [nvarchar](200) NULL,						--贸易商名称
 CONSTRAINT [PK_CainzProduct] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO

CREATE INDEX [Index_CainzProduct_barcode] on [dbo].[CainzProduct] ([ProductBarcode])


