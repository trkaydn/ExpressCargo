using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccessLayer.Abstract
{
	public interface IRepository<T> where T : class
	{
		List<T> List();

		void Insert(T p);

		void Update(T p);

		T Get(Expression<Func<T, bool>> filter);

		void Delete(T p);

		List<T> List(Expression<Func<T, bool>> filter);
	}
}
