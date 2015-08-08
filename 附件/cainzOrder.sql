USE [db002]
GO

/****** Object:  Table [dbo].[CainzOrder]    Script Date: 2015-08-07 21:10:17 ******/
DROP TABLE [dbo].[CainzOrder]
GO

/****** Object:  Table [dbo].[CainzOrder]    Script Date: 2015-08-07 21:10:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[CainzOrder](
	[OrderID] [uniqueidentifier] NOT NULL,		--主键
	[OrderNo] [varchar](50)  NULL,				--订单编号
	[FactoryID] [uniqueidentifier]  NULL,		--客户编号 这里一般是指工厂
	[FactoryName] [nvarchar](300) NULL,		--客户名称
	[Phone] [varchar](500) NULL,				--电话
	[Contact] [nvarchar](300) NULL,				--联系人
	[Address] [nvarchar](400) NULL,				--地址

	[Receiver] [nvarchar](200) NULL,			--接收人
	[SendDate] [datetime] NULL,					--发货日期
	[Money] [decimal](18, 4) NOT NULL,			
	[Status] [int]  default 0 NULL,				--状态

	[CreatorID] [uniqueidentifier]  NULL,		--创建人编号
	[Creator] [nvarchar](200) NULL,				--创建人姓名

	[LastUpdate] [datetime] default getdate() NULL,	--更新日期

	[Buyer] [varchar](200) NULL,				--对口业务员

	[Remark] [nvarchar](400) NULL,				--备注
	[isDraft] [int] default 1 NULL,				--是否是草稿
	[IsDelete] [int] default 0 NOT NULL,		--删除标记
	[CreateTime] [datetime] default getdate() NOT NULL,

 CONSTRAINT [PK_CainzOrder] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC

)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO

SET ANSI_PADDING OFF
GO


