using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class City
	{
		[Key]
		public int CityID { get; set; }

		[Required, StringLength(50)]
		public string CityName { get; set; }
	}
}
