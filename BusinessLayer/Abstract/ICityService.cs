using EntityLayer.Concrete;
using System.Collections.Generic;


namespace BusinessLayer.Abstract
{
	public interface ICityService
	{
		List<City> GetList();

		void CityAdd(City city);

		City GetByID(int id);

		void CityDelete(City city);

		void CityUpdate(City city);
	}
}
