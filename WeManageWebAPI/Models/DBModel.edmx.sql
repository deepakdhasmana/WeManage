
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/23/2018 12:46:28
-- Generated from EDMX file: C:\Users\deepak.dashmana\Documents\Visual Studio 2015\Projects\WeManage\WeManageWebAPI\Models\DBModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [WeManage];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UserLogins'
CREATE TABLE [dbo].[UserLogins] (
    [UserLoginID] int IDENTITY(1,1) NOT NULL,
    [UserID] nvarchar(20)  NOT NULL,
    [UserName] nvarchar(100)  NOT NULL,
    [Password] nvarchar(20)  NOT NULL,
    [Flag] tinyint  NOT NULL,
    [LastLoginTimeStamp] datetime  NOT NULL
);
GO

-- Creating table 'Projects'
CREATE TABLE [dbo].[Projects] (
    [ProjectID] int IDENTITY(1,1) NOT NULL,
    [ProjectCode] nvarchar(max)  NOT NULL,
    [ProjectName] nvarchar(max)  NOT NULL,
    [ProjectStartDate] nvarchar(max)  NOT NULL,
    [ProjectEndDate] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Tasks'
CREATE TABLE [dbo].[Tasks] (
    [TasksID] int IDENTITY(1,1) NOT NULL,
    [TasksStartDate] float  NOT NULL,
    [TasksEndDate] datetime  NOT NULL,
    [TasksHours] float  NOT NULL,
    [TasksStatus] tinyint  NOT NULL,
    [TasksStartDateActual] datetime  NOT NULL,
    [TasksEndDateActual] datetime  NOT NULL,
    [TasksHoursActual] float  NOT NULL,
    [TasksHoursCoding] float  NOT NULL,
    [TasksHoursTesting] float  NOT NULL,
    [TasksHoursOthers] float  NOT NULL,
    [TasksSV] float  NOT NULL,
    [TasksEV] float  NOT NULL,
    [TasksIsMilestone] tinyint  NOT NULL,
    [TasksProjectID] int  NOT NULL
);
GO

-- Creating table 'DTS'
CREATE TABLE [dbo].[DTS] (
    [DTSID] int IDENTITY(1,1) NOT NULL,
    [DTSDate] datetime  NOT NULL,
    [DTSTasksID] int  NOT NULL,
    [DTSUserLoginID] int  NOT NULL,
    [DTSActivityID] int  NOT NULL,
    [DTSTimeFrom] nvarchar(max)  NOT NULL,
    [DTSTimeTill] nvarchar(max)  NOT NULL,
    [DTSHours] nvarchar(max)  NOT NULL,
    [DTSStatus] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'QCs'
CREATE TABLE [dbo].[QCs] (
    [QCID] int IDENTITY(1,1) NOT NULL,
    [QCDate] nvarchar(max)  NOT NULL,
    [QCBugs] nvarchar(max)  NOT NULL,
    [QCProjectID] nvarchar(max)  NOT NULL,
    [QCUserLoginID] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [UserLoginID] in table 'UserLogins'
ALTER TABLE [dbo].[UserLogins]
ADD CONSTRAINT [PK_UserLogins]
    PRIMARY KEY CLUSTERED ([UserLoginID] ASC);
GO

-- Creating primary key on [ProjectID] in table 'Projects'
ALTER TABLE [dbo].[Projects]
ADD CONSTRAINT [PK_Projects]
    PRIMARY KEY CLUSTERED ([ProjectID] ASC);
GO

-- Creating primary key on [TasksID] in table 'Tasks'
ALTER TABLE [dbo].[Tasks]
ADD CONSTRAINT [PK_Tasks]
    PRIMARY KEY CLUSTERED ([TasksID] ASC);
GO

-- Creating primary key on [DTSID] in table 'DTS'
ALTER TABLE [dbo].[DTS]
ADD CONSTRAINT [PK_DTS]
    PRIMARY KEY CLUSTERED ([DTSID] ASC);
GO

-- Creating primary key on [QCID] in table 'QCs'
ALTER TABLE [dbo].[QCs]
ADD CONSTRAINT [PK_QCs]
    PRIMARY KEY CLUSTERED ([QCID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------