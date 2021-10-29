using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class Status
	{
		[Key]
		public int StatusID { get; set; }

		[Required]
		public string StatusName { get; set; }
	}
}
