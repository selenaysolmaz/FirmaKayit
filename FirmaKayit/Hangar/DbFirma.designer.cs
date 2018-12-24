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

namespace FirmaKayit.Hangar
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="FirmaKayit")]
	public partial class DbFirmaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertbgFirmaKayit(bgFirmaKayit instance);
    partial void UpdatebgFirmaKayit(bgFirmaKayit instance);
    partial void DeletebgFirmaKayit(bgFirmaKayit instance);
    partial void InsertbgFirmaTipi(bgFirmaTipi instance);
    partial void UpdatebgFirmaTipi(bgFirmaTipi instance);
    partial void DeletebgFirmaTipi(bgFirmaTipi instance);
    #endregion
		
		public DbFirmaDataContext() : 
				base(global::FirmaKayit.Properties.Settings.Default.FirmaKayitConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DbFirmaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbFirmaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbFirmaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbFirmaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<bgFirmaKayit> bgFirmaKayits
		{
			get
			{
				return this.GetTable<bgFirmaKayit>();
			}
		}
		
		public System.Data.Linq.Table<bgFirmaTipi> bgFirmaTipis
		{
			get
			{
				return this.GetTable<bgFirmaTipi>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.bgFirmaKayit")]
	public partial class bgFirmaKayit : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _Fno;
		
		private System.Nullable<int> _Ftipi;
		
		private string _Fadi;
		
		private string _Fadres;
		
		private string _Ftel1;
		
		private string _Ftel2;
		
		private string _Ffax;
		
		private string _Fyetkili;
		
		private string _Fdepartman;
		
		private string _Fweb;
		
		private string _Femail;
		
		private string _Fvd;
		
		private string _Fvno;
		
		private System.Nullable<int> _saveUser;
		
		private System.Nullable<System.DateTime> _saveDate;
		
		private System.Nullable<int> _updateUser;
		
		private System.Nullable<System.DateTime> _updateDate;
		
		private EntityRef<bgFirmaTipi> _bgFirmaTipi;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFnoChanging(System.Nullable<int> value);
    partial void OnFnoChanged();
    partial void OnFtipiChanging(System.Nullable<int> value);
    partial void OnFtipiChanged();
    partial void OnFadiChanging(string value);
    partial void OnFadiChanged();
    partial void OnFadresChanging(string value);
    partial void OnFadresChanged();
    partial void OnFtel1Changing(string value);
    partial void OnFtel1Changed();
    partial void OnFtel2Changing(string value);
    partial void OnFtel2Changed();
    partial void OnFfaxChanging(string value);
    partial void OnFfaxChanged();
    partial void OnFyetkiliChanging(string value);
    partial void OnFyetkiliChanged();
    partial void OnFdepartmanChanging(string value);
    partial void OnFdepartmanChanged();
    partial void OnFwebChanging(string value);
    partial void OnFwebChanged();
    partial void OnFemailChanging(string value);
    partial void OnFemailChanged();
    partial void OnFvdChanging(string value);
    partial void OnFvdChanged();
    partial void OnFvnoChanging(string value);
    partial void OnFvnoChanged();
    partial void OnsaveUserChanging(System.Nullable<int> value);
    partial void OnsaveUserChanged();
    partial void OnsaveDateChanging(System.Nullable<System.DateTime> value);
    partial void OnsaveDateChanged();
    partial void OnupdateUserChanging(System.Nullable<int> value);
    partial void OnupdateUserChanged();
    partial void OnupdateDateChanging(System.Nullable<System.DateTime> value);
    partial void OnupdateDateChanged();
    #endregion
		
		public bgFirmaKayit()
		{
			this._bgFirmaTipi = default(EntityRef<bgFirmaTipi>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fno", DbType="Int")]
		public System.Nullable<int> Fno
		{
			get
			{
				return this._Fno;
			}
			set
			{
				if ((this._Fno != value))
				{
					this.OnFnoChanging(value);
					this.SendPropertyChanging();
					this._Fno = value;
					this.SendPropertyChanged("Fno");
					this.OnFnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ftipi", DbType="Int")]
		public System.Nullable<int> Ftipi
		{
			get
			{
				return this._Ftipi;
			}
			set
			{
				if ((this._Ftipi != value))
				{
					if (this._bgFirmaTipi.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnFtipiChanging(value);
					this.SendPropertyChanging();
					this._Ftipi = value;
					this.SendPropertyChanged("Ftipi");
					this.OnFtipiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fadi", DbType="NVarChar(250)")]
		public string Fadi
		{
			get
			{
				return this._Fadi;
			}
			set
			{
				if ((this._Fadi != value))
				{
					this.OnFadiChanging(value);
					this.SendPropertyChanging();
					this._Fadi = value;
					this.SendPropertyChanged("Fadi");
					this.OnFadiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fadres", DbType="NVarChar(MAX)")]
		public string Fadres
		{
			get
			{
				return this._Fadres;
			}
			set
			{
				if ((this._Fadres != value))
				{
					this.OnFadresChanging(value);
					this.SendPropertyChanging();
					this._Fadres = value;
					this.SendPropertyChanged("Fadres");
					this.OnFadresChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ftel1", DbType="NVarChar(20)")]
		public string Ftel1
		{
			get
			{
				return this._Ftel1;
			}
			set
			{
				if ((this._Ftel1 != value))
				{
					this.OnFtel1Changing(value);
					this.SendPropertyChanging();
					this._Ftel1 = value;
					this.SendPropertyChanged("Ftel1");
					this.OnFtel1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ftel2", DbType="NVarChar(20)")]
		public string Ftel2
		{
			get
			{
				return this._Ftel2;
			}
			set
			{
				if ((this._Ftel2 != value))
				{
					this.OnFtel2Changing(value);
					this.SendPropertyChanging();
					this._Ftel2 = value;
					this.SendPropertyChanged("Ftel2");
					this.OnFtel2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ffax", DbType="NVarChar(20)")]
		public string Ffax
		{
			get
			{
				return this._Ffax;
			}
			set
			{
				if ((this._Ffax != value))
				{
					this.OnFfaxChanging(value);
					this.SendPropertyChanging();
					this._Ffax = value;
					this.SendPropertyChanged("Ffax");
					this.OnFfaxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fyetkili", DbType="NVarChar(120)")]
		public string Fyetkili
		{
			get
			{
				return this._Fyetkili;
			}
			set
			{
				if ((this._Fyetkili != value))
				{
					this.OnFyetkiliChanging(value);
					this.SendPropertyChanging();
					this._Fyetkili = value;
					this.SendPropertyChanged("Fyetkili");
					this.OnFyetkiliChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fdepartman", DbType="NVarChar(50)")]
		public string Fdepartman
		{
			get
			{
				return this._Fdepartman;
			}
			set
			{
				if ((this._Fdepartman != value))
				{
					this.OnFdepartmanChanging(value);
					this.SendPropertyChanging();
					this._Fdepartman = value;
					this.SendPropertyChanged("Fdepartman");
					this.OnFdepartmanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fweb", DbType="NVarChar(100)")]
		public string Fweb
		{
			get
			{
				return this._Fweb;
			}
			set
			{
				if ((this._Fweb != value))
				{
					this.OnFwebChanging(value);
					this.SendPropertyChanging();
					this._Fweb = value;
					this.SendPropertyChanged("Fweb");
					this.OnFwebChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Femail", DbType="NVarChar(100)")]
		public string Femail
		{
			get
			{
				return this._Femail;
			}
			set
			{
				if ((this._Femail != value))
				{
					this.OnFemailChanging(value);
					this.SendPropertyChanging();
					this._Femail = value;
					this.SendPropertyChanged("Femail");
					this.OnFemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fvd", DbType="NVarChar(80)")]
		public string Fvd
		{
			get
			{
				return this._Fvd;
			}
			set
			{
				if ((this._Fvd != value))
				{
					this.OnFvdChanging(value);
					this.SendPropertyChanging();
					this._Fvd = value;
					this.SendPropertyChanged("Fvd");
					this.OnFvdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fvno", DbType="NVarChar(20)")]
		public string Fvno
		{
			get
			{
				return this._Fvno;
			}
			set
			{
				if ((this._Fvno != value))
				{
					this.OnFvnoChanging(value);
					this.SendPropertyChanging();
					this._Fvno = value;
					this.SendPropertyChanged("Fvno");
					this.OnFvnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_saveUser", DbType="Int")]
		public System.Nullable<int> saveUser
		{
			get
			{
				return this._saveUser;
			}
			set
			{
				if ((this._saveUser != value))
				{
					this.OnsaveUserChanging(value);
					this.SendPropertyChanging();
					this._saveUser = value;
					this.SendPropertyChanged("saveUser");
					this.OnsaveUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_saveDate", DbType="Date")]
		public System.Nullable<System.DateTime> saveDate
		{
			get
			{
				return this._saveDate;
			}
			set
			{
				if ((this._saveDate != value))
				{
					this.OnsaveDateChanging(value);
					this.SendPropertyChanging();
					this._saveDate = value;
					this.SendPropertyChanged("saveDate");
					this.OnsaveDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_updateUser", DbType="Int")]
		public System.Nullable<int> updateUser
		{
			get
			{
				return this._updateUser;
			}
			set
			{
				if ((this._updateUser != value))
				{
					this.OnupdateUserChanging(value);
					this.SendPropertyChanging();
					this._updateUser = value;
					this.SendPropertyChanged("updateUser");
					this.OnupdateUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_updateDate", DbType="Date")]
		public System.Nullable<System.DateTime> updateDate
		{
			get
			{
				return this._updateDate;
			}
			set
			{
				if ((this._updateDate != value))
				{
					this.OnupdateDateChanging(value);
					this.SendPropertyChanging();
					this._updateDate = value;
					this.SendPropertyChanged("updateDate");
					this.OnupdateDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="bgFirmaTipi_bgFirmaKayit", Storage="_bgFirmaTipi", ThisKey="Ftipi", OtherKey="Id", IsForeignKey=true)]
		public bgFirmaTipi bgFirmaTipi
		{
			get
			{
				return this._bgFirmaTipi.Entity;
			}
			set
			{
				bgFirmaTipi previousValue = this._bgFirmaTipi.Entity;
				if (((previousValue != value) 
							|| (this._bgFirmaTipi.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._bgFirmaTipi.Entity = null;
						previousValue.bgFirmaKayits.Remove(this);
					}
					this._bgFirmaTipi.Entity = value;
					if ((value != null))
					{
						value.bgFirmaKayits.Add(this);
						this._Ftipi = value.Id;
					}
					else
					{
						this._Ftipi = default(Nullable<int>);
					}
					this.SendPropertyChanged("bgFirmaTipi");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.bgFirmaTipi")]
	public partial class bgFirmaTipi : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Ftipi;
		
		private EntitySet<bgFirmaKayit> _bgFirmaKayits;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFtipiChanging(string value);
    partial void OnFtipiChanged();
    #endregion
		
		public bgFirmaTipi()
		{
			this._bgFirmaKayits = new EntitySet<bgFirmaKayit>(new Action<bgFirmaKayit>(this.attach_bgFirmaKayits), new Action<bgFirmaKayit>(this.detach_bgFirmaKayits));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ftipi", DbType="NVarChar(20)")]
		public string Ftipi
		{
			get
			{
				return this._Ftipi;
			}
			set
			{
				if ((this._Ftipi != value))
				{
					this.OnFtipiChanging(value);
					this.SendPropertyChanging();
					this._Ftipi = value;
					this.SendPropertyChanged("Ftipi");
					this.OnFtipiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="bgFirmaTipi_bgFirmaKayit", Storage="_bgFirmaKayits", ThisKey="Id", OtherKey="Ftipi")]
		public EntitySet<bgFirmaKayit> bgFirmaKayits
		{
			get
			{
				return this._bgFirmaKayits;
			}
			set
			{
				this._bgFirmaKayits.Assign(value);
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
		
		private void attach_bgFirmaKayits(bgFirmaKayit entity)
		{
			this.SendPropertyChanging();
			entity.bgFirmaTipi = this;
		}
		
		private void detach_bgFirmaKayits(bgFirmaKayit entity)
		{
			this.SendPropertyChanging();
			entity.bgFirmaTipi = null;
		}
	}
}
#pragma warning restore 1591
