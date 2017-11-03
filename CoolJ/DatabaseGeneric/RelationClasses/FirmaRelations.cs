///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.2
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using NinjaSoftware.EnioNg.CoolJ;
using NinjaSoftware.EnioNg.CoolJ.FactoryClasses;
using NinjaSoftware.EnioNg.CoolJ.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace NinjaSoftware.EnioNg.CoolJ.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Firma. </summary>
	public partial class FirmaRelations
	{
		/// <summary>CTor</summary>
		public FirmaRelations()
		{
		}

		/// <summary>Gets all relations of the FirmaEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ArtiklEntityUsingFirmaId);
			toReturn.Add(this.BrojacEntityUsingFirmaId);
			toReturn.Add(this.ConfigEntityUsingFirmaId);
			toReturn.Add(this.PartnerEntityUsingFirmaId);
			toReturn.Add(this.PdvEntityUsingFirmaId);
			toReturn.Add(this.RacunGlavaEntityUsingFirmaId);
			toReturn.Add(this.TarifaEntityUsingFirmaId);
			toReturn.Add(this.UserEntityUsingFirmaId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between FirmaEntity and ArtiklEntity over the 1:n relation they have, using the relation between the fields:
		/// Firma.FirmaId - Artikl.FirmaId
		/// </summary>
		public virtual IEntityRelation ArtiklEntityUsingFirmaId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ArtiklCollection" , true);
				relation.AddEntityFieldPair(FirmaFields.FirmaId, ArtiklFields.FirmaId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("FirmaEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ArtiklEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between FirmaEntity and BrojacEntity over the 1:n relation they have, using the relation between the fields:
		/// Firma.FirmaId - Brojac.FirmaId
		/// </summary>
		public virtual IEntityRelation BrojacEntityUsingFirmaId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "BrojacCollection" , true);
				relation.AddEntityFieldPair(FirmaFields.FirmaId, BrojacFields.FirmaId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("FirmaEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BrojacEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between FirmaEntity and ConfigEntity over the 1:n relation they have, using the relation between the fields:
		/// Firma.FirmaId - Config.FirmaId
		/// </summary>
		public virtual IEntityRelation ConfigEntityUsingFirmaId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ConfigCollection" , true);
				relation.AddEntityFieldPair(FirmaFields.FirmaId, ConfigFields.FirmaId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("FirmaEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ConfigEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between FirmaEntity and PartnerEntity over the 1:n relation they have, using the relation between the fields:
		/// Firma.FirmaId - Partner.FirmaId
		/// </summary>
		public virtual IEntityRelation PartnerEntityUsingFirmaId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "PartnerCollection" , true);
				relation.AddEntityFieldPair(FirmaFields.FirmaId, PartnerFields.FirmaId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("FirmaEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PartnerEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between FirmaEntity and PdvEntity over the 1:n relation they have, using the relation between the fields:
		/// Firma.FirmaId - Pdv.FirmaId
		/// </summary>
		public virtual IEntityRelation PdvEntityUsingFirmaId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "PdvCollection" , true);
				relation.AddEntityFieldPair(FirmaFields.FirmaId, PdvFields.FirmaId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("FirmaEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PdvEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between FirmaEntity and RacunGlavaEntity over the 1:n relation they have, using the relation between the fields:
		/// Firma.FirmaId - RacunGlava.FirmaId
		/// </summary>
		public virtual IEntityRelation RacunGlavaEntityUsingFirmaId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "RacunGlavaCollection" , true);
				relation.AddEntityFieldPair(FirmaFields.FirmaId, RacunGlavaFields.FirmaId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("FirmaEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RacunGlavaEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between FirmaEntity and TarifaEntity over the 1:n relation they have, using the relation between the fields:
		/// Firma.FirmaId - Tarifa.FirmaId
		/// </summary>
		public virtual IEntityRelation TarifaEntityUsingFirmaId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "TarifaCollection" , true);
				relation.AddEntityFieldPair(FirmaFields.FirmaId, TarifaFields.FirmaId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("FirmaEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TarifaEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between FirmaEntity and UserEntity over the 1:n relation they have, using the relation between the fields:
		/// Firma.FirmaId - User.FirmaId
		/// </summary>
		public virtual IEntityRelation UserEntityUsingFirmaId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "UserCollection" , true);
				relation.AddEntityFieldPair(FirmaFields.FirmaId, UserFields.FirmaId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("FirmaEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", false);
				return relation;
			}
		}


		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}
		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticFirmaRelations
	{
		internal static readonly IEntityRelation ArtiklEntityUsingFirmaIdStatic = new FirmaRelations().ArtiklEntityUsingFirmaId;
		internal static readonly IEntityRelation BrojacEntityUsingFirmaIdStatic = new FirmaRelations().BrojacEntityUsingFirmaId;
		internal static readonly IEntityRelation ConfigEntityUsingFirmaIdStatic = new FirmaRelations().ConfigEntityUsingFirmaId;
		internal static readonly IEntityRelation PartnerEntityUsingFirmaIdStatic = new FirmaRelations().PartnerEntityUsingFirmaId;
		internal static readonly IEntityRelation PdvEntityUsingFirmaIdStatic = new FirmaRelations().PdvEntityUsingFirmaId;
		internal static readonly IEntityRelation RacunGlavaEntityUsingFirmaIdStatic = new FirmaRelations().RacunGlavaEntityUsingFirmaId;
		internal static readonly IEntityRelation TarifaEntityUsingFirmaIdStatic = new FirmaRelations().TarifaEntityUsingFirmaId;
		internal static readonly IEntityRelation UserEntityUsingFirmaIdStatic = new FirmaRelations().UserEntityUsingFirmaId;

		/// <summary>CTor</summary>
		static StaticFirmaRelations()
		{
		}
	}
}
