using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressCargo.Models
{
	public class ContactVM
	{
		public int ContactID { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string ContactMail { get; set; }

		public string Message { get; set; }
		public DateTime ContactDate { get; set; }
	}
}
