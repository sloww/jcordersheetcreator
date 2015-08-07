USE [db002]
GO

/****** Object:  Table [dbo].[CainzOrder]    Script Date: 2015-08-07 21:10:17 ******/
--DROP TABLE [dbo].[CainzOrder]
GO

/****** Object:  Table [dbo].[CainzOrder]    Script Date: 2015-08-07 21:10:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[CainzOrder](
	[OrderId] [uniqueidentifier] NOT NULL,		--主键
	[OrderNo] [varchar](50) NOT NULL,			--订单编号
	[NitORI] [varchar](200) NOT NULL,
	[CustomerId] [uniqueidentifier] NOT NULL,	--客户编号 这里一般是指工厂
	[CustomerName] [nvarchar](300) NULL,		--客户名称
	[Phone] [varchar](500) NULL,				--电话
	[Contact] [nvarchar](300) NULL,				--联系人
	[Address] [nvarchar](400) NULL,				--地址
	--[Invoice] [nvarchar](400) NULL,
	--[Company] [nvarchar](500) NULL,
	[SendAddress] [nvarchar](200) NULL,			--送货地址
	[Receiver] [nvarchar](200) NULL,			--接收人
	[Telephone] [varchar](400) NULL,			--电话
	--[Fax] [varchar](500) NULL,
	--[FinanceContact] [nvarchar](400) NULL,
	--[BankName] [nvarchar](400) NULL,
	--[CardNum] [varchar](400) NULL,
	--[Taxpayer] [varchar](400) NULL,
	[SendDate] [datetime] NOT NULL,
	[Money] [decimal](18, 4) NOT NULL,			--发货日期
	[Status] [int] NOT NULL,					--状态

	[CreateUserNo] [varchar](300) NOT NULL,		--创建人编号
	[CreateUserName] [nvarchar](200) NULL,		--创建人姓名
	[LastUpdate] [datetime] NOT NULL,			--更新日期
	[FirstNum] [varchar](500) NULL,
	[SecondNum] [varchar](500) NULL,
	[Buyer] [varchar](500) NULL,				--对口业务员

	[Remark] [nvarchar](400) NULL,				--备注
	[isDraft] [int] NULL,						--是否是草稿
	[IsDelete] [int] NOT NULL,					--删除标记
	[CreateTime] [datetime] NOT NULL,

 CONSTRAINT [PK_CainzOrder] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO

SET ANSI_PADDING OFF
GO


