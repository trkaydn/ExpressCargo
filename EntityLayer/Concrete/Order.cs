using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class Order
	{
		[Key]
		public int OrderID { get; set; }

		public string TrackNumber { get; set; }

		[StringLength(50)]
		public string SenderName { get; set; }

		[StringLength(50)]
		public string SenderPhone { get; set; }

		[StringLength(50)]
		public string ReceiverName { get; set; }

		[StringLength(50)]
		public string ReceiverPhone { get; set; }

		public string ShippingAddress { get; set; }

		public int SizeID { get; set; }
		public double? Price { get; set; }

		public DateTime OrderDate { get; set; }

		public int SenderDistrictID { get; set; }

		public int ReceiverDistrictID { get; set; }

		public int StatusID { get; set; }

		public virtual List<Stage> Stages { get; set; }
		public virtual Size Size { get; set; }
		public virtual District ReceiverDistrict { get; set; }
		public virtual District SenderDistrict { get; set; }
		public virtual Status Status { get; set; }

	}
}
