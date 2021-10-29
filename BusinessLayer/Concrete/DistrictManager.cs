using BusinessLayer.Abstract;
using BusinessLayer.PasswordHasher;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
	public class DistrictManager : IDistrictService
	{
		IDistrictDal _districtDal;

		public DistrictManager(IDistrictDal districtDal)
		{
			_districtDal = districtDal;
		}

		public void DistrictAdd(District district)
		{
			_districtDal.Insert(district);
		}

		public void DistrictDelete(District district)
		{
			_districtDal.Delete(district);
		}

		public void DistrictUpdate(District district)
		{
			_districtDal.Update(district);
		}

		public District GetByID(int id)
		{
			return _districtDal.Get(x => x.DistrictID == id);
		}

		public District GetByLoginName(string loginName)
		{
			return _districtDal.Get(x => x.LoginName == loginName);
		}

		public District GetByLoginNamePassword(string loginName, string password)
		{
			password = SHA512Hasher.Hash(password);
			return _districtDal.Get(x => x.LoginName == loginName && x.Password == password);
		}


		public List<District> GetList()
		{
			return _districtDal.List();
		}

		public List<District> GetByCityID(int cityId)
		{
			return _districtDal.List(x => x.CityID == cityId);

		}
	}
}
