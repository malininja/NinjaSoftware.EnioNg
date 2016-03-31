﻿
-- ----------------------------------------------------------------------------------------------------------------
-- Generated by LLBLGen Pro v4.2  Build: December 11th, 2015
-- PostgreSql 7.x/8.x/9.x DDL Script generated from project: Enio
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

-- ###############################################################################################################
-- Rename statements
-- ###############################################################################################################

-- ###############################################################################################################
-- DROP statements for elements no longer needed or replaced elements.
-- ###############################################################################################################

-- ###############################################################################################################
-- ADD statements for new elements (except FK/UC)
-- ###############################################################################################################

-- ###############################################################################################################
-- ALTER statements for table fields and ADD statements for new primary key constraints
-- ###############################################################################################################
ALTER TABLE "public"."Partner" 
	ALTER COLUMN "Mjesto" TYPE varchar(40);


-- ###############################################################################################################
-- ADD statements for new foreign key constraints, unique constraints and default values
-- ###############################################################################################################

