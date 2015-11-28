using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Data.Entity;

namespace DataAccesLayer
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly EntityContext aEntityContex;
		
		public ICuentaRepository Cuentas {get; set;}
		public IMensajeRepository Mensajes {get; set;}
		public IServicioRepository Servicios {get; set;}
		
		public UnitOfWork(EntityContext pEntityContext)
		{
			this.aEntityContex=pEntityContext;
			this.Cuentas = new CuentaRepository(this.aEntityContex);
			this.Mensajes = new MensajeRepositoty(this.aEntityContex);
			this.Servicios = new ServicioRepository(this.aEntityContex);
		}
		public int Commit()
		{
			return aEntityContex.SaveChanges();
		}
	}
}