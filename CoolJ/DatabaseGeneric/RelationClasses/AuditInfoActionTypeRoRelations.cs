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
	/// <summary>Implements the relations factory for the entity: AuditInfoActionTypeRo. </summary>
	public partial class AuditInfoActionTypeRoRelations
	{
		/// <summary>CTor</summary>
		public AuditInfoActionTypeRoRelations()
		{
		}

		/// <summary>Gets all relations of the AuditInfoActionTypeRoEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AuditInfoEntityUsingAuditInfoActionTypeId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between AuditInfoActionTypeRoEntity and AuditInfoEntity over the 1:n relation they have, using the relation between the fields:
		/// AuditInfoActionTypeRo.AuditInfoActionTypeId - AuditInfo.AuditInfoActionTypeId
		/// </summary>
		public virtual IEntityRelation AuditInfoEntityUsingAuditInfoActionTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "AuditInfoCollection" , true);
				relation.AddEntityFieldPair(AuditInfoActionTypeRoFields.AuditInfoActionTypeId, AuditInfoFields.AuditInfoActionTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AuditInfoActionTypeRoEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AuditInfoEntity", false);
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
	internal static class StaticAuditInfoActionTypeRoRelations
	{
		internal static readonly IEntityRelation AuditInfoEntityUsingAuditInfoActionTypeIdStatic = new AuditInfoActionTypeRoRelations().AuditInfoEntityUsingAuditInfoActionTypeId;

		/// <summary>CTor</summary>
		static StaticAuditInfoActionTypeRoRelations()
		{
		}
	}
}
