﻿
-- ----------------------------------------------------------------------------------------------------------------
-- Generated by LLBLGen Pro v4.0  Build: May 15th, 2013
-- PostgreSql 7.x/8.x/9.x DDL Script generated from project: Enio
-- Project filename: G:\Documents\Visual Studio 2010\Projects\NinjaSoftware.EnioNg\Enio.llblgenproj
-- Script generated on: 04-ruj-2013 15:54.26
--
-- This is a Create script for creating a NEW data model. If you want DDL SQL for updating an existing model,
-- please create an Update script instead. 
--
-- This script might create schemas, which requires you to assign a proper user to the schema. Adjust the CREATE SCHEMA
-- statements below, if any, to avoid errors at runtime. Schemas aren't dropped in the DROP section.
--
--      >>>>> WARNING <<<<<
--      This is a CREATE script, with DROP statements for the existing tables, foreign keys and other constraints
--      This means that existing tables, data, constraints and other elements in the catalog/schemas addressed
--      are deleted. Use this Create script only to create new schemas with tables/constraints and other elements.
--
-- ----------------------------------------------------------------------------------------------------------------
-- ###############################################################################################################
-- DROP statements for existing elements. 
-- ###############################################################################################################
-- DROP statements for dropping existing elements with the same names as the ones created are commented out below. 
-- If you want to enable these statements for DROPping the existing elements first (which will remove all the data
-- in these existing elements), uncomment these statements by removing the two comment markers /* and */

-- Remove the comment marker on the NEXT line to enable DROP statements to remove existing elements
/* 
-- ----------------------------------------------------------------------------------------------------------------
-- DROP Foreign keys
-- ----------------------------------------------------------------------------------------------------------------

ALTER TABLE "public"."Artikl" DROP CONSTRAINT "FK_4e45d5942e08ead3c4e0bd8e7ed";

ALTER TABLE "public"."AuditInfo" DROP CONSTRAINT "FK_3e4d1924d38a8f32c0896d38bb1";

ALTER TABLE "public"."AuditInfo" DROP CONSTRAINT "FK_85d4ef0444ca6cd7a4cc1416bca";

ALTER TABLE "public"."AuditInfo" DROP CONSTRAINT "FK_e73cd164dba948457c85c27d632";

ALTER TABLE "public"."Error" DROP CONSTRAINT "FK_73aecbe4cfe9b4a40434eacf011";

ALTER TABLE "public"."RacunGlava" DROP CONSTRAINT "FK_432e8c241f98aed846b19115ec5";

ALTER TABLE "public"."RacunGlava" DROP CONSTRAINT "FK_6e54b2d453d9c2aca491fc88eb6";

ALTER TABLE "public"."RacunGlava" DROP CONSTRAINT "FK_de4ccaf4171b10223250058c83a";

ALTER TABLE "public"."RacunStavka" DROP CONSTRAINT "FK_0f87aab433f919d541b07458fb6";

ALTER TABLE "public"."RacunStavka" DROP CONSTRAINT "FK_494c7c54bbc8faa69f07c2ed698";

ALTER TABLE "public"."User" DROP CONSTRAINT "FK_15df8b8464f933e1f3cce430182";
-- ----------------------------------------------------------------------------------------------------------------
-- DROP tables for schema 'public' 
-- ----------------------------------------------------------------------------------------------------------------

DROP TABLE "public"."Artikl";

DROP TABLE "public"."AuditInfo";

DROP TABLE "public"."AuditInfoActionTypeRo";

DROP TABLE "public"."Brojac";

DROP TABLE "public"."Config";

DROP TABLE "public"."EntityRo";

DROP TABLE "public"."Error";

DROP TABLE "public"."Partner";

DROP TABLE "public"."Pdv";

DROP TABLE "public"."RacunGlava";

DROP TABLE "public"."RacunStavka";

DROP TABLE "public"."RoleRo";

DROP TABLE "public"."StatusRo";

DROP TABLE "public"."Tarifa";

DROP TABLE "public"."User";
-- ----------------------------------------------------------------------------------------------------------------
-- DROP sequences for schema 'public'
-- ----------------------------------------------------------------------------------------------------------------

DROP SEQUENCE "public"."GenericSequence";
*/
-- Remove the comment marker on the PREVIOUS line to enable DROP statements to remove existing elements

-- ###############################################################################################################
-- Create statements for catalogs, schemas, tables and sequences
-- ###############################################################################################################
-- ----------------------------------------------------------------------------------------------------------------
-- Catalog 'Default'
-- ----------------------------------------------------------------------------------------------------------------

-- ----------------------------------------------------------------------------------------------------------------
-- Schema 'public'
-- ----------------------------------------------------------------------------------------------------------------
--CREATE SCHEMA "public" /* AUTHORIZATION username */ ;

-- -------[ Tables ]-----------------------------------------------------------------------------------------------

CREATE TABLE "public"."Artikl"
(
	"ArtiklId" int8 NOT NULL, 
	"ConcurrencyGuid" varchar(50) NOT NULL, 
	"Jm" varchar(10) NOT NULL, 
	"Naziv" varchar(100) NOT NULL, 
	"PdvId" int8 NOT NULL, 
	"IsActive" bool NOT NULL, 
	"Cijena" numeric(10, 2) NOT NULL 
);

CREATE TABLE "public"."AuditInfo"
(
	"ActionDateTime" date NOT NULL, 
	"AuditInfoActionTypeId" int8 NOT NULL, 
	"AuditInfoId" int8 NOT NULL, 
	"ConcurrencyGuid" varchar(50) NOT NULL, 
	"EntityId" int8 NOT NULL, 
	"JsonData" text NOT NULL, 
	"PrimaryKeyValue" int8 NOT NULL, 
	"UserId" int8 NOT NULL 
);

CREATE TABLE "public"."AuditInfoActionTypeRo"
(
	"AuditInfoActionTypeId" int8 NOT NULL, 
	"Code" varchar(128) NOT NULL, 
	"Name" varchar(256) NOT NULL 
);

CREATE TABLE "public"."Brojac"
(
	"BrojacId" int8 NOT NULL, 
	"ConcurrencyGuid" varchar(50) NOT NULL, 
	"Godina" int2 NOT NULL, 
	"Naziv" varchar(100) NOT NULL, 
	"SlijedeciBroj" int4 NOT NULL 
);

CREATE TABLE "public"."Config"
(
	"Adresa" varchar(100) NULL, 
	"AktivnaGodina" int2 NOT NULL, 
	"ConcurrencyGuid" varchar(50) NOT NULL, 
	"Mjesto" varchar(100) NULL, 
	"Naziv" varchar(100) NOT NULL, 
	"Oib" varchar(11) NOT NULL, 
	"Zr" varchar(50) NULL, 
	"ConfigId" int8 NOT NULL 
);

CREATE TABLE "public"."EntityRo"
(
	"Code" varchar(128) NOT NULL, 
	"EntityId" int8 NOT NULL, 
	"Name" varchar(256) NOT NULL 
);

CREATE TABLE "public"."Error"
(
	"ConcurrencyGuid" varchar(50) NOT NULL, 
	"ErrorDateTime" date NOT NULL, 
	"ErrorId" int8 NOT NULL, 
	"Message" text NOT NULL, 
	"ParentErrorId" int8 NULL, 
	"StackTrace" text NULL 
);

CREATE TABLE "public"."Partner"
(
	"Adresa" varchar(100) NULL, 
	"ConcurrencyGuid" varchar(50) NOT NULL, 
	"Mjesto" varchar(20) NULL, 
	"Naziv" varchar(100) NOT NULL, 
	"Oib" varchar(11) NOT NULL, 
	"PartnerId" int8 NOT NULL, 
	"Posta" varchar(10) NULL, 
	"Valuta" int2 NOT NULL, 
	"IsActive" bool NOT NULL 
);

CREATE TABLE "public"."Pdv"
(
	"ConcurrencyGuid" varchar(50) NOT NULL, 
	"Naziv" varchar(128) NOT NULL, 
	"PdvId" int8 NOT NULL, 
	"Stopa" numeric(4, 2) NOT NULL 
);

CREATE TABLE "public"."RacunGlava"
(
	"ConcurrencyGuid" varchar(50) NOT NULL, 
	"Datum" date NOT NULL, 
	"Godina" int2 NOT NULL, 
	"MjestoRadaAdresa" varchar(100) NULL, 
	"MjestoRadaNaziv" varchar(100) NULL, 
	"PartnerId" int8 NOT NULL, 
	"RacunGlavaId" int8 NOT NULL, 
	"TarifaId" int8 NOT NULL, 
	"TarifaStopa" numeric(5, 2) NOT NULL, 
	"Valuta" int2 NOT NULL, 
	"StatusId" int8 NOT NULL, 
	"BrojRacuna" int4 NOT NULL, 
	"Vrijeme" varchar(10) NOT NULL 
);

CREATE TABLE "public"."RacunStavka"
(
	"ArtiklId" int8 NOT NULL, 
	"Cijena" numeric(10, 2) NOT NULL, 
	"ConcurrencyGuid" varchar(50) NOT NULL, 
	"Iznos" numeric(10, 2) NOT NULL, 
	"Kolicina" numeric(8, 2) NOT NULL, 
	"PdvIznos" numeric(10, 2) NOT NULL, 
	"PdvPosto" numeric(4, 2) NOT NULL, 
	"Pozicija" int2 NOT NULL, 
	"RacunGlavaId" int8 NOT NULL, 
	"RacunStavkaId" int8 NOT NULL, 
	"TarifaIznos" numeric(10, 2) NOT NULL 
);

CREATE TABLE "public"."RoleRo"
(
	"Code" varchar(50) NOT NULL, 
	"Name" varchar(50) NOT NULL, 
	"RoleId" int8 NOT NULL 
);

CREATE TABLE "public"."StatusRo"
(
	"Code" varchar(50) NOT NULL, 
	"Name" varchar(50) NOT NULL, 
	"StatusId" int8 NOT NULL 
);

CREATE TABLE "public"."Tarifa"
(
	"ConcurrencyGuid" varchar(50) NOT NULL, 
	"Naziv" varchar(100) NOT NULL, 
	"Stopa" numeric(5, 2) NOT NULL, 
	"TarifaId" int8 NOT NULL, 
	"IsActive" bool NOT NULL 
);

CREATE TABLE "public"."User"
(
	"ConcurrencyGuid" varchar(50) NOT NULL, 
	"UserId" int8 NOT NULL, 
	"Password" varchar(50) NOT NULL, 
	"Username" varchar(20) NOT NULL, 
	"RoleId" int8 NOT NULL 
);
-- -------[ Sequences ]--------------------------------------------------------------------------------------------

CREATE SEQUENCE "public"."GenericSequence" INCREMENT BY 1 NO MAXVALUE START WITH 1 NO CYCLE;

-- ###############################################################################################################
-- Create statements for Primary key constraints, Foreign key constraints and Unique constraints
-- ###############################################################################################################
-- ----------------------------------------------------------------------------------------------------------------
-- Catalog 'Default'
-- ----------------------------------------------------------------------------------------------------------------
-- ----------------------------------------------------------------------------------------------------------------
-- Primary Key constraints for schema 'public'
-- ----------------------------------------------------------------------------------------------------------------

ALTER TABLE "public"."Artikl"
	ADD CONSTRAINT "PK_8936853496aa7bc23377b00435f" PRIMARY KEY
	( 
		"ArtiklId" 
	);

ALTER TABLE "public"."AuditInfo"
	ADD CONSTRAINT "PK_0b908d34826b12bb7f49a3bff25" PRIMARY KEY
	( 
		"AuditInfoId" 
	);

ALTER TABLE "public"."AuditInfoActionTypeRo"
	ADD CONSTRAINT "PK_e26b5a24d0a8d27157211cb9154" PRIMARY KEY
	( 
		"AuditInfoActionTypeId" 
	);

ALTER TABLE "public"."Brojac"
	ADD CONSTRAINT "PK_35b0167480796dc7e7f871d25c8" PRIMARY KEY
	( 
		"BrojacId" 
	);

ALTER TABLE "public"."Config"
	ADD CONSTRAINT "PK_4861c114d20abf7ca2468310c58" PRIMARY KEY
	( 
		"ConfigId" 
	);

ALTER TABLE "public"."EntityRo"
	ADD CONSTRAINT "PK_59b55aa44c4bece91530673aba6" PRIMARY KEY
	( 
		"EntityId" 
	);

ALTER TABLE "public"."Error"
	ADD CONSTRAINT "PK_b6348e9412e9413b94bc7580ebc" PRIMARY KEY
	( 
		"ErrorId" 
	);

ALTER TABLE "public"."Partner"
	ADD CONSTRAINT "PK_ec363ca41a09a25ebb6c0283629" PRIMARY KEY
	( 
		"PartnerId" 
	);

ALTER TABLE "public"."Pdv"
	ADD CONSTRAINT "PK_f05e1b744968e53080a88f8b528" PRIMARY KEY
	( 
		"PdvId" 
	);

ALTER TABLE "public"."RacunGlava"
	ADD CONSTRAINT "PK_2ace6ec4137803379b7e704c868" PRIMARY KEY
	( 
		"RacunGlavaId" 
	);

ALTER TABLE "public"."RacunStavka"
	ADD CONSTRAINT "PK_eea0bcd456c9a21f143257b7cdb" PRIMARY KEY
	( 
		"RacunStavkaId" 
	);

ALTER TABLE "public"."RoleRo"
	ADD CONSTRAINT "PK_eb5df4740fda93e603b4a609eef" PRIMARY KEY
	( 
		"RoleId" 
	);

ALTER TABLE "public"."StatusRo"
	ADD CONSTRAINT "PK_c966b344206835938ce0e1a22cb" PRIMARY KEY
	( 
		"StatusId" 
	);

