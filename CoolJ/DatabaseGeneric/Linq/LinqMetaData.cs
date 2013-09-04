///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.0
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

using NinjaSoftware.EnioNg.CoolJ;
using NinjaSoftware.EnioNg.CoolJ.EntityClasses;
using NinjaSoftware.EnioNg.CoolJ.FactoryClasses;
using NinjaSoftware.EnioNg.CoolJ.HelperClasses;
using NinjaSoftware.EnioNg.CoolJ.RelationClasses;

namespace NinjaSoftware.EnioNg.CoolJ.Linq
{
	/// <summary>Meta-data class for the construction of Linq queries which are to be executed using LLBLGen Pro code.</summary>
	public partial class LinqMetaData: ILinqMetaData
	{
		#region Class Member Declarations
		private IDataAccessAdapter _adapterToUse;
		private FunctionMappingStore _customFunctionMappings;
		private Context _contextToUse;
		#endregion
		
		/// <summary>CTor. Using this ctor will leave the IDataAccessAdapter object to use empty. To be able to execute the query, an IDataAccessAdapter instance
		/// is required, and has to be set on the LLBLGenProProvider2 object in the query to execute. </summary>
		public LinqMetaData() : this(null, null)
		{
		}
		
		/// <summary>CTor which accepts an IDataAccessAdapter implementing object, which will be used to execute queries created with this metadata class.</summary>
		/// <param name="adapterToUse">the IDataAccessAdapter to use in queries created with this meta data</param>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(IDataAccessAdapter adapterToUse) : this (adapterToUse, null)
		{
		}

		/// <summary>CTor which accepts an IDataAccessAdapter implementing object, which will be used to execute queries created with this metadata class.</summary>
		/// <param name="adapterToUse">the IDataAccessAdapter to use in queries created with this meta data</param>
		/// <param name="customFunctionMappings">The custom function mappings to use. These take higher precedence than the ones in the DQE to use.</param>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(IDataAccessAdapter adapterToUse, FunctionMappingStore customFunctionMappings)
		{
			_adapterToUse = adapterToUse;
			_customFunctionMappings = customFunctionMappings;
		}
	
		/// <summary>returns the datasource to use in a Linq query for the entity type specified</summary>
		/// <param name="typeOfEntity">the type of the entity to get the datasource for</param>
		/// <returns>the requested datasource</returns>
		public IDataSource GetQueryableForEntity(int typeOfEntity)
		{
			IDataSource toReturn = null;
			switch((NinjaSoftware.EnioNg.CoolJ.EntityType)typeOfEntity)
			{
				case NinjaSoftware.EnioNg.CoolJ.EntityType.ArtiklEntity:
					toReturn = this.Artikl;
					break;
				case NinjaSoftware.EnioNg.CoolJ.EntityType.AuditInfoEntity:
					toReturn = this.AuditInfo;
					break;
				case NinjaSoftware.EnioNg.CoolJ.EntityType.AuditInfoActionTypeRoEntity:
					toReturn = this.AuditInfoActionTypeRo;
					break;
				case NinjaSoftware.EnioNg.CoolJ.EntityType.BrojacEntity:
					toReturn = this.Brojac;
					break;
				case NinjaSoftware.EnioNg.CoolJ.EntityType.ConfigEntity:
					toReturn = this.Config;
					break;
				case NinjaSoftware.EnioNg.CoolJ.EntityType.EntityRoEntity:
					toReturn = this.EntityRo;
					break;
				case NinjaSoftware.EnioNg.CoolJ.EntityType.ErrorEntity:
					toReturn = this.Error;
					break;
				case NinjaSoftware.EnioNg.CoolJ.EntityType.PartnerEntity:
					toReturn = this.Partner;
					break;
				case NinjaSoftware.EnioNg.CoolJ.EntityType.PdvEntity:
					toReturn = this.Pdv;
					break;
				case NinjaSoftware.EnioNg.CoolJ.EntityType.RacunGlavaEntity:
					toReturn = this.RacunGlava;
					break;
				case NinjaSoftware.EnioNg.CoolJ.EntityType.RacunStavkaEntity:
					toReturn = this.RacunStavka;
					break;
				case NinjaSoftware.EnioNg.CoolJ.EntityType.RoleRoEntity:
					toReturn = this.RoleRo;
					break;
				case NinjaSoftware.EnioNg.CoolJ.EntityType.StatusRoEntity:
					toReturn = this.StatusRo;
					break;
				case NinjaSoftware.EnioNg.CoolJ.EntityType.TarifaEntity:
					toReturn = this.Tarifa;
					break;
				case NinjaSoftware.EnioNg.CoolJ.EntityType.UserEntity:
					toReturn = this.User;
					break;
				default:
					toReturn = null;
					break;
			}
			return toReturn;
		}

