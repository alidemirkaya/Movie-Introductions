﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Movieintroductions
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Filmler")]
	public partial class MovieScreenDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertFilms(Films instance);
    partial void UpdateFilms(Films instance);
    partial void DeleteFilms(Films instance);
    partial void InsertFilmScreen(FilmScreen instance);
    partial void UpdateFilmScreen(FilmScreen instance);
    partial void DeleteFilmScreen(FilmScreen instance);
    #endregion
		
		public MovieScreenDataContext() : 
				base(global::Movieintroductions.Properties.Settings.Default.FilmlerConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MovieScreenDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MovieScreenDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MovieScreenDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MovieScreenDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Films> Films
		{
			get
			{
				return this.GetTable<Films>();
			}
		}
		
		public System.Data.Linq.Table<FilmScreen> FilmScreen
		{
			get
			{
				return this.GetTable<FilmScreen>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Films")]
	public partial class Films : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Film_Id;
		
		private string _Film_Name;
		
		private System.Data.Linq.Binary _Film_Pic;
		
		private string _Explan;
		
		private System.Nullable<System.DateTime> _Vision_Date;
		
		private System.Nullable<decimal> _Imdb;
		
		private System.Nullable<int> _Time;
		
		private EntitySet<FilmScreen> _FilmScreen;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnFilm_IdChanging(int value);
    partial void OnFilm_IdChanged();
    partial void OnFilm_NameChanging(string value);
    partial void OnFilm_NameChanged();
    partial void OnFilm_PicChanging(System.Data.Linq.Binary value);
    partial void OnFilm_PicChanged();
    partial void OnExplanChanging(string value);
    partial void OnExplanChanged();
    partial void OnVision_DateChanging(System.Nullable<System.DateTime> value);
    partial void OnVision_DateChanged();
    partial void OnImdbChanging(System.Nullable<decimal> value);
    partial void OnImdbChanged();
    partial void OnTimeChanging(System.Nullable<int> value);
    partial void OnTimeChanged();
    #endregion
		
		public Films()
		{
			this._FilmScreen = new EntitySet<FilmScreen>(new Action<FilmScreen>(this.attach_FilmScreen), new Action<FilmScreen>(this.detach_FilmScreen));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Film_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Film_Id
		{
			get
			{
				return this._Film_Id;
			}
			set
			{
				if ((this._Film_Id != value))
				{
					this.OnFilm_IdChanging(value);
					this.SendPropertyChanging();
					this._Film_Id = value;
					this.SendPropertyChanged("Film_Id");
					this.OnFilm_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Film_Name", DbType="NVarChar(400)")]
		public string Film_Name
		{
			get
			{
				return this._Film_Name;
			}
			set
			{
				if ((this._Film_Name != value))
				{
					this.OnFilm_NameChanging(value);
					this.SendPropertyChanging();
					this._Film_Name = value;
					this.SendPropertyChanged("Film_Name");
					this.OnFilm_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Film_Pic", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Film_Pic
		{
			get
			{
				return this._Film_Pic;
			}
			set
			{
				if ((this._Film_Pic != value))
				{
					this.OnFilm_PicChanging(value);
					this.SendPropertyChanging();
					this._Film_Pic = value;
					this.SendPropertyChanged("Film_Pic");
					this.OnFilm_PicChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Explan", DbType="NVarChar(MAX)")]
		public string Explan
		{
			get
			{
				return this._Explan;
			}
			set
			{
				if ((this._Explan != value))
				{
					this.OnExplanChanging(value);
					this.SendPropertyChanging();
					this._Explan = value;
					this.SendPropertyChanged("Explan");
					this.OnExplanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vision_Date", DbType="Date")]
		public System.Nullable<System.DateTime> Vision_Date
		{
			get
			{
				return this._Vision_Date;
			}
			set
			{
				if ((this._Vision_Date != value))
				{
					this.OnVision_DateChanging(value);
					this.SendPropertyChanging();
					this._Vision_Date = value;
					this.SendPropertyChanged("Vision_Date");
					this.OnVision_DateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Imdb", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Imdb
		{
			get
			{
				return this._Imdb;
			}
			set
			{
				if ((this._Imdb != value))
				{
					this.OnImdbChanging(value);
					this.SendPropertyChanging();
					this._Imdb = value;
					this.SendPropertyChanged("Imdb");
					this.OnImdbChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Time", DbType="Int")]
		public System.Nullable<int> Time
		{
			get
			{
				return this._Time;
			}
			set
			{
				if ((this._Time != value))
				{
					this.OnTimeChanging(value);
					this.SendPropertyChanging();
					this._Time = value;
					this.SendPropertyChanged("Time");
					this.OnTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Films_FilmScreen", Storage="_FilmScreen", ThisKey="Film_Id", OtherKey="Movie_Id")]
		public EntitySet<FilmScreen> FilmScreen
		{
			get
			{
				return this._FilmScreen;
			}
			set
			{
				this._FilmScreen.Assign(value);
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
		
		private void attach_FilmScreen(FilmScreen entity)
		{
			this.SendPropertyChanging();
			entity.Films = this;
		}
		
		private void detach_FilmScreen(FilmScreen entity)
		{
			this.SendPropertyChanging();
			entity.Films = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.FilmScreen")]
	public partial class FilmScreen : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _FG_Id;
		
		private System.Nullable<int> _Movie_Id;
		
		private System.Data.Linq.Binary _Picture;
		
		private EntityRef<Films> _Films;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnFG_IdChanging(int value);
    partial void OnFG_IdChanged();
    partial void OnMovie_IdChanging(System.Nullable<int> value);
    partial void OnMovie_IdChanged();
    partial void OnPictureChanging(System.Data.Linq.Binary value);
    partial void OnPictureChanged();
    #endregion
		
		public FilmScreen()
		{
			this._Films = default(EntityRef<Films>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FG_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int FG_Id
		{
			get
			{
				return this._FG_Id;
			}
			set
			{
				if ((this._FG_Id != value))
				{
					this.OnFG_IdChanging(value);
					this.SendPropertyChanging();
					this._FG_Id = value;
					this.SendPropertyChanged("FG_Id");
					this.OnFG_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Movie_Id", DbType="Int")]
		public System.Nullable<int> Movie_Id
		{
			get
			{
				return this._Movie_Id;
			}
			set
			{
				if ((this._Movie_Id != value))
				{
					if (this._Films.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMovie_IdChanging(value);
					this.SendPropertyChanging();
					this._Movie_Id = value;
					this.SendPropertyChanged("Movie_Id");
					this.OnMovie_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Picture", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Picture
		{
			get
			{
				return this._Picture;
			}
			set
			{
				if ((this._Picture != value))
				{
					this.OnPictureChanging(value);
					this.SendPropertyChanging();
					this._Picture = value;
					this.SendPropertyChanged("Picture");
					this.OnPictureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Films_FilmScreen", Storage="_Films", ThisKey="Movie_Id", OtherKey="Film_Id", IsForeignKey=true, DeleteRule="CASCADE")]
		public Films Films
		{
			get
			{
				return this._Films.Entity;
			}
			set
			{
				Films previousValue = this._Films.Entity;
				if (((previousValue != value) 
							|| (this._Films.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Films.Entity = null;
						previousValue.FilmScreen.Remove(this);
					}
					this._Films.Entity = value;
					if ((value != null))
					{
						value.FilmScreen.Add(this);
						this._Movie_Id = value.Film_Id;
					}
					else
					{
						this._Movie_Id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Films");
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
