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
	[OrderDetailId] [uniqueidentifier] NOT NULL,--����
	[OrderId] [uniqueidentifier] NOT NULL,		--��������
	[RowNo] [int] NULL,							--��ʱ�� ��κ�
	[ProductId] [uniqueidentifier] NOT NULL,	--��Ʒ���
	[ProductBarcode] [nvarchar](200) NOT NULL,	--��Ʒ����
	[ProductName] [nvarchar](200) NOT NULL,		--��Ʒ����
	[ProductPrice] [decimal](18, 4) NOT NULL,	--��Ʒ�۸�
	[OrderNum] [int] NOT NULL,					--��������
	[CdFileName] [nvarchar](200) NULL,			--�ļ���
	--[PopDesignNo] [nvarchar](200) NULL,			
	[PopSize] [nvarchar](200) NULL,				--ӡˢƷ�ߴ�
	[PopMaterial] [nvarchar](200) NULL,			--����
	[PopCategory] [nvarchar](200) NULL,			--���
	[PopCateName] [nvarchar](200) NULL,			--�������
	[Color] [nvarchar](200) NULL,				--��ɫ
	--[POPNum] [int] NULL,
	--[RealNum] [int] NULL,
	[UnitId] [uniqueidentifier]  NULL,			--������λ���
	[UnitName] [nvarchar](20)  NULL,			--������λ����
	[ExpectDate] [datetime] NULL,				--������������
	[ExpectDateFormat] [nvarchar](200) NULL,	--��ʽ���Ľ������� yyyyMMdd
	--[ProbabilityDate] [datetime] NOT NULL,	--?
	--[ETD] [nvarchar](200) NULL,
	--[Reference] [nvarchar](50) NULL,
	--[PrintMoney] [decimal](18, 4) NOT NULL,
	--[CheckMoney] [decimal](18, 4) NOT NULL,
	--[InvoiceMoney] [decimal](18, 4) NOT NULL,
	[Sample] [nvarchar](20) NULL,				--��Ʒ
	[Status] [int] NOT NULL,					--״̬
	[IsDelete] [int] NOT NULL,					--�Ƿ�ɾ�� 0 δɾ�� 1ɾ��
	[CreateTime] [datetime] NOT NULL,			--��������
	[Remark] [nvarchar](200) NULL,				--��ע
	[BatchNo] [nvarchar](200) NULL,				--����
 CONSTRAINT [PK_CainzOrderDetail] PRIMARY KEY CLUSTERED 
(
	[OrderDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO


