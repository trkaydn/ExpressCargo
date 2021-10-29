using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
	public interface IExceptionLogService
	{
		List<ExceptionLog> GetList();

		void ExceptionLogAdd(ExceptionLog exception);

		ExceptionLog GetByID(int id);

		void ExceptionLogDelete(ExceptionLog exceptionLog);

		void ExceptionLogUpdate(ExceptionLog exceptionLog);
	}
}
