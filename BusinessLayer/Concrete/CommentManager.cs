using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.Concrete
{
	public class CommentManager : ICommentService
	{
		ICommentDal _commentDal;

		public CommentManager(ICommentDal commentDal)
		{
			_commentDal = commentDal;
		}

		public void CommentAdd(Comment comment)
		{
			comment.CommentDate = System.DateTime.Now;
			_commentDal.Insert(comment);
		}

		public void CommentDelete(Comment comment)
		{
			_commentDal.Delete(comment);
		}

		public void CommentUpdate(Comment comment)
		{
			_commentDal.Update(comment);
		}

		public Comment GetByID(int id)
		{
			return _commentDal.Get(x => x.CommentID == id);
		}

		public List<Comment> GetLast4ActiveComments()
		{
			return _commentDal.List()
				.Where(x => x.IsActive).OrderByDescending(x => x.CommentDate).ToList();
		}

		public List<Comment> GetList()
		{
			return _commentDal.List();
		}

		public List<Comment> GetOrderedList()
		{
			return _commentDal.List()
				.OrderByDescending(x => x.CommentDate).ToList();
		}
	}
}
