﻿
-- ----------------------------------------------------------------------------------------------------------------
-- Generated by LLBLGen Pro v4.2  Build: December 11th, 2015
-- SQL Server 2000/2005/2008/2008R2/2012/Express DDL Script generated from project: Enio
-- Project filename: C:\Users\ninja\Documents\GitHub\NinjaSoftware.EnioNg\Enio.llblgenproj
-- Script generated on: 31-ožu-2016 07:07.48
--
-- This is an Update script for updating an existing data model to a newer version. If you want DDL SQL for a new model,
-- please create a Create script instead. 
--
-- This script might create schemas, which requires you to assign a proper user to the schema. Adjust the CREATE SCHEMA
-- statements below, if any, to avoid errors at runtime.
--
-- Please run the scripts in the right order, use the timestamp in the filename and inside this script for that.
-- This script might need adjustment in some statements. You should consider this script as a starting point for
-- upgrading the existing data model.
-- ----------------------------------------------------------------------------------------------------------------
-- ###############################################################################################################
-- Drop constraints referring to elements which are changed in this script (constraints are recreated later on)
-- ###############################################################################################################

USE [EnioNg]
GO

-- ###############################################################################################################
-- Rename statements
-- ###############################################################################################################

USE [EnioNg]
GO

-- ###############################################################################################################
-- DROP statements for elements no longer needed or replaced elements.
-- ###############################################################################################################

USE [EnioNg]
GO

-- ###############################################################################################################
-- ADD statements for new elements (except FK/UC)
-- ###############################################################################################################

USE [EnioNg]
GO

-- ###############################################################################################################
-- ALTER statements for table fields and ADD statements for new primary key constraints
-- ###############################################################################################################

USE [EnioNg]
GO

ALTER TABLE [dbo].[Partner] 
	ALTER COLUMN [Mjesto] [nvarchar] (40) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
GO

-- ###############################################################################################################
-- ADD statements for new foreign key constraints, unique constraints and default values
-- ###############################################################################################################

USE [EnioNg]
GO

