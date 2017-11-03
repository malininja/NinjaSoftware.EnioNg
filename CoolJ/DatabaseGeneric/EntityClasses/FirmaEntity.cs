///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.2
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Xml.Serialization;
using NinjaSoftware.EnioNg.CoolJ;
using NinjaSoftware.EnioNg.CoolJ.HelperClasses;
using NinjaSoftware.EnioNg.CoolJ.FactoryClasses;
using NinjaSoftware.EnioNg.CoolJ.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;
using Newtonsoft.Json;
using NinjaSoftware.Api.CoolJ;

namespace NinjaSoftware.EnioNg.CoolJ.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'Firma'.<br/><br/></summary>
	[Serializable]
	[JsonObject(MemberSerialization.OptIn)] 
	public partial class FirmaEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<ArtiklEntity> _artiklCollection;
		private EntityCollection<BrojacEntity> _brojacCollection;
		private EntityCollection<ConfigEntity> _configCollection;
		private EntityCollection<PartnerEntity> _partnerCollection;
		private EntityCollection<PdvEntity> _pdvCollection;
		private EntityCollection<RacunGlavaEntity> _racunGlavaCollection;
		private EntityCollection<TarifaEntity> _tarifaCollection;
		private EntityCollection<UserEntity> _userCollection;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name ArtiklCollection</summary>
			public static readonly string ArtiklCollection = "ArtiklCollection";
			/// <summary>Member name BrojacCollection</summary>
			public static readonly string BrojacCollection = "BrojacCollection";
			/// <summary>Member name ConfigCollection</summary>
			public static readonly string ConfigCollection = "ConfigCollection";
			/// <summary>Member name PartnerCollection</summary>
			public static readonly string PartnerCollection = "PartnerCollection";
			/// <summary>Member name PdvCollection</summary>
			public static readonly string PdvCollection = "PdvCollection";
			/// <summary>Member name RacunGlavaCollection</summary>
			public static readonly string RacunGlavaCollection = "RacunGlavaCollection";
			/// <summary>Member name TarifaCollection</summary>
			public static readonly string TarifaCollection = "TarifaCollection";
			/// <summary>Member name UserCollection</summary>
			public static readonly string UserCollection = "UserCollection";
		}

        /// <summary>
		/// Returns number of entities after filterBucket is applied.
		/// If you need number of all entities send null as filterBucket.
        /// </summary>
		public static int GetNumberOfEntities(DataAccessAdapterBase adapter, 
			IRelationPredicateBucket filterBucket)
		{
			EntityCollection entityCollection = new EntityCollection(new FirmaEntityFactory());
			return adapter.GetDbCount(entityCollection, filterBucket);
		}
		
		/// <summary>
        /// Efficient pageing for grid.
        /// </summary>
        /// <param name="pageNumber">Must be greater than zero.</param>
        /// <param name="sortDirection">Validne vrijednosti su 'asc' i 'desc'.</param>
        public static EntityCollection<FirmaEntity> FetchFirmaCollectionForPaging(DataAccessAdapterBase adapter,
			RelationPredicateBucket bucket,
			PrefetchPath2 prefetchPath,
            int pageNumber,
            int pageSize,
            string sortField,
			bool isSortAscending)
        {
			string sortDirection = isSortAscending ? "asc" : "desc";

            Type sortEntityFieldType = typeof(FirmaFields);
            string sortEntityFieldTypeName = SortHelper.GetEntityFieldTypeNameForSorting(sortField, sortEntityFieldType);
            if (!string.IsNullOrWhiteSpace(sortEntityFieldTypeName))
            {
                sortEntityFieldType = Type.GetType(sortEntityFieldTypeName);
            }

            sortField = SortHelper.GetSortField(sortField);			

			SortExpression sort = SortHelper.GetSortExpression(sortField, sortDirection, sortEntityFieldType);
			
            EntityCollection<FirmaEntity> toReturn = new EntityCollection<FirmaEntity>(new FirmaEntityFactory());
            adapter.FetchEntityCollection(toReturn, bucket, pageSize, sort, prefetchPath, pageNumber, pageSize);

            return toReturn;
        }
		
		public static EntityCollection<FirmaEntity> FetchFirmaCollection(DataAccessAdapterBase adapter,
			IRelationPredicateBucket filterBucket,
			PrefetchPath2 prefetchPath)
		{
			EntityCollection<FirmaEntity> toReturn = new EntityCollection<FirmaEntity>(new FirmaEntityFactory());
			adapter.FetchEntityCollection(toReturn, filterBucket, prefetchPath);
			return toReturn;
		}
		
		public static FirmaEntity FetchFirma(DataAccessAdapterBase adapter, PrefetchPath2 prefetchPath, long FirmaId)
		{
			FirmaEntity _FirmaEntity = new FirmaEntity(FirmaId);
			adapter.FetchEntity(_FirmaEntity, prefetchPath);
			return _FirmaEntity;
		}
		
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static FirmaEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public FirmaEntity():base("FirmaEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public FirmaEntity(IEntityFields2 fields):base("FirmaEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this FirmaEntity</param>
		public FirmaEntity(IValidator validator):base("FirmaEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="firmaId">PK value for Firma which data should be fetched into this Firma object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public FirmaEntity(System.Int64 firmaId):base("FirmaEntity")
		{
			InitClassEmpty(null, null);
			this.FirmaId = firmaId;
		}

		/// <summary> CTor</summary>
		/// <param name="firmaId">PK value for Firma which data should be fetched into this Firma object</param>
		/// <param name="validator">The custom validator object for this FirmaEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public FirmaEntity(System.Int64 firmaId, IValidator validator):base("FirmaEntity")
		{
			InitClassEmpty(validator, null);
			this.FirmaId = firmaId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected FirmaEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_artiklCollection = (EntityCollection<ArtiklEntity>)info.GetValue("_artiklCollection", typeof(EntityCollection<ArtiklEntity>));
				_brojacCollection = (EntityCollection<BrojacEntity>)info.GetValue("_brojacCollection", typeof(EntityCollection<BrojacEntity>));
				_configCollection = (EntityCollection<ConfigEntity>)info.GetValue("_configCollection", typeof(EntityCollection<ConfigEntity>));
				_partnerCollection = (EntityCollection<PartnerEntity>)info.GetValue("_partnerCollection", typeof(EntityCollection<PartnerEntity>));
				_pdvCollection = (EntityCollection<PdvEntity>)info.GetValue("_pdvCollection", typeof(EntityCollection<PdvEntity>));
				_racunGlavaCollection = (EntityCollection<RacunGlavaEntity>)info.GetValue("_racunGlavaCollection", typeof(EntityCollection<RacunGlavaEntity>));
				_tarifaCollection = (EntityCollection<TarifaEntity>)info.GetValue("_tarifaCollection", typeof(EntityCollection<TarifaEntity>));
				_userCollection = (EntityCollection<UserEntity>)info.GetValue("_userCollection", typeof(EntityCollection<UserEntity>));
				this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}


		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		protected override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
		{
			switch(propertyName)
			{
				case "ArtiklCollection":
					this.ArtiklCollection.Add((ArtiklEntity)entity);
					break;
				case "BrojacCollection":
					this.BrojacCollection.Add((BrojacEntity)entity);
					break;
				case "ConfigCollection":
					this.ConfigCollection.Add((ConfigEntity)entity);
					break;
				case "PartnerCollection":
					this.PartnerCollection.Add((PartnerEntity)entity);
					break;
				case "PdvCollection":
					this.PdvCollection.Add((PdvEntity)entity);
					break;
				case "RacunGlavaCollection":
					this.RacunGlavaCollection.Add((RacunGlavaEntity)entity);
					break;
				case "TarifaCollection":
					this.TarifaCollection.Add((TarifaEntity)entity);
					break;
				case "UserCollection":
					this.UserCollection.Add((UserEntity)entity);
					break;
				default:
					this.OnSetRelatedEntityProperty(propertyName, entity);
					break;
			}
		}
		
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		protected override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		internal static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "ArtiklCollection":
					toReturn.Add(Relations.ArtiklEntityUsingFirmaId);
					break;
				case "BrojacCollection":
					toReturn.Add(Relations.BrojacEntityUsingFirmaId);
					break;
				case "ConfigCollection":
					toReturn.Add(Relations.ConfigEntityUsingFirmaId);
					break;
				case "PartnerCollection":
					toReturn.Add(Relations.PartnerEntityUsingFirmaId);
					break;
				case "PdvCollection":
					toReturn.Add(Relations.PdvEntityUsingFirmaId);
					break;
				case "RacunGlavaCollection":
					toReturn.Add(Relations.RacunGlavaEntityUsingFirmaId);
					break;
				case "TarifaCollection":
					toReturn.Add(Relations.TarifaEntityUsingFirmaId);
					break;
				case "UserCollection":
					toReturn.Add(Relations.UserEntityUsingFirmaId);
					break;
				default:
					break;				
			}
			return toReturn;
		}
#if !CF
		/// <summary>Checks if the relation mapped by the property with the name specified is a one way / single sided relation. If the passed in name is null, it/ will return true if the entity has any single-sided relation</summary>
		/// <param name="propertyName">Name of the property which is mapped onto the relation to check, or null to check if the entity has any relation/ which is single sided</param>
		/// <returns>true if the relation is single sided / one way (so the opposite relation isn't present), false otherwise</returns>
		protected override bool CheckOneWayRelations(string propertyName)
		{
			int numberOfOneWayRelations = 0;
			switch(propertyName)
			{
				case null:
					return ((numberOfOneWayRelations > 0) || base.CheckOneWayRelations(null));
				default:
					return base.CheckOneWayRelations(propertyName);
			}
		}
#endif
		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		protected override void SetRelatedEntity(IEntityCore relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "ArtiklCollection":
					this.ArtiklCollection.Add((ArtiklEntity)relatedEntity);
					break;
				case "BrojacCollection":
					this.BrojacCollection.Add((BrojacEntity)relatedEntity);
					break;
				case "ConfigCollection":
					this.ConfigCollection.Add((ConfigEntity)relatedEntity);
					break;
				case "PartnerCollection":
					this.PartnerCollection.Add((PartnerEntity)relatedEntity);
					break;
				case "PdvCollection":
					this.PdvCollection.Add((PdvEntity)relatedEntity);
					break;
				case "RacunGlavaCollection":
					this.RacunGlavaCollection.Add((RacunGlavaEntity)relatedEntity);
					break;
				case "TarifaCollection":
					this.TarifaCollection.Add((TarifaEntity)relatedEntity);
					break;
				case "UserCollection":
					this.UserCollection.Add((UserEntity)relatedEntity);
					break;
				default:
					break;
			}
		}

		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		protected override void UnsetRelatedEntity(IEntityCore relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "ArtiklCollection":
					this.PerformRelatedEntityRemoval(this.ArtiklCollection, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "BrojacCollection":
					this.PerformRelatedEntityRemoval(this.BrojacCollection, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ConfigCollection":
					this.PerformRelatedEntityRemoval(this.ConfigCollection, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "PartnerCollection":
					this.PerformRelatedEntityRemoval(this.PartnerCollection, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "PdvCollection":
					this.PerformRelatedEntityRemoval(this.PdvCollection, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "RacunGlavaCollection":
					this.PerformRelatedEntityRemoval(this.RacunGlavaCollection, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "TarifaCollection":
					this.PerformRelatedEntityRemoval(this.TarifaCollection, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "UserCollection":
					this.PerformRelatedEntityRemoval(this.UserCollection, relatedEntity, signalRelatedEntityManyToOne);
					break;
				default:
					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		protected override List<IEntity2> GetDependingRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();
			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		protected override List<IEntity2> GetDependentRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.ArtiklCollection);
			toReturn.Add(this.BrojacCollection);
			toReturn.Add(this.ConfigCollection);
			toReturn.Add(this.PartnerCollection);
			toReturn.Add(this.PdvCollection);
			toReturn.Add(this.RacunGlavaCollection);
			toReturn.Add(this.TarifaCollection);
			toReturn.Add(this.UserCollection);
			return toReturn;
		}

		/// <summary>ISerializable member. Does custom serialization so event handlers do not get serialized. Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				info.AddValue("_artiklCollection", ((_artiklCollection!=null) && (_artiklCollection.Count>0) && !this.MarkedForDeletion)?_artiklCollection:null);
				info.AddValue("_brojacCollection", ((_brojacCollection!=null) && (_brojacCollection.Count>0) && !this.MarkedForDeletion)?_brojacCollection:null);
				info.AddValue("_configCollection", ((_configCollection!=null) && (_configCollection.Count>0) && !this.MarkedForDeletion)?_configCollection:null);
				info.AddValue("_partnerCollection", ((_partnerCollection!=null) && (_partnerCollection.Count>0) && !this.MarkedForDeletion)?_partnerCollection:null);
				info.AddValue("_pdvCollection", ((_pdvCollection!=null) && (_pdvCollection.Count>0) && !this.MarkedForDeletion)?_pdvCollection:null);
				info.AddValue("_racunGlavaCollection", ((_racunGlavaCollection!=null) && (_racunGlavaCollection.Count>0) && !this.MarkedForDeletion)?_racunGlavaCollection:null);
				info.AddValue("_tarifaCollection", ((_tarifaCollection!=null) && (_tarifaCollection.Count>0) && !this.MarkedForDeletion)?_tarifaCollection:null);
				info.AddValue("_userCollection", ((_userCollection!=null) && (_userCollection.Count>0) && !this.MarkedForDeletion)?_userCollection:null);
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new FirmaRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Artikl' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoArtiklCollection()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ArtiklFields.FirmaId, null, ComparisonOperator.Equal, this.FirmaId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Brojac' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBrojacCollection()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(BrojacFields.FirmaId, null, ComparisonOperator.Equal, this.FirmaId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Config' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoConfigCollection()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ConfigFields.FirmaId, null, ComparisonOperator.Equal, this.FirmaId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Partner' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPartnerCollection()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PartnerFields.FirmaId, null, ComparisonOperator.Equal, this.FirmaId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Pdv' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPdvCollection()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PdvFields.FirmaId, null, ComparisonOperator.Equal, this.FirmaId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'RacunGlava' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRacunGlavaCollection()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RacunGlavaFields.FirmaId, null, ComparisonOperator.Equal, this.FirmaId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Tarifa' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoTarifaCollection()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(TarifaFields.FirmaId, null, ComparisonOperator.Equal, this.FirmaId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'User' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUserCollection()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserFields.FirmaId, null, ComparisonOperator.Equal, this.FirmaId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(FirmaEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._artiklCollection);
			collectionsQueue.Enqueue(this._brojacCollection);
			collectionsQueue.Enqueue(this._configCollection);
			collectionsQueue.Enqueue(this._partnerCollection);
			collectionsQueue.Enqueue(this._pdvCollection);
			collectionsQueue.Enqueue(this._racunGlavaCollection);
			collectionsQueue.Enqueue(this._tarifaCollection);
			collectionsQueue.Enqueue(this._userCollection);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._artiklCollection = (EntityCollection<ArtiklEntity>) collectionsQueue.Dequeue();
			this._brojacCollection = (EntityCollection<BrojacEntity>) collectionsQueue.Dequeue();
			this._configCollection = (EntityCollection<ConfigEntity>) collectionsQueue.Dequeue();
			this._partnerCollection = (EntityCollection<PartnerEntity>) collectionsQueue.Dequeue();
			this._pdvCollection = (EntityCollection<PdvEntity>) collectionsQueue.Dequeue();
			this._racunGlavaCollection = (EntityCollection<RacunGlavaEntity>) collectionsQueue.Dequeue();
			this._tarifaCollection = (EntityCollection<TarifaEntity>) collectionsQueue.Dequeue();
			this._userCollection = (EntityCollection<UserEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._artiklCollection != null);
			toReturn |=(this._brojacCollection != null);
			toReturn |=(this._configCollection != null);
			toReturn |=(this._partnerCollection != null);
			toReturn |=(this._pdvCollection != null);
			toReturn |=(this._racunGlavaCollection != null);
			toReturn |=(this._tarifaCollection != null);
			toReturn |=(this._userCollection != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ArtiklEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ArtiklEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<BrojacEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BrojacEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ConfigEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ConfigEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<PartnerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PartnerEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<PdvEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PdvEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RacunGlavaEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RacunGlavaEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<TarifaEntity>(EntityFactoryCache2.GetEntityFactory(typeof(TarifaEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("ArtiklCollection", _artiklCollection);
			toReturn.Add("BrojacCollection", _brojacCollection);
			toReturn.Add("ConfigCollection", _configCollection);
			toReturn.Add("PartnerCollection", _partnerCollection);
			toReturn.Add("PdvCollection", _pdvCollection);
			toReturn.Add("RacunGlavaCollection", _racunGlavaCollection);
			toReturn.Add("TarifaCollection", _tarifaCollection);
			toReturn.Add("UserCollection", _userCollection);
			return toReturn;
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}


		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FirmaId", fieldHashtable);
		}
		#endregion

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this FirmaEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();

		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static FirmaRelations Relations
		{
			get	{ return new FirmaRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Artikl' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathArtiklCollection
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<ArtiklEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ArtiklEntityFactory))), (IEntityRelation)GetRelationsForField("ArtiklCollection")[0], (int)NinjaSoftware.EnioNg.CoolJ.EntityType.FirmaEntity, (int)NinjaSoftware.EnioNg.CoolJ.EntityType.ArtiklEntity, 0, null, null, null, null, "ArtiklCollection", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Brojac' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBrojacCollection
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<BrojacEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BrojacEntityFactory))), (IEntityRelation)GetRelationsForField("BrojacCollection")[0], (int)NinjaSoftware.EnioNg.CoolJ.EntityType.FirmaEntity, (int)NinjaSoftware.EnioNg.CoolJ.EntityType.BrojacEntity, 0, null, null, null, null, "BrojacCollection", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Config' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathConfigCollection
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<ConfigEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ConfigEntityFactory))), (IEntityRelation)GetRelationsForField("ConfigCollection")[0], (int)NinjaSoftware.EnioNg.CoolJ.EntityType.FirmaEntity, (int)NinjaSoftware.EnioNg.CoolJ.EntityType.ConfigEntity, 0, null, null, null, null, "ConfigCollection", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Partner' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPartnerCollection
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<PartnerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PartnerEntityFactory))), (IEntityRelation)GetRelationsForField("PartnerCollection")[0], (int)NinjaSoftware.EnioNg.CoolJ.EntityType.FirmaEntity, (int)NinjaSoftware.EnioNg.CoolJ.EntityType.PartnerEntity, 0, null, null, null, null, "PartnerCollection", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Pdv' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPdvCollection
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<PdvEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PdvEntityFactory))), (IEntityRelation)GetRelationsForField("PdvCollection")[0], (int)NinjaSoftware.EnioNg.CoolJ.EntityType.FirmaEntity, (int)NinjaSoftware.EnioNg.CoolJ.EntityType.PdvEntity, 0, null, null, null, null, "PdvCollection", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RacunGlava' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRacunGlavaCollection
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<RacunGlavaEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RacunGlavaEntityFactory))), (IEntityRelation)GetRelationsForField("RacunGlavaCollection")[0], (int)NinjaSoftware.EnioNg.CoolJ.EntityType.FirmaEntity, (int)NinjaSoftware.EnioNg.CoolJ.EntityType.RacunGlavaEntity, 0, null, null, null, null, "RacunGlavaCollection", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Tarifa' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathTarifaCollection
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<TarifaEntity>(EntityFactoryCache2.GetEntityFactory(typeof(TarifaEntityFactory))), (IEntityRelation)GetRelationsForField("TarifaCollection")[0], (int)NinjaSoftware.EnioNg.CoolJ.EntityType.FirmaEntity, (int)NinjaSoftware.EnioNg.CoolJ.EntityType.TarifaEntity, 0, null, null, null, null, "TarifaCollection", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'User' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUserCollection
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))), (IEntityRelation)GetRelationsForField("UserCollection")[0], (int)NinjaSoftware.EnioNg.CoolJ.EntityType.FirmaEntity, (int)NinjaSoftware.EnioNg.CoolJ.EntityType.UserEntity, 0, null, null, null, null, "UserCollection", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return FieldsCustomProperties;}
		}

		/// <summary> The FirmaId property of the Entity Firma<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Firma"."FirmaId"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		[JsonProperty]
		public virtual System.Int64 FirmaId
		{
			get { return (System.Int64)GetValue((int)FirmaFieldIndex.FirmaId, true); }
			set	{ SetValue((int)FirmaFieldIndex.FirmaId, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ArtiklEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ArtiklEntity))]
		public virtual EntityCollection<ArtiklEntity> ArtiklCollection
		{
			get { return GetOrCreateEntityCollection<ArtiklEntity, ArtiklEntityFactory>("Firma", true, false, ref _artiklCollection);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'BrojacEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(BrojacEntity))]
		public virtual EntityCollection<BrojacEntity> BrojacCollection
		{
			get { return GetOrCreateEntityCollection<BrojacEntity, BrojacEntityFactory>("Firma", true, false, ref _brojacCollection);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ConfigEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ConfigEntity))]
		public virtual EntityCollection<ConfigEntity> ConfigCollection
		{
			get { return GetOrCreateEntityCollection<ConfigEntity, ConfigEntityFactory>("Firma", true, false, ref _configCollection);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'PartnerEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(PartnerEntity))]
		public virtual EntityCollection<PartnerEntity> PartnerCollection
		{
			get { return GetOrCreateEntityCollection<PartnerEntity, PartnerEntityFactory>("Firma", true, false, ref _partnerCollection);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'PdvEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(PdvEntity))]
		public virtual EntityCollection<PdvEntity> PdvCollection
		{
			get { return GetOrCreateEntityCollection<PdvEntity, PdvEntityFactory>("Firma", true, false, ref _pdvCollection);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'RacunGlavaEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(RacunGlavaEntity))]
		public virtual EntityCollection<RacunGlavaEntity> RacunGlavaCollection
		{
			get { return GetOrCreateEntityCollection<RacunGlavaEntity, RacunGlavaEntityFactory>("Firma", true, false, ref _racunGlavaCollection);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'TarifaEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(TarifaEntity))]
		public virtual EntityCollection<TarifaEntity> TarifaCollection
		{
			get { return GetOrCreateEntityCollection<TarifaEntity, TarifaEntityFactory>("Firma", true, false, ref _tarifaCollection);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'UserEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(UserEntity))]
		public virtual EntityCollection<UserEntity> UserCollection
		{
			get { return GetOrCreateEntityCollection<UserEntity, UserEntityFactory>("Firma", true, false, ref _userCollection);	}
		}
	
		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}
		
		/// <summary>Returns the NinjaSoftware.EnioNg.CoolJ.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)NinjaSoftware.EnioNg.CoolJ.EntityType.FirmaEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
