BEGIN TRANSACTION;
GO

CREATE TABLE [Category] (
    [Id] uniqueidentifier NOT NULL,
    [Description] nvarchar(max) NULL,
    CONSTRAINT [PK_Category] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [CategoryProduct] (
    [CategoriesId] uniqueidentifier NOT NULL,
    [ProductsId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_CategoryProduct] PRIMARY KEY ([CategoriesId], [ProductsId]),
    CONSTRAINT [FK_CategoryProduct_Category_CategoriesId] FOREIGN KEY ([CategoriesId]) REFERENCES [Category] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_CategoryProduct_Product_ProductsId] FOREIGN KEY ([ProductsId]) REFERENCES [Product] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_CategoryProduct_ProductsId] ON [CategoryProduct] ([ProductsId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'202110111500_addCategoria', N'5.0.7');
GO

COMMIT;
GO

