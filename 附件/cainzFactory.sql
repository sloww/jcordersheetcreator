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

	[FactoryID] [uniqueidentifier] NOT NULL,				--������� *	
	[FactoryName] [nvarchar](100) NOT NULL,					--�������� *
	[FactoryNameJP] [varchar](100) NOT NULL,				--�������Ƽ�д *
	[FactoryAddress] [nvarchar](200) NULL,					--��ϵ�˵�ַ

	[TraderID][uniqueidentifier] NULL,						--ó���̱��
	[TraderName] [nvarchar](200) NULL,						--ó��������

	[Contact] [nvarchar](300) NULL,							--��ϵ������
	[ContactPhone] [varchar](100) NULL,						--��ϵ�˵绰

	[Receiver] [nvarchar](200) NULL,						--�ջ�������
	[ReceiverPhone] [varchar](200) NULL,					--�ջ��˵绰
							
	[Remark] [varchar](200) NULL,							--��ע
	[CreateTime] [datetime] default getdate() NOT NULL,		--����ʱ��
	[Deleted] [int] default 0 NOT NULL,						--�Ƿ�ɾ�� *

 CONSTRAINT [PK_CainzFactory] PRIMARY KEY CLUSTERED 
(
	[FactoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO

SET ANSI_PADDING OFF
GO

CREATE INDEX [Index_CainzCustomer_FactoryNameJP] on [dbo].[CainzFactory] ([FactoryNameJP]) --����������
CREATE INDEX [Index_CainzCustomer_FactoryName] on [dbo].[CainzFactory] ([FactoryName])		--��������д����


