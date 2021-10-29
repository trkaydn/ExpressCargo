using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
	public interface ISizeService
	{
		List<Size> GetList();

		void SizeAdd(Size size);

		Size GetByID(int id);

		void SizeDelete(Size size);

		void SizeUpdate(Size size);
	}
}
