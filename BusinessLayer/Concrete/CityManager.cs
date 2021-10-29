using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
	public class CityManager : ICityService
	{
		ICityDal _cityDal;

		public CityManager(ICityDal cityDal)
		{
			_cityDal = cityDal;
		}

		public void CityAdd(City city)
		{
			_cityDal.Insert(city);
		}

		public void CityDelete(City city)
		{
			_cityDal.Delete(city);
		}

		public void CityUpdate(City city)
		{
			_cityDal.Update(city);
		}

		public City GetByID(int id)
		{
			return _cityDal.Get(x => x.CityID == id);
		}

		public List<City> GetList()
		{
			return _cityDal.List();
		}
	}
}
