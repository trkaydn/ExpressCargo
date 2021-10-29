using EntityLayer.Concrete;
using System.Collections.Generic;


namespace BusinessLayer.Abstract
{
	public interface IStatusService
	{
		List<Status> GetList();
		List<Status> GetListGreaterThanDistrictStatus(int statusID);

		void StatusAdd(Status status);

		Status GetByID(int id);

		void StatusDelete(Status status);

		void StatusUpdate(Status status);
	}
}
