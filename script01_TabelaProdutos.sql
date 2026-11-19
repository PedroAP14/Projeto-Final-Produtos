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
CREATE TABLE [TB_PRODUTOS] (
    [Id] int NOT NULL IDENTITY,
    [Nome] varchar(500) NOT NULL,
    [Descricao] varchar(500) NOT NULL,
    [Preco] float NOT NULL,
    [Quantidade] int NOT NULL,
    [TipoCategoria] int NOT NULL,
    CONSTRAINT [PK_TB_PRODUTOS] PRIMARY KEY ([Id])
);

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Descricao', N'Nome', N'Preco', N'Quantidade', N'TipoCategoria') AND [object_id] = OBJECT_ID(N'[TB_PRODUTOS]'))
    SET IDENTITY_INSERT [TB_PRODUTOS] ON;
INSERT INTO [TB_PRODUTOS] ([Id], [Descricao], [Nome], [Preco], [Quantidade], [TipoCategoria])
VALUES (1, 'Banana-prata fresca in natura, polpa firme e sabor suave. Vendida por quilo', 'Banana-Prata (Kg)', 9.8699999999999992E0, 0, 1);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Descricao', N'Nome', N'Preco', N'Quantidade', N'TipoCategoria') AND [object_id] = OBJECT_ID(N'[TB_PRODUTOS]'))
    SET IDENTITY_INSERT [TB_PRODUTOS] OFF;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20261119001019_Produtos-v1', N'10.0.0');

COMMIT;
GO

