using System;

namespace ExpressCargo.Models
{
	public class AdminCommentVM
	{
		public int CommentID { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string CommentContent { get; set; }

		public DateTime CommentDate { get; set; }
		public bool IsActive { get; set; }
	}
}
