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
	/// <summary>Entity class which represents the entity 'AuditInfo'.<br/><br/></summary>
	[Serializable]
	[JsonObject(MemberSerialization.OptIn)] 
	public partial class AuditInfoEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AuditInfoActionTypeRoEntity _auditInfoActionType;
		private EntityRoEntity _entity;
		private UserEntity _user;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name AuditInfoActionType</summary>
			public static readonly string AuditInfoActionType = "AuditInfoActionType";
			/// <summary>Member name Entity</summary>
			public static readonly string Entity = "Entity";
			/// <summary>Member name User</summary>
			public static readonly string User = "User";
		}

        /// <summary>
		/// Returns number of entities after filterBucket is applied.
		/// If you need number of all entities send null as filterBucket.
        /// </summary>
		public static int GetNumberOfEntities(DataAccessAdapterBase adapter, 
			IRelationPredicateBucket filterBucket)
		{
			EntityCollection entityCollection = new EntityCollection(new AuditInfoEntityFactory());
			return adapter.GetDbCount(entityCollection, filterBucket);
		}
		
		/// <summary>
        /// Efficient pageing for grid.
        /// </summary>
        /// <param name="pageNumber">Must be greater than zero.</param>
        /// <param name="sortDirection">Validne vrijednosti su 'asc' i 'desc'.</param>
        public static EntityCollection<AuditInfoEntity> FetchAuditInfoCollectionForPaging(DataAccessAdapterBase adapter,
			RelationPredicateBucket bucket,
			PrefetchPath2 prefetchPath,
            int pageNumber,
            int pageSize,
            string sortField,
			bool isSortAscending)
        {
			string sortDirection = isSortAscending ? "asc" : "desc";

            Type sortEntityFieldType = typeof(AuditInfoFields);
            string sortEntityFieldTypeName = SortHelper.GetEntityFieldTypeNameForSorting(sortField, sortEntityFieldType);
            if (!string.IsNullOrWhiteSpace(sortEntityFieldTypeName))
            {
                sortEntityFieldType = Type.GetType(sortEntityFieldTypeName);
            }

            sortField = SortHelper.GetSortField(sortField);			

			SortExpression sort = SortHelper.GetSortExpression(sortField, sortDirection, sortEntityFieldType);
			
            EntityCollection<AuditInfoEntity> toReturn = new EntityCollection<AuditInfoEntity>(new AuditInfoEntityFactory());
            adapter.FetchEntityCollection(toReturn, bucket, pageSize, sort, prefetchPath, pageNumber, pageSize);

            return toReturn;
        }
		
		public static EntityCollection<AuditInfoEntity> FetchAuditInfoCollection(DataAccessAdapterBase adapter,
			IRelationPredicateBucket filterBucket,
			PrefetchPath2 prefetchPath)
		{
			EntityCollection<AuditInfoEntity> toReturn = new EntityCollection<AuditInfoEntity>(new AuditInfoEntityFactory());
			adapter.FetchEntityCollection(toReturn, filterBucket, prefetchPath);
			return toReturn;
		}
		
		public static AuditInfoEntity FetchAuditInfo(DataAccessAdapterBase adapter, PrefetchPath2 prefetchPath, long AuditInfoId)
		{
			AuditInfoEntity _AuditInfoEntity = new AuditInfoEntity(AuditInfoId);
			adapter.FetchEntity(_AuditInfoEntity, prefetchPath);
			return _AuditInfoEntity;
		}
		
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static AuditInfoEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public AuditInfoEntity():base("AuditInfoEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public AuditInfoEntity(IEntityFields2 fields):base("AuditInfoEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this AuditInfoEntity</param>
		public AuditInfoEntity(IValidator validator):base("AuditInfoEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="auditInfoId">PK value for AuditInfo which data should be fetched into this AuditInfo object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public AuditInfoEntity(System.Int64 auditInfoId):base("AuditInfoEntity")
		{
			InitClassEmpty(null, null);
			this.AuditInfoId = auditInfoId;
		}

		/// <summary> CTor</summary>
		/// <param name="auditInfoId">PK value for AuditInfo which data should be fetched into this AuditInfo object</param>
		/// <param name="validator">The custom validator object for this AuditInfoEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public AuditInfoEntity(System.Int64 auditInfoId, IValidator validator):base("AuditInfoEntity")
		{
			InitClassEmpty(validator, null);
			this.AuditInfoId = auditInfoId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected AuditInfoEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_auditInfoActionType = (AuditInfoActionTypeRoEntity)info.GetValue("_auditInfoActionType", typeof(AuditInfoActionTypeRoEntity));
				if(_auditInfoActionType!=null)
				{
					_auditInfoActionType.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_entity = (EntityRoEntity)info.GetValue("_entity", typeof(EntityRoEntity));
				if(_entity!=null)
				{
					_entity.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_user = (UserEntity)info.GetValue("_user", typeof(UserEntity));
				if(_user!=null)
				{
					_user.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((AuditInfoFieldIndex)fieldIndex)
			{
				case AuditInfoFieldIndex.AuditInfoActionTypeId:
					DesetupSyncAuditInfoActionType(true, false);
					break;
				case AuditInfoFieldIndex.EntityId:
					DesetupSyncEntity(true, false);
					break;
				case AuditInfoFieldIndex.UserId:
					DesetupSyncUser(true, false);
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
				case "AuditInfoActionType":
					this.AuditInfoActionType = (AuditInfoActionTypeRoEntity)entity;
					break;
				case "Entity":
					this.Entity = (EntityRoEntity)entity;
					break;
				case "User":
					this.User = (UserEntity)entity;
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
				case "AuditInfoActionType":
					toReturn.Add(Relations.AuditInfoActionTypeRoEntityUsingAuditInfoActionTypeId);
					break;
				case "Entity":
					toReturn.Add(Relations.EntityRoEntityUsingEntityId);
					break;
				case "User":
					toReturn.Add(Relations.UserEntityUsingUserId);
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
				case "AuditInfoActionType":
					SetupSyncAuditInfoActionType(relatedEntity);
					break;
				case "Entity":
					SetupSyncEntity(relatedEntity);
					break;
				case "User":
					SetupSyncUser(relatedEntity);
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
				case "AuditInfoActionType":
					DesetupSyncAuditInfoActionType(false, true);
					break;
				case "Entity":
					DesetupSyncEntity(false, true);
					break;
				case "User":
					DesetupSyncUser(false, true);
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
			if(_auditInfoActionType!=null)
			{
				toReturn.Add(_auditInfoActionType);
			}
			if(_entity!=null)
			{
				toReturn.Add(_entity);
			}
			if(_user!=null)
			{
				toReturn.Add(_user);
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
				info.AddValue("_auditInfoActionType", (!this.MarkedForDeletion?_auditInfoActionType:null));
				info.AddValue("_entity", (!this.MarkedForDeletion?_entity:null));
				info.AddValue("_user", (!this.MarkedForDeletion?_user:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new AuditInfoRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'AuditInfoActionTypeRo' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAuditInfoActionType()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AuditInfoActionTypeRoFields.AuditInfoActionTypeId, null, ComparisonOperator.Equal, this.AuditInfoActionTypeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'EntityRo' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEntity()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EntityRoFields.EntityId, null, ComparisonOperator.Equal, this.EntityId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'User' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUser()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(AuditInfoEntityFactory));
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
			toReturn.Add("AuditInfoActionType", _auditInfoActionType);
			toReturn.Add("Entity", _entity);
			toReturn.Add("User", _user);
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
			_fieldsCustomProperties.Add("ActionDateTime", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AuditInfoActionTypeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AuditInfoId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ConcurrencyGuid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("EntityId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("JsonData", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PrimaryKeyValue", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("UserId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _auditInfoActionType</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAuditInfoActionType(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _auditInfoActionType, new PropertyChangedEventHandler( OnAuditInfoActionTypePropertyChanged ), "AuditInfoActionType", NinjaSoftware.EnioNg.CoolJ.RelationClasses.StaticAuditInfoRelations.AuditInfoActionTypeRoEntityUsingAuditInfoActionTypeIdStatic, true, signalRelatedEntity, "AuditInfoCollection", resetFKFields, new int[] { (int)AuditInfoFieldIndex.AuditInfoActionTypeId } );
			_auditInfoActionType = null;
		}

		/// <summary> setups the sync logic for member _auditInfoActionType</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAuditInfoActionType(IEntityCore relatedEntity)
		{
			if(_auditInfoActionType!=relatedEntity)
			{
				DesetupSyncAuditInfoActionType(true, true);
				_auditInfoActionType = (AuditInfoActionTypeRoEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _auditInfoActionType, new PropertyChangedEventHandler( OnAuditInfoActionTypePropertyChanged ), "AuditInfoActionType", NinjaSoftware.EnioNg.CoolJ.RelationClasses.StaticAuditInfoRelations.AuditInfoActionTypeRoEntityUsingAuditInfoActionTypeIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnAuditInfoActionTypePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _entity</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncEntity(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _entity, new PropertyChangedEventHandler( OnEntityPropertyChanged ), "Entity", NinjaSoftware.EnioNg.CoolJ.RelationClasses.StaticAuditInfoRelations.EntityRoEntityUsingEntityIdStatic, true, signalRelatedEntity, "AuditInfoCollection", resetFKFields, new int[] { (int)AuditInfoFieldIndex.EntityId } );
			_entity = null;
		}

		/// <summary> setups the sync logic for member _entity</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncEntity(IEntityCore relatedEntity)
		{
			if(_entity!=relatedEntity)
			{
				DesetupSyncEntity(true, true);
				_entity = (EntityRoEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _entity, new PropertyChangedEventHandler( OnEntityPropertyChanged ), "Entity", NinjaSoftware.EnioNg.CoolJ.RelationClasses.StaticAuditInfoRelations.EntityRoEntityUsingEntityIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnEntityPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _user</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncUser(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _user, new PropertyChangedEventHandler( OnUserPropertyChanged ), "User", NinjaSoftware.EnioNg.CoolJ.RelationClasses.StaticAuditInfoRelations.UserEntityUsingUserIdStatic, true, signalRelatedEntity, "AuditInfoCollection", resetFKFields, new int[] { (int)AuditInfoFieldIndex.UserId } );
			_user = null;
		}

		/// <summary> setups the sync logic for member _user</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncUser(IEntityCore relatedEntity)
		{
			if(_user!=relatedEntity)
			{
				DesetupSyncUser(true, true);
				_user = (UserEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _user, new PropertyChangedEventHandler( OnUserPropertyChanged ), "User", NinjaSoftware.EnioNg.CoolJ.RelationClasses.StaticAuditInfoRelations.UserEntityUsingUserIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnUserPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this AuditInfoEntity</param>
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
		public  static AuditInfoRelations Relations
		{
			get	{ return new AuditInfoRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AuditInfoActionTypeRo' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAuditInfoActionType
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AuditInfoActionTypeRoEntityFactory))),	(IEntityRelation)GetRelationsForField("AuditInfoActionType")[0], (int)NinjaSoftware.EnioNg.CoolJ.EntityType.AuditInfoEntity, (int)NinjaSoftware.EnioNg.CoolJ.EntityType.AuditInfoActionTypeRoEntity, 0, null, null, null, null, "AuditInfoActionType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'EntityRo' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEntity
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(EntityRoEntityFactory))),	(IEntityRelation)GetRelationsForField("Entity")[0], (int)NinjaSoftware.EnioNg.CoolJ.EntityType.AuditInfoEntity, (int)NinjaSoftware.EnioNg.CoolJ.EntityType.EntityRoEntity, 0, null, null, null, null, "Entity", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'User' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUser
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))),	(IEntityRelation)GetRelationsForField("User")[0], (int)NinjaSoftware.EnioNg.CoolJ.EntityType.AuditInfoEntity, (int)NinjaSoftware.EnioNg.CoolJ.EntityType.UserEntity, 0, null, null, null, null, "User", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The ActionDateTime property of the Entity AuditInfo<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AuditInfo"."ActionDateTime"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]
		public virtual System.DateTime ActionDateTime
		{
			get { return (System.DateTime)GetValue((int)AuditInfoFieldIndex.ActionDateTime, true); }
			set	{ SetValue((int)AuditInfoFieldIndex.ActionDateTime, value); }
		}

		/// <summary> The AuditInfoActionTypeId property of the Entity AuditInfo<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AuditInfo"."AuditInfoActionTypeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]
		public virtual System.Int64 AuditInfoActionTypeId
		{
			get { return (System.Int64)GetValue((int)AuditInfoFieldIndex.AuditInfoActionTypeId, true); }
			set	{ SetValue((int)AuditInfoFieldIndex.AuditInfoActionTypeId, value); }
		}

		/// <summary> The AuditInfoId property of the Entity AuditInfo<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AuditInfo"."AuditInfoId"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		[JsonProperty]
		public virtual System.Int64 AuditInfoId
		{
			get { return (System.Int64)GetValue((int)AuditInfoFieldIndex.AuditInfoId, true); }
			set	{ SetValue((int)AuditInfoFieldIndex.AuditInfoId, value); }
		}

		/// <summary> The ConcurrencyGuid property of the Entity AuditInfo<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AuditInfo"."ConcurrencyGuid"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]
		public virtual System.String ConcurrencyGuid
		{
			get { return (System.String)GetValue((int)AuditInfoFieldIndex.ConcurrencyGuid, true); }
			set	{ SetValue((int)AuditInfoFieldIndex.ConcurrencyGuid, value); }
		}

		/// <summary> The EntityId property of the Entity AuditInfo<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AuditInfo"."EntityId"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]
		public virtual System.Int64 EntityId
		{
			get { return (System.Int64)GetValue((int)AuditInfoFieldIndex.EntityId, true); }
			set	{ SetValue((int)AuditInfoFieldIndex.EntityId, value); }
		}

		/// <summary> The JsonData property of the Entity AuditInfo<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AuditInfo"."JsonData"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]
		public virtual System.String JsonData
		{
			get { return (System.String)GetValue((int)AuditInfoFieldIndex.JsonData, true); }
			set	{ SetValue((int)AuditInfoFieldIndex.JsonData, value); }
		}

		/// <summary> The PrimaryKeyValue property of the Entity AuditInfo<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AuditInfo"."PrimaryKeyValue"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]
		public virtual System.Int64 PrimaryKeyValue
		{
			get { return (System.Int64)GetValue((int)AuditInfoFieldIndex.PrimaryKeyValue, true); }
			set	{ SetValue((int)AuditInfoFieldIndex.PrimaryKeyValue, value); }
		}

		/// <summary> The UserId property of the Entity AuditInfo<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AuditInfo"."UserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]
		public virtual System.Int64 UserId
		{
			get { return (System.Int64)GetValue((int)AuditInfoFieldIndex.UserId, true); }
			set	{ SetValue((int)AuditInfoFieldIndex.UserId, value); }
		}

		/// <summary> Gets / sets related entity of type 'AuditInfoActionTypeRoEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		[JsonProperty]
		public virtual AuditInfoActionTypeRoEntity AuditInfoActionType
		{
			get	{ return _auditInfoActionType; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncAuditInfoActionType(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "AuditInfoCollection", "AuditInfoActionType", _auditInfoActionType, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'EntityRoEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		[JsonProperty]
		public virtual EntityRoEntity Entity
		{
			get	{ return _entity; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncEntity(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "AuditInfoCollection", "Entity", _entity, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'UserEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		[JsonProperty]
		public virtual UserEntity User
		{
			get	{ return _user; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncUser(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "AuditInfoCollection", "User", _user, true); 
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
			get { return (int)NinjaSoftware.EnioNg.CoolJ.EntityType.AuditInfoEntity; }
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
