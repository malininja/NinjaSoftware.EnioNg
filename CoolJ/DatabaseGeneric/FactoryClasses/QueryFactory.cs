///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.0
// Code is generated on: 17. listopada 2014. 18:56:10
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
////////////////////////////////////////////////////////////// 
using System;
using System.Linq;
using NinjaSoftware.EnioNg.CoolJ.EntityClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec;

namespace NinjaSoftware.EnioNg.CoolJ.FactoryClasses
{
	/// <summary>Factory class to produce DynamicQuery instances and EntityQuery instances</summary>
	public partial class QueryFactory
	{
		private int _aliasCounter = 0;

		/// <summary>Creates a new DynamicQuery instance with no alias set.</summary>
		/// <returns>Ready to use DynamicQuery instance</returns>
		public DynamicQuery Create()
		{
			return Create(string.Empty);
		}

		/// <summary>Creates a new DynamicQuery instance with the alias specified as the alias set.</summary>
		/// <param name="alias">The alias.</param>
		/// <returns>Ready to use DynamicQuery instance</returns>
		public DynamicQuery Create(string alias)
		{
			return new DynamicQuery(new ElementCreator(), alias, this.GetNextAliasCounterValue());
		}

		/// <summary>Creates a new DynamicQuery which wraps the specified TableValuedFunction call</summary>
		/// <param name="toWrap">The table valued function call to wrap.</param>
		/// <returns>toWrap wrapped in a DynamicQuery.</returns>
		public DynamicQuery Create(TableValuedFunctionCall toWrap)
		{
			return this.Create().From(new TvfCallWrapper(toWrap)).Select(toWrap.GetFieldsAsArray().Select(f => this.Field(toWrap.Alias, f.Alias)).ToArray());
		}

		/// <summary>Creates a new EntityQuery for the entity of the type specified with no alias set.</summary>
		/// <typeparam name="TEntity">The type of the entity to produce the query for.</typeparam>
		/// <returns>ready to use EntityQuery instance</returns>
		public EntityQuery<TEntity> Create<TEntity>()
			where TEntity : IEntityCore
		{
			return Create<TEntity>(string.Empty);
		}

		/// <summary>Creates a new EntityQuery for the entity of the type specified with the alias specified as the alias set.</summary>
		/// <typeparam name="TEntity">The type of the entity to produce the query for.</typeparam>
		/// <param name="alias">The alias.</param>
		/// <returns>ready to use EntityQuery instance</returns>
		public EntityQuery<TEntity> Create<TEntity>(string alias)
			where TEntity : IEntityCore
		{
			return new EntityQuery<TEntity>(new ElementCreator(), alias, this.GetNextAliasCounterValue());
		}
				
		/// <summary>Creates a new field object with the name specified and of resulttype 'object'. Used for referring to aliased fields in another projection.</summary>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField2 Field(string fieldName)
		{
			return Field<object>(string.Empty, fieldName);
		}

		/// <summary>Creates a new field object with the name specified and of resulttype 'object'. Used for referring to aliased fields in another projection.</summary>
		/// <param name="targetAlias">The alias of the table/query to target.</param>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField2 Field(string targetAlias, string fieldName)
		{
			return Field<object>(targetAlias, fieldName);
		}

		/// <summary>Creates a new field object with the name specified and of resulttype 'TValue'. Used for referring to aliased fields in another projection.</summary>
		/// <typeparam name="TValue">The type of the value represented by the field.</typeparam>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField2 Field<TValue>(string fieldName)
		{
			return Field<TValue>(string.Empty, fieldName);
		}

		/// <summary>Creates a new field object with the name specified and of resulttype 'TValue'. Used for referring to aliased fields in another projection.</summary>
		/// <typeparam name="TValue">The type of the value.</typeparam>
		/// <param name="targetAlias">The alias of the table/query to target.</param>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField2 Field<TValue>(string targetAlias, string fieldName)
		{
			return new EntityField2(fieldName, targetAlias, typeof(TValue));
		}
		
		/// <summary>Gets the next alias counter value to produce artifical aliases with</summary>
		private int GetNextAliasCounterValue()
		{
			_aliasCounter++;
			return _aliasCounter;
		}
		

		/// <summary>Creates and returns a new EntityQuery for the Artikl entity</summary>
		public EntityQuery<ArtiklEntity> Artikl
		{
			get { return Create<ArtiklEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the AuditInfo entity</summary>
		public EntityQuery<AuditInfoEntity> AuditInfo
		{
			get { return Create<AuditInfoEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the AuditInfoActionTypeRo entity</summary>
		public EntityQuery<AuditInfoActionTypeRoEntity> AuditInfoActionTypeRo
		{
			get { return Create<AuditInfoActionTypeRoEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Brojac entity</summary>
		public EntityQuery<BrojacEntity> Brojac
		{
			get { return Create<BrojacEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Config entity</summary>
		public EntityQuery<ConfigEntity> Config
		{
			get { return Create<ConfigEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the EntityRo entity</summary>
		public EntityQuery<EntityRoEntity> EntityRo
		{
			get { return Create<EntityRoEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Error entity</summary>
		public EntityQuery<ErrorEntity> Error
		{
			get { return Create<ErrorEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Partner entity</summary>
		public EntityQuery<PartnerEntity> Partner
		{
			get { return Create<PartnerEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Pdv entity</summary>
		public EntityQuery<PdvEntity> Pdv
		{
			get { return Create<PdvEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the RacunGlava entity</summary>
		public EntityQuery<RacunGlavaEntity> RacunGlava
		{
			get { return Create<RacunGlavaEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the RacunStavka entity</summary>
		public EntityQuery<RacunStavkaEntity> RacunStavka
		{
			get { return Create<RacunStavkaEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the RoleRo entity</summary>
		public EntityQuery<RoleRoEntity> RoleRo
		{
			get { return Create<RoleRoEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the StatusRo entity</summary>
		public EntityQuery<StatusRoEntity> StatusRo
		{
			get { return Create<StatusRoEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Tarifa entity</summary>
		public EntityQuery<TarifaEntity> Tarifa
		{
			get { return Create<TarifaEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the User entity</summary>
		public EntityQuery<UserEntity> User
		{
			get { return Create<UserEntity>(); }
		}

 

	}
}