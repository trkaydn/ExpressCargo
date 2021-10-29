using EntityLayer.Concrete;
using System.Collections.Generic;

namespace DataAccessLayer.Abstract
{
	public interface IOrderDal : IRepository<Order>
	{
		List<Order> GetListWithRelations(int districtID);
		Order GetWithRelationsByTrackNumber(string trackNumber);
		Order GetWithStages(int id);
	}
}
