using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
	public class Stage
	{
		[Key]
		public int StageID { get; set; }

		[Required]
		public int OrderID { get; set; }

		[Required, ForeignKey("Status")]
		public int StatusID { get; set; }

		public virtual Status Status { get; set; }

		[Required]
		public DateTime StatusDate { get; set; }
	}
}
