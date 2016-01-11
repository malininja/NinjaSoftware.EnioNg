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
	/// <summary>Implements the relations factory for the entity: RacunGlava. </summary>
	public partial class RacunGlavaRelations
	{
		/// <summary>CTor</summary>
		public RacunGlavaRelations()
		{
		}

		/// <summary>Gets all relations of the RacunGlavaEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.RacunStavkaEntityUsingRacunGlavaId);
			toReturn.Add(this.PartnerEntityUsingPartnerId);
			toReturn.Add(this.StatusRoEntityUsingStatusId);
			toReturn.Add(this.TarifaEntityUsingTarifaId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between RacunGlavaEntity and RacunStavkaEntity over the 1:n relation they have, using the relation between the fields:
		/// RacunGlava.RacunGlavaId - RacunStavka.RacunGlavaId
		/// </summary>
		public virtual IEntityRelation RacunStavkaEntityUsingRacunGlavaId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "RacunStavkaCollection" , true);
				relation.AddEntityFieldPair(RacunGlavaFields.RacunGlavaId, RacunStavkaFields.RacunGlavaId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RacunGlavaEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RacunStavkaEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between RacunGlavaEntity and PartnerEntity over the m:1 relation they have, using the relation between the fields:
		/// RacunGlava.PartnerId - Partner.PartnerId
		/// </summary>
		public virtual IEntityRelation PartnerEntityUsingPartnerId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Partner", false);
				relation.AddEntityFieldPair(PartnerFields.PartnerId, RacunGlavaFields.PartnerId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PartnerEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RacunGlavaEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between RacunGlavaEntity and StatusRoEntity over the m:1 relation they have, using the relation between the fields:
		/// RacunGlava.StatusId - StatusRo.StatusId
		/// </summary>
		public virtual IEntityRelation StatusRoEntityUsingStatusId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Status", false);
				relation.AddEntityFieldPair(StatusRoFields.StatusId, RacunGlavaFields.StatusId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StatusRoEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RacunGlavaEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between RacunGlavaEntity and TarifaEntity over the m:1 relation they have, using the relation between the fields:
		/// RacunGlava.TarifaId - Tarifa.TarifaId
		/// </summary>
		public virtual IEntityRelation TarifaEntityUsingTarifaId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Tarifa", false);
				relation.AddEntityFieldPair(TarifaFields.TarifaId, RacunGlavaFields.TarifaId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TarifaEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RacunGlavaEntity", true);
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
	internal static class StaticRacunGlavaRelations
	{
		internal static readonly IEntityRelation RacunStavkaEntityUsingRacunGlavaIdStatic = new RacunGlavaRelations().RacunStavkaEntityUsingRacunGlavaId;
		internal static readonly IEntityRelation PartnerEntityUsingPartnerIdStatic = new RacunGlavaRelations().PartnerEntityUsingPartnerId;
		internal static readonly IEntityRelation StatusRoEntityUsingStatusIdStatic = new RacunGlavaRelations().StatusRoEntityUsingStatusId;
		internal static readonly IEntityRelation TarifaEntityUsingTarifaIdStatic = new RacunGlavaRelations().TarifaEntityUsingTarifaId;

		/// <summary>CTor</summary>
		static StaticRacunGlavaRelations()
		{
		}
	}
}
