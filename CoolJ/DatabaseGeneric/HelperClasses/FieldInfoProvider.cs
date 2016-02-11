///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.2
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace NinjaSoftware.EnioNg.CoolJ.HelperClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>Singleton implementation of the FieldInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the FieldInfoProviderBase class is threadsafe.</remarks>
	internal static class FieldInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IFieldInfoProvider _providerInstance = new FieldInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static FieldInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the FieldInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IFieldInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the FieldInfoProvider. Used by singleton wrapper.</summary>
	internal class FieldInfoProviderCore : FieldInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="FieldInfoProviderCore"/> class.</summary>
		internal FieldInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			this.InitClass( (15 + 0));
			InitArtiklEntityInfos();
			InitAuditInfoEntityInfos();
			InitAuditInfoActionTypeRoEntityInfos();
			InitBrojacEntityInfos();
			InitConfigEntityInfos();
			InitEntityRoEntityInfos();
			InitErrorEntityInfos();
			InitPartnerEntityInfos();
			InitPdvEntityInfos();
			InitRacunGlavaEntityInfos();
			InitRacunStavkaEntityInfos();
			InitRoleRoEntityInfos();
			InitStatusRoEntityInfos();
			InitTarifaEntityInfos();
			InitUserEntityInfos();

			this.ConstructElementFieldStructures(InheritanceInfoProviderSingleton.GetInstance());
		}

		/// <summary>Inits ArtiklEntity's FieldInfo objects</summary>
		private void InitArtiklEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ArtiklFieldIndex), "ArtiklEntity");
			this.AddElementFieldInfo("ArtiklEntity", "ArtiklId", typeof(System.Int64), true, false, false, false,  (int)ArtiklFieldIndex.ArtiklId, 0, 0, 19);
			this.AddElementFieldInfo("ArtiklEntity", "Cijena", typeof(System.Decimal), false, false, false, false,  (int)ArtiklFieldIndex.Cijena, 0, 2, 10);
			this.AddElementFieldInfo("ArtiklEntity", "ConcurrencyGuid", typeof(System.String), false, false, false, false,  (int)ArtiklFieldIndex.ConcurrencyGuid, 50, 0, 0);
			this.AddElementFieldInfo("ArtiklEntity", "IsActive", typeof(System.Boolean), false, false, false, false,  (int)ArtiklFieldIndex.IsActive, 0, 0, 0);
			this.AddElementFieldInfo("ArtiklEntity", "Jm", typeof(System.String), false, false, false, false,  (int)ArtiklFieldIndex.Jm, 10, 0, 0);
			this.AddElementFieldInfo("ArtiklEntity", "Naziv", typeof(System.String), false, false, false, false,  (int)ArtiklFieldIndex.Naziv, 100, 0, 0);
			this.AddElementFieldInfo("ArtiklEntity", "PdvId", typeof(System.Int64), false, true, false, false,  (int)ArtiklFieldIndex.PdvId, 0, 0, 19);
		}
		/// <summary>Inits AuditInfoEntity's FieldInfo objects</summary>
		private void InitAuditInfoEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AuditInfoFieldIndex), "AuditInfoEntity");
			this.AddElementFieldInfo("AuditInfoEntity", "ActionDateTime", typeof(System.DateTime), false, false, false, false,  (int)AuditInfoFieldIndex.ActionDateTime, 0, 0, 0);
			this.AddElementFieldInfo("AuditInfoEntity", "AuditInfoActionTypeId", typeof(System.Int64), false, true, false, false,  (int)AuditInfoFieldIndex.AuditInfoActionTypeId, 0, 0, 19);
			this.AddElementFieldInfo("AuditInfoEntity", "AuditInfoId", typeof(System.Int64), true, false, false, false,  (int)AuditInfoFieldIndex.AuditInfoId, 0, 0, 19);
			this.AddElementFieldInfo("AuditInfoEntity", "ConcurrencyGuid", typeof(System.String), false, false, false, false,  (int)AuditInfoFieldIndex.ConcurrencyGuid, 50, 0, 0);
			this.AddElementFieldInfo("AuditInfoEntity", "EntityId", typeof(System.Int64), false, true, false, false,  (int)AuditInfoFieldIndex.EntityId, 0, 0, 19);
			this.AddElementFieldInfo("AuditInfoEntity", "JsonData", typeof(System.String), false, false, false, false,  (int)AuditInfoFieldIndex.JsonData, 1073741823, 0, 0);
			this.AddElementFieldInfo("AuditInfoEntity", "PrimaryKeyValue", typeof(System.Int64), false, false, false, false,  (int)AuditInfoFieldIndex.PrimaryKeyValue, 0, 0, 19);
			this.AddElementFieldInfo("AuditInfoEntity", "UserId", typeof(System.Int64), false, true, false, false,  (int)AuditInfoFieldIndex.UserId, 0, 0, 19);
		}
		/// <summary>Inits AuditInfoActionTypeRoEntity's FieldInfo objects</summary>
		private void InitAuditInfoActionTypeRoEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AuditInfoActionTypeRoFieldIndex), "AuditInfoActionTypeRoEntity");
			this.AddElementFieldInfo("AuditInfoActionTypeRoEntity", "AuditInfoActionTypeId", typeof(System.Int64), true, false, false, false,  (int)AuditInfoActionTypeRoFieldIndex.AuditInfoActionTypeId, 0, 0, 19);
			this.AddElementFieldInfo("AuditInfoActionTypeRoEntity", "Code", typeof(System.String), false, false, false, false,  (int)AuditInfoActionTypeRoFieldIndex.Code, 128, 0, 0);
			this.AddElementFieldInfo("AuditInfoActionTypeRoEntity", "Name", typeof(System.String), false, false, false, false,  (int)AuditInfoActionTypeRoFieldIndex.Name, 256, 0, 0);
		}
		/// <summary>Inits BrojacEntity's FieldInfo objects</summary>
		private void InitBrojacEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(BrojacFieldIndex), "BrojacEntity");
			this.AddElementFieldInfo("BrojacEntity", "BrojacId", typeof(System.Int64), true, false, false, false,  (int)BrojacFieldIndex.BrojacId, 0, 0, 19);
			this.AddElementFieldInfo("BrojacEntity", "ConcurrencyGuid", typeof(System.String), false, false, false, false,  (int)BrojacFieldIndex.ConcurrencyGuid, 50, 0, 0);
			this.AddElementFieldInfo("BrojacEntity", "Godina", typeof(System.Int16), false, false, false, false,  (int)BrojacFieldIndex.Godina, 0, 0, 0);
			this.AddElementFieldInfo("BrojacEntity", "Naziv", typeof(System.String), false, false, false, false,  (int)BrojacFieldIndex.Naziv, 100, 0, 0);
			this.AddElementFieldInfo("BrojacEntity", "SlijedeciBroj", typeof(System.Int32), false, false, false, false,  (int)BrojacFieldIndex.SlijedeciBroj, 0, 0, 0);
		}
		/// <summary>Inits ConfigEntity's FieldInfo objects</summary>
		private void InitConfigEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ConfigFieldIndex), "ConfigEntity");
			this.AddElementFieldInfo("ConfigEntity", "Adresa", typeof(System.String), false, false, false, true,  (int)ConfigFieldIndex.Adresa, 100, 0, 0);
			this.AddElementFieldInfo("ConfigEntity", "AktivnaGodina", typeof(System.Int16), false, false, false, false,  (int)ConfigFieldIndex.AktivnaGodina, 0, 0, 0);
			this.AddElementFieldInfo("ConfigEntity", "ConcurrencyGuid", typeof(System.String), false, false, false, false,  (int)ConfigFieldIndex.ConcurrencyGuid, 50, 0, 0);
			this.AddElementFieldInfo("ConfigEntity", "ConfigId", typeof(System.Int64), true, false, false, false,  (int)ConfigFieldIndex.ConfigId, 0, 0, 19);
			this.AddElementFieldInfo("ConfigEntity", "Mjesto", typeof(System.String), false, false, false, true,  (int)ConfigFieldIndex.Mjesto, 100, 0, 0);
			this.AddElementFieldInfo("ConfigEntity", "Naziv", typeof(System.String), false, false, false, false,  (int)ConfigFieldIndex.Naziv, 100, 0, 0);
			this.AddElementFieldInfo("ConfigEntity", "Oib", typeof(System.String), false, false, false, false,  (int)ConfigFieldIndex.Oib, 11, 0, 0);
			this.AddElementFieldInfo("ConfigEntity", "Zr", typeof(System.String), false, false, false, true,  (int)ConfigFieldIndex.Zr, 50, 0, 0);
		}
		/// <summary>Inits EntityRoEntity's FieldInfo objects</summary>
		private void InitEntityRoEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(EntityRoFieldIndex), "EntityRoEntity");
			this.AddElementFieldInfo("EntityRoEntity", "Code", typeof(System.String), false, false, false, false,  (int)EntityRoFieldIndex.Code, 128, 0, 0);
			this.AddElementFieldInfo("EntityRoEntity", "EntityId", typeof(System.Int64), true, false, false, false,  (int)EntityRoFieldIndex.EntityId, 0, 0, 19);
			this.AddElementFieldInfo("EntityRoEntity", "Name", typeof(System.String), false, false, false, false,  (int)EntityRoFieldIndex.Name, 256, 0, 0);
		}
		/// <summary>Inits ErrorEntity's FieldInfo objects</summary>
		private void InitErrorEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ErrorFieldIndex), "ErrorEntity");
			this.AddElementFieldInfo("ErrorEntity", "ConcurrencyGuid", typeof(System.String), false, false, false, false,  (int)ErrorFieldIndex.ConcurrencyGuid, 50, 0, 0);
			this.AddElementFieldInfo("ErrorEntity", "ErrorDateTime", typeof(System.DateTime), false, false, false, false,  (int)ErrorFieldIndex.ErrorDateTime, 0, 0, 0);
			this.AddElementFieldInfo("ErrorEntity", "ErrorId", typeof(System.Int64), true, false, false, false,  (int)ErrorFieldIndex.ErrorId, 0, 0, 19);
			this.AddElementFieldInfo("ErrorEntity", "Message", typeof(System.String), false, false, false, false,  (int)ErrorFieldIndex.Message, 1073741823, 0, 0);
			this.AddElementFieldInfo("ErrorEntity", "ParentErrorId", typeof(Nullable<System.Int64>), false, true, false, true,  (int)ErrorFieldIndex.ParentErrorId, 0, 0, 19);
			this.AddElementFieldInfo("ErrorEntity", "StackTrace", typeof(System.String), false, false, false, true,  (int)ErrorFieldIndex.StackTrace, 1073741823, 0, 0);
		}
		/// <summary>Inits PartnerEntity's FieldInfo objects</summary>
		private void InitPartnerEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(PartnerFieldIndex), "PartnerEntity");
			this.AddElementFieldInfo("PartnerEntity", "Adresa", typeof(System.String), false, false, false, true,  (int)PartnerFieldIndex.Adresa, 100, 0, 0);
			this.AddElementFieldInfo("PartnerEntity", "ConcurrencyGuid", typeof(System.String), false, false, false, false,  (int)PartnerFieldIndex.ConcurrencyGuid, 50, 0, 0);
			this.AddElementFieldInfo("PartnerEntity", "IsActive", typeof(System.Boolean), false, false, false, false,  (int)PartnerFieldIndex.IsActive, 0, 0, 0);
			this.AddElementFieldInfo("PartnerEntity", "Mjesto", typeof(System.String), false, false, false, true,  (int)PartnerFieldIndex.Mjesto, 20, 0, 0);
			this.AddElementFieldInfo("PartnerEntity", "Naziv", typeof(System.String), false, false, false, false,  (int)PartnerFieldIndex.Naziv, 100, 0, 0);
			this.AddElementFieldInfo("PartnerEntity", "Oib", typeof(System.String), false, false, false, false,  (int)PartnerFieldIndex.Oib, 11, 0, 0);
			this.AddElementFieldInfo("PartnerEntity", "PartnerId", typeof(System.Int64), true, false, false, false,  (int)PartnerFieldIndex.PartnerId, 0, 0, 19);
			this.AddElementFieldInfo("PartnerEntity", "Posta", typeof(System.String), false, false, false, true,  (int)PartnerFieldIndex.Posta, 10, 0, 0);
			this.AddElementFieldInfo("PartnerEntity", "Valuta", typeof(System.Int16), false, false, false, false,  (int)PartnerFieldIndex.Valuta, 0, 0, 0);
		}
		/// <summary>Inits PdvEntity's FieldInfo objects</summary>
		private void InitPdvEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(PdvFieldIndex), "PdvEntity");
			this.AddElementFieldInfo("PdvEntity", "ConcurrencyGuid", typeof(System.String), false, false, false, false,  (int)PdvFieldIndex.ConcurrencyGuid, 50, 0, 0);
			this.AddElementFieldInfo("PdvEntity", "Naziv", typeof(System.String), false, false, false, false,  (int)PdvFieldIndex.Naziv, 128, 0, 0);
			this.AddElementFieldInfo("PdvEntity", "PdvId", typeof(System.Int64), true, false, false, false,  (int)PdvFieldIndex.PdvId, 0, 0, 19);
			this.AddElementFieldInfo("PdvEntity", "Stopa", typeof(System.Decimal), false, false, false, false,  (int)PdvFieldIndex.Stopa, 0, 2, 4);
		}
		/// <summary>Inits RacunGlavaEntity's FieldInfo objects</summary>
		private void InitRacunGlavaEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(RacunGlavaFieldIndex), "RacunGlavaEntity");
			this.AddElementFieldInfo("RacunGlavaEntity", "BrojRacuna", typeof(System.Int32), false, false, false, false,  (int)RacunGlavaFieldIndex.BrojRacuna, 0, 0, 0);
			this.AddElementFieldInfo("RacunGlavaEntity", "ConcurrencyGuid", typeof(System.String), false, false, false, false,  (int)RacunGlavaFieldIndex.ConcurrencyGuid, 50, 0, 0);
			this.AddElementFieldInfo("RacunGlavaEntity", "Datum", typeof(System.DateTime), false, false, false, false,  (int)RacunGlavaFieldIndex.Datum, 0, 0, 0);
			this.AddElementFieldInfo("RacunGlavaEntity", "Godina", typeof(System.Int16), false, false, false, false,  (int)RacunGlavaFieldIndex.Godina, 0, 0, 0);
			this.AddElementFieldInfo("RacunGlavaEntity", "JePdvRacun", typeof(System.Boolean), false, false, false, false,  (int)RacunGlavaFieldIndex.JePdvRacun, 0, 0, 0);
			this.AddElementFieldInfo("RacunGlavaEntity", "MjestoRadaAdresa", typeof(System.String), false, false, false, true,  (int)RacunGlavaFieldIndex.MjestoRadaAdresa, 100, 0, 0);
			this.AddElementFieldInfo("RacunGlavaEntity", "MjestoRadaNaziv", typeof(System.String), false, false, false, true,  (int)RacunGlavaFieldIndex.MjestoRadaNaziv, 100, 0, 0);
			this.AddElementFieldInfo("RacunGlavaEntity", "PartnerId", typeof(System.Int64), false, true, false, false,  (int)RacunGlavaFieldIndex.PartnerId, 0, 0, 19);
			this.AddElementFieldInfo("RacunGlavaEntity", "RacunGlavaId", typeof(System.Int64), true, false, false, false,  (int)RacunGlavaFieldIndex.RacunGlavaId, 0, 0, 19);
			this.AddElementFieldInfo("RacunGlavaEntity", "StatusId", typeof(System.Int64), false, true, false, false,  (int)RacunGlavaFieldIndex.StatusId, 0, 0, 19);
			this.AddElementFieldInfo("RacunGlavaEntity", "TarifaId", typeof(System.Int64), false, true, false, false,  (int)RacunGlavaFieldIndex.TarifaId, 0, 0, 19);
			this.AddElementFieldInfo("RacunGlavaEntity", "TarifaStopa", typeof(System.Decimal), false, false, false, false,  (int)RacunGlavaFieldIndex.TarifaStopa, 0, 2, 5);
			this.AddElementFieldInfo("RacunGlavaEntity", "Valuta", typeof(System.Int16), false, false, false, false,  (int)RacunGlavaFieldIndex.Valuta, 0, 0, 0);
			this.AddElementFieldInfo("RacunGlavaEntity", "Vrijeme", typeof(System.String), false, false, false, true,  (int)RacunGlavaFieldIndex.Vrijeme, 10, 0, 0);
			this.AddElementFieldInfo("RacunGlavaEntity", "Zaglavlje", typeof(System.String), false, false, false, true,  (int)RacunGlavaFieldIndex.Zaglavlje, 1024, 0, 0);
		}
		/// <summary>Inits RacunStavkaEntity's FieldInfo objects</summary>
		private void InitRacunStavkaEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(RacunStavkaFieldIndex), "RacunStavkaEntity");
			this.AddElementFieldInfo("RacunStavkaEntity", "ArtiklId", typeof(System.Int64), false, true, false, false,  (int)RacunStavkaFieldIndex.ArtiklId, 0, 0, 19);
			this.AddElementFieldInfo("RacunStavkaEntity", "Cijena", typeof(System.Decimal), false, false, false, false,  (int)RacunStavkaFieldIndex.Cijena, 0, 2, 10);
			this.AddElementFieldInfo("RacunStavkaEntity", "ConcurrencyGuid", typeof(System.String), false, false, false, false,  (int)RacunStavkaFieldIndex.ConcurrencyGuid, 50, 0, 0);
			this.AddElementFieldInfo("RacunStavkaEntity", "Iznos", typeof(System.Decimal), false, false, false, false,  (int)RacunStavkaFieldIndex.Iznos, 0, 2, 10);
			this.AddElementFieldInfo("RacunStavkaEntity", "Kolicina", typeof(System.Decimal), false, false, false, false,  (int)RacunStavkaFieldIndex.Kolicina, 0, 2, 8);
			this.AddElementFieldInfo("RacunStavkaEntity", "PdvIznos", typeof(System.Decimal), false, false, false, false,  (int)RacunStavkaFieldIndex.PdvIznos, 0, 2, 10);
			this.AddElementFieldInfo("RacunStavkaEntity", "PdvPosto", typeof(System.Decimal), false, false, false, false,  (int)RacunStavkaFieldIndex.PdvPosto, 0, 2, 4);
			this.AddElementFieldInfo("RacunStavkaEntity", "Pozicija", typeof(System.Int16), false, false, false, false,  (int)RacunStavkaFieldIndex.Pozicija, 0, 0, 0);
			this.AddElementFieldInfo("RacunStavkaEntity", "RacunGlavaId", typeof(System.Int64), false, true, false, false,  (int)RacunStavkaFieldIndex.RacunGlavaId, 0, 0, 19);
			this.AddElementFieldInfo("RacunStavkaEntity", "RacunStavkaId", typeof(System.Int64), true, false, false, false,  (int)RacunStavkaFieldIndex.RacunStavkaId, 0, 0, 19);
			this.AddElementFieldInfo("RacunStavkaEntity", "TarifaIznos", typeof(System.Decimal), false, false, false, false,  (int)RacunStavkaFieldIndex.TarifaIznos, 0, 2, 10);
		}
		/// <summary>Inits RoleRoEntity's FieldInfo objects</summary>
		private void InitRoleRoEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(RoleRoFieldIndex), "RoleRoEntity");
			this.AddElementFieldInfo("RoleRoEntity", "Code", typeof(System.String), false, false, false, false,  (int)RoleRoFieldIndex.Code, 50, 0, 0);
			this.AddElementFieldInfo("RoleRoEntity", "Name", typeof(System.String), false, false, false, false,  (int)RoleRoFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("RoleRoEntity", "RoleId", typeof(System.Int64), true, false, false, false,  (int)RoleRoFieldIndex.RoleId, 0, 0, 19);
		}
		/// <summary>Inits StatusRoEntity's FieldInfo objects</summary>
		private void InitStatusRoEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(StatusRoFieldIndex), "StatusRoEntity");
			this.AddElementFieldInfo("StatusRoEntity", "Code", typeof(System.String), false, false, false, false,  (int)StatusRoFieldIndex.Code, 50, 0, 0);
			this.AddElementFieldInfo("StatusRoEntity", "Name", typeof(System.String), false, false, false, false,  (int)StatusRoFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("StatusRoEntity", "StatusId", typeof(System.Int64), true, false, false, false,  (int)StatusRoFieldIndex.StatusId, 0, 0, 19);
		}
		/// <summary>Inits TarifaEntity's FieldInfo objects</summary>
		private void InitTarifaEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(TarifaFieldIndex), "TarifaEntity");
			this.AddElementFieldInfo("TarifaEntity", "ConcurrencyGuid", typeof(System.String), false, false, false, false,  (int)TarifaFieldIndex.ConcurrencyGuid, 50, 0, 0);
			this.AddElementFieldInfo("TarifaEntity", "IsActive", typeof(System.Boolean), false, false, false, false,  (int)TarifaFieldIndex.IsActive, 0, 0, 0);
			this.AddElementFieldInfo("TarifaEntity", "Naziv", typeof(System.String), false, false, false, false,  (int)TarifaFieldIndex.Naziv, 100, 0, 0);
			this.AddElementFieldInfo("TarifaEntity", "Stopa", typeof(System.Decimal), false, false, false, false,  (int)TarifaFieldIndex.Stopa, 0, 2, 5);
			this.AddElementFieldInfo("TarifaEntity", "TarifaId", typeof(System.Int64), true, false, false, false,  (int)TarifaFieldIndex.TarifaId, 0, 0, 19);
		}
		/// <summary>Inits UserEntity's FieldInfo objects</summary>
		private void InitUserEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(UserFieldIndex), "UserEntity");
			this.AddElementFieldInfo("UserEntity", "ConcurrencyGuid", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.ConcurrencyGuid, 50, 0, 0);
			this.AddElementFieldInfo("UserEntity", "Password", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.Password, 256, 0, 0);
			this.AddElementFieldInfo("UserEntity", "RoleId", typeof(System.Int64), false, true, false, false,  (int)UserFieldIndex.RoleId, 0, 0, 19);
			this.AddElementFieldInfo("UserEntity", "UserId", typeof(System.Int64), true, false, false, false,  (int)UserFieldIndex.UserId, 0, 0, 19);
			this.AddElementFieldInfo("UserEntity", "Username", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.Username, 20, 0, 0);
		}
		
	}
}




