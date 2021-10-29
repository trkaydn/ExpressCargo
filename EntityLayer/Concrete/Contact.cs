using System;
using System.ComponentModel.DataAnnotations;


namespace EntityLayer.Concrete
{
	public class Contact
	{
		[Key]
		public int ContactID { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string ContactMail { get; set; }

		public string Message { get; set; }
		public DateTime ContactDate { get; set; }

	}
}
