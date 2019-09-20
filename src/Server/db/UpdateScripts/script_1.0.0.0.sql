-------------------------------------------------------------------------------------------------------------
-- Create Database
-------------------------------------------------------------------------------------------------------------
CREATE DATABASE [Lucas]
GO

-------------------------------------------------------------------------------------------------------------
-- Create Tables
-------------------------------------------------------------------------------------------------------------
USE [Lucas]
GO

CREATE TABLE [User] (
    [UserId] int NOT NULL IDENTITY,
    [FirstName] nvarchar(100) NOT NULL,
	[LastName] nvarchar(100) NOT NULL,
	[Location] nvarchar(50) NOT NULL,
	[Bob] datetime,
	[PhoneNumber] nvarchar(12),
	[Email] nvarchar(100) NOT NULL,
	[Active] bit NOT NULL,
	[Created] datetime NOT NULL,
	[Modified] datetime NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY ([UserId])
);
GO

CREATE TABLE [Pet] (
    [PetId] int NOT NULL IDENTITY,
    [UserId] int NOT NULL,
    [Name] nvarchar(100) NOT NULL,
    [isOwner] bit,
	[Created] datetime NOT NULL,
	[Modified] datetime NOT NULL,
    CONSTRAINT [PK_Pet] PRIMARY KEY ([PetId]),
    CONSTRAINT [FK_Pet_User_UserId] FOREIGN KEY ([UserId]) REFERENCES [User] ([UserId]) ON DELETE CASCADE
);
GO
