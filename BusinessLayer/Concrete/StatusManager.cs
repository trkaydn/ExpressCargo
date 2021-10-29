using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
	public class StatusManager : IStatusService
	{
		IStatusDal _statusDal;

		public StatusManager(IStatusDal statusDal)
		{
			_statusDal = statusDal;
		}

		public Status GetByID(int id)
		{
			return _statusDal.Get(x => x.StatusID == id);
		}

		public List<Status> GetList()
		{
			return _statusDal.List();
		}

		public List<Status> GetListGreaterThanDistrictStatus(int statusID)
		{
			return _statusDal.GetListGreaterThanDistrictStatus(statusID);
		}

		public void StatusAdd(Status status)
		{
			_statusDal.Insert(status);
		}

		public void StatusDelete(Status status)
		{
			_statusDal.Delete(status);
		}

		public void StatusUpdate(Status status)
		{
			_statusDal.Update(status);
		}
	}
}
