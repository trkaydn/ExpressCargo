using System;
using System.ComponentModel.DataAnnotations;


namespace EntityLayer.Concrete
{
	public class ExceptionLog
	{
		[Key]
		public int ErrorID { get; set; }

		[StringLength(10)]
		public string RequestMethod { get; set; }

		public int StatusCode { get; set; }

		public string ErrorPath { get; set; }

		public string ErrorMessage { get; set; }

		public DateTime ErrorTime { get; set; } = DateTime.Now;
	}
}
