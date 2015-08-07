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
	[OrderDetailId] [uniqueidentifier] NOT NULL,--主键
	[OrderId] [uniqueidentifier] NOT NULL,		--订单主键
	[RowNo] [int] NULL,							--临时用 项次号
	[ProductId] [uniqueidentifier] NOT NULL,	--产品编号
	[ProductBarcode] [nvarchar](200) NOT NULL,	--产品条码
	[ProductName] [nvarchar](200) NOT NULL,		--产品名称
	[ProductPrice] [decimal](18, 4) NOT NULL,	--产品价格
	[OrderNum] [int] NOT NULL,					--订购数量
	[CdFileName] [nvarchar](200) NULL,			--文件名
	--[PopDesignNo] [nvarchar](200) NULL,			
	[PopSize] [nvarchar](200) NULL,				--印刷品尺寸
	[PopMaterial] [nvarchar](200) NULL,			--材质
	[PopCategory] [nvarchar](200) NULL,			--类别
	[PopCateName] [nvarchar](200) NULL,			--类别名称
	[Color] [nvarchar](200) NULL,				--颜色
	--[POPNum] [int] NULL,
	--[RealNum] [int] NULL,
	[UnitId] [uniqueidentifier]  NULL,			--计量单位编号
	[UnitName] [nvarchar](20)  NULL,			--计量单位名称
	[ExpectDate] [datetime] NULL,				--期望交货日期
	[ExpectDateFormat] [nvarchar](200) NULL,	--格式化的交货日期 yyyyMMdd
	--[ProbabilityDate] [datetime] NOT NULL,	--?
	--[ETD] [nvarchar](200) NULL,
	--[Reference] [nvarchar](50) NULL,
	--[PrintMoney] [decimal](18, 4) NOT NULL,
	--[CheckMoney] [decimal](18, 4) NOT NULL,
	--[InvoiceMoney] [decimal](18, 4) NOT NULL,
	[Sample] [nvarchar](20) NULL,				--样品
	[Status] [int] NOT NULL,					--状态
	[IsDelete] [int] NOT NULL,					--是否删除 0 未删除 1删除
	[CreateTime] [datetime] NOT NULL,			--创建日期
	[Remark] [nvarchar](200) NULL,				--备注
	[BatchNo] [nvarchar](200) NULL,				--批次
 CONSTRAINT [PK_CainzOrderDetail] PRIMARY KEY CLUSTERED 
(
	[OrderDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO


