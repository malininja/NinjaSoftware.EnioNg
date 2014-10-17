///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.0
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
	/// <summary>Entity class which represents the entity 'RacunStavka'.<br/><br/></summary>
	[Serializable]
	[JsonObject(MemberSerialization.OptIn)] 
	public partial class RacunStavkaEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private ArtiklEntity _artikl;
		private RacunGlavaEntity _racunGlava;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Artikl</summary>
			public static readonly string Artikl = "Artikl";
			/// <summary>Member name RacunGlava</summary>
			public static readonly string RacunGlava = "RacunGlava";
		}

        /// <summary>
		/// Returns number of entities after filterBucket is applied.
		/// If you need number of all entities send null as filterBucket.
        /// </summary>
		public static int GetNumberOfEntities(DataAccessAdapterBase adapter, 
			IRelationPredicateBucket filterBucket)
		{
			EntityCollection entityCollection = new EntityCollection(new RacunStavkaEntityFactory());
			return adapter.GetDbCount(entityCollection, filterBucket);
		}
		
		/// <summary>
        /// Efficient pageing for grid.
        /// </summary>
        /// <param name="pageNumber">Must be greater than zero.</param>
        /// <param name="sortDirection">Validne vrijednosti su 'asc' i 'desc'.</param>
        public static EntityCollection<RacunStavkaEntity> FetchRacunStavkaCollectionForPaging(DataAccessAdapterBase adapter,
			RelationPredicateBucket bucket,
			PrefetchPath2 prefetchPath,
            int pageNumber,
            int pageSize,
            string sortField,
			bool isSortAscending)
        {
			string sortDirection = isSortAscending ? "asc" : "desc";

            Type sortEntityFieldType = typeof(RacunStavkaFields);
            string sortEntityFieldTypeName = SortHelper.GetEntityFieldTypeNameForSorting(sortField, sortEntityFieldType);
            if (!string.IsNullOrWhiteSpace(sortEntityFieldTypeName))
            {
                sortEntityFieldType = Type.GetType(sortEntityFieldTypeName);
            }

            sortField = SortHelper.GetSortField(sortField);			

			SortExpression sort = SortHelper.GetSortExpression(sortField, sortDirection, sortEntityFieldType);
			
            EntityCollection<RacunStavkaEntity> toReturn = new EntityCollection<RacunStavkaEntity>(new RacunStavkaEntityFactory());
            adapter.FetchEntityCollection(toReturn, bucket, pageSize, sort, prefetchPath, pageNumber, pageSize);

            return toReturn;
        }
		
		public static EntityCollection<RacunStavkaEntity> FetchRacunStavkaCollection(DataAccessAdapterBase adapter,
			IRelationPredicateBucket filterBucket,
			PrefetchPath2 prefetchPath)
		{
			EntityCollection<RacunStavkaEntity> toReturn = new EntityCollection<RacunStavkaEntity>(new RacunStavkaEntityFactory());
			adapter.FetchEntityCollection(toReturn, filterBucket, prefetchPath);
			return toReturn;
		}
		
		public static RacunStavkaEntity FetchRacunStavka(DataAccessAdapterBase adapter, PrefetchPath2 prefetchPath, long RacunStavkaId)
		{
			RacunStavkaEntity _RacunStavkaEntity = new RacunStavkaEntity(RacunStavkaId);
			adapter.FetchEntity(_RacunStavkaEntity, prefetchPath);
			return _RacunStavkaEntity;
		}
		
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static RacunStavkaEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public RacunStavkaEntity():base("RacunStavkaEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public RacunStavkaEntity(IEntityFields2 fields):base("RacunStavkaEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this RacunStavkaEntity</param>
		public RacunStavkaEntity(IValidator validator):base("RacunStavkaEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="racunStavkaId">PK value for RacunStavka which data should be fetched into this RacunStavka object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public RacunStavkaEntity(System.Int64 racunStavkaId):base("RacunStavkaEntity")
		{
			InitClassEmpty(null, null);
			this.RacunStavkaId = racunStavkaId;
		}

		/// <summary> CTor</summary>
		/// <param name="racunStavkaId">PK value for RacunStavka which data should be fetched into this RacunStavka object</param>
		/// <param name="validator">The custom validator object for this RacunStavkaEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public RacunStavkaEntity(System.Int64 racunStavkaId, IValidator validator):base("RacunStavkaEntity")
		{
			InitClassEmpty(validator, null);
			this.RacunStavkaId = racunStavkaId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected RacunStavkaEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_artikl = (ArtiklEntity)info.GetValue("_artikl", typeof(ArtiklEntity));
				if(_artikl!=null)
				{
					_artikl.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_racunGlava = (RacunGlavaEntity)info.GetValue("_racunGlava", typeof(RacunGlavaEntity));
				if(_racunGlava!=null)
				{
					_racunGlava.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((RacunStavkaFieldIndex)fieldIndex)
			{
				case RacunStavkaFieldIndex.ArtiklId:
					DesetupSyncArtikl(true, false);
					break;
				case RacunStavkaFieldIndex.RacunGlavaId:
					DesetupSyncRacunGlava(true, false);
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		protected override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
		{
			switch(propertyName)
			{
				case "Artikl":
					this.Artikl = (ArtiklEntity)entity;
					break;
				case "RacunGlava":
					this.RacunGlava = (RacunGlavaEntity)entity;
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
				case "Artikl":
					toReturn.Add(Relations.ArtiklEntityUsingArtiklId);
					break;
				case "RacunGlava":
					toReturn.Add(Relations.RacunGlavaEntityUsingRacunGlavaId);
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
				case "Artikl":
					SetupSyncArtikl(relatedEntity);
					break;
				case "RacunGlava":
					SetupSyncRacunGlava(relatedEntity);
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
				case "Artikl":
					DesetupSyncArtikl(false, true);
					break;
				case "RacunGlava":
					DesetupSyncRacunGlava(false, true);
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
			if(_artikl!=null)
			{
				toReturn.Add(_artikl);
			}
			if(_racunGlava!=null)
			{
				toReturn.Add(_racunGlava);
			}
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
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
				info.AddValue("_artikl", (!this.MarkedForDeletion?_artikl:null));
				info.AddValue("_racunGlava", (!this.MarkedForDeletion?_racunGlava:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new RacunStavkaRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Artikl' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoArtikl()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ArtiklFields.ArtiklId, null, ComparisonOperator.Equal, this.ArtiklId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'RacunGlava' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRacunGlava()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RacunGlavaFields.RacunGlavaId, null, ComparisonOperator.Equal, this.RacunGlavaId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(RacunStavkaEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Artikl", _artikl);
			toReturn.Add("RacunGlava", _racunGlava);
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
			_fieldsCustomProperties.Add("ArtiklId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Cijena", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ConcurrencyGuid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Iznos", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Kolicina", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PdvIznos", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PdvPosto", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Pozicija", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("RacunGlavaId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("RacunStavkaId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TarifaIznos", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _artikl</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncArtikl(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _artikl, new PropertyChangedEventHandler( OnArtiklPropertyChanged ), "Artikl", NinjaSoftware.EnioNg.CoolJ.RelationClasses.StaticRacunStavkaRelations.ArtiklEntityUsingArtiklIdStatic, true, signalRelatedEntity, "RacunStavkaCollection", resetFKFields, new int[] { (int)RacunStavkaFieldIndex.ArtiklId } );
			_artikl = null;
		}

		/// <summary> setups the sync logic for member _artikl</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncArtikl(IEntityCore relatedEntity)
		{
			if(_artikl!=relatedEntity)
			{
				DesetupSyncArtikl(true, true);
				_artikl = (ArtiklEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _artikl, new PropertyChangedEventHandler( OnArtiklPropertyChanged ), "Artikl", NinjaSoftware.EnioNg.CoolJ.RelationClasses.StaticRacunStavkaRelations.ArtiklEntityUsingArtiklIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnArtiklPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _racunGlava</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncRacunGlava(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _racunGlava, new PropertyChangedEventHandler( OnRacunGlavaPropertyChanged ), "RacunGlava", NinjaSoftware.EnioNg.CoolJ.RelationClasses.StaticRacunStavkaRelations.RacunGlavaEntityUsingRacunGlavaIdStatic, true, signalRelatedEntity, "RacunStavkaCollection", resetFKFields, new int[] { (int)RacunStavkaFieldIndex.RacunGlavaId } );
			_racunGlava = null;
		}

		/// <summary> setups the sync logic for member _racunGlava</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncRacunGlava(IEntityCore relatedEntity)
		{
			if(_racunGlava!=relatedEntity)
			{
				DesetupSyncRacunGlava(true, true);
				_racunGlava = (RacunGlavaEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _racunGlava, new PropertyChangedEventHandler( OnRacunGlavaPropertyChanged ), "RacunGlava", NinjaSoftware.EnioNg.CoolJ.RelationClasses.StaticRacunStavkaRelations.RacunGlavaEntityUsingRacunGlavaIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnRacunGlavaPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this RacunStavkaEntity</param>
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
		public  static RacunStavkaRelations Relations
		{
			get	{ return new RacunStavkaRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Artikl' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathArtikl
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(ArtiklEntityFactory))),	(IEntityRelation)GetRelationsForField("Artikl")[0], (int)NinjaSoftware.EnioNg.CoolJ.EntityType.RacunStavkaEntity, (int)NinjaSoftware.EnioNg.CoolJ.EntityType.ArtiklEntity, 0, null, null, null, null, "Artikl", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RacunGlava' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRacunGlava
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(RacunGlavaEntityFactory))),	(IEntityRelation)GetRelationsForField("RacunGlava")[0], (int)NinjaSoftware.EnioNg.CoolJ.EntityType.RacunStavkaEntity, (int)NinjaSoftware.EnioNg.CoolJ.EntityType.RacunGlavaEntity, 0, null, null, null, null, "RacunGlava", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The ArtiklId property of the Entity RacunStavka<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RacunStavka"."ArtiklId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bigint, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]
		public virtual System.Int64 ArtiklId
		{
			get { return (System.Int64)GetValue((int)RacunStavkaFieldIndex.ArtiklId, true); }
			set	{ SetValue((int)RacunStavkaFieldIndex.ArtiklId, value); }
		}

		/// <summary> The Cijena property of the Entity RacunStavka<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RacunStavka"."Cijena"<br/>
		/// Table field type characteristics (type, precision, scale, length): Numeric, 10, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]
		public virtual System.Decimal Cijena
		{
			get { return (System.Decimal)GetValue((int)RacunStavkaFieldIndex.Cijena, true); }
			set	{ SetValue((int)RacunStavkaFieldIndex.Cijena, value); }
		}

		/// <summary> The ConcurrencyGuid property of the Entity RacunStavka<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RacunStavka"."ConcurrencyGuid"<br/>
		/// Table field type characteristics (type, precision, scale, length): Varchar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]
		public virtual System.String ConcurrencyGuid
		{
			get { return (System.String)GetValue((int)RacunStavkaFieldIndex.ConcurrencyGuid, true); }
			set	{ SetValue((int)RacunStavkaFieldIndex.ConcurrencyGuid, value); }
		}

		/// <summary> The Iznos property of the Entity RacunStavka<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RacunStavka"."Iznos"<br/>
		/// Table field type characteristics (type, precision, scale, length): Numeric, 10, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]
		public virtual System.Decimal Iznos
		{
			get { return (System.Decimal)GetValue((int)RacunStavkaFieldIndex.Iznos, true); }
			set	{ SetValue((int)RacunStavkaFieldIndex.Iznos, value); }
		}

		/// <summary> The Kolicina property of the Entity RacunStavka<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RacunStavka"."Kolicina"<br/>
		/// Table field type characteristics (type, precision, scale, length): Numeric, 8, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]
		public virtual System.Decimal Kolicina
		{
			get { return (System.Decimal)GetValue((int)RacunStavkaFieldIndex.Kolicina, true); }
			set	{ SetValue((int)RacunStavkaFieldIndex.Kolicina, value); }
		}

		/// <summary> The PdvIznos property of the Entity RacunStavka<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RacunStavka"."PdvIznos"<br/>
		/// Table field type characteristics (type, precision, scale, length): Numeric, 10, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]
		public virtual System.Decimal PdvIznos
		{
			get { return (System.Decimal)GetValue((int)RacunStavkaFieldIndex.PdvIznos, true); }
			set	{ SetValue((int)RacunStavkaFieldIndex.PdvIznos, value); }
		}

		/// <summary> The PdvPosto property of the Entity RacunStavka<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RacunStavka"."PdvPosto"<br/>
		/// Table field type characteristics (type, precision, scale, length): Numeric, 4, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]
		public virtual System.Decimal PdvPosto
		{
			get { return (System.Decimal)GetValue((int)RacunStavkaFieldIndex.PdvPosto, true); }
			set	{ SetValue((int)RacunStavkaFieldIndex.PdvPosto, value); }
		}

		/// <summary> The Pozicija property of the Entity RacunStavka<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RacunStavka"."Pozicija"<br/>
		/// Table field type characteristics (type, precision, scale, length): Smallint, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]
		public virtual System.Int16 Pozicija
		{
			get { return (System.Int16)GetValue((int)RacunStavkaFieldIndex.Pozicija, true); }
			set	{ SetValue((int)RacunStavkaFieldIndex.Pozicija, value); }
		}

		/// <summary> The RacunGlavaId property of the Entity RacunStavka<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RacunStavka"."RacunGlavaId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bigint, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]
		public virtual System.Int64 RacunGlavaId
		{
			get { return (System.Int64)GetValue((int)RacunStavkaFieldIndex.RacunGlavaId, true); }
			set	{ SetValue((int)RacunStavkaFieldIndex.RacunGlavaId, value); }
		}

		/// <summary> The RacunStavkaId property of the Entity RacunStavka<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RacunStavka"."RacunStavkaId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bigint, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		[JsonProperty]
		public virtual System.Int64 RacunStavkaId
		{
			get { return (System.Int64)GetValue((int)RacunStavkaFieldIndex.RacunStavkaId, true); }
			set	{ SetValue((int)RacunStavkaFieldIndex.RacunStavkaId, value); }
		}

		/// <summary> The TarifaIznos property of the Entity RacunStavka<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RacunStavka"."TarifaIznos"<br/>
		/// Table field type characteristics (type, precision, scale, length): Numeric, 10, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]
		public virtual System.Decimal TarifaIznos
		{
			get { return (System.Decimal)GetValue((int)RacunStavkaFieldIndex.TarifaIznos, true); }
			set	{ SetValue((int)RacunStavkaFieldIndex.TarifaIznos, value); }
		}

		/// <summary> Gets / sets related entity of type 'ArtiklEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		[JsonProperty]
		public virtual ArtiklEntity Artikl
		{
			get	{ return _artikl; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncArtikl(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "RacunStavkaCollection", "Artikl", _artikl, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'RacunGlavaEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		[JsonProperty]
		public virtual RacunGlavaEntity RacunGlava
		{
			get	{ return _racunGlava; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncRacunGlava(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "RacunStavkaCollection", "RacunGlava", _racunGlava, true); 
				}
			}
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
			get { return (int)NinjaSoftware.EnioNg.CoolJ.EntityType.RacunStavkaEntity; }
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
