using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class District
	{
		[Key]
		public int DistrictID { get; set; }

		[Required, StringLength(50)]
		public string DistrictName { get; set; }

		[Required]
		public int CityID { get; set; }

		[Required, StringLength(50)]
		public string LoginName { get; set; }

		[Required, StringLength(250)]
		public string Password { get; set; }

		public virtual City City { get; set; }

	}
}
