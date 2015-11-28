using System;

namespace Core
{
	public interface IUnitOfWork : IDisposable
	{
		public void Commit();
		public void Dispose();
	}
}