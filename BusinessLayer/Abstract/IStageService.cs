using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
	public interface IStageService
	{
		List<Stage> GetList();

		List<Stage> GetOrderedList();

		void StageAdd(Stage stage);

		Stage GetByID(int id);

		void StageDelete(Stage stage);

		void StageUpdate(Stage stage);
	}
}
