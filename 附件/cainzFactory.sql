USE [db002]
GO

/****** Object:  Table [dbo].[CainzFactory]    Script Date: 2015-08-08 15:33:50 ******/
DROP TABLE [dbo].[CainzCustomer]
GO

/****** Object:  Table [dbo].[CainzFactory]    Script Date: 2015-08-08 15:33:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[CainzFactory](

	[FactoryID] [uniqueidentifier] NOT NULL,				--工厂编号 *	
	[FactoryName] [nvarchar](100) NOT NULL,					--工厂名称 *
	[FactoryNameJP] [varchar](100) NOT NULL,				--工厂名称简写 *
	[FactoryAddress] [nvarchar](200) NULL,					--联系人地址

	[TraderID][uniqueidentifier] NULL,						--贸易商编号
	[TraderName] [nvarchar](200) NULL,						--贸易商名称

	[Contact] [nvarchar](300) NULL,							--联系人姓名
	[ContactPhone] [varchar](100) NULL,						--联系人电话

	[Receiver] [nvarchar](200) NULL,						--收货人姓名
	[ReceiverPhone] [varchar](200) NULL,					--收货人电话
							
	[Remark] [varchar](200) NULL,							--备注
	[CreateTime] [datetime] default getdate() NOT NULL,		--创建时间
	[Deleted] [int] default 0 NOT NULL,						--是否删除 *

 CONSTRAINT [PK_CainzFactory] PRIMARY KEY CLUSTERED 
(
	[FactoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO

SET ANSI_PADDING OFF
GO

CREATE INDEX [Index_CainzCustomer_FactoryNameJP] on [dbo].[CainzFactory] ([FactoryNameJP]) --工厂名索引
CREATE INDEX [Index_CainzCustomer_FactoryName] on [dbo].[CainzFactory] ([FactoryName])		--工厂名简写索引


