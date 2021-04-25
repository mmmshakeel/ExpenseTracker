
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/25/2021 19:53:58
-- Generated from EDMX file: C:\Users\Shakeel\Documents\CW2\Code\ExpenseTracker\ExpenseTracker\ExpenseTrackerDatabase.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [AppDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_TransactionEvent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Events] DROP CONSTRAINT [FK_TransactionEvent];
GO
IF OBJECT_ID(N'[dbo].[FK_ExpenseCategoryTransaction]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transactions] DROP CONSTRAINT [FK_ExpenseCategoryTransaction];
GO
IF OBJECT_ID(N'[dbo].[FK_IncomeSourceTransaction]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transactions] DROP CONSTRAINT [FK_IncomeSourceTransaction];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ExpenseCategories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ExpenseCategories];
GO
IF OBJECT_ID(N'[dbo].[IncomeSources]', 'U') IS NOT NULL
    DROP TABLE [dbo].[IncomeSources];
GO
IF OBJECT_ID(N'[dbo].[Transactions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Transactions];
GO
IF OBJECT_ID(N'[dbo].[Events]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Events];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ExpenseCategories'
CREATE TABLE [dbo].[ExpenseCategories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'IncomeSources'
CREATE TABLE [dbo].[IncomeSources] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Transactions'
CREATE TABLE [dbo].[Transactions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Detail] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL,
    [Currency] nvarchar(max)  NOT NULL,
    [Amount] float  NOT NULL,
    [TransactionType] nvarchar(max)  NOT NULL,
    [RecurrentType] nvarchar(max)  NOT NULL,
    [ExpenseCategoryId] int  NOT NULL,
    [IncomeSourceId] int  NOT NULL,
    [ExpenseCategory_Id] int  NULL,
    [IncomeSource_Id] int  NULL
);
GO

-- Creating table 'Events'
CREATE TABLE [dbo].[Events] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [EventType] nvarchar(max)  NOT NULL,
    [Location] nvarchar(max)  NULL,
    [From] datetime  NOT NULL,
    [To] datetime  NULL,
    [Repeat] nvarchar(max)  NOT NULL,
    [Currency] nvarchar(max)  NOT NULL,
    [Cost] float  NOT NULL,
    [Details] nvarchar(max)  NULL,
    [Reminder] nvarchar(max)  NULL,
    [Transaction_Id] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ExpenseCategories'
ALTER TABLE [dbo].[ExpenseCategories]
ADD CONSTRAINT [PK_ExpenseCategories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'IncomeSources'
ALTER TABLE [dbo].[IncomeSources]
ADD CONSTRAINT [PK_IncomeSources]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [PK_Transactions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [PK_Events]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Transaction_Id] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [FK_TransactionEvent]
    FOREIGN KEY ([Transaction_Id])
    REFERENCES [dbo].[Transactions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TransactionEvent'
CREATE INDEX [IX_FK_TransactionEvent]
ON [dbo].[Events]
    ([Transaction_Id]);
GO

-- Creating foreign key on [ExpenseCategory_Id] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [FK_ExpenseCategoryTransaction]
    FOREIGN KEY ([ExpenseCategory_Id])
    REFERENCES [dbo].[ExpenseCategories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExpenseCategoryTransaction'
CREATE INDEX [IX_FK_ExpenseCategoryTransaction]
ON [dbo].[Transactions]
    ([ExpenseCategory_Id]);
GO

-- Creating foreign key on [IncomeSource_Id] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [FK_IncomeSourceTransaction]
    FOREIGN KEY ([IncomeSource_Id])
    REFERENCES [dbo].[IncomeSources]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_IncomeSourceTransaction'
CREATE INDEX [IX_FK_IncomeSourceTransaction]
ON [dbo].[Transactions]
    ([IncomeSource_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------