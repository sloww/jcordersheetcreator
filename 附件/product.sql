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
	[ProductID] [uniqueidentifier] NOT NULL,				--ID���� *
	[ProductBarcode] [nvarchar](100) NOT NULL,				--������ *
	[ProductName] [nvarchar](200) NULL,						--��Ʒ����
	[ProductMaterial] [nvarchar](200) NULL,					--��Ʒ����
	[ProductSize] [nvarchar](200) NULL,						--��Ʒ�ߴ�
	[ProductColor] [nvarchar](200) NULL,					--��Ʒ��ɫ
	[ProductPrice] [money] NULL,							--��Ʒ����
	[CreateTime] [datetime] default getdate() NOT NULL,		--����ʱ��
	[Deleted] [int] default 0 NOT NULL,						--�Ƿ�ɾ�� *
	[ModifyTime] [datetime] default getdate() NOT NULL,		--�޸�����
	[Modified] [int] default 0 NOT NULL,					--�Ƿ��޸�
	[TraderID] [uniqueidentifier] NULL,						--ó���̱��
	[TraderName] [nvarchar](200) NULL,						--ó��������
 CONSTRAINT [PK_CainzProduct] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO

CREATE INDEX [Index_CainzProduct_barcode] on [dbo].[CainzProduct] ([ProductBarcode])


