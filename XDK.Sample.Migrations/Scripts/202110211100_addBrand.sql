BEGIN TRANSACTION;
GO

ALTER TABLE [Product] ADD [BrandId] uniqueidentifier NULL;
GO

CREATE TABLE [Brand] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(max) NULL,
    [EnterpriseName] nvarchar(max) NULL,
    CONSTRAINT [PK_Brand] PRIMARY KEY ([Id])
);
GO

CREATE INDEX [IX_Product_BrandId] ON [Product] ([BrandId]);
GO

ALTER TABLE [Product] ADD CONSTRAINT [FK_Product_Brand_BrandId] FOREIGN KEY ([BrandId]) REFERENCES [Brand] ([Id]) ON DELETE NO ACTION;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'202110211100_addBrand', N'5.0.7');
GO

COMMIT;
GO