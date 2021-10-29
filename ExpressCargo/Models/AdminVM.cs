using System.Collections.Generic;

namespace ExpressCargo.Models
{
	public class AdminVM
	{
		public List<AdminContactVM> LastContacts { get; set; } = new();
		public List<AdminCommentVM> LastComments { get; set; } = new();
		public int Waiting { get; set; }
		public int OnRoad { get; set; }
		public int OnArrival { get; set; }
		public int Completed { get; set; }
		public int All { get; set; }
	}
}
