using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class Size
	{
		[Key]
		public int SizeID { get; set; }
		public string SizeName { get; set; }
	}
}
