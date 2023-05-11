﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MisonVoiApp
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MaisonAuto")]
	public partial class AutoClientDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertclient(client instance);
    partial void Updateclient(client instance);
    partial void Deleteclient(client instance);
    partial void InsertAchatCache(AchatCache instance);
    partial void UpdateAchatCache(AchatCache instance);
    partial void DeleteAchatCache(AchatCache instance);
    partial void InsertAchatLoyer(AchatLoyer instance);
    partial void UpdateAchatLoyer(AchatLoyer instance);
    partial void DeleteAchatLoyer(AchatLoyer instance);
    #endregion
		
		public AutoClientDBDataContext() : 
				base(global::MisonVoiApp.Properties.Settings.Default.MaisonAutoConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public AutoClientDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AutoClientDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AutoClientDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AutoClientDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<client> clients
		{
			get
			{
				return this.GetTable<client>();
			}
		}
		
		public System.Data.Linq.Table<AchatCache> AchatCaches
		{
			get
			{
				return this.GetTable<AchatCache>();
			}
		}
		
		public System.Data.Linq.Table<AchatLoyer> AchatLoyers
		{
			get
			{
				return this.GetTable<AchatLoyer>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.client")]
	public partial class client : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _CINclient;
		
		private string _nomCompletClient;
		
		private string _phoneNumber;
		
		private string _adresse;
		
		private System.Nullable<System.DateTime> _dateNaissance;
		
		private string _occupation;
		
		private System.Data.Linq.Binary _photo;
		
		private EntitySet<AchatCache> _AchatCaches;
		
		private EntitySet<AchatLoyer> _AchatLoyers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCINclientChanging(string value);
    partial void OnCINclientChanged();
    partial void OnnomCompletClientChanging(string value);
    partial void OnnomCompletClientChanged();
    partial void OnphoneNumberChanging(string value);
    partial void OnphoneNumberChanged();
    partial void OnadresseChanging(string value);
    partial void OnadresseChanged();
    partial void OndateNaissanceChanging(System.Nullable<System.DateTime> value);
    partial void OndateNaissanceChanged();
    partial void OnoccupationChanging(string value);
    partial void OnoccupationChanged();
    partial void OnphotoChanging(System.Data.Linq.Binary value);
    partial void OnphotoChanged();
    #endregion
		
		public client()
		{
			this._AchatCaches = new EntitySet<AchatCache>(new Action<AchatCache>(this.attach_AchatCaches), new Action<AchatCache>(this.detach_AchatCaches));
			this._AchatLoyers = new EntitySet<AchatLoyer>(new Action<AchatLoyer>(this.attach_AchatLoyers), new Action<AchatLoyer>(this.detach_AchatLoyers));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CINclient", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CINclient
		{
			get
			{
				return this._CINclient;
			}
			set
			{
				if ((this._CINclient != value))
				{
					this.OnCINclientChanging(value);
					this.SendPropertyChanging();
					this._CINclient = value;
					this.SendPropertyChanged("CINclient");
					this.OnCINclientChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nomCompletClient", DbType="VarChar(100)")]
		public string nomCompletClient
		{
			get
			{
				return this._nomCompletClient;
			}
			set
			{
				if ((this._nomCompletClient != value))
				{
					this.OnnomCompletClientChanging(value);
					this.SendPropertyChanging();
					this._nomCompletClient = value;
					this.SendPropertyChanged("nomCompletClient");
					this.OnnomCompletClientChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phoneNumber", DbType="VarChar(50)")]
		public string phoneNumber
		{
			get
			{
				return this._phoneNumber;
			}
			set
			{
				if ((this._phoneNumber != value))
				{
					this.OnphoneNumberChanging(value);
					this.SendPropertyChanging();
					this._phoneNumber = value;
					this.SendPropertyChanged("phoneNumber");
					this.OnphoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adresse", DbType="VarChar(50)")]
		public string adresse
		{
			get
			{
				return this._adresse;
			}
			set
			{
				if ((this._adresse != value))
				{
					this.OnadresseChanging(value);
					this.SendPropertyChanging();
					this._adresse = value;
					this.SendPropertyChanged("adresse");
					this.OnadresseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dateNaissance", DbType="Date")]
		public System.Nullable<System.DateTime> dateNaissance
		{
			get
			{
				return this._dateNaissance;
			}
			set
			{
				if ((this._dateNaissance != value))
				{
					this.OndateNaissanceChanging(value);
					this.SendPropertyChanging();
					this._dateNaissance = value;
					this.SendPropertyChanged("dateNaissance");
					this.OndateNaissanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_occupation", DbType="VarChar(50)")]
		public string occupation
		{
			get
			{
				return this._occupation;
			}
			set
			{
				if ((this._occupation != value))
				{
					this.OnoccupationChanging(value);
					this.SendPropertyChanging();
					this._occupation = value;
					this.SendPropertyChanged("occupation");
					this.OnoccupationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_photo", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary photo
		{
			get
			{
				return this._photo;
			}
			set
			{
				if ((this._photo != value))
				{
					this.OnphotoChanging(value);
					this.SendPropertyChanging();
					this._photo = value;
					this.SendPropertyChanged("photo");
					this.OnphotoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="client_AchatCache", Storage="_AchatCaches", ThisKey="CINclient", OtherKey="idClient")]
		public EntitySet<AchatCache> AchatCaches
		{
			get
			{
				return this._AchatCaches;
			}
			set
			{
				this._AchatCaches.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="client_AchatLoyer", Storage="_AchatLoyers", ThisKey="CINclient", OtherKey="idClient")]
		public EntitySet<AchatLoyer> AchatLoyers
		{
			get
			{
				return this._AchatLoyers;
			}
			set
			{
				this._AchatLoyers.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_AchatCaches(AchatCache entity)
		{
			this.SendPropertyChanging();
			entity.client = this;
		}
		
		private void detach_AchatCaches(AchatCache entity)
		{
			this.SendPropertyChanging();
			entity.client = null;
		}
		
		private void attach_AchatLoyers(AchatLoyer entity)
		{
			this.SendPropertyChanging();
			entity.client = this;
		}
		
		private void detach_AchatLoyers(AchatLoyer entity)
		{
			this.SendPropertyChanging();
			entity.client = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AchatCache")]
	public partial class AchatCache : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _idClient;
		
		private int _idVoiture;
		
		private System.Nullable<System.DateTime> _achatDate;
		
		private System.Nullable<double> _remisePromotionelle;
		
		private System.Nullable<double> _fraisMatriculation;
		
		private System.Nullable<double> _autreFrais;
		
		private System.Nullable<double> _totalAchat;
		
		private System.Nullable<int> _jrsGarantis;
		
		private EntityRef<client> _client;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidClientChanging(string value);
    partial void OnidClientChanged();
    partial void OnidVoitureChanging(int value);
    partial void OnidVoitureChanged();
    partial void OnachatDateChanging(System.Nullable<System.DateTime> value);
    partial void OnachatDateChanged();
    partial void OnremisePromotionelleChanging(System.Nullable<double> value);
    partial void OnremisePromotionelleChanged();
    partial void OnfraisMatriculationChanging(System.Nullable<double> value);
    partial void OnfraisMatriculationChanged();
    partial void OnautreFraisChanging(System.Nullable<double> value);
    partial void OnautreFraisChanged();
    partial void OntotalAchatChanging(System.Nullable<double> value);
    partial void OntotalAchatChanged();
    partial void OnjrsGarantisChanging(System.Nullable<int> value);
    partial void OnjrsGarantisChanged();
    #endregion
		
		public AchatCache()
		{
			this._client = default(EntityRef<client>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idClient", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string idClient
		{
			get
			{
				return this._idClient;
			}
			set
			{
				if ((this._idClient != value))
				{
					if (this._client.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidClientChanging(value);
					this.SendPropertyChanging();
					this._idClient = value;
					this.SendPropertyChanged("idClient");
					this.OnidClientChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idVoiture", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int idVoiture
		{
			get
			{
				return this._idVoiture;
			}
			set
			{
				if ((this._idVoiture != value))
				{
					this.OnidVoitureChanging(value);
					this.SendPropertyChanging();
					this._idVoiture = value;
					this.SendPropertyChanged("idVoiture");
					this.OnidVoitureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_achatDate", DbType="Date")]
		public System.Nullable<System.DateTime> achatDate
		{
			get
			{
				return this._achatDate;
			}
			set
			{
				if ((this._achatDate != value))
				{
					this.OnachatDateChanging(value);
					this.SendPropertyChanging();
					this._achatDate = value;
					this.SendPropertyChanged("achatDate");
					this.OnachatDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_remisePromotionelle", DbType="Float")]
		public System.Nullable<double> remisePromotionelle
		{
			get
			{
				return this._remisePromotionelle;
			}
			set
			{
				if ((this._remisePromotionelle != value))
				{
					this.OnremisePromotionelleChanging(value);
					this.SendPropertyChanging();
					this._remisePromotionelle = value;
					this.SendPropertyChanged("remisePromotionelle");
					this.OnremisePromotionelleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fraisMatriculation", DbType="Float")]
		public System.Nullable<double> fraisMatriculation
		{
			get
			{
				return this._fraisMatriculation;
			}
			set
			{
				if ((this._fraisMatriculation != value))
				{
					this.OnfraisMatriculationChanging(value);
					this.SendPropertyChanging();
					this._fraisMatriculation = value;
					this.SendPropertyChanged("fraisMatriculation");
					this.OnfraisMatriculationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_autreFrais", DbType="Float")]
		public System.Nullable<double> autreFrais
		{
			get
			{
				return this._autreFrais;
			}
			set
			{
				if ((this._autreFrais != value))
				{
					this.OnautreFraisChanging(value);
					this.SendPropertyChanging();
					this._autreFrais = value;
					this.SendPropertyChanged("autreFrais");
					this.OnautreFraisChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_totalAchat", DbType="Float")]
		public System.Nullable<double> totalAchat
		{
			get
			{
				return this._totalAchat;
			}
			set
			{
				if ((this._totalAchat != value))
				{
					this.OntotalAchatChanging(value);
					this.SendPropertyChanging();
					this._totalAchat = value;
					this.SendPropertyChanged("totalAchat");
					this.OntotalAchatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_jrsGarantis", DbType="Int")]
		public System.Nullable<int> jrsGarantis
		{
			get
			{
				return this._jrsGarantis;
			}
			set
			{
				if ((this._jrsGarantis != value))
				{
					this.OnjrsGarantisChanging(value);
					this.SendPropertyChanging();
					this._jrsGarantis = value;
					this.SendPropertyChanged("jrsGarantis");
					this.OnjrsGarantisChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="client_AchatCache", Storage="_client", ThisKey="idClient", OtherKey="CINclient", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public client client
		{
			get
			{
				return this._client.Entity;
			}
			set
			{
				client previousValue = this._client.Entity;
				if (((previousValue != value) 
							|| (this._client.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._client.Entity = null;
						previousValue.AchatCaches.Remove(this);
					}
					this._client.Entity = value;
					if ((value != null))
					{
						value.AchatCaches.Add(this);
						this._idClient = value.CINclient;
					}
					else
					{
						this._idClient = default(string);
					}
					this.SendPropertyChanged("client");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AchatLoyers")]
	public partial class AchatLoyer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _idClient;
		
		private int _idVoiture;
		
		private System.Nullable<System.DateTime> _dateAchat;
		
		private System.Nullable<double> _prixVoiture;
		
		private System.Nullable<double> _ApportClientTTC;
		
		private System.Nullable<int> _nbLoyers;
		
		private System.Nullable<double> _LoyerTTC;
		
		private System.Nullable<double> _AssurenceMensuelle;
		
		private System.Nullable<double> _coutGlobalTTC;
		
		private System.Nullable<int> _jrsGarantis;
		
		private EntityRef<client> _client;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidClientChanging(string value);
    partial void OnidClientChanged();
    partial void OnidVoitureChanging(int value);
    partial void OnidVoitureChanged();
    partial void OndateAchatChanging(System.Nullable<System.DateTime> value);
    partial void OndateAchatChanged();
    partial void OnprixVoitureChanging(System.Nullable<double> value);
    partial void OnprixVoitureChanged();
    partial void OnApportClientTTCChanging(System.Nullable<double> value);
    partial void OnApportClientTTCChanged();
    partial void OnnbLoyersChanging(System.Nullable<int> value);
    partial void OnnbLoyersChanged();
    partial void OnLoyerTTCChanging(System.Nullable<double> value);
    partial void OnLoyerTTCChanged();
    partial void OnAssurenceMensuelleChanging(System.Nullable<double> value);
    partial void OnAssurenceMensuelleChanged();
    partial void OncoutGlobalTTCChanging(System.Nullable<double> value);
    partial void OncoutGlobalTTCChanged();
    partial void OnjrsGarantisChanging(System.Nullable<int> value);
    partial void OnjrsGarantisChanged();
    #endregion
		
		public AchatLoyer()
		{
			this._client = default(EntityRef<client>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idClient", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string idClient
		{
			get
			{
				return this._idClient;
			}
			set
			{
				if ((this._idClient != value))
				{
					if (this._client.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidClientChanging(value);
					this.SendPropertyChanging();
					this._idClient = value;
					this.SendPropertyChanged("idClient");
					this.OnidClientChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idVoiture", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int idVoiture
		{
			get
			{
				return this._idVoiture;
			}
			set
			{
				if ((this._idVoiture != value))
				{
					this.OnidVoitureChanging(value);
					this.SendPropertyChanging();
					this._idVoiture = value;
					this.SendPropertyChanged("idVoiture");
					this.OnidVoitureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dateAchat", DbType="Date")]
		public System.Nullable<System.DateTime> dateAchat
		{
			get
			{
				return this._dateAchat;
			}
			set
			{
				if ((this._dateAchat != value))
				{
					this.OndateAchatChanging(value);
					this.SendPropertyChanging();
					this._dateAchat = value;
					this.SendPropertyChanged("dateAchat");
					this.OndateAchatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prixVoiture", DbType="Float")]
		public System.Nullable<double> prixVoiture
		{
			get
			{
				return this._prixVoiture;
			}
			set
			{
				if ((this._prixVoiture != value))
				{
					this.OnprixVoitureChanging(value);
					this.SendPropertyChanging();
					this._prixVoiture = value;
					this.SendPropertyChanged("prixVoiture");
					this.OnprixVoitureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ApportClientTTC", DbType="Float")]
		public System.Nullable<double> ApportClientTTC
		{
			get
			{
				return this._ApportClientTTC;
			}
			set
			{
				if ((this._ApportClientTTC != value))
				{
					this.OnApportClientTTCChanging(value);
					this.SendPropertyChanging();
					this._ApportClientTTC = value;
					this.SendPropertyChanged("ApportClientTTC");
					this.OnApportClientTTCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nbLoyers", DbType="Int")]
		public System.Nullable<int> nbLoyers
		{
			get
			{
				return this._nbLoyers;
			}
			set
			{
				if ((this._nbLoyers != value))
				{
					this.OnnbLoyersChanging(value);
					this.SendPropertyChanging();
					this._nbLoyers = value;
					this.SendPropertyChanged("nbLoyers");
					this.OnnbLoyersChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoyerTTC", DbType="Float")]
		public System.Nullable<double> LoyerTTC
		{
			get
			{
				return this._LoyerTTC;
			}
			set
			{
				if ((this._LoyerTTC != value))
				{
					this.OnLoyerTTCChanging(value);
					this.SendPropertyChanging();
					this._LoyerTTC = value;
					this.SendPropertyChanged("LoyerTTC");
					this.OnLoyerTTCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AssurenceMensuelle", DbType="Float")]
		public System.Nullable<double> AssurenceMensuelle
		{
			get
			{
				return this._AssurenceMensuelle;
			}
			set
			{
				if ((this._AssurenceMensuelle != value))
				{
					this.OnAssurenceMensuelleChanging(value);
					this.SendPropertyChanging();
					this._AssurenceMensuelle = value;
					this.SendPropertyChanged("AssurenceMensuelle");
					this.OnAssurenceMensuelleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_coutGlobalTTC", DbType="Float")]
		public System.Nullable<double> coutGlobalTTC
		{
			get
			{
				return this._coutGlobalTTC;
			}
			set
			{
				if ((this._coutGlobalTTC != value))
				{
					this.OncoutGlobalTTCChanging(value);
					this.SendPropertyChanging();
					this._coutGlobalTTC = value;
					this.SendPropertyChanged("coutGlobalTTC");
					this.OncoutGlobalTTCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_jrsGarantis", DbType="Int")]
		public System.Nullable<int> jrsGarantis
		{
			get
			{
				return this._jrsGarantis;
			}
			set
			{
				if ((this._jrsGarantis != value))
				{
					this.OnjrsGarantisChanging(value);
					this.SendPropertyChanging();
					this._jrsGarantis = value;
					this.SendPropertyChanged("jrsGarantis");
					this.OnjrsGarantisChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="client_AchatLoyer", Storage="_client", ThisKey="idClient", OtherKey="CINclient", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public client client
		{
			get
			{
				return this._client.Entity;
			}
			set
			{
				client previousValue = this._client.Entity;
				if (((previousValue != value) 
							|| (this._client.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._client.Entity = null;
						previousValue.AchatLoyers.Remove(this);
					}
					this._client.Entity = value;
					if ((value != null))
					{
						value.AchatLoyers.Add(this);
						this._idClient = value.CINclient;
					}
					else
					{
						this._idClient = default(string);
					}
					this.SendPropertyChanged("client");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591