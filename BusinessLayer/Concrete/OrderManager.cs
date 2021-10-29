using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.Concrete
{
	public class OrderManager : IOrderService
	{
		IOrderDal _orderDal;

		public OrderManager(IOrderDal orderDal)
		{
			_orderDal = orderDal;
		}

		public Order GetByID(int id)
		{
			return _orderDal.Get(x => x.OrderID == id);
		}

		public List<Order> GetList()
		{
			return _orderDal.List();
		}

		public List<Order> GetListWithRelations(int districtID)
		{
			return _orderDal.GetListWithRelations(districtID);
		}

		public Order GetWithRelationsByTrackNumber(string trackNumber)
		{
			return _orderDal.GetWithRelationsByTrackNumber(trackNumber);
		}

		public List<Order> GetOrderedListByDistrictID(int districtID)
		{
			return _orderDal.List(x => x.ReceiverDistrictID == districtID || x.SenderDistrictID == districtID)
				.OrderByDescending(x => x.OrderDate).ToList();
		}

		public Order GetWithStages(int id)
		{
			return _orderDal.GetWithStages(id);
		}

		public void OrderAdd(Order order)
		{
			order.OrderDate = System.DateTime.Now;
			_orderDal.Insert(order);
		}

		public void OrderDelete(Order order)
		{
			_orderDal.Delete(order);
		}

		public void OrderUpdate(Order order)
		{
			_orderDal.Update(order);
		}
	}
}
