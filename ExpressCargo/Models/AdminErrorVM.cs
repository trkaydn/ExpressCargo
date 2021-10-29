using System;

namespace ExpressCargo.Models
{
	public class AdminErrorVM
	{
		public int ErrorID { get; set; }

		public string RequestMethod { get; set; }

		public int StatusCode { get; set; }

		public string ErrorPath { get; set; }

		public string ErrorMessage { get; set; }

		public DateTime ErrorTime { get; set; }
	}
}
