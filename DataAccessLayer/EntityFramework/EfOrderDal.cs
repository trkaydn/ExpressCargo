using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.EntityFramework
{
	public class EfOrderDal : GenericRepository<Order>, IOrderDal
	{
		public Order GetWithStages(int id)
		{
			using (Context context = new Context())
			{
				return context.Order
					.Include(x => x.Stages)
					.Include(x => x.Status)
					.Include(x => x.Size)
					.FirstOrDefault(x => x.OrderID == id);
			}
		}

		public List<Order> GetListWithRelations(int districtID)
		{
			using (Context contaxt = new Context())
			{
				return contaxt.Order
					.Where(x => x.SenderDistrictID == districtID || x.ReceiverDistrictID == districtID)
					.Include(x => x.Size)
					.Include(x => x.ReceiverDistrict.City)
					.Include(x => x.Status)
					.Include(x => x.Stages)
					.OrderByDescending(x => x.OrderDate).ToList();
			}
		}

		public Order GetWithRelationsByTrackNumber(string trackNumber)
		{
			using (Context contaxt = new Context())
			{
				return contaxt.Order
					.Include(x => x.Size)
					.Include(x => x.ReceiverDistrict.City)
					.Include(x => x.SenderDistrict.City)
					.Include(x => x.Status)
					.Include(x => x.Stages).ThenInclude(x => x.Status)
					.FirstOrDefault(x => x.TrackNumber == trackNumber);
			}
		}
	}
}
