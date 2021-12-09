IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
CREATE TABLE [__EFMigrationsHistory] (
    [MigrationId] nvarchar(150) NOT NULL,
    [ProductVersion] nvarchar(32) NOT NULL,
    CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Application] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(max) NULL,
    [RedirectUri] nvarchar(max) NULL,
    [LogoutRedirectUri] nvarchar(max) NULL,
    [Secret] nvarchar(max) NULL,
    CONSTRAINT [PK_Application] PRIMARY KEY ([Id])
    );
GO

CREATE TABLE [Claim] (
    [Id] uniqueidentifier NOT NULL,
    [Type] nvarchar(max) NULL,
    [Value] nvarchar(max) NULL,
    [ValueType] nvarchar(max) NULL,
    [Issuer] nvarchar(max) NULL,
    [OriginalIssuer] nvarchar(max) NULL,
    CONSTRAINT [PK_Claim] PRIMARY KEY ([Id])
    );
GO

CREATE TABLE [Order] (
    [Id] uniqueidentifier NOT NULL,
    [Date] datetime2 NOT NULL,
    [IsCanceled] bit NOT NULL,
     CONSTRAINT [PK_Order] PRIMARY KEY ([Id])
    );
GO

CREATE TABLE [Product] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(max) NULL,
    [Description] nvarchar(max) NULL,
    [Quantity] int NOT NULL,
    [Price] decimal(18,2) NOT NULL,
    CONSTRAINT [PK_Product] PRIMARY KEY ([Id])
    );
GO

CREATE TABLE [User] (
    [Id] uniqueidentifier NOT NULL,
    [Email] nvarchar(max) NULL,
    [Username] nvarchar(max) NULL,
    [Password] nvarchar(max) NULL,
    CONSTRAINT [PK_User] PRIMARY KEY ([Id])
    );
GO

CREATE TABLE [OrderItem] (
    [Id] uniqueidentifier NOT NULL,
    [ProductId] uniqueidentifier NOT NULL,
    [OrderId] uniqueidentifier NOT NULL,
    [Quantity] int NOT NULL,
    [UnitValue] decimal(18,2) NOT NULL,
    CONSTRAINT [PK_OrderItem] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_OrderItem_Order_OrderId] FOREIGN KEY ([OrderId]) REFERENCES [Order] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_OrderItem_Product_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [Product] ([Id]) ON DELETE CASCADE
    );
GO

CREATE TABLE [ClaimUser] (
    [ClaimsId] uniqueidentifier NOT NULL,
    [UsersId] uniqueidentifier NOT NULL,
     CONSTRAINT [PK_ClaimUser] PRIMARY KEY ([ClaimsId], [UsersId]),
    CONSTRAINT [FK_ClaimUser_Claim_ClaimsId] FOREIGN KEY ([ClaimsId]) REFERENCES [Claim] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_ClaimUser_User_UsersId] FOREIGN KEY ([UsersId]) REFERENCES [User] ([Id]) ON DELETE CASCADE
    );
GO

CREATE INDEX [IX_ClaimUser_UsersId] ON [ClaimUser] ([UsersId]);
GO

CREATE INDEX [IX_OrderItem_OrderId] ON [OrderItem] ([OrderId]);
GO

CREATE INDEX [IX_OrderItem_ProductId] ON [OrderItem] ([ProductId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210823192231_Initial', N'5.0.7');
GO

COMMIT;
GO

