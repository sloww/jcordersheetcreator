use db002


ALTER TABLE CainzOrder
ADD [OrderExNo] varchar(50)  NULL

ALTER TABLE CainzOrder
ADD [TraderName] nvarchar(300)  NULL

ALTER TABLE CainzOrder
ADD[TraderID] uniqueidentifier  NULL

ALTER TABLE CainzOrder
ADD[OrderDate] datetime  NULL