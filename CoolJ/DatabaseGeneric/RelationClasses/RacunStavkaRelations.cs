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
	/// <summary>Implements the relations factory for the entity: RacunStavka. </summary>
	public partial class RacunStavkaRelations
	{
		/// <summary>CTor</summary>
		public RacunStavkaRelations()
		{
		}

		/// <summary>Gets all relations of the RacunStavkaEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ArtiklEntityUsingArtiklId);
			toReturn.Add(this.RacunGlavaEntityUsingRacunGlavaId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between RacunStavkaEntity and ArtiklEntity over the m:1 relation they have, using the relation between the fields:
		/// RacunStavka.ArtiklId - Artikl.ArtiklId
		/// </summary>
		public virtual IEntityRelation ArtiklEntityUsingArtiklId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Artikl", false);
				relation.AddEntityFieldPair(ArtiklFields.ArtiklId, RacunStavkaFields.ArtiklId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ArtiklEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RacunStavkaEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between RacunStavkaEntity and RacunGlavaEntity over the m:1 relation they have, using the relation between the fields:
		/// RacunStavka.RacunGlavaId - RacunGlava.RacunGlavaId
		/// </summary>
		public virtual IEntityRelation RacunGlavaEntityUsingRacunGlavaId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "RacunGlava", false);
				relation.AddEntityFieldPair(RacunGlavaFields.RacunGlavaId, RacunStavkaFields.RacunGlavaId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RacunGlavaEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RacunStavkaEntity", true);
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
	internal static class StaticRacunStavkaRelations
	{
		internal static readonly IEntityRelation ArtiklEntityUsingArtiklIdStatic = new RacunStavkaRelations().ArtiklEntityUsingArtiklId;
		internal static readonly IEntityRelation RacunGlavaEntityUsingRacunGlavaIdStatic = new RacunStavkaRelations().RacunGlavaEntityUsingRacunGlavaId;

		/// <summary>CTor</summary>
		static StaticRacunStavkaRelations()
		{
		}
	}
}
