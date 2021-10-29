using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
	public class ExceptionLogManager : IExceptionLogService
	{
		IExceptionLogDal _exceptionLogDal;

		public ExceptionLogManager(IExceptionLogDal exceptionLogDal)
		{
			_exceptionLogDal = exceptionLogDal;
		}

		public void ExceptionLogAdd(ExceptionLog exception)
		{
			_exceptionLogDal.Insert(exception);
		}

		public void ExceptionLogDelete(ExceptionLog exceptionLog)
		{
			_exceptionLogDal.Delete(exceptionLog);
		}

		public void ExceptionLogUpdate(ExceptionLog exceptionLog)
		{
			_exceptionLogDal.Update(exceptionLog);
		}

		public ExceptionLog GetByID(int id)
		{
			return _exceptionLogDal.Get(x => x.ErrorID == id);
		}

		public List<ExceptionLog> GetList()
		{
			return _exceptionLogDal.List();
		}
	}
}
