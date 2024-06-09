IF DB_ID('db_biamanager') IS NULL
BEGIN
    CREATE DATABASE db_biamanager;
END
GO

USE db_biamanager;
GO

CREATE TABLE [dbo].[table_type] (
    [TableIDType] varchar(10) COLLATE Vietnamese_CI_AS NOT NULL,
    [TableType_Name] varchar(50) COLLATE Vietnamese_CI_AS NOT NULL,
    [TableType_Price] int NOT NULL DEFAULT '0',
    [TableTypeStatus] varchar(10) NOT NULL DEFAULT '0',
    PRIMARY KEY CLUSTERED ([TableIDType])
);
GO

CREATE TABLE [dbo].[items_category] (
    [IdItemCategory] varchar(10) COLLATE Vietnamese_CI_AS NOT NULL,
    [ItemCategory_Name] varchar(50) COLLATE Vietnamese_CI_AS NOT NULL,
    [ItemCategoryStatus] varchar(10) NOT NULL DEFAULT '0',
    PRIMARY KEY CLUSTERED ([IdItemCategory])
);
GO

CREATE TABLE [dbo].[items_menu] (
    [IdItem] varchar(10) COLLATE Vietnamese_CI_AS NOT NULL,
    [item_Name] varchar(50) COLLATE Vietnamese_CI_AS NOT NULL,
    [IdItemCategory] varchar(10) COLLATE Vietnamese_CI_AS NOT NULL,
    [item_Price] int NOT NULL,
    [item_image] image NULL,
    [ItemStatus] varchar(10) NOT NULL DEFAULT '0',
    PRIMARY KEY CLUSTERED ([IdItem]),
    CONSTRAINT [FK_items_menu_items_category] FOREIGN KEY ([IdItemCategory]) REFERENCES [dbo].[items_category] ([IdItemCategory])
);
GO

CREATE TABLE [dbo].[table_detail] (
    [TableID] varchar(10) COLLATE Vietnamese_CI_AS NOT NULL,
    [TableNumber] int NOT NULL,
    [Status] int NOT NULL DEFAULT '0',
    [TableIDType] varchar(10) COLLATE Vietnamese_CI_AS NOT NULL,
    [TableStatus] varchar(10) NOT NULL DEFAULT '0',
    PRIMARY KEY CLUSTERED ([TableID]),
    CONSTRAINT [FK_table_tabletype] FOREIGN KEY ([TableIDType]) REFERENCES [dbo].[table_type] ([TableIDType])
);
GO

CREATE TABLE [dbo].[user_account] (
    [IdUser] varchar(15) COLLATE Vietnamese_CI_AS NOT NULL,
    [UserName] varchar(200) COLLATE Vietnamese_CI_AS NOT NULL,
    [UserPassword] varchar(70) COLLATE Vietnamese_CI_AS NOT NULL,
    [UserRole] int NULL,
    [AccountStatus] varchar(10) NOT NULL DEFAULT '0',
    PRIMARY KEY CLUSTERED ([IdUser])
);
GO

CREATE TABLE [dbo].[user_info] (
    [idUser] varchar(15) COLLATE Vietnamese_CI_AS NOT NULL,
    [User_FullName] varchar(50) COLLATE Vietnamese_CI_AS NOT NULL,
    [User_Phone] varchar(10) COLLATE Vietnamese_CI_AS NOT NULL,
    [User_BankAccountNumber] varchar(12) COLLATE Vietnamese_CI_AS NULL,
    [User_BankName] varchar(50) COLLATE Vietnamese_CI_AS NULL,
    [User_BillPath] varchar(200) COLLATE Vietnamese_CI_AS NULL,
    CONSTRAINT [FK_user_info_user] FOREIGN KEY ([idUser]) REFERENCES [dbo].[user_account] ([IdUser])
);
GO

CREATE TABLE [dbo].[work_shift_log] (
    [LogID] INT IDENTITY(1,1) PRIMARY KEY,
    [IdUser] varchar(15) COLLATE Vietnamese_CI_AS NOT NULL,
    [ShiftStart] DATETIME NOT NULL,
    [ShiftEnd] DATETIME NULL,
    CONSTRAINT [FK_work_shift_log_user_account] FOREIGN KEY ([IdUser]) REFERENCES [dbo].[user_account] ([IdUser])
);
GO

CREATE TABLE [dbo].[invoice] (
    [IdInvoice] varchar(10) COLLATE Vietnamese_CI_AS NOT NULL,
    [TableID] varchar(10) COLLATE Vietnamese_CI_AS NOT NULL,
    [Invoice_time] datetime NOT NULL,
    [Invoice_Status] int NULL,
    [Invoice_Total] decimal(18, 2) NULL,
    [Invoice_Received] decimal(18, 2) NULL,
    [Invoice_Change] decimal(18, 2) NULL,
    [Invoice_PaymentTime] datetime NULL,
    [IdUser] varchar(15) COLLATE Vietnamese_CI_AS NOT NULL,
    PRIMARY KEY CLUSTERED ([IdInvoice]),
    CONSTRAINT [FK_orders_table] FOREIGN KEY ([TableID]) REFERENCES [dbo].[table_detail] ([TableID]),
    CONSTRAINT [IdUser] FOREIGN KEY ([IdUser]) REFERENCES [dbo].[user_account] ([IdUser]),
);
GO

CREATE TABLE [dbo].[invoice_detail] (
    [IdInvoice] varchar(10) COLLATE Vietnamese_CI_AS NOT NULL,
    [IdItem] varchar(10) COLLATE Vietnamese_CI_AS NOT NULL,
    [Invoice_TotalAmount] float NOT NULL,
    [Invoice_Price] int NOT NULL,
    CONSTRAINT [FK_invoice_detail_invoice] FOREIGN KEY ([IdInvoice]) REFERENCES [dbo].[invoice] ([IdInvoice]),
    CONSTRAINT [FK_invoice_detail_items_menu] FOREIGN KEY ([IdItem]) REFERENCES [dbo].[items_menu] ([IdItem])
);
GO

INSERT INTO user_account (IdUser,UserName, UserPassword, UserRole) VALUES ('U0', 'admin', '240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9', 0);
INSERT INTO user_info (idUser, User_FullName, User_Phone, User_BankAccountNumber, User_BankName, User_BillPath) VALUES ('U0', 'Administrator', '', '', '', '');
INSERT INTO table_type (TableIDType,TableType_Name, TableType_Price) VALUES ('TBT01', 'Carom billiards', 25000);
INSERT INTO table_type (TableIDType,TableType_Name, TableType_Price) VALUES ('TBT02', 'Pocket Billiards', 30000);
INSERT INTO items_category (IdItemCategory, ItemCategory_Name) VALUES ('ICD', 'Other');
INSERT INTO items_menu (IdItem, item_Name, IdItemCategory, item_Price) VALUES ('IHour', 'Play time', 'ICD', 30000);