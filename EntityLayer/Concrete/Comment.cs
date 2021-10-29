using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class Comment
	{
		[Key]
		public int CommentID { get; set; }

		[StringLength(50)]
		public string FirstName { get; set; }

		[StringLength(50)]
		public string LastName { get; set; }

		public string CommentContent { get; set; }

		public DateTime CommentDate { get; set; }
		public bool IsActive { get; set; } = false;
	}
}
