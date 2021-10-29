using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
	public class SizeManager : ISizeService
	{
		ISizeDal _sizeDal;

		public SizeManager(ISizeDal sizeDal)
		{
			_sizeDal = sizeDal;
		}

		public Size GetByID(int id)
		{
			return _sizeDal.Get(x => x.SizeID == id);
		}

		public List<Size> GetList()
		{
			return _sizeDal.List();
		}

		public void SizeAdd(Size size)
		{
			_sizeDal.Insert(size);
		}

		public void SizeDelete(Size size)
		{
			_sizeDal.Delete(size);
		}

		public void SizeUpdate(Size size)
		{
			_sizeDal.Update(size);
		}
	}
}
