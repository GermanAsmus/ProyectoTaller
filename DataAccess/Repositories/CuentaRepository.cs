using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccess.Repositories
{
	public class CuentaRepository : GenRepository<Cuenta>, ICuentaRepository
	{
		public CuentaRepository(EntityContext context): base (context){}
		public EntityContext EntityContext
		{ 
			get 
			{
				return aContext as EntityContext;
			}
		}
	}
}