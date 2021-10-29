using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.Concrete
{
	public class StageManager : IStageService
	{
		IStageDal _stageDal;

		public StageManager(IStageDal stageDal)
		{
			_stageDal = stageDal;
		}

		public Stage GetByID(int id)
		{
			return _stageDal.Get(x => x.StageID == id);
		}

		public List<Stage> GetList()
		{
			return _stageDal.List();
		}

		public List<Stage> GetOrderedList()
		{
			return _stageDal.List().OrderByDescending(x => x.StatusDate).ToList();
		}

		public void StageAdd(Stage stage)
		{
			stage.StatusDate = System.DateTime.Now;
			_stageDal.Insert(stage);
		}

		public void StageDelete(Stage stage)
		{
			_stageDal.Delete(stage);
		}

		public void StageUpdate(Stage stage)
		{
			_stageDal.Update(stage);
		}
	}
}
