///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.0
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
	/// <summary>Implements the relations factory for the entity: Error. </summary>
	public partial class ErrorRelations
	{
		/// <summary>CTor</summary>
		public ErrorRelations()
		{
		}

		/// <summary>Gets all relations of the ErrorEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ErrorEntityUsingParentErrorId);
			toReturn.Add(this.ErrorEntityUsingErrorIdParentErrorId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between ErrorEntity and ErrorEntity over the 1:n relation they have, using the relation between the fields:
		/// Error.ErrorId - Error.ParentErrorId
		/// </summary>
		public virtual IEntityRelation ErrorEntityUsingParentErrorId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ChildErrorCollection" , true);
				relation.AddEntityFieldPair(ErrorFields.ErrorId, ErrorFields.ParentErrorId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ErrorEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ErrorEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between ErrorEntity and ErrorEntity over the m:1 relation they have, using the relation between the fields:
		/// Error.ParentErrorId - Error.ErrorId
		/// </summary>
		public virtual IEntityRelation ErrorEntityUsingErrorIdParentErrorId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ParentError", false);
				relation.AddEntityFieldPair(ErrorFields.ErrorId, ErrorFields.ParentErrorId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ErrorEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ErrorEntity", true);
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
	internal static class StaticErrorRelations
	{
		internal static readonly IEntityRelation ErrorEntityUsingParentErrorIdStatic = new ErrorRelations().ErrorEntityUsingParentErrorId;
		internal static readonly IEntityRelation ErrorEntityUsingErrorIdParentErrorIdStatic = new ErrorRelations().ErrorEntityUsingErrorIdParentErrorId;

		/// <summary>CTor</summary>
		static StaticErrorRelations()
		{
		}
	}
}
