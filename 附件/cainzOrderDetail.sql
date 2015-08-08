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

	[OrderDetailID] [uniqueidentifier] NOT NULL,--����
	[OrderID] [uniqueidentifier] NOT NULL,		--��������
	[RowNo] [int] NULL,							--��ʱ�� ��κ�

	[ProductID] [uniqueidentifier] NOT NULL,	--ID���� *
	[ProductBarcode] [nvarchar](100) NOT NULL,	--������ *
	[ProductName] [nvarchar](200) NULL,			--��Ʒ����
	[ProductMaterial] [nvarchar](200) NULL,		--��Ʒ����
	[ProductSize] [nvarchar](200) NULL,			--��Ʒ�ߴ�
	[ProductColor] [nvarchar](200) NULL,		--��Ʒ��ɫ
	[ProductPrice] [money] NULL,				--��Ʒ����

	[POPNum] [int] default 0 NULL,

	[UnitID] [uniqueidentifier]  NULL,			--������λ���
	[UnitName] [nvarchar](20)  NULL,			--������λ����
	[ExpectDate] [datetime] NULL,				--������������
	[ExpectDateFormat] [nvarchar](200) NULL,	--��ʽ���Ľ������� yyyyMMdd
	[TotalMoney] [decimal](18, 4) NOT NULL,		--С��
	[Sample] [nvarchar](20) NULL,				--��Ʒ
	[Status] [int] default 0 NOT NULL,			--״̬
	[IsDelete] [int] default 0 NOT NULL,		--�Ƿ�ɾ�� 0 δɾ�� 1ɾ��
	[CreateTime] [datetime] default getdate() NOT NULL,	--��������
	[Remark] [nvarchar](200) NULL,				--��ע
	[BatchNo] [nvarchar](200) NULL,				--����

 CONSTRAINT [PK_CainzOrderDetail] PRIMARY KEY CLUSTERED 
(
	[OrderDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO


