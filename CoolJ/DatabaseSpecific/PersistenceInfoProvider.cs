///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.2
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Data;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace NinjaSoftware.EnioNg.CoolJ.DatabaseSpecific
{
	/// <summary>Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the PersistenceInfoProviderBase class is threadsafe.</remarks>
	internal static class PersistenceInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static PersistenceInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the PersistenceInfoProviderCore</summary>
		/// <returns>Instance of the PersistenceInfoProvider.</returns>
		public static IPersistenceInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the PersistenceInfoProvider. Used by singleton wrapper.</summary>
	internal class PersistenceInfoProviderCore : PersistenceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="PersistenceInfoProviderCore"/> class.</summary>
		internal PersistenceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			this.InitClass(15);
			InitArtiklEntityMappings();
			InitAuditInfoEntityMappings();
			InitAuditInfoActionTypeRoEntityMappings();
			InitBrojacEntityMappings();
			InitConfigEntityMappings();
			InitEntityRoEntityMappings();
			InitErrorEntityMappings();
			InitPartnerEntityMappings();
			InitPdvEntityMappings();
			InitRacunGlavaEntityMappings();
			InitRacunStavkaEntityMappings();
			InitRoleRoEntityMappings();
			InitStatusRoEntityMappings();
			InitTarifaEntityMappings();
			InitUserEntityMappings();
		}

		/// <summary>Inits ArtiklEntity's mappings</summary>
		private void InitArtiklEntityMappings()
		{
			this.AddElementMapping("ArtiklEntity", @"Default", @"public", "Artikl", 7, 0);
			this.AddElementFieldMapping("ArtiklEntity", "ArtiklId", "ArtiklId", false, "Bigint", 0, 19, 0, false, "public.GenericSequence", null, typeof(System.Int64), 0);
			this.AddElementFieldMapping("ArtiklEntity", "Cijena", "Cijena", false, "Numeric", 0, 10, 2, false, "", null, typeof(System.Decimal), 1);
			this.AddElementFieldMapping("ArtiklEntity", "ConcurrencyGuid", "ConcurrencyGuid", false, "Varchar", 50, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("ArtiklEntity", "IsActive", "IsActive", false, "Boolean", 0, 0, 0, false, "", null, typeof(System.Boolean), 3);
			this.AddElementFieldMapping("ArtiklEntity", "Jm", "Jm", false, "Varchar", 10, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("ArtiklEntity", "Naziv", "Naziv", false, "Varchar", 100, 0, 0, false, "", null, typeof(System.String), 5);
			this.AddElementFieldMapping("ArtiklEntity", "PdvId", "PdvId", false, "Bigint", 0, 19, 0, false, "", null, typeof(System.Int64), 6);
		}

		/// <summary>Inits AuditInfoEntity's mappings</summary>
		private void InitAuditInfoEntityMappings()
		{
			this.AddElementMapping("AuditInfoEntity", @"Default", @"public", "AuditInfo", 8, 0);
			this.AddElementFieldMapping("AuditInfoEntity", "ActionDateTime", "ActionDateTime", false, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("AuditInfoEntity", "AuditInfoActionTypeId", "AuditInfoActionTypeId", false, "Bigint", 0, 19, 0, false, "", null, typeof(System.Int64), 1);
			this.AddElementFieldMapping("AuditInfoEntity", "AuditInfoId", "AuditInfoId", false, "Bigint", 0, 19, 0, false, "public.GenericSequence", null, typeof(System.Int64), 2);
			this.AddElementFieldMapping("AuditInfoEntity", "ConcurrencyGuid", "ConcurrencyGuid", false, "Varchar", 50, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("AuditInfoEntity", "EntityId", "EntityId", false, "Bigint", 0, 19, 0, false, "", null, typeof(System.Int64), 4);
			this.AddElementFieldMapping("AuditInfoEntity", "JsonData", "JsonData", false, "Text", 1073741823, 0, 0, false, "", null, typeof(System.String), 5);
			this.AddElementFieldMapping("AuditInfoEntity", "PrimaryKeyValue", "PrimaryKeyValue", false, "Bigint", 0, 19, 0, false, "", null, typeof(System.Int64), 6);
			this.AddElementFieldMapping("AuditInfoEntity", "UserId", "UserId", false, "Bigint", 0, 19, 0, false, "", null, typeof(System.Int64), 7);
		}

		/// <summary>Inits AuditInfoActionTypeRoEntity's mappings</summary>
		private void InitAuditInfoActionTypeRoEntityMappings()
		{
			this.AddElementMapping("AuditInfoActionTypeRoEntity", @"Default", @"public", "AuditInfoActionTypeRo", 3, 0);
			this.AddElementFieldMapping("AuditInfoActionTypeRoEntity", "AuditInfoActionTypeId", "AuditInfoActionTypeId", false, "Bigint", 0, 19, 0, false, "", null, typeof(System.Int64), 0);
			this.AddElementFieldMapping("AuditInfoActionTypeRoEntity", "Code", "Code", false, "Varchar", 128, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("AuditInfoActionTypeRoEntity", "Name", "Name", false, "Varchar", 256, 0, 0, false, "", null, typeof(System.String), 2);
		}

		/// <summary>Inits BrojacEntity's mappings</summary>
		private void InitBrojacEntityMappings()
		{
			this.AddElementMapping("BrojacEntity", @"Default", @"public", "Brojac", 5, 0);
			this.AddElementFieldMapping("BrojacEntity", "BrojacId", "BrojacId", false, "Bigint", 0, 19, 0, false, "public.GenericSequence", null, typeof(System.Int64), 0);
			this.AddElementFieldMapping("BrojacEntity", "ConcurrencyGuid", "ConcurrencyGuid", false, "Varchar", 50, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("BrojacEntity", "Godina", "Godina", false, "Smallint", 0, 0, 0, false, "", null, typeof(System.Int16), 2);
			this.AddElementFieldMapping("BrojacEntity", "Naziv", "Naziv", false, "Varchar", 100, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("BrojacEntity", "SlijedeciBroj", "SlijedeciBroj", false, "Integer", 0, 0, 0, false, "", null, typeof(System.Int32), 4);
		}

		/// <summary>Inits ConfigEntity's mappings</summary>
		private void InitConfigEntityMappings()
		{
			this.AddElementMapping("ConfigEntity", @"Default", @"public", "Config", 8, 0);
			this.AddElementFieldMapping("ConfigEntity", "Adresa", "Adresa", true, "Varchar", 100, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("ConfigEntity", "AktivnaGodina", "AktivnaGodina", false, "Smallint", 0, 0, 0, false, "", null, typeof(System.Int16), 1);
			this.AddElementFieldMapping("ConfigEntity", "ConcurrencyGuid", "ConcurrencyGuid", false, "Varchar", 50, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("ConfigEntity", "ConfigId", "ConfigId", false, "Bigint", 0, 19, 0, false, "", null, typeof(System.Int64), 3);
			this.AddElementFieldMapping("ConfigEntity", "Mjesto", "Mjesto", true, "Varchar", 100, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("ConfigEntity", "Naziv", "Naziv", false, "Varchar", 100, 0, 0, false, "", null, typeof(System.String), 5);
			this.AddElementFieldMapping("ConfigEntity", "Oib", "Oib", false, "Varchar", 11, 0, 0, false, "", null, typeof(System.String), 6);
			this.AddElementFieldMapping("ConfigEntity", "Zr", "Zr", true, "Varchar", 50, 0, 0, false, "", null, typeof(System.String), 7);
		}

		/// <summary>Inits EntityRoEntity's mappings</summary>
		private void InitEntityRoEntityMappings()
		{
			this.AddElementMapping("EntityRoEntity", @"Default", @"public", "EntityRo", 3, 0);
			this.AddElementFieldMapping("EntityRoEntity", "Code", "Code", false, "Varchar", 128, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("EntityRoEntity", "EntityId", "EntityId", false, "Bigint", 0, 19, 0, false, "", null, typeof(System.Int64), 1);
			this.AddElementFieldMapping("EntityRoEntity", "Name", "Name", false, "Varchar", 256, 0, 0, false, "", null, typeof(System.String), 2);
		}

		/// <summary>Inits ErrorEntity's mappings</summary>
		private void InitErrorEntityMappings()
		{
			this.AddElementMapping("ErrorEntity", @"Default", @"public", "Error", 6, 0);
			this.AddElementFieldMapping("ErrorEntity", "ConcurrencyGuid", "ConcurrencyGuid", false, "Varchar", 50, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("ErrorEntity", "ErrorDateTime", "ErrorDateTime", false, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("ErrorEntity", "ErrorId", "ErrorId", false, "Bigint", 0, 19, 0, false, "public.GenericSequence", null, typeof(System.Int64), 2);
			this.AddElementFieldMapping("ErrorEntity", "Message", "Message", false, "Text", 1073741823, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("ErrorEntity", "ParentErrorId", "ParentErrorId", true, "Bigint", 0, 19, 0, false, "", null, typeof(System.Int64), 4);
			this.AddElementFieldMapping("ErrorEntity", "StackTrace", "StackTrace", true, "Text", 1073741823, 0, 0, false, "", null, typeof(System.String), 5);
		}

		/// <summary>Inits PartnerEntity's mappings</summary>
		private void InitPartnerEntityMappings()
		{
			this.AddElementMapping("PartnerEntity", @"Default", @"public", "Partner", 9, 0);
			this.AddElementFieldMapping("PartnerEntity", "Adresa", "Adresa", true, "Varchar", 100, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("PartnerEntity", "ConcurrencyGuid", "ConcurrencyGuid", false, "Varchar", 50, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("PartnerEntity", "IsActive", "IsActive", false, "Boolean", 0, 0, 0, false, "", null, typeof(System.Boolean), 2);
			this.AddElementFieldMapping("PartnerEntity", "Mjesto", "Mjesto", true, "Varchar", 20, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("PartnerEntity", "Naziv", "Naziv", false, "Varchar", 100, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("PartnerEntity", "Oib", "Oib", false, "Varchar", 11, 0, 0, false, "", null, typeof(System.String), 5);
			this.AddElementFieldMapping("PartnerEntity", "PartnerId", "PartnerId", false, "Bigint", 0, 19, 0, false, "public.GenericSequence", null, typeof(System.Int64), 6);
			this.AddElementFieldMapping("PartnerEntity", "Posta", "Posta", true, "Varchar", 10, 0, 0, false, "", null, typeof(System.String), 7);
			this.AddElementFieldMapping("PartnerEntity", "Valuta", "Valuta", false, "Smallint", 0, 0, 0, false, "", null, typeof(System.Int16), 8);
		}

		/// <summary>Inits PdvEntity's mappings</summary>
		private void InitPdvEntityMappings()
		{
			this.AddElementMapping("PdvEntity", @"Default", @"public", "Pdv", 4, 0);
			this.AddElementFieldMapping("PdvEntity", "ConcurrencyGuid", "ConcurrencyGuid", false, "Varchar", 50, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("PdvEntity", "Naziv", "Naziv", false, "Varchar", 128, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("PdvEntity", "PdvId", "PdvId", false, "Bigint", 0, 19, 0, false, "public.GenericSequence", null, typeof(System.Int64), 2);
			this.AddElementFieldMapping("PdvEntity", "Stopa", "Stopa", false, "Numeric", 0, 4, 2, false, "", null, typeof(System.Decimal), 3);
		}

		/// <summary>Inits RacunGlavaEntity's mappings</summary>
		private void InitRacunGlavaEntityMappings()
		{
			this.AddElementMapping("RacunGlavaEntity", @"Default", @"public", "RacunGlava", 15, 0);
			this.AddElementFieldMapping("RacunGlavaEntity", "BrojRacuna", "BrojRacuna", false, "Integer", 0, 0, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("RacunGlavaEntity", "ConcurrencyGuid", "ConcurrencyGuid", false, "Varchar", 50, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("RacunGlavaEntity", "Datum", "Datum", false, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("RacunGlavaEntity", "Godina", "Godina", false, "Smallint", 0, 0, 0, false, "", null, typeof(System.Int16), 3);
			this.AddElementFieldMapping("RacunGlavaEntity", "JePdvRacun", "JePdvRacun", false, "Boolean", 0, 0, 0, false, "", null, typeof(System.Boolean), 4);
			this.AddElementFieldMapping("RacunGlavaEntity", "MjestoRadaAdresa", "MjestoRadaAdresa", true, "Varchar", 100, 0, 0, false, "", null, typeof(System.String), 5);
			this.AddElementFieldMapping("RacunGlavaEntity", "MjestoRadaNaziv", "MjestoRadaNaziv", true, "Varchar", 100, 0, 0, false, "", null, typeof(System.String), 6);
			this.AddElementFieldMapping("RacunGlavaEntity", "PartnerId", "PartnerId", false, "Bigint", 0, 19, 0, false, "", null, typeof(System.Int64), 7);
			this.AddElementFieldMapping("RacunGlavaEntity", "RacunGlavaId", "RacunGlavaId", false, "Bigint", 0, 19, 0, false, "public.GenericSequence", null, typeof(System.Int64), 8);
			this.AddElementFieldMapping("RacunGlavaEntity", "StatusId", "StatusId", false, "Bigint", 0, 19, 0, false, "", null, typeof(System.Int64), 9);
			this.AddElementFieldMapping("RacunGlavaEntity", "TarifaId", "TarifaId", false, "Bigint", 0, 19, 0, false, "", null, typeof(System.Int64), 10);
			this.AddElementFieldMapping("RacunGlavaEntity", "TarifaStopa", "TarifaStopa", false, "Numeric", 0, 5, 2, false, "", null, typeof(System.Decimal), 11);
			this.AddElementFieldMapping("RacunGlavaEntity", "Valuta", "Valuta", false, "Smallint", 0, 0, 0, false, "", null, typeof(System.Int16), 12);
			this.AddElementFieldMapping("RacunGlavaEntity", "Vrijeme", "Vrijeme", true, "Varchar", 10, 0, 0, false, "", null, typeof(System.String), 13);
			this.AddElementFieldMapping("RacunGlavaEntity", "Zaglavlje", "Zaglavlje", true, "Varchar", 1024, 0, 0, false, "", null, typeof(System.String), 14);
		}

		/// <summary>Inits RacunStavkaEntity's mappings</summary>
		private void InitRacunStavkaEntityMappings()
		{
			this.AddElementMapping("RacunStavkaEntity", @"Default", @"public", "RacunStavka", 11, 0);
			this.AddElementFieldMapping("RacunStavkaEntity", "ArtiklId", "ArtiklId", false, "Bigint", 0, 19, 0, false, "", null, typeof(System.Int64), 0);
			this.AddElementFieldMapping("RacunStavkaEntity", "Cijena", "Cijena", false, "Numeric", 0, 10, 2, false, "", null, typeof(System.Decimal), 1);
			this.AddElementFieldMapping("RacunStavkaEntity", "ConcurrencyGuid", "ConcurrencyGuid", false, "Varchar", 50, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("RacunStavkaEntity", "Iznos", "Iznos", false, "Numeric", 0, 10, 2, false, "", null, typeof(System.Decimal), 3);
			this.AddElementFieldMapping("RacunStavkaEntity", "Kolicina", "Kolicina", false, "Numeric", 0, 8, 2, false, "", null, typeof(System.Decimal), 4);
			this.AddElementFieldMapping("RacunStavkaEntity", "PdvIznos", "PdvIznos", false, "Numeric", 0, 10, 2, false, "", null, typeof(System.Decimal), 5);
			this.AddElementFieldMapping("RacunStavkaEntity", "PdvPosto", "PdvPosto", false, "Numeric", 0, 4, 2, false, "", null, typeof(System.Decimal), 6);
			this.AddElementFieldMapping("RacunStavkaEntity", "Pozicija", "Pozicija", false, "Smallint", 0, 0, 0, false, "", null, typeof(System.Int16), 7);
			this.AddElementFieldMapping("RacunStavkaEntity", "RacunGlavaId", "RacunGlavaId", false, "Bigint", 0, 19, 0, false, "", null, typeof(System.Int64), 8);
			this.AddElementFieldMapping("RacunStavkaEntity", "RacunStavkaId", "RacunStavkaId", false, "Bigint", 0, 19, 0, false, "public.GenericSequence", null, typeof(System.Int64), 9);
			this.AddElementFieldMapping("RacunStavkaEntity", "TarifaIznos", "TarifaIznos", false, "Numeric", 0, 10, 2, false, "", null, typeof(System.Decimal), 10);
		}

		/// <summary>Inits RoleRoEntity's mappings</summary>
		private void InitRoleRoEntityMappings()
		{
			this.AddElementMapping("RoleRoEntity", @"Default", @"public", "RoleRo", 3, 0);
			this.AddElementFieldMapping("RoleRoEntity", "Code", "Code", false, "Varchar", 50, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("RoleRoEntity", "Name", "Name", false, "Varchar", 50, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("RoleRoEntity", "RoleId", "RoleId", false, "Bigint", 0, 19, 0, false, "", null, typeof(System.Int64), 2);
		}

		/// <summary>Inits StatusRoEntity's mappings</summary>
		private void InitStatusRoEntityMappings()
		{
			this.AddElementMapping("StatusRoEntity", @"Default", @"public", "StatusRo", 3, 0);
			this.AddElementFieldMapping("StatusRoEntity", "Code", "Code", false, "Varchar", 50, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("StatusRoEntity", "Name", "Name", false, "Varchar", 50, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("StatusRoEntity", "StatusId", "StatusId", false, "Bigint", 0, 19, 0, false, "", null, typeof(System.Int64), 2);
		}

		/// <summary>Inits TarifaEntity's mappings</summary>
		private void InitTarifaEntityMappings()
		{
			this.AddElementMapping("TarifaEntity", @"Default", @"public", "Tarifa", 5, 0);
			this.AddElementFieldMapping("TarifaEntity", "ConcurrencyGuid", "ConcurrencyGuid", false, "Varchar", 50, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("TarifaEntity", "IsActive", "IsActive", false, "Boolean", 0, 0, 0, false, "", null, typeof(System.Boolean), 1);
			this.AddElementFieldMapping("TarifaEntity", "Naziv", "Naziv", false, "Varchar", 100, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("TarifaEntity", "Stopa", "Stopa", false, "Numeric", 0, 5, 2, false, "", null, typeof(System.Decimal), 3);
			this.AddElementFieldMapping("TarifaEntity", "TarifaId", "TarifaId", false, "Bigint", 0, 19, 0, false, "public.GenericSequence", null, typeof(System.Int64), 4);
		}

		/// <summary>Inits UserEntity's mappings</summary>
		private void InitUserEntityMappings()
		{
			this.AddElementMapping("UserEntity", @"Default", @"public", "User", 5, 0);
			this.AddElementFieldMapping("UserEntity", "ConcurrencyGuid", "ConcurrencyGuid", false, "Varchar", 50, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("UserEntity", "Password", "Password", false, "Varchar", 256, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("UserEntity", "RoleId", "RoleId", false, "Bigint", 0, 19, 0, false, "", null, typeof(System.Int64), 2);
			this.AddElementFieldMapping("UserEntity", "UserId", "UserId", false, "Bigint", 0, 19, 0, false, "public.GenericSequence", null, typeof(System.Int64), 3);
			this.AddElementFieldMapping("UserEntity", "Username", "Username", false, "Varchar", 20, 0, 0, false, "", null, typeof(System.String), 4);
		}

	}
}
