using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccess.Repositories
{
	public class ServicioRepository : GenRepository<Servicio>, ICuentaRepository
	{
		public ServicioRepository(EntityContext context): base (context){}
		public EntityContext EntityContext
		{ 
			get 
			{
				return aContext as EntityContext;
			}
		}
	}
}