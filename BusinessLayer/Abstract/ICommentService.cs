using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
	public interface ICommentService
	{
		List<Comment> GetList();
		List<Comment> GetOrderedList();
		List<Comment> GetLast4ActiveComments();

		void CommentAdd(Comment comment);

		Comment GetByID(int id);

		void CommentDelete(Comment comment);

		void CommentUpdate(Comment comment);
	}
}
