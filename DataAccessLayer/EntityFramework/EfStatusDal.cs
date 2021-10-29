using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.EntityFramework
{
	public class EfStatusDal : GenericRepository<Status>, IStatusDal
	{
		public List<Status> GetListGreaterThanDistrictStatus(int statusID)
		{
			using (Context context = new Context())
			{
				return context.Status.Where(x => x.StatusID >= statusID).ToList();
			}
		}
	}
}
