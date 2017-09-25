
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/25/2017 09:22:29
-- Generated from EDMX file: C:\Users\Administrateur\Source\Repos\ProjetAbiMetierDAO\DAO\ABI.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ABI];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CollaborateurContrats]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContratsSet] DROP CONSTRAINT [FK_CollaborateurContrats];
GO
IF OBJECT_ID(N'[dbo].[FK_Temporaire_inherits_Contrats]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContratsSet_Temporaire] DROP CONSTRAINT [FK_Temporaire_inherits_Contrats];
GO
IF OBJECT_ID(N'[dbo].[FK_CDI_inherits_Contrats]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContratsSet_CDI] DROP CONSTRAINT [FK_CDI_inherits_Contrats];
GO
IF OBJECT_ID(N'[dbo].[FK_Cdd_inherits_Temporaire]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContratsSet_Cdd] DROP CONSTRAINT [FK_Cdd_inherits_Temporaire];
GO
IF OBJECT_ID(N'[dbo].[FK_Interim_inherits_Temporaire]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContratsSet_Interim] DROP CONSTRAINT [FK_Interim_inherits_Temporaire];
GO
IF OBJECT_ID(N'[dbo].[FK_Stage_inherits_Temporaire]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContratsSet_Stage] DROP CONSTRAINT [FK_Stage_inherits_Temporaire];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CollaborateurSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CollaborateurSet];
GO
IF OBJECT_ID(N'[dbo].[ContratsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContratsSet];
GO
IF OBJECT_ID(N'[dbo].[ContratsSet_Temporaire]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContratsSet_Temporaire];
GO
IF OBJECT_ID(N'[dbo].[ContratsSet_CDI]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContratsSet_CDI];
GO
IF OBJECT_ID(N'[dbo].[ContratsSet_Cdd]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContratsSet_Cdd];
GO
IF OBJECT_ID(N'[dbo].[ContratsSet_Interim]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContratsSet_Interim];
GO
IF OBJECT_ID(N'[dbo].[ContratsSet_Stage]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContratsSet_Stage];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CollaborateurSet'
CREATE TABLE [dbo].[CollaborateurSet] (
    [Matricule] int  NOT NULL,
    [PrenomCollaborateur] nvarchar(20)  NOT NULL,
    [NomCollaborateur] nvarchar(20)  NOT NULL,
    [PhotoCollaborateur] nvarchar(max)  NOT NULL,
    [NumeroSecu] int  NOT NULL
);
GO

-- Creating table 'ContratsSet'
CREATE TABLE [dbo].[ContratsSet] (
    [NumeroContrat] int IDENTITY(1,1) NOT NULL,
    [Qualification] nvarchar(20)  NOT NULL,
    [Statut] nvarchar(20)  NOT NULL,
    [SalaireBrut] decimal(18,0)  NULL,
    [DateDebut] datetime  NOT NULL,
    [DateFinReel] datetime  NULL,
    [CollaborateurMatricule] int  NOT NULL
);
GO

-- Creating table 'ContratsSet_Temporaire'
CREATE TABLE [dbo].[ContratsSet_Temporaire] (
    [DateFin] datetime  NOT NULL,
    [Motf] nvarchar(max)  NOT NULL,
    [NumeroContrat] int  NOT NULL
);
GO

-- Creating table 'ContratsSet_CDI'
CREATE TABLE [dbo].[ContratsSet_CDI] (
    [NumeroContrat] int  NOT NULL
);
GO

-- Creating table 'ContratsSet_Cdd'
CREATE TABLE [dbo].[ContratsSet_Cdd] (
    [NumeroContrat] int  NOT NULL
);
GO

-- Creating table 'ContratsSet_Interim'
CREATE TABLE [dbo].[ContratsSet_Interim] (
    [AgenceInterim] nvarchar(max)  NOT NULL,
    [Indemnites] decimal(18,0)  NOT NULL,
    [NumeroContrat] int  NOT NULL
);
GO

-- Creating table 'ContratsSet_Stage'
CREATE TABLE [dbo].[ContratsSet_Stage] (
    [Ecole] nvarchar(max)  NOT NULL,
    [Mission] nvarchar(max)  NOT NULL,
    [NumeroContrat] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Matricule] in table 'CollaborateurSet'
ALTER TABLE [dbo].[CollaborateurSet]
ADD CONSTRAINT [PK_CollaborateurSet]
    PRIMARY KEY CLUSTERED ([Matricule] ASC);
GO

-- Creating primary key on [NumeroContrat] in table 'ContratsSet'
ALTER TABLE [dbo].[ContratsSet]
ADD CONSTRAINT [PK_ContratsSet]
    PRIMARY KEY CLUSTERED ([NumeroContrat] ASC);
GO

-- Creating primary key on [NumeroContrat] in table 'ContratsSet_Temporaire'
ALTER TABLE [dbo].[ContratsSet_Temporaire]
ADD CONSTRAINT [PK_ContratsSet_Temporaire]
    PRIMARY KEY CLUSTERED ([NumeroContrat] ASC);
GO

-- Creating primary key on [NumeroContrat] in table 'ContratsSet_CDI'
ALTER TABLE [dbo].[ContratsSet_CDI]
ADD CONSTRAINT [PK_ContratsSet_CDI]
    PRIMARY KEY CLUSTERED ([NumeroContrat] ASC);
GO

-- Creating primary key on [NumeroContrat] in table 'ContratsSet_Cdd'
ALTER TABLE [dbo].[ContratsSet_Cdd]
ADD CONSTRAINT [PK_ContratsSet_Cdd]
    PRIMARY KEY CLUSTERED ([NumeroContrat] ASC);
GO

-- Creating primary key on [NumeroContrat] in table 'ContratsSet_Interim'
ALTER TABLE [dbo].[ContratsSet_Interim]
ADD CONSTRAINT [PK_ContratsSet_Interim]
    PRIMARY KEY CLUSTERED ([NumeroContrat] ASC);
GO

-- Creating primary key on [NumeroContrat] in table 'ContratsSet_Stage'
ALTER TABLE [dbo].[ContratsSet_Stage]
ADD CONSTRAINT [PK_ContratsSet_Stage]
    PRIMARY KEY CLUSTERED ([NumeroContrat] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CollaborateurMatricule] in table 'ContratsSet'
ALTER TABLE [dbo].[ContratsSet]
ADD CONSTRAINT [FK_CollaborateurContrats]
    FOREIGN KEY ([CollaborateurMatricule])
    REFERENCES [dbo].[CollaborateurSet]
        ([Matricule])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CollaborateurContrats'
CREATE INDEX [IX_FK_CollaborateurContrats]
ON [dbo].[ContratsSet]
    ([CollaborateurMatricule]);
GO

-- Creating foreign key on [NumeroContrat] in table 'ContratsSet_Temporaire'
ALTER TABLE [dbo].[ContratsSet_Temporaire]
ADD CONSTRAINT [FK_Temporaire_inherits_Contrats]
    FOREIGN KEY ([NumeroContrat])
    REFERENCES [dbo].[ContratsSet]
        ([NumeroContrat])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [NumeroContrat] in table 'ContratsSet_CDI'
ALTER TABLE [dbo].[ContratsSet_CDI]
ADD CONSTRAINT [FK_CDI_inherits_Contrats]
    FOREIGN KEY ([NumeroContrat])
    REFERENCES [dbo].[ContratsSet]
        ([NumeroContrat])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [NumeroContrat] in table 'ContratsSet_Cdd'
ALTER TABLE [dbo].[ContratsSet_Cdd]
ADD CONSTRAINT [FK_Cdd_inherits_Temporaire]
    FOREIGN KEY ([NumeroContrat])
    REFERENCES [dbo].[ContratsSet_Temporaire]
        ([NumeroContrat])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [NumeroContrat] in table 'ContratsSet_Interim'
ALTER TABLE [dbo].[ContratsSet_Interim]
ADD CONSTRAINT [FK_Interim_inherits_Temporaire]
    FOREIGN KEY ([NumeroContrat])
    REFERENCES [dbo].[ContratsSet_Temporaire]
        ([NumeroContrat])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [NumeroContrat] in table 'ContratsSet_Stage'
ALTER TABLE [dbo].[ContratsSet_Stage]
ADD CONSTRAINT [FK_Stage_inherits_Temporaire]
    FOREIGN KEY ([NumeroContrat])
    REFERENCES [dbo].[ContratsSet_Temporaire]
        ([NumeroContrat])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------