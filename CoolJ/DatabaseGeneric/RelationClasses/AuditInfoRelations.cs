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
	/// <summary>Implements the relations factory for the entity: AuditInfo. </summary>
	public partial class AuditInfoRelations
	{
		/// <summary>CTor</summary>
		public AuditInfoRelations()
		{
		}

		/// <summary>Gets all relations of the AuditInfoEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AuditInfoActionTypeRoEntityUsingAuditInfoActionTypeId);
			toReturn.Add(this.EntityRoEntityUsingEntityId);
			toReturn.Add(this.UserEntityUsingUserId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between AuditInfoEntity and AuditInfoActionTypeRoEntity over the m:1 relation they have, using the relation between the fields:
		/// AuditInfo.AuditInfoActionTypeId - AuditInfoActionTypeRo.AuditInfoActionTypeId
		/// </summary>
		public virtual IEntityRelation AuditInfoActionTypeRoEntityUsingAuditInfoActionTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AuditInfoActionType", false);
				relation.AddEntityFieldPair(AuditInfoActionTypeRoFields.AuditInfoActionTypeId, AuditInfoFields.AuditInfoActionTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AuditInfoActionTypeRoEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AuditInfoEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between AuditInfoEntity and EntityRoEntity over the m:1 relation they have, using the relation between the fields:
		/// AuditInfo.EntityId - EntityRo.EntityId
		/// </summary>
		public virtual IEntityRelation EntityRoEntityUsingEntityId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Entity", false);
				relation.AddEntityFieldPair(EntityRoFields.EntityId, AuditInfoFields.EntityId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EntityRoEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AuditInfoEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between AuditInfoEntity and UserEntity over the m:1 relation they have, using the relation between the fields:
		/// AuditInfo.UserId - User.UserId
		/// </summary>
		public virtual IEntityRelation UserEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "User", false);
				relation.AddEntityFieldPair(UserFields.UserId, AuditInfoFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AuditInfoEntity", true);
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
	internal static class StaticAuditInfoRelations
	{
		internal static readonly IEntityRelation AuditInfoActionTypeRoEntityUsingAuditInfoActionTypeIdStatic = new AuditInfoRelations().AuditInfoActionTypeRoEntityUsingAuditInfoActionTypeId;
		internal static readonly IEntityRelation EntityRoEntityUsingEntityIdStatic = new AuditInfoRelations().EntityRoEntityUsingEntityId;
		internal static readonly IEntityRelation UserEntityUsingUserIdStatic = new AuditInfoRelations().UserEntityUsingUserId;

		/// <summary>CTor</summary>
		static StaticAuditInfoRelations()
		{
		}
	}
}
