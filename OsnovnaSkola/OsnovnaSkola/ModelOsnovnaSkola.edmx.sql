
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/10/2020 19:03:06
-- Generated from EDMX file: C:\Users\Bozo\Desktop\Baze Specifikacije\OsnovnaSkola\OsnovnaSkola\ModelOsnovnaSkola.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [OsnovnaSkola];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Zadaje]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Kontrolna_tacka] DROP CONSTRAINT [FK_Zadaje];
GO
IF OBJECT_ID(N'[dbo].[FK_Vezana]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Predavanja] DROP CONSTRAINT [FK_Vezana];
GO
IF OBJECT_ID(N'[dbo].[FK_PredmetOblast]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Oblasti] DROP CONSTRAINT [FK_PredmetOblast];
GO
IF OBJECT_ID(N'[dbo].[FK_Pripada]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ucenici] DROP CONSTRAINT [FK_Pripada];
GO
IF OBJECT_ID(N'[dbo].[FK_Predjena]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cas] DROP CONSTRAINT [FK_Predjena];
GO
IF OBJECT_ID(N'[dbo].[FK_Kontrolna_tackaOdrzava]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[KontrolnaTackaCasovi] DROP CONSTRAINT [FK_Kontrolna_tackaOdrzava];
GO
IF OBJECT_ID(N'[dbo].[FK_CasOdrzava]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[KontrolnaTackaCasovi] DROP CONSTRAINT [FK_CasOdrzava];
GO
IF OBJECT_ID(N'[dbo].[FK_OdeljenjeIma]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Imaju] DROP CONSTRAINT [FK_OdeljenjeIma];
GO
IF OBJECT_ID(N'[dbo].[FK_CasIma]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Imaju] DROP CONSTRAINT [FK_CasIma];
GO
IF OBJECT_ID(N'[dbo].[FK_UcenikPrisustvo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Prisustva] DROP CONSTRAINT [FK_UcenikPrisustvo];
GO
IF OBJECT_ID(N'[dbo].[FK_CasPrisustvo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Prisustva] DROP CONSTRAINT [FK_CasPrisustvo];
GO
IF OBJECT_ID(N'[dbo].[FK_Kontrolna_tackaRadi]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Rade] DROP CONSTRAINT [FK_Kontrolna_tackaRadi];
GO
IF OBJECT_ID(N'[dbo].[FK_UcenikRadi]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Rade] DROP CONSTRAINT [FK_UcenikRadi];
GO
IF OBJECT_ID(N'[dbo].[FK_Drzi]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cas] DROP CONSTRAINT [FK_Drzi];
GO
IF OBJECT_ID(N'[dbo].[FK_Evidentira]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Prisustva] DROP CONSTRAINT [FK_Evidentira];
GO
IF OBJECT_ID(N'[dbo].[FK_ZaposleniRadi]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Rade] DROP CONSTRAINT [FK_ZaposleniRadi];
GO
IF OBJECT_ID(N'[dbo].[FK_ZaposleniPredavanje]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Predavanja] DROP CONSTRAINT [FK_ZaposleniPredavanje];
GO
IF OBJECT_ID(N'[dbo].[FK_NastavnikNastavnikOdeljenje]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NastavnikOdeljenjes] DROP CONSTRAINT [FK_NastavnikNastavnikOdeljenje];
GO
IF OBJECT_ID(N'[dbo].[FK_OdeljenjeNastavnikOdeljenje]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NastavnikOdeljenjes] DROP CONSTRAINT [FK_OdeljenjeNastavnikOdeljenje];
GO
IF OBJECT_ID(N'[dbo].[FK_PredmetNastavnik]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Zaposlenici_Nastavnik] DROP CONSTRAINT [FK_PredmetNastavnik];
GO
IF OBJECT_ID(N'[dbo].[FK_Nastavnik_inherits_Zaposleni]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Zaposlenici_Nastavnik] DROP CONSTRAINT [FK_Nastavnik_inherits_Zaposleni];
GO
IF OBJECT_ID(N'[dbo].[FK_Ucitelj_inherits_Zaposleni]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Zaposlenici_Ucitelj] DROP CONSTRAINT [FK_Ucitelj_inherits_Zaposleni];
GO
IF OBJECT_ID(N'[dbo].[FK_Domaci_inherits_Kontrolna_tacka]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Kontrolna_tacka_Domaci] DROP CONSTRAINT [FK_Domaci_inherits_Kontrolna_tacka];
GO
IF OBJECT_ID(N'[dbo].[FK_Kontrolni_inherits_Kontrolna_tacka]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Kontrolna_tacka_Kontrolni] DROP CONSTRAINT [FK_Kontrolni_inherits_Kontrolna_tacka];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Zaposlenici]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Zaposlenici];
GO
IF OBJECT_ID(N'[dbo].[Kontrolna_tacka]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Kontrolna_tacka];
GO
IF OBJECT_ID(N'[dbo].[Predavanja]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Predavanja];
GO
IF OBJECT_ID(N'[dbo].[Oblasti]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Oblasti];
GO
IF OBJECT_ID(N'[dbo].[Cas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cas];
GO
IF OBJECT_ID(N'[dbo].[Predmeti]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Predmeti];
GO
IF OBJECT_ID(N'[dbo].[Odeljenja]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Odeljenja];
GO
IF OBJECT_ID(N'[dbo].[Ucenici]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ucenici];
GO
IF OBJECT_ID(N'[dbo].[KontrolnaTackaCasovi]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KontrolnaTackaCasovi];
GO
IF OBJECT_ID(N'[dbo].[Imaju]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Imaju];
GO
IF OBJECT_ID(N'[dbo].[Prisustva]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Prisustva];
GO
IF OBJECT_ID(N'[dbo].[Rade]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Rade];
GO
IF OBJECT_ID(N'[dbo].[NastavnikOdeljenjes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NastavnikOdeljenjes];
GO
IF OBJECT_ID(N'[dbo].[Zaposlenici_Nastavnik]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Zaposlenici_Nastavnik];
GO
IF OBJECT_ID(N'[dbo].[Zaposlenici_Ucitelj]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Zaposlenici_Ucitelj];
GO
IF OBJECT_ID(N'[dbo].[Kontrolna_tacka_Domaci]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Kontrolna_tacka_Domaci];
GO
IF OBJECT_ID(N'[dbo].[Kontrolna_tacka_Kontrolni]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Kontrolna_tacka_Kontrolni];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Zaposlenici'
CREATE TABLE [dbo].[Zaposlenici] (
    [Id_zaposlenog] int IDENTITY(1,1) NOT NULL,
    [ime] nvarchar(max)  NOT NULL,
    [prezime] nvarchar(max)  NOT NULL,
    [zvanje] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Kontrolna_tacka'
CREATE TABLE [dbo].[Kontrolna_tacka] (
    [Id_kontrolne_tacke] int IDENTITY(1,1) NOT NULL,
    [zadatak] nvarchar(max)  NOT NULL,
    [ZaposleniId_zaposlenog] int  NOT NULL
);
GO

-- Creating table 'Predavanja'
CREATE TABLE [dbo].[Predavanja] (
    [Id_predavanja] int IDENTITY(1,1) NOT NULL,
    [opis] nvarchar(max)  NOT NULL,
    [datum_odrzavanja] datetime  NOT NULL,
    [OblastId_oblasti] int  NOT NULL,
    [ZaposleniId_zaposlenog] int  NOT NULL
);
GO

-- Creating table 'Oblasti'
CREATE TABLE [dbo].[Oblasti] (
    [Id_oblasti] int IDENTITY(1,1) NOT NULL,
    [naziv] nvarchar(max)  NOT NULL,
    [PredmetId_predmeta] int  NOT NULL
);
GO

-- Creating table 'Cas'
CREATE TABLE [dbo].[Cas] (
    [Id_casa] int IDENTITY(1,1) NOT NULL,
    [pocetak] time  NOT NULL,
    [kraj] time  NOT NULL,
    [datum] datetime  NOT NULL,
    [OblastId_oblasti] int  NULL,
    [ZaposleniId_zaposlenog] int  NOT NULL
);
GO

-- Creating table 'Predmeti'
CREATE TABLE [dbo].[Predmeti] (
    [Id_predmeta] int IDENTITY(1,1) NOT NULL,
    [razred] smallint  NOT NULL,
    [naziv] nvarchar(max)  NOT NULL,
    [broj_oblasti] smallint  NOT NULL
);
GO

-- Creating table 'Odeljenja'
CREATE TABLE [dbo].[Odeljenja] (
    [Id_odeljenja] int IDENTITY(1,1) NOT NULL,
    [razred] smallint  NOT NULL,
    [Ucitelj_Id_zaposlenog] int  NULL
);
GO

-- Creating table 'Ucenici'
CREATE TABLE [dbo].[Ucenici] (
    [Id_ucenika] int IDENTITY(1,1) NOT NULL,
    [ime] nvarchar(max)  NOT NULL,
    [prezime] nvarchar(max)  NOT NULL,
    [OdeljenjeId_odeljenja] int  NOT NULL,
    [Odeljenje_Id_odeljenja] int  NULL
);
GO

-- Creating table 'KontrolnaTackaCasovi'
CREATE TABLE [dbo].[KontrolnaTackaCasovi] (
    [Kontrolna_tackaId_kontrolne_tacke] int  NOT NULL,
    [CasId_casa] int  NOT NULL
);
GO

-- Creating table 'Imaju'
CREATE TABLE [dbo].[Imaju] (
    [OdeljenjeId_odeljenja] int  NOT NULL,
    [CasId_casa] int  NOT NULL
);
GO

-- Creating table 'Prisustva'
CREATE TABLE [dbo].[Prisustva] (
    [UcenikId_ucenika] int  NOT NULL,
    [CasId_casa] int  NOT NULL,
    [ZaposleniId_zaposlenog] int  NOT NULL
);
GO

-- Creating table 'Rade'
CREATE TABLE [dbo].[Rade] (
    [Kontrolna_tackaId_kontrolne_tacke] int  NOT NULL,
    [UcenikId_ucenika] int  NOT NULL,
    [ZaposleniId_zaposlenog] int  NOT NULL,
    [ocena] smallint  NOT NULL
);
GO

-- Creating table 'NastavnikOdeljenjes'
CREATE TABLE [dbo].[NastavnikOdeljenjes] (
    [NastavnikId_zaposlenog] int  NOT NULL,
    [OdeljenjeId_odeljenja] int  NOT NULL,
    [Razredni] bit  NOT NULL
);
GO

-- Creating table 'Zaposlenici_Nastavnik'
CREATE TABLE [dbo].[Zaposlenici_Nastavnik] (
    [PredmetId_predmeta] int  NULL,
    [Id_zaposlenog] int  NOT NULL
);
GO

-- Creating table 'Zaposlenici_Ucitelj'
CREATE TABLE [dbo].[Zaposlenici_Ucitelj] (
    [Id_zaposlenog] int  NOT NULL
);
GO

-- Creating table 'Kontrolna_tacka_Domaci'
CREATE TABLE [dbo].[Kontrolna_tacka_Domaci] (
    [dan_zadavanja] datetime  NOT NULL,
    [dan_predaje] datetime  NOT NULL,
    [Id_kontrolne_tacke] int  NOT NULL
);
GO

-- Creating table 'Kontrolna_tacka_Kontrolni'
CREATE TABLE [dbo].[Kontrolna_tacka_Kontrolni] (
    [datum_odrzavanja] datetime  NOT NULL,
    [Id_kontrolne_tacke] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id_zaposlenog] in table 'Zaposlenici'
ALTER TABLE [dbo].[Zaposlenici]
ADD CONSTRAINT [PK_Zaposlenici]
    PRIMARY KEY CLUSTERED ([Id_zaposlenog] ASC);
GO

-- Creating primary key on [Id_kontrolne_tacke] in table 'Kontrolna_tacka'
ALTER TABLE [dbo].[Kontrolna_tacka]
ADD CONSTRAINT [PK_Kontrolna_tacka]
    PRIMARY KEY CLUSTERED ([Id_kontrolne_tacke] ASC);
GO

-- Creating primary key on [Id_predavanja] in table 'Predavanja'
ALTER TABLE [dbo].[Predavanja]
ADD CONSTRAINT [PK_Predavanja]
    PRIMARY KEY CLUSTERED ([Id_predavanja] ASC);
GO

-- Creating primary key on [Id_oblasti] in table 'Oblasti'
ALTER TABLE [dbo].[Oblasti]
ADD CONSTRAINT [PK_Oblasti]
    PRIMARY KEY CLUSTERED ([Id_oblasti] ASC);
GO

-- Creating primary key on [Id_casa] in table 'Cas'
ALTER TABLE [dbo].[Cas]
ADD CONSTRAINT [PK_Cas]
    PRIMARY KEY CLUSTERED ([Id_casa] ASC);
GO

-- Creating primary key on [Id_predmeta] in table 'Predmeti'
ALTER TABLE [dbo].[Predmeti]
ADD CONSTRAINT [PK_Predmeti]
    PRIMARY KEY CLUSTERED ([Id_predmeta] ASC);
GO

-- Creating primary key on [Id_odeljenja] in table 'Odeljenja'
ALTER TABLE [dbo].[Odeljenja]
ADD CONSTRAINT [PK_Odeljenja]
    PRIMARY KEY CLUSTERED ([Id_odeljenja] ASC);
GO

-- Creating primary key on [Id_ucenika] in table 'Ucenici'
ALTER TABLE [dbo].[Ucenici]
ADD CONSTRAINT [PK_Ucenici]
    PRIMARY KEY CLUSTERED ([Id_ucenika] ASC);
GO

-- Creating primary key on [Kontrolna_tackaId_kontrolne_tacke], [CasId_casa] in table 'KontrolnaTackaCasovi'
ALTER TABLE [dbo].[KontrolnaTackaCasovi]
ADD CONSTRAINT [PK_KontrolnaTackaCasovi]
    PRIMARY KEY CLUSTERED ([Kontrolna_tackaId_kontrolne_tacke], [CasId_casa] ASC);
GO

-- Creating primary key on [OdeljenjeId_odeljenja], [CasId_casa] in table 'Imaju'
ALTER TABLE [dbo].[Imaju]
ADD CONSTRAINT [PK_Imaju]
    PRIMARY KEY CLUSTERED ([OdeljenjeId_odeljenja], [CasId_casa] ASC);
GO

-- Creating primary key on [UcenikId_ucenika], [CasId_casa] in table 'Prisustva'
ALTER TABLE [dbo].[Prisustva]
ADD CONSTRAINT [PK_Prisustva]
    PRIMARY KEY CLUSTERED ([UcenikId_ucenika], [CasId_casa] ASC);
GO

-- Creating primary key on [Kontrolna_tackaId_kontrolne_tacke], [UcenikId_ucenika] in table 'Rade'
ALTER TABLE [dbo].[Rade]
ADD CONSTRAINT [PK_Rade]
    PRIMARY KEY CLUSTERED ([Kontrolna_tackaId_kontrolne_tacke], [UcenikId_ucenika] ASC);
GO

-- Creating primary key on [NastavnikId_zaposlenog], [OdeljenjeId_odeljenja] in table 'NastavnikOdeljenjes'
ALTER TABLE [dbo].[NastavnikOdeljenjes]
ADD CONSTRAINT [PK_NastavnikOdeljenjes]
    PRIMARY KEY CLUSTERED ([NastavnikId_zaposlenog], [OdeljenjeId_odeljenja] ASC);
GO

-- Creating primary key on [Id_zaposlenog] in table 'Zaposlenici_Nastavnik'
ALTER TABLE [dbo].[Zaposlenici_Nastavnik]
ADD CONSTRAINT [PK_Zaposlenici_Nastavnik]
    PRIMARY KEY CLUSTERED ([Id_zaposlenog] ASC);
GO

-- Creating primary key on [Id_zaposlenog] in table 'Zaposlenici_Ucitelj'
ALTER TABLE [dbo].[Zaposlenici_Ucitelj]
ADD CONSTRAINT [PK_Zaposlenici_Ucitelj]
    PRIMARY KEY CLUSTERED ([Id_zaposlenog] ASC);
GO

-- Creating primary key on [Id_kontrolne_tacke] in table 'Kontrolna_tacka_Domaci'
ALTER TABLE [dbo].[Kontrolna_tacka_Domaci]
ADD CONSTRAINT [PK_Kontrolna_tacka_Domaci]
    PRIMARY KEY CLUSTERED ([Id_kontrolne_tacke] ASC);
GO

-- Creating primary key on [Id_kontrolne_tacke] in table 'Kontrolna_tacka_Kontrolni'
ALTER TABLE [dbo].[Kontrolna_tacka_Kontrolni]
ADD CONSTRAINT [PK_Kontrolna_tacka_Kontrolni]
    PRIMARY KEY CLUSTERED ([Id_kontrolne_tacke] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ZaposleniId_zaposlenog] in table 'Kontrolna_tacka'
ALTER TABLE [dbo].[Kontrolna_tacka]
ADD CONSTRAINT [FK_Zadaje]
    FOREIGN KEY ([ZaposleniId_zaposlenog])
    REFERENCES [dbo].[Zaposlenici]
        ([Id_zaposlenog])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Zadaje'
CREATE INDEX [IX_FK_Zadaje]
ON [dbo].[Kontrolna_tacka]
    ([ZaposleniId_zaposlenog]);
GO

-- Creating foreign key on [OblastId_oblasti] in table 'Predavanja'
ALTER TABLE [dbo].[Predavanja]
ADD CONSTRAINT [FK_Vezana]
    FOREIGN KEY ([OblastId_oblasti])
    REFERENCES [dbo].[Oblasti]
        ([Id_oblasti])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Vezana'
CREATE INDEX [IX_FK_Vezana]
ON [dbo].[Predavanja]
    ([OblastId_oblasti]);
GO

-- Creating foreign key on [PredmetId_predmeta] in table 'Oblasti'
ALTER TABLE [dbo].[Oblasti]
ADD CONSTRAINT [FK_PredmetOblast]
    FOREIGN KEY ([PredmetId_predmeta])
    REFERENCES [dbo].[Predmeti]
        ([Id_predmeta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PredmetOblast'
CREATE INDEX [IX_FK_PredmetOblast]
ON [dbo].[Oblasti]
    ([PredmetId_predmeta]);
GO

-- Creating foreign key on [Odeljenje_Id_odeljenja] in table 'Ucenici'
ALTER TABLE [dbo].[Ucenici]
ADD CONSTRAINT [FK_Pripada]
    FOREIGN KEY ([Odeljenje_Id_odeljenja])
    REFERENCES [dbo].[Odeljenja]
        ([Id_odeljenja])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Pripada'
CREATE INDEX [IX_FK_Pripada]
ON [dbo].[Ucenici]
    ([Odeljenje_Id_odeljenja]);
GO

-- Creating foreign key on [OblastId_oblasti] in table 'Cas'
ALTER TABLE [dbo].[Cas]
ADD CONSTRAINT [FK_Predjena]
    FOREIGN KEY ([OblastId_oblasti])
    REFERENCES [dbo].[Oblasti]
        ([Id_oblasti])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Predjena'
CREATE INDEX [IX_FK_Predjena]
ON [dbo].[Cas]
    ([OblastId_oblasti]);
GO

-- Creating foreign key on [Kontrolna_tackaId_kontrolne_tacke] in table 'KontrolnaTackaCasovi'
ALTER TABLE [dbo].[KontrolnaTackaCasovi]
ADD CONSTRAINT [FK_Kontrolna_tackaOdrzava]
    FOREIGN KEY ([Kontrolna_tackaId_kontrolne_tacke])
    REFERENCES [dbo].[Kontrolna_tacka]
        ([Id_kontrolne_tacke])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [CasId_casa] in table 'KontrolnaTackaCasovi'
ALTER TABLE [dbo].[KontrolnaTackaCasovi]
ADD CONSTRAINT [FK_CasOdrzava]
    FOREIGN KEY ([CasId_casa])
    REFERENCES [dbo].[Cas]
        ([Id_casa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CasOdrzava'
CREATE INDEX [IX_FK_CasOdrzava]
ON [dbo].[KontrolnaTackaCasovi]
    ([CasId_casa]);
GO

-- Creating foreign key on [OdeljenjeId_odeljenja] in table 'Imaju'
ALTER TABLE [dbo].[Imaju]
ADD CONSTRAINT [FK_OdeljenjeIma]
    FOREIGN KEY ([OdeljenjeId_odeljenja])
    REFERENCES [dbo].[Odeljenja]
        ([Id_odeljenja])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [CasId_casa] in table 'Imaju'
ALTER TABLE [dbo].[Imaju]
ADD CONSTRAINT [FK_CasIma]
    FOREIGN KEY ([CasId_casa])
    REFERENCES [dbo].[Cas]
        ([Id_casa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CasIma'
CREATE INDEX [IX_FK_CasIma]
ON [dbo].[Imaju]
    ([CasId_casa]);
GO

-- Creating foreign key on [UcenikId_ucenika] in table 'Prisustva'
ALTER TABLE [dbo].[Prisustva]
ADD CONSTRAINT [FK_UcenikPrisustvo]
    FOREIGN KEY ([UcenikId_ucenika])
    REFERENCES [dbo].[Ucenici]
        ([Id_ucenika])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [CasId_casa] in table 'Prisustva'
ALTER TABLE [dbo].[Prisustva]
ADD CONSTRAINT [FK_CasPrisustvo]
    FOREIGN KEY ([CasId_casa])
    REFERENCES [dbo].[Cas]
        ([Id_casa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CasPrisustvo'
CREATE INDEX [IX_FK_CasPrisustvo]
ON [dbo].[Prisustva]
    ([CasId_casa]);
GO

-- Creating foreign key on [Kontrolna_tackaId_kontrolne_tacke] in table 'Rade'
ALTER TABLE [dbo].[Rade]
ADD CONSTRAINT [FK_Kontrolna_tackaRadi]
    FOREIGN KEY ([Kontrolna_tackaId_kontrolne_tacke])
    REFERENCES [dbo].[Kontrolna_tacka]
        ([Id_kontrolne_tacke])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [UcenikId_ucenika] in table 'Rade'
ALTER TABLE [dbo].[Rade]
ADD CONSTRAINT [FK_UcenikRadi]
    FOREIGN KEY ([UcenikId_ucenika])
    REFERENCES [dbo].[Ucenici]
        ([Id_ucenika])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UcenikRadi'
CREATE INDEX [IX_FK_UcenikRadi]
ON [dbo].[Rade]
    ([UcenikId_ucenika]);
GO

-- Creating foreign key on [ZaposleniId_zaposlenog] in table 'Cas'
ALTER TABLE [dbo].[Cas]
ADD CONSTRAINT [FK_Drzi]
    FOREIGN KEY ([ZaposleniId_zaposlenog])
    REFERENCES [dbo].[Zaposlenici]
        ([Id_zaposlenog])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Drzi'
CREATE INDEX [IX_FK_Drzi]
ON [dbo].[Cas]
    ([ZaposleniId_zaposlenog]);
GO

-- Creating foreign key on [ZaposleniId_zaposlenog] in table 'Prisustva'
ALTER TABLE [dbo].[Prisustva]
ADD CONSTRAINT [FK_Evidentira]
    FOREIGN KEY ([ZaposleniId_zaposlenog])
    REFERENCES [dbo].[Zaposlenici]
        ([Id_zaposlenog])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Evidentira'
CREATE INDEX [IX_FK_Evidentira]
ON [dbo].[Prisustva]
    ([ZaposleniId_zaposlenog]);
GO

-- Creating foreign key on [ZaposleniId_zaposlenog] in table 'Rade'
ALTER TABLE [dbo].[Rade]
ADD CONSTRAINT [FK_ZaposleniRadi]
    FOREIGN KEY ([ZaposleniId_zaposlenog])
    REFERENCES [dbo].[Zaposlenici]
        ([Id_zaposlenog])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ZaposleniRadi'
CREATE INDEX [IX_FK_ZaposleniRadi]
ON [dbo].[Rade]
    ([ZaposleniId_zaposlenog]);
GO

-- Creating foreign key on [ZaposleniId_zaposlenog] in table 'Predavanja'
ALTER TABLE [dbo].[Predavanja]
ADD CONSTRAINT [FK_ZaposleniPredavanje]
    FOREIGN KEY ([ZaposleniId_zaposlenog])
    REFERENCES [dbo].[Zaposlenici]
        ([Id_zaposlenog])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ZaposleniPredavanje'
CREATE INDEX [IX_FK_ZaposleniPredavanje]
ON [dbo].[Predavanja]
    ([ZaposleniId_zaposlenog]);
GO

-- Creating foreign key on [NastavnikId_zaposlenog] in table 'NastavnikOdeljenjes'
ALTER TABLE [dbo].[NastavnikOdeljenjes]
ADD CONSTRAINT [FK_NastavnikNastavnikOdeljenje]
    FOREIGN KEY ([NastavnikId_zaposlenog])
    REFERENCES [dbo].[Zaposlenici_Nastavnik]
        ([Id_zaposlenog])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [OdeljenjeId_odeljenja] in table 'NastavnikOdeljenjes'
ALTER TABLE [dbo].[NastavnikOdeljenjes]
ADD CONSTRAINT [FK_OdeljenjeNastavnikOdeljenje]
    FOREIGN KEY ([OdeljenjeId_odeljenja])
    REFERENCES [dbo].[Odeljenja]
        ([Id_odeljenja])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OdeljenjeNastavnikOdeljenje'
CREATE INDEX [IX_FK_OdeljenjeNastavnikOdeljenje]
ON [dbo].[NastavnikOdeljenjes]
    ([OdeljenjeId_odeljenja]);
GO

-- Creating foreign key on [PredmetId_predmeta] in table 'Zaposlenici_Nastavnik'
ALTER TABLE [dbo].[Zaposlenici_Nastavnik]
ADD CONSTRAINT [FK_PredmetNastavnik]
    FOREIGN KEY ([PredmetId_predmeta])
    REFERENCES [dbo].[Predmeti]
        ([Id_predmeta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PredmetNastavnik'
CREATE INDEX [IX_FK_PredmetNastavnik]
ON [dbo].[Zaposlenici_Nastavnik]
    ([PredmetId_predmeta]);
GO

-- Creating foreign key on [Ucitelj_Id_zaposlenog] in table 'Odeljenja'
ALTER TABLE [dbo].[Odeljenja]
ADD CONSTRAINT [FK_UciteljOdeljenje]
    FOREIGN KEY ([Ucitelj_Id_zaposlenog])
    REFERENCES [dbo].[Zaposlenici_Ucitelj]
        ([Id_zaposlenog])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UciteljOdeljenje'
CREATE INDEX [IX_FK_UciteljOdeljenje]
ON [dbo].[Odeljenja]
    ([Ucitelj_Id_zaposlenog]);
GO

-- Creating foreign key on [Id_zaposlenog] in table 'Zaposlenici_Nastavnik'
ALTER TABLE [dbo].[Zaposlenici_Nastavnik]
ADD CONSTRAINT [FK_Nastavnik_inherits_Zaposleni]
    FOREIGN KEY ([Id_zaposlenog])
    REFERENCES [dbo].[Zaposlenici]
        ([Id_zaposlenog])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id_zaposlenog] in table 'Zaposlenici_Ucitelj'
ALTER TABLE [dbo].[Zaposlenici_Ucitelj]
ADD CONSTRAINT [FK_Ucitelj_inherits_Zaposleni]
    FOREIGN KEY ([Id_zaposlenog])
    REFERENCES [dbo].[Zaposlenici]
        ([Id_zaposlenog])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id_kontrolne_tacke] in table 'Kontrolna_tacka_Domaci'
ALTER TABLE [dbo].[Kontrolna_tacka_Domaci]
ADD CONSTRAINT [FK_Domaci_inherits_Kontrolna_tacka]
    FOREIGN KEY ([Id_kontrolne_tacke])
    REFERENCES [dbo].[Kontrolna_tacka]
        ([Id_kontrolne_tacke])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id_kontrolne_tacke] in table 'Kontrolna_tacka_Kontrolni'
ALTER TABLE [dbo].[Kontrolna_tacka_Kontrolni]
ADD CONSTRAINT [FK_Kontrolni_inherits_Kontrolna_tacka]
    FOREIGN KEY ([Id_kontrolne_tacke])
    REFERENCES [dbo].[Kontrolna_tacka]
        ([Id_kontrolne_tacke])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------