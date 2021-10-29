using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
	public interface IContactService
	{
		List<Contact> GetList();

		List<Contact> GetOrderedList();

		void ContactAdd(Contact contact);

		Contact GetByID(int id);

		void ContactDelete(Contact contact);

		void ContactUpdate(Contact contact);
	}
}
