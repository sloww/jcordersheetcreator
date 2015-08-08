USE [db002]
GO

/****** Object:  Table [dbo].[CainzTrader]    Script Date: 2015-08-08 15:48:48 ******/
DROP TABLE [dbo].[CainzTrader]
GO

/****** Object:  Table [dbo].[CainzTrader]    Script Date: 2015-08-08 15:48:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[CainzTrader](
	[TraderID] [uniqueidentifier] NOT NULL,
	[TraderName] [nvarchar](200) NULL,
	[TraderShortName] [nvarchar](200) NULL,	
	[IsDelete] [int] default 0 NOT NULL,
	[CreateTime] [datetime] default getdate() NOT NULL,
	[Remark] [nvarchar](400) NULL,
 CONSTRAINT [PK_CainzTrader] PRIMARY KEY CLUSTERED 
(
	[TraderID]  ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO

SET ANSI_PADDING OFF
GO


