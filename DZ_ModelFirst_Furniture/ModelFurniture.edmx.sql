
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/12/2022 13:17:12
-- Generated from EDMX file: C:\Users\Fiks\source\repos\ITFiks\ITFIKS\DZ_ModelFirst_Furniture\ModelFurniture.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Furniture];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ClientProductSale]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductSales] DROP CONSTRAINT [FK_ClientProductSale];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductProductSale]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductSales] DROP CONSTRAINT [FK_ProductProductSale];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Clients]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clients];
GO
IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
GO
IF OBJECT_ID(N'[dbo].[ProductSales]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductSales];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Clients'
CREATE TABLE [dbo].[Clients] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Fio] nvarchar(max)  NOT NULL,
    [PhoneNumber] float  NOT NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [CostPrice] float  NOT NULL,
    [Weight] float  NOT NULL,
    [Height] float  NOT NULL,
    [Width] float  NOT NULL,
    [Material] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ProductSales'
CREATE TABLE [dbo].[ProductSales] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Price] float  NOT NULL,
    [DateSale] datetime  NOT NULL,
    [ClientId] int  NOT NULL,
    [ProductId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Clients'
ALTER TABLE [dbo].[Clients]
ADD CONSTRAINT [PK_Clients]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProductSales'
ALTER TABLE [dbo].[ProductSales]
ADD CONSTRAINT [PK_ProductSales]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ClientId] in table 'ProductSales'
ALTER TABLE [dbo].[ProductSales]
ADD CONSTRAINT [FK_ClientProductSale]
    FOREIGN KEY ([ClientId])
    REFERENCES [dbo].[Clients]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientProductSale'
CREATE INDEX [IX_FK_ClientProductSale]
ON [dbo].[ProductSales]
    ([ClientId]);
GO

-- Creating foreign key on [ProductId] in table 'ProductSales'
ALTER TABLE [dbo].[ProductSales]
ADD CONSTRAINT [FK_ProductProductSale]
    FOREIGN KEY ([ProductId])
    REFERENCES [dbo].[Products]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductProductSale'
CREATE INDEX [IX_FK_ProductProductSale]
ON [dbo].[ProductSales]
    ([ProductId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------