
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/20/2022 12:36:09
-- Generated from EDMX file: C:\Users\Fiks\source\repos\ITFiks\ITFIKS\CW_Barber_DatebaseFirst\ModelBarber.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BarberShop];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__ArchiveVi__Barbe__44FF419A]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ArchiveVisits] DROP CONSTRAINT [FK__ArchiveVi__Barbe__44FF419A];
GO
IF OBJECT_ID(N'[dbo].[FK__ArchiveVi__Clien__440B1D61]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ArchiveVisits] DROP CONSTRAINT [FK__ArchiveVi__Clien__440B1D61];
GO
IF OBJECT_ID(N'[dbo].[FK_ArchiveVisits_servicesList]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ArchiveVisits] DROP CONSTRAINT [FK_ArchiveVisits_servicesList];
GO
IF OBJECT_ID(N'[dbo].[FK__Barbers__Postion__4222D4EF]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Barbers] DROP CONSTRAINT [FK__Barbers__Postion__4222D4EF];
GO
IF OBJECT_ID(N'[dbo].[FK__Schedule__Barber__4316F928]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Schedules] DROP CONSTRAINT [FK__Schedule__Barber__4316F928];
GO
IF OBJECT_ID(N'[dbo].[FK_BarberBarberService]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BarberServices] DROP CONSTRAINT [FK_BarberBarberService];
GO
IF OBJECT_ID(N'[dbo].[FK_servicesListBarberService]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BarberServices] DROP CONSTRAINT [FK_servicesListBarberService];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ArchiveVisits]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ArchiveVisits];
GO
IF OBJECT_ID(N'[dbo].[Barbers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Barbers];
GO
IF OBJECT_ID(N'[dbo].[Clients]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clients];
GO
IF OBJECT_ID(N'[dbo].[Positions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Positions];
GO
IF OBJECT_ID(N'[dbo].[Schedules]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Schedules];
GO
IF OBJECT_ID(N'[dbo].[servicesLists]', 'U') IS NOT NULL
    DROP TABLE [dbo].[servicesLists];
GO
IF OBJECT_ID(N'[dbo].[BarberServices]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BarberServices];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ArchiveVisits'
CREATE TABLE [dbo].[ArchiveVisits] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ClientId] int  NOT NULL,
    [BarberId] int  NOT NULL,
    [Date] datetime  NOT NULL,
    [Price] decimal(19,4)  NOT NULL,
    [Rating] int  NOT NULL,
    [Feedback] nvarchar(100)  NOT NULL,
    [ServiceId] int  NULL
);
GO

-- Creating table 'Barbers'
CREATE TABLE [dbo].[Barbers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FIO] nvarchar(100)  NOT NULL,
    [Gender] bit  NOT NULL,
    [PhoneNumber] int  NOT NULL,
    [Email] nvarchar(50)  NOT NULL,
    [Birthday] datetime  NOT NULL,
    [DateAdmission] datetime  NOT NULL,
    [PostionId] int  NOT NULL
);
GO

-- Creating table 'Clients'
CREATE TABLE [dbo].[Clients] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FIO] nvarchar(100)  NOT NULL,
    [PhoneNumber] int  NOT NULL,
    [Email] nvarchar(50)  NOT NULL,
    [DateAdmission] datetime  NOT NULL
);
GO

-- Creating table 'Positions'
CREATE TABLE [dbo].[Positions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(100)  NOT NULL
);
GO

-- Creating table 'Schedules'
CREATE TABLE [dbo].[Schedules] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [BarberId] int  NOT NULL,
    [FreeDate] datetime  NOT NULL,
    [FreeTime] time  NOT NULL
);
GO

-- Creating table 'servicesLists'
CREATE TABLE [dbo].[servicesLists] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(100)  NOT NULL,
    [Price] decimal(19,4)  NOT NULL,
    [Time] time  NOT NULL
);
GO

-- Creating table 'BarberServices'
CREATE TABLE [dbo].[BarberServices] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [BarberId] int  NOT NULL,
    [ServiceId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ArchiveVisits'
ALTER TABLE [dbo].[ArchiveVisits]
ADD CONSTRAINT [PK_ArchiveVisits]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Barbers'
ALTER TABLE [dbo].[Barbers]
ADD CONSTRAINT [PK_Barbers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Clients'
ALTER TABLE [dbo].[Clients]
ADD CONSTRAINT [PK_Clients]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Positions'
ALTER TABLE [dbo].[Positions]
ADD CONSTRAINT [PK_Positions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Schedules'
ALTER TABLE [dbo].[Schedules]
ADD CONSTRAINT [PK_Schedules]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'servicesLists'
ALTER TABLE [dbo].[servicesLists]
ADD CONSTRAINT [PK_servicesLists]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BarberServices'
ALTER TABLE [dbo].[BarberServices]
ADD CONSTRAINT [PK_BarberServices]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [BarberId] in table 'ArchiveVisits'
ALTER TABLE [dbo].[ArchiveVisits]
ADD CONSTRAINT [FK__ArchiveVi__Barbe__44FF419A]
    FOREIGN KEY ([BarberId])
    REFERENCES [dbo].[Barbers]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ArchiveVi__Barbe__44FF419A'
CREATE INDEX [IX_FK__ArchiveVi__Barbe__44FF419A]
ON [dbo].[ArchiveVisits]
    ([BarberId]);
GO

-- Creating foreign key on [ClientId] in table 'ArchiveVisits'
ALTER TABLE [dbo].[ArchiveVisits]
ADD CONSTRAINT [FK__ArchiveVi__Clien__440B1D61]
    FOREIGN KEY ([ClientId])
    REFERENCES [dbo].[Clients]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ArchiveVi__Clien__440B1D61'
CREATE INDEX [IX_FK__ArchiveVi__Clien__440B1D61]
ON [dbo].[ArchiveVisits]
    ([ClientId]);
GO

-- Creating foreign key on [ServiceId] in table 'ArchiveVisits'
ALTER TABLE [dbo].[ArchiveVisits]
ADD CONSTRAINT [FK_ArchiveVisits_servicesList]
    FOREIGN KEY ([ServiceId])
    REFERENCES [dbo].[servicesLists]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArchiveVisits_servicesList'
CREATE INDEX [IX_FK_ArchiveVisits_servicesList]
ON [dbo].[ArchiveVisits]
    ([ServiceId]);
GO

-- Creating foreign key on [PostionId] in table 'Barbers'
ALTER TABLE [dbo].[Barbers]
ADD CONSTRAINT [FK__Barbers__Postion__4222D4EF]
    FOREIGN KEY ([PostionId])
    REFERENCES [dbo].[Positions]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Barbers__Postion__4222D4EF'
CREATE INDEX [IX_FK__Barbers__Postion__4222D4EF]
ON [dbo].[Barbers]
    ([PostionId]);
GO

-- Creating foreign key on [BarberId] in table 'Schedules'
ALTER TABLE [dbo].[Schedules]
ADD CONSTRAINT [FK__Schedule__Barber__4316F928]
    FOREIGN KEY ([BarberId])
    REFERENCES [dbo].[Barbers]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Schedule__Barber__4316F928'
CREATE INDEX [IX_FK__Schedule__Barber__4316F928]
ON [dbo].[Schedules]
    ([BarberId]);
GO

-- Creating foreign key on [BarberId] in table 'BarberServices'
ALTER TABLE [dbo].[BarberServices]
ADD CONSTRAINT [FK_BarberBarberService]
    FOREIGN KEY ([BarberId])
    REFERENCES [dbo].[Barbers]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BarberBarberService'
CREATE INDEX [IX_FK_BarberBarberService]
ON [dbo].[BarberServices]
    ([BarberId]);
GO

-- Creating foreign key on [ServiceId] in table 'BarberServices'
ALTER TABLE [dbo].[BarberServices]
ADD CONSTRAINT [FK_servicesListBarberService]
    FOREIGN KEY ([ServiceId])
    REFERENCES [dbo].[servicesLists]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_servicesListBarberService'
CREATE INDEX [IX_FK_servicesListBarberService]
ON [dbo].[BarberServices]
    ([ServiceId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------