using System;

namespace ExpressCargo.Models
{
	public class AdminContactVM
	{
		public int ContactID { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string ContactMail { get; set; }

		public string Message { get; set; }
		public DateTime ContactDate { get; set; }
	}
}
