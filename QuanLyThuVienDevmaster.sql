create database [QuanLyThuVienDevmaster]
go

use [QuanLyThuVienDevmaster]
go

create table [BookType](
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Code] VARCHAR(20) NOT NULL,
	[Title] NVARCHAR(255) NOT NULL,
	[Notes] NTEXT,
	[Status] TINYINT NULL DEFAULT 1
)
go

create table [Publisher](
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Code] VARCHAR(20) NOT NULL,
	[Name] NVARCHAR(255) NOT NULL,
	[Notes] NTEXT,
	[Status] TINYINT NULL DEFAULT 1
)
go

create table [Author](
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Code] VARCHAR(20) NOT NULL,
	[FullName] NVARCHAR(255) NOT NULL,
	[Gender] TINYINT NOT NULL DEFAULT 0,
	[Notes] NTEXT,
	[Status] TINYINT NULL DEFAULT 1
)
go

create table [Employee](
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Code] VARCHAR(20) NOT NULL,
	[FirstName] NVARCHAR(255) NOT NULL,
	[LastName] NVARCHAR(255) NOT NULL,
	[Email] VARCHAR(255) NOT NULL,
	[Password] VARCHAR(255) NOT NULL,
	[Phone] VARCHAR(50) NOT NULL,
	[Gender] TINYINT NOT NULL DEFAULT 0,
	[DOB] DATETIME,
	[CreatedTime] DATETIME DEFAULT CURRENT_TIMESTAMP,
	[UpdatedTime] DATETIME,
	[CreatedBy] INT FOREIGN KEY REFERENCES [Employee]([Id]),
	[UpdatedBy] INT FOREIGN KEY REFERENCES [Employee]([Id]),
	[Notes] NTEXT,
	[Status] TINYINT NULL DEFAULT 1
)
go

create table [Reader](
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Code] VARCHAR(20) NOT NULL,
	[FirstName] NVARCHAR(255) NOT NULL,
	[LastName] NVARCHAR(255) NOT NULL,
	[Email] VARCHAR(255) NOT NULL,
	[Password] VARCHAR(255) NOT NULL,
	[Phone] VARCHAR(50) NOT NULL,
	[Gender] TINYINT NOT NULL DEFAULT 0,
	[DOB] DATETIME,
	[Money] DECIMAL(18,2) DEFAULT 0,
	[CreatedTime] DATETIME DEFAULT CURRENT_TIMESTAMP,
	[UpdatedTime] DATETIME,
	[CreatedBy] INT FOREIGN KEY REFERENCES [Employee]([Id]),
	[UpdatedBy] INT FOREIGN KEY REFERENCES [Employee]([Id]),
	[Notes] NTEXT,
	[Status] TINYINT NULL DEFAULT 1
)
go

create table [BookTitle](
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Code] VARCHAR(20) NOT NULL,
	[Name] NVARCHAR(255) NOT NULL,
	[PublisherId] INT NOT NULL FOREIGN KEY REFERENCES [Publisher]([Id]),
	[AuthorId] INT NOT NULL FOREIGN KEY REFERENCES [Author]([Id]),
	[BookTypeId] INT NOT NULL FOREIGN KEY REFERENCES [BookType]([Id]),
	[Image] NVARCHAR(500),
	[PublishYear] INT,
	[PageNo] INT,
	[Price] DECIMAL(18,2) NOT NULL,
	[Description] NVARCHAR(MAX),
	[CreatedTime] DATETIME DEFAULT CURRENT_TIMESTAMP,
	[UpdatedTime] DATETIME,
	[CreatedBy] INT FOREIGN KEY REFERENCES [Employee]([Id]),
	[UpdatedBy] INT FOREIGN KEY REFERENCES [Employee]([Id]),
	[Notes] NTEXT,
	[Status] TINYINT DEFAULT 1
)
go

create table [Book](
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Code] VARCHAR(20) NOT NULL,
	[BookTitleId] INT NOT NULL FOREIGN KEY REFERENCES [BookTitle]([Id]),
	[BookLocation] VARCHAR(20),
	[OriginalState] TINYINT DEFAULT 100,
	[CreatedTime] DATETIME DEFAULT CURRENT_TIMESTAMP,
	[UpdatedTime] DATETIME,
	[CreatedBy] INT FOREIGN KEY REFERENCES [Employee]([Id]),
	[UpdatedBy] INT FOREIGN KEY REFERENCES [Employee]([Id]),
	[Notes] NTEXT,
	[Status] TINYINT NULL DEFAULT 1
)
go

create table [Review](
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[ReaderId] INT NOT NULL FOREIGN KEY REFERENCES [Reader]([Id]),
	[BookTitleId] INT NOT NULL FOREIGN KEY REFERENCES [BookTitle]([Id]),
	[Point] TINYINT DEFAULT 0,
	[CreatedTime] DATETIME DEFAULT CURRENT_TIMESTAMP
)
go

create table [BookBorrowReturn](
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Code] VARCHAR(20) NOT NULL,
	[ReaderId] INT NOT NULL FOREIGN KEY REFERENCES [Reader]([Id]),
	[Deposits] DECIMAL(18,2) NOT NULL,
	[BorrowFee] DECIMAL(18,2) NOT NULL,
	[PenaltyFee] DECIMAL(18,2),
	[IsOnline] BIT DEFAULT 0,
	[IsBorrow] BIT DEFAULT 0,
	[IsReturn] BIT DEFAULT 0,
	[CreatedTime] DATETIME DEFAULT CURRENT_TIMESTAMP,
	[ReturnTime] DATETIME,
	[Notes] NTEXT
)
go

-- Chưa mượn > Đã mượn > Đã trả

create table [BookBorrowReturnDetail](
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[BookBorrowReturnId] INT NOT NULL FOREIGN KEY REFERENCES [BookBorrowReturn]([Id]),
	[BookId] INT NOT NULL FOREIGN KEY REFERENCES [Book]([Id]),
	[ReturnState] TINYINT NULL DEFAULT 100,
	[Notes] NTEXT
)
go

create table [SystemConfigParameter](
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Code] INT NOT NULL,
	[Value] INT NOT NULL,
	[CreatedTime] DATETIME DEFAULT CURRENT_TIMESTAMP,
	[Description] NVARCHAR(255),
	[Status] TINYINT NULL DEFAULT 1
)
go