		/// <summary>returns the datasource to use in a Linq query when targeting ArtiklEntity instances in the database.</summary>
		public DataSource2<ArtiklEntity> Artikl
		{
			get { return new DataSource2<ArtiklEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting AuditInfoEntity instances in the database.</summary>
		public DataSource2<AuditInfoEntity> AuditInfo
		{
			get { return new DataSource2<AuditInfoEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting AuditInfoActionTypeRoEntity instances in the database.</summary>
		public DataSource2<AuditInfoActionTypeRoEntity> AuditInfoActionTypeRo
		{
			get { return new DataSource2<AuditInfoActionTypeRoEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting BrojacEntity instances in the database.</summary>
		public DataSource2<BrojacEntity> Brojac
		{
			get { return new DataSource2<BrojacEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ConfigEntity instances in the database.</summary>
		public DataSource2<ConfigEntity> Config
		{
			get { return new DataSource2<ConfigEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting EntityRoEntity instances in the database.</summary>
		public DataSource2<EntityRoEntity> EntityRo
		{
			get { return new DataSource2<EntityRoEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ErrorEntity instances in the database.</summary>
		public DataSource2<ErrorEntity> Error
		{
			get { return new DataSource2<ErrorEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting PartnerEntity instances in the database.</summary>
		public DataSource2<PartnerEntity> Partner
		{
			get { return new DataSource2<PartnerEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting PdvEntity instances in the database.</summary>
		public DataSource2<PdvEntity> Pdv
		{
			get { return new DataSource2<PdvEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting RacunGlavaEntity instances in the database.</summary>
		public DataSource2<RacunGlavaEntity> RacunGlava
		{
			get { return new DataSource2<RacunGlavaEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting RacunStavkaEntity instances in the database.</summary>
		public DataSource2<RacunStavkaEntity> RacunStavka
		{
			get { return new DataSource2<RacunStavkaEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting RoleRoEntity instances in the database.</summary>
		public DataSource2<RoleRoEntity> RoleRo
		{
			get { return new DataSource2<RoleRoEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting StatusRoEntity instances in the database.</summary>
		public DataSource2<StatusRoEntity> StatusRo
		{
			get { return new DataSource2<StatusRoEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting TarifaEntity instances in the database.</summary>
		public DataSource2<TarifaEntity> Tarifa
		{
			get { return new DataSource2<TarifaEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting UserEntity instances in the database.</summary>
		public DataSource2<UserEntity> User
		{
			get { return new DataSource2<UserEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
 
		#region Class Property Declarations
		/// <summary> Gets / sets the IDataAccessAdapter to use for the queries created with this meta data object.</summary>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public IDataAccessAdapter AdapterToUse
		{
			get { return _adapterToUse;}
			set { _adapterToUse = value;}
		}

		/// <summary>Gets or sets the custom function mappings to use. These take higher precedence than the ones in the DQE to use</summary>
		public FunctionMappingStore CustomFunctionMappings
		{
			get { return _customFunctionMappings; }
			set { _customFunctionMappings = value; }
		}
		
		/// <summary>Gets or sets the Context instance to use for entity fetches.</summary>
		public Context ContextToUse
		{
			get { return _contextToUse;}
			set { _contextToUse = value;}
		}
		#endregion
	}
}