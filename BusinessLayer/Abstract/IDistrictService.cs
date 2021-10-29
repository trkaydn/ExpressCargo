using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
	public interface IDistrictService
	{
		List<District> GetList();
		void DistrictAdd(District district);

		District GetByID(int id);
		List<District> GetByCityID(int cityId);

		District GetByLoginName(string loginName);

		District GetByLoginNamePassword(string loginName,string password);

		void DistrictDelete(District district);

		void DistrictUpdate(District district);
	}
}
