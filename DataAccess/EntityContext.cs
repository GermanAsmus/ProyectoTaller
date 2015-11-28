using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace DataAccessLayer
{
	public class EntityContext : DbContext
	{
		public EntityContext():base("name=EntityContext")
		{
			this.Configuration.LazyLoadingEnabled = false;
		}
		public virtual DbSet<Cuenta> Cuentas {get; set;}
		public virtual DbSet<Mensaje> Mensajes {get; set;}
		public virtual DbSet<Servicio> Servicios {get; set;}
	}
}