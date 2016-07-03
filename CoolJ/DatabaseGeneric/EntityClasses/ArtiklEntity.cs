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
	/// <summary>Entity class which represents the entity 'Artikl'.<br/><br/></summary>
	[Serializable]
	[JsonObject(MemberSerialization.OptIn)] 
	public partial class ArtiklEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<RacunStavkaEntity> _racunStavkaCollection;
		private PdvEntity _pdv;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Pdv</summary>
			public static readonly string Pdv = "Pdv";
			/// <summary>Member name RacunStavkaCollection</summary>
			public static readonly string RacunStavkaCollection = "RacunStavkaCollection";
		}

        /// <summary>
		/// Returns number of entities after filterBucket is applied.
		/// If you need number of all entities send null as filterBucket.
        /// </summary>
		public static int GetNumberOfEntities(DataAccessAdapterBase adapter, 
			IRelationPredicateBucket filterBucket)
		{
			EntityCollection entityCollection = new EntityCollection(new ArtiklEntityFactory());
			return adapter.GetDbCount(entityCollection, filterBucket);
		}
		
		/// <summary>
        /// Efficient pageing for grid.
        /// </summary>
        /// <param name="pageNumber">Must be greater than zero.</param>
        /// <param name="sortDirection">Validne vrijednosti su 'asc' i 'desc'.</param>
        public static EntityCollection<ArtiklEntity> FetchArtiklCollectionForPaging(DataAccessAdapterBase adapter,
			RelationPredicateBucket bucket,
			PrefetchPath2 prefetchPath,
            int pageNumber,
            int pageSize,
            string sortField,
			bool isSortAscending)
        {
			string sortDirection = isSortAscending ? "asc" : "desc";

            Type sortEntityFieldType = typeof(ArtiklFields);
            string sortEntityFieldTypeName = SortHelper.GetEntityFieldTypeNameForSorting(sortField, sortEntityFieldType);
            if (!string.IsNullOrWhiteSpace(sortEntityFieldTypeName))
            {
                sortEntityFieldType = Type.GetType(sortEntityFieldTypeName);
            }

            sortField = SortHelper.GetSortField(sortField);			

			SortExpression sort = SortHelper.GetSortExpression(sortField, sortDirection, sortEntityFieldType);
			
            EntityCollection<ArtiklEntity> toReturn = new EntityCollection<ArtiklEntity>(new ArtiklEntityFactory());
            adapter.FetchEntityCollection(toReturn, bucket, pageSize, sort, prefetchPath, pageNumber, pageSize);

            return toReturn;
        }
		
		public static EntityCollection<ArtiklEntity> FetchArtiklCollection(DataAccessAdapterBase adapter,
			IRelationPredicateBucket filterBucket,
			PrefetchPath2 prefetchPath)
		{
			EntityCollection<ArtiklEntity> toReturn = new EntityCollection<ArtiklEntity>(new ArtiklEntityFactory());
			adapter.FetchEntityCollection(toReturn, filterBucket, prefetchPath);
			return toReturn;
		}
		
		public static ArtiklEntity FetchArtikl(DataAccessAdapterBase adapter, PrefetchPath2 prefetchPath, long ArtiklId)
		{
			ArtiklEntity _ArtiklEntity = new ArtiklEntity(ArtiklId);
			adapter.FetchEntity(_ArtiklEntity, prefetchPath);
			return _ArtiklEntity;
		}
		
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ArtiklEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public ArtiklEntity():base("ArtiklEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public ArtiklEntity(IEntityFields2 fields):base("ArtiklEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this ArtiklEntity</param>
		public ArtiklEntity(IValidator validator):base("ArtiklEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="artiklId">PK value for Artikl which data should be fetched into this Artikl object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public ArtiklEntity(System.Int64 artiklId):base("ArtiklEntity")
		{
			InitClassEmpty(null, null);
			this.ArtiklId = artiklId;
		}

		/// <summary> CTor</summary>
		/// <param name="artiklId">PK value for Artikl which data should be fetched into this Artikl object</param>
		/// <param name="validator">The custom validator object for this ArtiklEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public ArtiklEntity(System.Int64 artiklId, IValidator validator):base("ArtiklEntity")
		{
			InitClassEmpty(validator, null);
			this.ArtiklId = artiklId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected ArtiklEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_racunStavkaCollection = (EntityCollection<RacunStavkaEntity>)info.GetValue("_racunStavkaCollection", typeof(EntityCollection<RacunStavkaEntity>));
				_pdv = (PdvEntity)info.GetValue("_pdv", typeof(PdvEntity));
				if(_pdv!=null)
				{
					_pdv.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((ArtiklFieldIndex)fieldIndex)
			{
				case ArtiklFieldIndex.PdvId:
					DesetupSyncPdv(true, false);
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
				case "Pdv":
					this.Pdv = (PdvEntity)entity;
					break;
				case "RacunStavkaCollection":
					this.RacunStavkaCollection.Add((RacunStavkaEntity)entity);
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
				case "Pdv":
					toReturn.Add(Relations.PdvEntityUsingPdvId);
					break;
				case "RacunStavkaCollection":
					toReturn.Add(Relations.RacunStavkaEntityUsingArtiklId);
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
				case "Pdv":
					SetupSyncPdv(relatedEntity);
					break;
				case "RacunStavkaCollection":
					this.RacunStavkaCollection.Add((RacunStavkaEntity)relatedEntity);
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
				case "Pdv":
					DesetupSyncPdv(false, true);
					break;
				case "RacunStavkaCollection":
					this.PerformRelatedEntityRemoval(this.RacunStavkaCollection, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_pdv!=null)
			{
				toReturn.Add(_pdv);
			}
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.RacunStavkaCollection);
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
				info.AddValue("_racunStavkaCollection", ((_racunStavkaCollection!=null) && (_racunStavkaCollection.Count>0) && !this.MarkedForDeletion)?_racunStavkaCollection:null);
				info.AddValue("_pdv", (!this.MarkedForDeletion?_pdv:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new ArtiklRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'RacunStavka' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRacunStavkaCollection()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RacunStavkaFields.ArtiklId, null, ComparisonOperator.Equal, this.ArtiklId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Pdv' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPdv()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PdvFields.PdvId, null, ComparisonOperator.Equal, this.PdvId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(ArtiklEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._racunStavkaCollection);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._racunStavkaCollection = (EntityCollection<RacunStavkaEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._racunStavkaCollection != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RacunStavkaEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RacunStavkaEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Pdv", _pdv);
			toReturn.Add("RacunStavkaCollection", _racunStavkaCollection);
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
			_fieldsCustomProperties.Add("IsActive", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Jm", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Naziv", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PdvId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _pdv</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncPdv(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _pdv, new PropertyChangedEventHandler( OnPdvPropertyChanged ), "Pdv", NinjaSoftware.EnioNg.CoolJ.RelationClasses.StaticArtiklRelations.PdvEntityUsingPdvIdStatic, true, signalRelatedEntity, "ArtiklCollection", resetFKFields, new int[] { (int)ArtiklFieldIndex.PdvId } );
			_pdv = null;
		}

		/// <summary> setups the sync logic for member _pdv</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncPdv(IEntityCore relatedEntity)
		{
			if(_pdv!=relatedEntity)
			{
				DesetupSyncPdv(true, true);
				_pdv = (PdvEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _pdv, new PropertyChangedEventHandler( OnPdvPropertyChanged ), "Pdv", NinjaSoftware.EnioNg.CoolJ.RelationClasses.StaticArtiklRelations.PdvEntityUsingPdvIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnPdvPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this ArtiklEntity</param>
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
		public  static ArtiklRelations Relations
		{
			get	{ return new ArtiklRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RacunStavka' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRacunStavkaCollection
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<RacunStavkaEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RacunStavkaEntityFactory))), (IEntityRelation)GetRelationsForField("RacunStavkaCollection")[0], (int)NinjaSoftware.EnioNg.CoolJ.EntityType.ArtiklEntity, (int)NinjaSoftware.EnioNg.CoolJ.EntityType.RacunStavkaEntity, 0, null, null, null, null, "RacunStavkaCollection", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Pdv' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPdv
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(PdvEntityFactory))),	(IEntityRelation)GetRelationsForField("Pdv")[0], (int)NinjaSoftware.EnioNg.CoolJ.EntityType.ArtiklEntity, (int)NinjaSoftware.EnioNg.CoolJ.EntityType.PdvEntity, 0, null, null, null, null, "Pdv", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The ArtiklId property of the Entity Artikl<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Artikl"."ArtiklId"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		[JsonProperty]
		public virtual System.Int64 ArtiklId
		{
			get { return (System.Int64)GetValue((int)ArtiklFieldIndex.ArtiklId, true); }
			set	{ SetValue((int)ArtiklFieldIndex.ArtiklId, value); }
		}

		/// <summary> The Cijena property of the Entity Artikl<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Artikl"."Cijena"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 10, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]
		public virtual System.Decimal Cijena
		{
			get { return (System.Decimal)GetValue((int)ArtiklFieldIndex.Cijena, true); }
			set	{ SetValue((int)ArtiklFieldIndex.Cijena, value); }
		}

		/// <summary> The ConcurrencyGuid property of the Entity Artikl<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Artikl"."ConcurrencyGuid"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]
		public virtual System.String ConcurrencyGuid
		{
			get { return (System.String)GetValue((int)ArtiklFieldIndex.ConcurrencyGuid, true); }
			set	{ SetValue((int)ArtiklFieldIndex.ConcurrencyGuid, value); }
		}

		/// <summary> The IsActive property of the Entity Artikl<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Artikl"."IsActive"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]
		public virtual System.Boolean IsActive
		{
			get { return (System.Boolean)GetValue((int)ArtiklFieldIndex.IsActive, true); }
			set	{ SetValue((int)ArtiklFieldIndex.IsActive, value); }
		}

		/// <summary> The Jm property of the Entity Artikl<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Artikl"."Jm"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]
		public virtual System.String Jm
		{
			get { return (System.String)GetValue((int)ArtiklFieldIndex.Jm, true); }
			set	{ SetValue((int)ArtiklFieldIndex.Jm, value); }
		}

		/// <summary> The Naziv property of the Entity Artikl<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Artikl"."Naziv"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 150<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]
		public virtual System.String Naziv
		{
			get { return (System.String)GetValue((int)ArtiklFieldIndex.Naziv, true); }
			set	{ SetValue((int)ArtiklFieldIndex.Naziv, value); }
		}

		/// <summary> The PdvId property of the Entity Artikl<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Artikl"."PdvId"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]
		public virtual System.Int64 PdvId
		{
			get { return (System.Int64)GetValue((int)ArtiklFieldIndex.PdvId, true); }
			set	{ SetValue((int)ArtiklFieldIndex.PdvId, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'RacunStavkaEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(RacunStavkaEntity))]
		public virtual EntityCollection<RacunStavkaEntity> RacunStavkaCollection
		{
			get { return GetOrCreateEntityCollection<RacunStavkaEntity, RacunStavkaEntityFactory>("Artikl", true, false, ref _racunStavkaCollection);	}
		}

		/// <summary> Gets / sets related entity of type 'PdvEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		[JsonProperty]
		public virtual PdvEntity Pdv
		{
			get	{ return _pdv; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncPdv(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "ArtiklCollection", "Pdv", _pdv, true); 
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
			get { return (int)NinjaSoftware.EnioNg.CoolJ.EntityType.ArtiklEntity; }
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
