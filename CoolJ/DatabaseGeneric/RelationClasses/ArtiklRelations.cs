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
	/// <summary>Implements the relations factory for the entity: Artikl. </summary>
	public partial class ArtiklRelations
	{
		/// <summary>CTor</summary>
		public ArtiklRelations()
		{
		}

		/// <summary>Gets all relations of the ArtiklEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.RacunStavkaEntityUsingArtiklId);
			toReturn.Add(this.PdvEntityUsingPdvId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between ArtiklEntity and RacunStavkaEntity over the 1:n relation they have, using the relation between the fields:
		/// Artikl.ArtiklId - RacunStavka.ArtiklId
		/// </summary>
		public virtual IEntityRelation RacunStavkaEntityUsingArtiklId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "RacunStavkaCollection" , true);
				relation.AddEntityFieldPair(ArtiklFields.ArtiklId, RacunStavkaFields.ArtiklId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ArtiklEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RacunStavkaEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between ArtiklEntity and PdvEntity over the m:1 relation they have, using the relation between the fields:
		/// Artikl.PdvId - Pdv.PdvId
		/// </summary>
		public virtual IEntityRelation PdvEntityUsingPdvId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Pdv", false);
				relation.AddEntityFieldPair(PdvFields.PdvId, ArtiklFields.PdvId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PdvEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ArtiklEntity", true);
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
	internal static class StaticArtiklRelations
	{
		internal static readonly IEntityRelation RacunStavkaEntityUsingArtiklIdStatic = new ArtiklRelations().RacunStavkaEntityUsingArtiklId;
		internal static readonly IEntityRelation PdvEntityUsingPdvIdStatic = new ArtiklRelations().PdvEntityUsingPdvId;

		/// <summary>CTor</summary>
		static StaticArtiklRelations()
		{
		}
	}
}
