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
	/// <summary>Implements the relations factory for the entity: Config. </summary>
	public partial class ConfigRelations
	{
		/// <summary>CTor</summary>
		public ConfigRelations()
		{
		}

		/// <summary>Gets all relations of the ConfigEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.FirmaEntityUsingFirmaId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between ConfigEntity and FirmaEntity over the m:1 relation they have, using the relation between the fields:
		/// Config.FirmaId - Firma.FirmaId
		/// </summary>
		public virtual IEntityRelation FirmaEntityUsingFirmaId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Firma", false);
				relation.AddEntityFieldPair(FirmaFields.FirmaId, ConfigFields.FirmaId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("FirmaEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ConfigEntity", true);
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
	internal static class StaticConfigRelations
	{
		internal static readonly IEntityRelation FirmaEntityUsingFirmaIdStatic = new ConfigRelations().FirmaEntityUsingFirmaId;

		/// <summary>CTor</summary>
		static StaticConfigRelations()
		{
		}
	}
}
