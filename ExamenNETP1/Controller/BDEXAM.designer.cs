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

namespace ExamenNETP1.Controller
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="examenNET")]
	public partial class BDEXAMDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSexo(Sexo instance);
    partial void UpdateSexo(Sexo instance);
    partial void DeleteSexo(Sexo instance);
    partial void InsertUsuario(Usuario instance);
    partial void UpdateUsuario(Usuario instance);
    partial void DeleteUsuario(Usuario instance);
    partial void InsertTipo_usuario(Tipo_usuario instance);
    partial void UpdateTipo_usuario(Tipo_usuario instance);
    partial void DeleteTipo_usuario(Tipo_usuario instance);
    partial void InsertDenuncia(Denuncia instance);
    partial void UpdateDenuncia(Denuncia instance);
    partial void DeleteDenuncia(Denuncia instance);
    partial void InsertEstado_Denuncia(Estado_Denuncia instance);
    partial void UpdateEstado_Denuncia(Estado_Denuncia instance);
    partial void DeleteEstado_Denuncia(Estado_Denuncia instance);
    partial void InsertComuna(Comuna instance);
    partial void UpdateComuna(Comuna instance);
    partial void DeleteComuna(Comuna instance);
    #endregion
		
		public BDEXAMDataContext() : 
				base(global::ExamenNETP1.Properties.Settings.Default.examenNETConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BDEXAMDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BDEXAMDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BDEXAMDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BDEXAMDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Sexo> Sexos
		{
			get
			{
				return this.GetTable<Sexo>();
			}
		}
		
		public System.Data.Linq.Table<Usuario> Usuarios
		{
			get
			{
				return this.GetTable<Usuario>();
			}
		}
		
		public System.Data.Linq.Table<Tipo_usuario> Tipo_usuarios
		{
			get
			{
				return this.GetTable<Tipo_usuario>();
			}
		}
		
		public System.Data.Linq.Table<Denuncia> Denuncias
		{
			get
			{
				return this.GetTable<Denuncia>();
			}
		}
		
		public System.Data.Linq.Table<Estado_Denuncia> Estado_Denuncias
		{
			get
			{
				return this.GetTable<Estado_Denuncia>();
			}
		}
		
		public System.Data.Linq.Table<Comuna> Comunas
		{
			get
			{
				return this.GetTable<Comuna>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Sexo")]
	public partial class Sexo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_sexo;
		
		private string _nombre_sexo;
		
		private EntitySet<Usuario> _Usuarios;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_sexoChanging(int value);
    partial void Onid_sexoChanged();
    partial void Onnombre_sexoChanging(string value);
    partial void Onnombre_sexoChanged();
    #endregion
		
		public Sexo()
		{
			this._Usuarios = new EntitySet<Usuario>(new Action<Usuario>(this.attach_Usuarios), new Action<Usuario>(this.detach_Usuarios));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_sexo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_sexo
		{
			get
			{
				return this._id_sexo;
			}
			set
			{
				if ((this._id_sexo != value))
				{
					this.Onid_sexoChanging(value);
					this.SendPropertyChanging();
					this._id_sexo = value;
					this.SendPropertyChanged("id_sexo");
					this.Onid_sexoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre_sexo", DbType="VarChar(100)")]
		public string nombre_sexo
		{
			get
			{
				return this._nombre_sexo;
			}
			set
			{
				if ((this._nombre_sexo != value))
				{
					this.Onnombre_sexoChanging(value);
					this.SendPropertyChanging();
					this._nombre_sexo = value;
					this.SendPropertyChanged("nombre_sexo");
					this.Onnombre_sexoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sexo_Usuario", Storage="_Usuarios", ThisKey="id_sexo", OtherKey="id_sexo")]
		public EntitySet<Usuario> Usuarios
		{
			get
			{
				return this._Usuarios;
			}
			set
			{
				this._Usuarios.Assign(value);
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
		
		private void attach_Usuarios(Usuario entity)
		{
			this.SendPropertyChanging();
			entity.Sexo = this;
		}
		
		private void detach_Usuarios(Usuario entity)
		{
			this.SendPropertyChanging();
			entity.Sexo = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Usuario")]
	public partial class Usuario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _correo_usuario;
		
		private System.Nullable<int> _id_sexo;
		
		private System.Nullable<int> _id_tipo_usuario;
		
		private string _nombres;
		
		private string _ap_paterno;
		
		private string _ap_materno;
		
		private string _clave;
		
		private System.Nullable<System.DateTime> _fecha_nacimiento;
		
		private EntitySet<Denuncia> _Denuncias;
		
		private EntityRef<Sexo> _Sexo;
		
		private EntityRef<Tipo_usuario> _Tipo_usuario;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Oncorreo_usuarioChanging(string value);
    partial void Oncorreo_usuarioChanged();
    partial void Onid_sexoChanging(System.Nullable<int> value);
    partial void Onid_sexoChanged();
    partial void Onid_tipo_usuarioChanging(System.Nullable<int> value);
    partial void Onid_tipo_usuarioChanged();
    partial void OnnombresChanging(string value);
    partial void OnnombresChanged();
    partial void Onap_paternoChanging(string value);
    partial void Onap_paternoChanged();
    partial void Onap_maternoChanging(string value);
    partial void Onap_maternoChanged();
    partial void OnclaveChanging(string value);
    partial void OnclaveChanged();
    partial void Onfecha_nacimientoChanging(System.Nullable<System.DateTime> value);
    partial void Onfecha_nacimientoChanged();
    #endregion
		
		public Usuario()
		{
			this._Denuncias = new EntitySet<Denuncia>(new Action<Denuncia>(this.attach_Denuncias), new Action<Denuncia>(this.detach_Denuncias));
			this._Sexo = default(EntityRef<Sexo>);
			this._Tipo_usuario = default(EntityRef<Tipo_usuario>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_correo_usuario", DbType="VarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string correo_usuario
		{
			get
			{
				return this._correo_usuario;
			}
			set
			{
				if ((this._correo_usuario != value))
				{
					this.Oncorreo_usuarioChanging(value);
					this.SendPropertyChanging();
					this._correo_usuario = value;
					this.SendPropertyChanged("correo_usuario");
					this.Oncorreo_usuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_sexo", DbType="Int")]
		public System.Nullable<int> id_sexo
		{
			get
			{
				return this._id_sexo;
			}
			set
			{
				if ((this._id_sexo != value))
				{
					if (this._Sexo.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_sexoChanging(value);
					this.SendPropertyChanging();
					this._id_sexo = value;
					this.SendPropertyChanged("id_sexo");
					this.Onid_sexoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_tipo_usuario", DbType="Int")]
		public System.Nullable<int> id_tipo_usuario
		{
			get
			{
				return this._id_tipo_usuario;
			}
			set
			{
				if ((this._id_tipo_usuario != value))
				{
					if (this._Tipo_usuario.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_tipo_usuarioChanging(value);
					this.SendPropertyChanging();
					this._id_tipo_usuario = value;
					this.SendPropertyChanged("id_tipo_usuario");
					this.Onid_tipo_usuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombres", DbType="VarChar(100)")]
		public string nombres
		{
			get
			{
				return this._nombres;
			}
			set
			{
				if ((this._nombres != value))
				{
					this.OnnombresChanging(value);
					this.SendPropertyChanging();
					this._nombres = value;
					this.SendPropertyChanged("nombres");
					this.OnnombresChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ap_paterno", DbType="VarChar(100)")]
		public string ap_paterno
		{
			get
			{
				return this._ap_paterno;
			}
			set
			{
				if ((this._ap_paterno != value))
				{
					this.Onap_paternoChanging(value);
					this.SendPropertyChanging();
					this._ap_paterno = value;
					this.SendPropertyChanged("ap_paterno");
					this.Onap_paternoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ap_materno", DbType="VarChar(100)")]
		public string ap_materno
		{
			get
			{
				return this._ap_materno;
			}
			set
			{
				if ((this._ap_materno != value))
				{
					this.Onap_maternoChanging(value);
					this.SendPropertyChanging();
					this._ap_materno = value;
					this.SendPropertyChanged("ap_materno");
					this.Onap_maternoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_clave", DbType="VarChar(32)")]
		public string clave
		{
			get
			{
				return this._clave;
			}
			set
			{
				if ((this._clave != value))
				{
					this.OnclaveChanging(value);
					this.SendPropertyChanging();
					this._clave = value;
					this.SendPropertyChanged("clave");
					this.OnclaveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fecha_nacimiento", DbType="Date")]
		public System.Nullable<System.DateTime> fecha_nacimiento
		{
			get
			{
				return this._fecha_nacimiento;
			}
			set
			{
				if ((this._fecha_nacimiento != value))
				{
					this.Onfecha_nacimientoChanging(value);
					this.SendPropertyChanging();
					this._fecha_nacimiento = value;
					this.SendPropertyChanged("fecha_nacimiento");
					this.Onfecha_nacimientoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_Denuncia", Storage="_Denuncias", ThisKey="correo_usuario", OtherKey="correo_usuario")]
		public EntitySet<Denuncia> Denuncias
		{
			get
			{
				return this._Denuncias;
			}
			set
			{
				this._Denuncias.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sexo_Usuario", Storage="_Sexo", ThisKey="id_sexo", OtherKey="id_sexo", IsForeignKey=true)]
		public Sexo Sexo
		{
			get
			{
				return this._Sexo.Entity;
			}
			set
			{
				Sexo previousValue = this._Sexo.Entity;
				if (((previousValue != value) 
							|| (this._Sexo.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Sexo.Entity = null;
						previousValue.Usuarios.Remove(this);
					}
					this._Sexo.Entity = value;
					if ((value != null))
					{
						value.Usuarios.Add(this);
						this._id_sexo = value.id_sexo;
					}
					else
					{
						this._id_sexo = default(Nullable<int>);
					}
					this.SendPropertyChanged("Sexo");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tipo_usuario_Usuario", Storage="_Tipo_usuario", ThisKey="id_tipo_usuario", OtherKey="id_tipo_usuario", IsForeignKey=true)]
		public Tipo_usuario Tipo_usuario
		{
			get
			{
				return this._Tipo_usuario.Entity;
			}
			set
			{
				Tipo_usuario previousValue = this._Tipo_usuario.Entity;
				if (((previousValue != value) 
							|| (this._Tipo_usuario.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Tipo_usuario.Entity = null;
						previousValue.Usuarios.Remove(this);
					}
					this._Tipo_usuario.Entity = value;
					if ((value != null))
					{
						value.Usuarios.Add(this);
						this._id_tipo_usuario = value.id_tipo_usuario;
					}
					else
					{
						this._id_tipo_usuario = default(Nullable<int>);
					}
					this.SendPropertyChanged("Tipo_usuario");
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
		
		private void attach_Denuncias(Denuncia entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = this;
		}
		
		private void detach_Denuncias(Denuncia entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tipo_usuario")]
	public partial class Tipo_usuario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_tipo_usuario;
		
		private string _nombre_tipo_usuario;
		
		private EntitySet<Usuario> _Usuarios;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_tipo_usuarioChanging(int value);
    partial void Onid_tipo_usuarioChanged();
    partial void Onnombre_tipo_usuarioChanging(string value);
    partial void Onnombre_tipo_usuarioChanged();
    #endregion
		
		public Tipo_usuario()
		{
			this._Usuarios = new EntitySet<Usuario>(new Action<Usuario>(this.attach_Usuarios), new Action<Usuario>(this.detach_Usuarios));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_tipo_usuario", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_tipo_usuario
		{
			get
			{
				return this._id_tipo_usuario;
			}
			set
			{
				if ((this._id_tipo_usuario != value))
				{
					this.Onid_tipo_usuarioChanging(value);
					this.SendPropertyChanging();
					this._id_tipo_usuario = value;
					this.SendPropertyChanged("id_tipo_usuario");
					this.Onid_tipo_usuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre_tipo_usuario", DbType="VarChar(150)")]
		public string nombre_tipo_usuario
		{
			get
			{
				return this._nombre_tipo_usuario;
			}
			set
			{
				if ((this._nombre_tipo_usuario != value))
				{
					this.Onnombre_tipo_usuarioChanging(value);
					this.SendPropertyChanging();
					this._nombre_tipo_usuario = value;
					this.SendPropertyChanged("nombre_tipo_usuario");
					this.Onnombre_tipo_usuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tipo_usuario_Usuario", Storage="_Usuarios", ThisKey="id_tipo_usuario", OtherKey="id_tipo_usuario")]
		public EntitySet<Usuario> Usuarios
		{
			get
			{
				return this._Usuarios;
			}
			set
			{
				this._Usuarios.Assign(value);
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
		
		private void attach_Usuarios(Usuario entity)
		{
			this.SendPropertyChanging();
			entity.Tipo_usuario = this;
		}
		
		private void detach_Usuarios(Usuario entity)
		{
			this.SendPropertyChanging();
			entity.Tipo_usuario = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Denuncia")]
	public partial class Denuncia : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_denuncia;
		
		private string _correo_usuario;
		
		private System.Nullable<int> _id_comuna;
		
		private System.Nullable<int> _id_estado;
		
		private System.Nullable<System.DateTime> _fecha_ingreso;
		
		private string _descripcion_caso;
		
		private System.Nullable<System.DateTime> _fecha_cierre;
		
		private EntityRef<Usuario> _Usuario;
		
		private EntityRef<Estado_Denuncia> _Estado_Denuncia;
		
		private EntityRef<Comuna> _Comuna;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_denunciaChanging(int value);
    partial void Onid_denunciaChanged();
    partial void Oncorreo_usuarioChanging(string value);
    partial void Oncorreo_usuarioChanged();
    partial void Onid_comunaChanging(System.Nullable<int> value);
    partial void Onid_comunaChanged();
    partial void Onid_estadoChanging(System.Nullable<int> value);
    partial void Onid_estadoChanged();
    partial void Onfecha_ingresoChanging(System.Nullable<System.DateTime> value);
    partial void Onfecha_ingresoChanged();
    partial void Ondescripcion_casoChanging(string value);
    partial void Ondescripcion_casoChanged();
    partial void Onfecha_cierreChanging(System.Nullable<System.DateTime> value);
    partial void Onfecha_cierreChanged();
    #endregion
		
		public Denuncia()
		{
			this._Usuario = default(EntityRef<Usuario>);
			this._Estado_Denuncia = default(EntityRef<Estado_Denuncia>);
			this._Comuna = default(EntityRef<Comuna>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_denuncia", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_denuncia
		{
			get
			{
				return this._id_denuncia;
			}
			set
			{
				if ((this._id_denuncia != value))
				{
					this.Onid_denunciaChanging(value);
					this.SendPropertyChanging();
					this._id_denuncia = value;
					this.SendPropertyChanged("id_denuncia");
					this.Onid_denunciaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_correo_usuario", DbType="VarChar(100)")]
		public string correo_usuario
		{
			get
			{
				return this._correo_usuario;
			}
			set
			{
				if ((this._correo_usuario != value))
				{
					if (this._Usuario.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Oncorreo_usuarioChanging(value);
					this.SendPropertyChanging();
					this._correo_usuario = value;
					this.SendPropertyChanged("correo_usuario");
					this.Oncorreo_usuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_comuna", DbType="Int")]
		public System.Nullable<int> id_comuna
		{
			get
			{
				return this._id_comuna;
			}
			set
			{
				if ((this._id_comuna != value))
				{
					if (this._Comuna.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_comunaChanging(value);
					this.SendPropertyChanging();
					this._id_comuna = value;
					this.SendPropertyChanged("id_comuna");
					this.Onid_comunaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_estado", DbType="Int")]
		public System.Nullable<int> id_estado
		{
			get
			{
				return this._id_estado;
			}
			set
			{
				if ((this._id_estado != value))
				{
					if (this._Estado_Denuncia.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_estadoChanging(value);
					this.SendPropertyChanging();
					this._id_estado = value;
					this.SendPropertyChanged("id_estado");
					this.Onid_estadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fecha_ingreso", DbType="DateTime")]
		public System.Nullable<System.DateTime> fecha_ingreso
		{
			get
			{
				return this._fecha_ingreso;
			}
			set
			{
				if ((this._fecha_ingreso != value))
				{
					this.Onfecha_ingresoChanging(value);
					this.SendPropertyChanging();
					this._fecha_ingreso = value;
					this.SendPropertyChanged("fecha_ingreso");
					this.Onfecha_ingresoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_descripcion_caso", DbType="VarChar(500)")]
		public string descripcion_caso
		{
			get
			{
				return this._descripcion_caso;
			}
			set
			{
				if ((this._descripcion_caso != value))
				{
					this.Ondescripcion_casoChanging(value);
					this.SendPropertyChanging();
					this._descripcion_caso = value;
					this.SendPropertyChanged("descripcion_caso");
					this.Ondescripcion_casoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fecha_cierre", DbType="DateTime")]
		public System.Nullable<System.DateTime> fecha_cierre
		{
			get
			{
				return this._fecha_cierre;
			}
			set
			{
				if ((this._fecha_cierre != value))
				{
					this.Onfecha_cierreChanging(value);
					this.SendPropertyChanging();
					this._fecha_cierre = value;
					this.SendPropertyChanged("fecha_cierre");
					this.Onfecha_cierreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_Denuncia", Storage="_Usuario", ThisKey="correo_usuario", OtherKey="correo_usuario", IsForeignKey=true)]
		public Usuario Usuario
		{
			get
			{
				return this._Usuario.Entity;
			}
			set
			{
				Usuario previousValue = this._Usuario.Entity;
				if (((previousValue != value) 
							|| (this._Usuario.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Usuario.Entity = null;
						previousValue.Denuncias.Remove(this);
					}
					this._Usuario.Entity = value;
					if ((value != null))
					{
						value.Denuncias.Add(this);
						this._correo_usuario = value.correo_usuario;
					}
					else
					{
						this._correo_usuario = default(string);
					}
					this.SendPropertyChanged("Usuario");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Estado_Denuncia_Denuncia", Storage="_Estado_Denuncia", ThisKey="id_estado", OtherKey="id_estado", IsForeignKey=true)]
		public Estado_Denuncia Estado_Denuncia
		{
			get
			{
				return this._Estado_Denuncia.Entity;
			}
			set
			{
				Estado_Denuncia previousValue = this._Estado_Denuncia.Entity;
				if (((previousValue != value) 
							|| (this._Estado_Denuncia.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Estado_Denuncia.Entity = null;
						previousValue.Denuncias.Remove(this);
					}
					this._Estado_Denuncia.Entity = value;
					if ((value != null))
					{
						value.Denuncias.Add(this);
						this._id_estado = value.id_estado;
					}
					else
					{
						this._id_estado = default(Nullable<int>);
					}
					this.SendPropertyChanged("Estado_Denuncia");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Comuna_Denuncia", Storage="_Comuna", ThisKey="id_comuna", OtherKey="id_comuna", IsForeignKey=true)]
		public Comuna Comuna
		{
			get
			{
				return this._Comuna.Entity;
			}
			set
			{
				Comuna previousValue = this._Comuna.Entity;
				if (((previousValue != value) 
							|| (this._Comuna.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Comuna.Entity = null;
						previousValue.Denuncias.Remove(this);
					}
					this._Comuna.Entity = value;
					if ((value != null))
					{
						value.Denuncias.Add(this);
						this._id_comuna = value.id_comuna;
					}
					else
					{
						this._id_comuna = default(Nullable<int>);
					}
					this.SendPropertyChanged("Comuna");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Estado_Denuncia")]
	public partial class Estado_Denuncia : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_estado;
		
		private string _nombre_estado;
		
		private EntitySet<Denuncia> _Denuncias;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_estadoChanging(int value);
    partial void Onid_estadoChanged();
    partial void Onnombre_estadoChanging(string value);
    partial void Onnombre_estadoChanged();
    #endregion
		
		public Estado_Denuncia()
		{
			this._Denuncias = new EntitySet<Denuncia>(new Action<Denuncia>(this.attach_Denuncias), new Action<Denuncia>(this.detach_Denuncias));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_estado", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_estado
		{
			get
			{
				return this._id_estado;
			}
			set
			{
				if ((this._id_estado != value))
				{
					this.Onid_estadoChanging(value);
					this.SendPropertyChanging();
					this._id_estado = value;
					this.SendPropertyChanged("id_estado");
					this.Onid_estadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre_estado", DbType="VarChar(100)")]
		public string nombre_estado
		{
			get
			{
				return this._nombre_estado;
			}
			set
			{
				if ((this._nombre_estado != value))
				{
					this.Onnombre_estadoChanging(value);
					this.SendPropertyChanging();
					this._nombre_estado = value;
					this.SendPropertyChanged("nombre_estado");
					this.Onnombre_estadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Estado_Denuncia_Denuncia", Storage="_Denuncias", ThisKey="id_estado", OtherKey="id_estado")]
		public EntitySet<Denuncia> Denuncias
		{
			get
			{
				return this._Denuncias;
			}
			set
			{
				this._Denuncias.Assign(value);
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
		
		private void attach_Denuncias(Denuncia entity)
		{
			this.SendPropertyChanging();
			entity.Estado_Denuncia = this;
		}
		
		private void detach_Denuncias(Denuncia entity)
		{
			this.SendPropertyChanging();
			entity.Estado_Denuncia = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Comuna")]
	public partial class Comuna : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_comuna;
		
		private string _nombre_comuna;
		
		private EntitySet<Denuncia> _Denuncias;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_comunaChanging(int value);
    partial void Onid_comunaChanged();
    partial void Onnombre_comunaChanging(string value);
    partial void Onnombre_comunaChanged();
    #endregion
		
		public Comuna()
		{
			this._Denuncias = new EntitySet<Denuncia>(new Action<Denuncia>(this.attach_Denuncias), new Action<Denuncia>(this.detach_Denuncias));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_comuna", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_comuna
		{
			get
			{
				return this._id_comuna;
			}
			set
			{
				if ((this._id_comuna != value))
				{
					this.Onid_comunaChanging(value);
					this.SendPropertyChanging();
					this._id_comuna = value;
					this.SendPropertyChanged("id_comuna");
					this.Onid_comunaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre_comuna", DbType="VarChar(150)")]
		public string nombre_comuna
		{
			get
			{
				return this._nombre_comuna;
			}
			set
			{
				if ((this._nombre_comuna != value))
				{
					this.Onnombre_comunaChanging(value);
					this.SendPropertyChanging();
					this._nombre_comuna = value;
					this.SendPropertyChanged("nombre_comuna");
					this.Onnombre_comunaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Comuna_Denuncia", Storage="_Denuncias", ThisKey="id_comuna", OtherKey="id_comuna")]
		public EntitySet<Denuncia> Denuncias
		{
			get
			{
				return this._Denuncias;
			}
			set
			{
				this._Denuncias.Assign(value);
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
		
		private void attach_Denuncias(Denuncia entity)
		{
			this.SendPropertyChanging();
			entity.Comuna = this;
		}
		
		private void detach_Denuncias(Denuncia entity)
		{
			this.SendPropertyChanging();
			entity.Comuna = null;
		}
	}
}
#pragma warning restore 1591
