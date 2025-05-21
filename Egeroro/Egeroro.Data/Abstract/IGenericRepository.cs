using System;
namespace Egeroro.Data.Abstract
{
	public interface IGenericRepository<T>
	{
		void Insert(T entity);
		void Update(T entity);
		void Delete(T entity);
		List<T> GetList();
		T GetById(int id);

	}
}

