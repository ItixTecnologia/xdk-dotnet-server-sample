BEGIN TRANSACTION;
GO

ALTER TABLE [Product] ADD [ParentProductId] uniqueidentifier NULL;
GO

CREATE INDEX [IX_Product_ParentProductId] ON [Product] ([ParentProductId]);
GO

ALTER TABLE [Product] ADD CONSTRAINT [FK_Product_Product_ParentProductId] FOREIGN KEY ([ParentProductId]) REFERENCES [Product] ([Id]) ON DELETE NO ACTION;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211020143227_product_parent', N'5.0.7');
GO

COMMIT;
GO

