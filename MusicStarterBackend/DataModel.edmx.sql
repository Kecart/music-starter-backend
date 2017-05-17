
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/17/2017 13:02:00
-- Generated from EDMX file: C:\Users\Kamil\documents\visual studio 2015\Projects\MusicStarterBackend\MusicStarterBackend\DataModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Database];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AuthorTrack]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TrackSet] DROP CONSTRAINT [FK_AuthorTrack];
GO
IF OBJECT_ID(N'[dbo].[FK_AuthorAlbum]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AlbumSet] DROP CONSTRAINT [FK_AuthorAlbum];
GO
IF OBJECT_ID(N'[dbo].[FK_AlbumTrack]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TrackSet] DROP CONSTRAINT [FK_AlbumTrack];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[AuthorSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AuthorSet];
GO
IF OBJECT_ID(N'[dbo].[TrackSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TrackSet];
GO
IF OBJECT_ID(N'[dbo].[AlbumSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AlbumSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AuthorSet'
CREATE TABLE [dbo].[AuthorSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TrackSet'
CREATE TABLE [dbo].[TrackSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Duration] time  NOT NULL,
    [DateTime] datetime  NOT NULL,
    [Rating] float  NOT NULL,
    [File] nvarchar(max)  NOT NULL,
    [Author_Id] int  NOT NULL,
    [Album_Id] int  NULL
);
GO

-- Creating table 'AlbumSet'
CREATE TABLE [dbo].[AlbumSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [CoverFile] nvarchar(max)  NOT NULL,
    [Author_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'AuthorSet'
ALTER TABLE [dbo].[AuthorSet]
ADD CONSTRAINT [PK_AuthorSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TrackSet'
ALTER TABLE [dbo].[TrackSet]
ADD CONSTRAINT [PK_TrackSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AlbumSet'
ALTER TABLE [dbo].[AlbumSet]
ADD CONSTRAINT [PK_AlbumSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Author_Id] in table 'TrackSet'
ALTER TABLE [dbo].[TrackSet]
ADD CONSTRAINT [FK_AuthorTrack]
    FOREIGN KEY ([Author_Id])
    REFERENCES [dbo].[AuthorSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AuthorTrack'
CREATE INDEX [IX_FK_AuthorTrack]
ON [dbo].[TrackSet]
    ([Author_Id]);
GO

-- Creating foreign key on [Author_Id] in table 'AlbumSet'
ALTER TABLE [dbo].[AlbumSet]
ADD CONSTRAINT [FK_AuthorAlbum]
    FOREIGN KEY ([Author_Id])
    REFERENCES [dbo].[AuthorSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AuthorAlbum'
CREATE INDEX [IX_FK_AuthorAlbum]
ON [dbo].[AlbumSet]
    ([Author_Id]);
GO

-- Creating foreign key on [Album_Id] in table 'TrackSet'
ALTER TABLE [dbo].[TrackSet]
ADD CONSTRAINT [FK_AlbumTrack]
    FOREIGN KEY ([Album_Id])
    REFERENCES [dbo].[AlbumSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AlbumTrack'
CREATE INDEX [IX_FK_AlbumTrack]
ON [dbo].[TrackSet]
    ([Album_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------