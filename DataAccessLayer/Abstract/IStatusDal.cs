using EntityLayer.Concrete;
using System.Collections.Generic;

namespace DataAccessLayer.Abstract
{
	public interface IStatusDal : IRepository<Status>
	{
		List<Status> GetListGreaterThanDistrictStatus(int statusID);
	}
}
