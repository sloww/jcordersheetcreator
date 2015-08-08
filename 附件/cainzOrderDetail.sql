USE [db002]
GO

/****** Object:  Table [dbo].[CainzOrderDetail]    Script Date: 2015-08-07 20:10:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[CainzOrderDetail]
GO

CREATE TABLE [dbo].[CainzOrderDetail](

	[OrderDetailID] [uniqueidentifier] NOT NULL,--主键
	[OrderID] [uniqueidentifier] NOT NULL,		--订单主键
	[RowNo] [int] NULL,							--临时用 项次号

	[ProductID] [uniqueidentifier] NOT NULL,	--ID号码 *
	[ProductBarcode] [nvarchar](100) NOT NULL,	--条形码 *
	[ProductName] [nvarchar](200) NULL,			--产品名称
	[ProductMaterial] [nvarchar](200) NULL,		--产品材质
	[ProductSize] [nvarchar](200) NULL,			--产品尺寸
	[ProductColor] [nvarchar](200) NULL,		--产品颜色
	[ProductPrice] [money] NULL,				--产品单价

	[POPNum] [int] default 0 NULL,

	[UnitID] [uniqueidentifier]  NULL,			--计量单位编号
	[UnitName] [nvarchar](20)  NULL,			--计量单位名称
	[ExpectDate] [datetime] NULL,				--期望交货日期
	[ExpectDateFormat] [nvarchar](200) NULL,	--格式化的交货日期 yyyyMMdd
	[TotalMoney] [decimal](18, 4) NOT NULL,		--小计
	[Sample] [nvarchar](20) NULL,				--样品
	[Status] [int] default 0 NOT NULL,			--状态
	[IsDelete] [int] default 0 NOT NULL,		--是否删除 0 未删除 1删除
	[CreateTime] [datetime] default getdate() NOT NULL,	--创建日期
	[Remark] [nvarchar](200) NULL,				--备注
	[BatchNo] [nvarchar](200) NULL,				--批次

 CONSTRAINT [PK_CainzOrderDetail] PRIMARY KEY CLUSTERED 
(
	[OrderDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO


