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
	[OrderID] [uniqueidentifier] NOT NULL,		--����
	[OrderNo] [varchar](50)  NULL,				--�������
	[FactoryID] [uniqueidentifier]  NULL,		--�ͻ���� ����һ����ָ����
	[FactoryName] [nvarchar](300) NULL,		--�ͻ�����
	[Phone] [varchar](500) NULL,				--�绰
	[Contact] [nvarchar](300) NULL,				--��ϵ��
	[Address] [nvarchar](400) NULL,				--��ַ

	[Receiver] [nvarchar](200) NULL,			--������
	[SendDate] [datetime] NULL,					--��������
	[Money] [decimal](18, 4) NOT NULL,			
	[Status] [int]  default 0 NULL,				--״̬

	[CreatorID] [uniqueidentifier]  NULL,		--�����˱��
	[Creator] [nvarchar](200) NULL,				--����������

	[LastUpdate] [datetime] default getdate() NULL,	--��������

	[Buyer] [varchar](200) NULL,				--�Կ�ҵ��Ա

	[Remark] [nvarchar](400) NULL,				--��ע
	[isDraft] [int] default 1 NULL,				--�Ƿ��ǲݸ�
	[IsDelete] [int] default 0 NOT NULL,		--ɾ�����
	[CreateTime] [datetime] default getdate() NOT NULL,

 CONSTRAINT [PK_CainzOrder] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC

)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO

SET ANSI_PADDING OFF
GO