ALTER TABLE "public"."Tarifa"
	ADD CONSTRAINT "PK_a89a7a34ced81027e34dae234e2" PRIMARY KEY
	( 
		"TarifaId" 
	);

ALTER TABLE "public"."User"
	ADD CONSTRAINT "PK_f232d1c4e00ad36363f6b81c847" PRIMARY KEY
	( 
		"UserId" 
	);
-- ----------------------------------------------------------------------------------------------------------------
-- Unique constraints for schema 'public'
-- ----------------------------------------------------------------------------------------------------------------
-- ----------------------------------------------------------------------------------------------------------------
-- All foreign Key constraints
-- ----------------------------------------------------------------------------------------------------------------

ALTER TABLE "public"."Artikl" 
	ADD CONSTRAINT "FK_4e45d5942e08ead3c4e0bd8e7ed" FOREIGN KEY
	(
		"PdvId" 
	)
	REFERENCES "public"."Pdv"
	(
		"PdvId" 
	)
	ON DELETE NO ACTION
	ON UPDATE NO ACTION;


ALTER TABLE "public"."AuditInfo" 
	ADD CONSTRAINT "FK_3e4d1924d38a8f32c0896d38bb1" FOREIGN KEY
	(
		"UserId" 
	)
	REFERENCES "public"."User"
	(
		"UserId" 
	)
	ON DELETE NO ACTION
	ON UPDATE NO ACTION;


ALTER TABLE "public"."AuditInfo" 
	ADD CONSTRAINT "FK_85d4ef0444ca6cd7a4cc1416bca" FOREIGN KEY
	(
		"AuditInfoActionTypeId" 
	)
	REFERENCES "public"."AuditInfoActionTypeRo"
	(
		"AuditInfoActionTypeId" 
	)
	ON DELETE NO ACTION
	ON UPDATE NO ACTION;


ALTER TABLE "public"."AuditInfo" 
	ADD CONSTRAINT "FK_e73cd164dba948457c85c27d632" FOREIGN KEY
	(
		"EntityId" 
	)
	REFERENCES "public"."EntityRo"
	(
		"EntityId" 
	)
	ON DELETE NO ACTION
	ON UPDATE NO ACTION;


ALTER TABLE "public"."Error" 
	ADD CONSTRAINT "FK_73aecbe4cfe9b4a40434eacf011" FOREIGN KEY
	(
		"ParentErrorId" 
	)
	REFERENCES "public"."Error"
	(
		"ErrorId" 
	)
	ON DELETE NO ACTION
	ON UPDATE NO ACTION;


ALTER TABLE "public"."RacunGlava" 
	ADD CONSTRAINT "FK_432e8c241f98aed846b19115ec5" FOREIGN KEY
	(
		"PartnerId" 
	)
	REFERENCES "public"."Partner"
	(
		"PartnerId" 
	)
	ON DELETE NO ACTION
	ON UPDATE NO ACTION;


ALTER TABLE "public"."RacunGlava" 
	ADD CONSTRAINT "FK_6e54b2d453d9c2aca491fc88eb6" FOREIGN KEY
	(
		"StatusId" 
	)
	REFERENCES "public"."StatusRo"
	(
		"StatusId" 
	)
	ON DELETE NO ACTION
	ON UPDATE NO ACTION;


ALTER TABLE "public"."RacunGlava" 
	ADD CONSTRAINT "FK_de4ccaf4171b10223250058c83a" FOREIGN KEY
	(
		"TarifaId" 
	)
	REFERENCES "public"."Tarifa"
	(
		"TarifaId" 
	)
	ON DELETE NO ACTION
	ON UPDATE NO ACTION;


ALTER TABLE "public"."RacunStavka" 
	ADD CONSTRAINT "FK_0f87aab433f919d541b07458fb6" FOREIGN KEY
	(
		"ArtiklId" 
	)
	REFERENCES "public"."Artikl"
	(
		"ArtiklId" 
	)
	ON DELETE NO ACTION
	ON UPDATE NO ACTION;


ALTER TABLE "public"."RacunStavka" 
	ADD CONSTRAINT "FK_494c7c54bbc8faa69f07c2ed698" FOREIGN KEY
	(
		"RacunGlavaId" 
	)
	REFERENCES "public"."RacunGlava"
	(
		"RacunGlavaId" 
	)
	ON DELETE NO ACTION
	ON UPDATE NO ACTION;


ALTER TABLE "public"."User" 
	ADD CONSTRAINT "FK_15df8b8464f933e1f3cce430182" FOREIGN KEY
	(
		"RoleId" 
	)
	REFERENCES "public"."RoleRo"
	(
		"RoleId" 
	)
	ON DELETE NO ACTION
	ON UPDATE NO ACTION;

