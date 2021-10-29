using EntityLayer.Concrete;
using System.Collections.Generic;


namespace BusinessLayer.Abstract
{
	public interface IOrderService
	{
		List<Order> GetList();

		List<Order> GetOrderedListByDistrictID(int districtID);

		public List<Order> GetListWithRelations(int districtID);
		public Order GetWithRelationsByTrackNumber(string trackNumber);

		void OrderAdd(Order order);

		Order GetByID(int id);

		Order GetWithStages(int id);

		void OrderDelete(Order order);

		void OrderUpdate(Order order);
	}
}
