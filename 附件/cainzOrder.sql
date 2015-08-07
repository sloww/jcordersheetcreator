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
	[OrderId] [uniqueidentifier] NOT NULL,		--����
	[OrderNo] [varchar](50) NOT NULL,			--�������
	[NitORI] [varchar](200) NOT NULL,
	[CustomerId] [uniqueidentifier] NOT NULL,	--�ͻ���� ����һ����ָ����
	[CustomerName] [nvarchar](300) NULL,		--�ͻ�����
	[Phone] [varchar](500) NULL,				--�绰
	[Contact] [nvarchar](300) NULL,				--��ϵ��
	[Address] [nvarchar](400) NULL,				--��ַ
	--[Invoice] [nvarchar](400) NULL,
	--[Company] [nvarchar](500) NULL,
	[SendAddress] [nvarchar](200) NULL,			--�ͻ���ַ
	[Receiver] [nvarchar](200) NULL,			--������
	[Telephone] [varchar](400) NULL,			--�绰
	--[Fax] [varchar](500) NULL,
	--[FinanceContact] [nvarchar](400) NULL,
	--[BankName] [nvarchar](400) NULL,
	--[CardNum] [varchar](400) NULL,
	--[Taxpayer] [varchar](400) NULL,
	[SendDate] [datetime] NOT NULL,
	[Money] [decimal](18, 4) NOT NULL,			--��������
	[Status] [int] NOT NULL,					--״̬

	[CreateUserNo] [varchar](300) NOT NULL,		--�����˱��
	[CreateUserName] [nvarchar](200) NULL,		--����������
	[LastUpdate] [datetime] NOT NULL,			--��������
	[FirstNum] [varchar](500) NULL,
	[SecondNum] [varchar](500) NULL,
	[Buyer] [varchar](500) NULL,				--�Կ�ҵ��Ա

	[Remark] [nvarchar](400) NULL,				--��ע
	[isDraft] [int] NULL,						--�Ƿ��ǲݸ�
	[IsDelete] [int] NOT NULL,					--ɾ�����
	[CreateTime] [datetime] NOT NULL,

 CONSTRAINT [PK_CainzOrder] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO

SET ANSI_PADDING OFF
GO


