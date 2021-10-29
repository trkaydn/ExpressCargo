using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressCargo.Models
{
	public class AdminOrderVM
	{
		public int OrderID { get; set; }

		public string TrackNumber { get; set; }

		public string SenderName { get; set; }

		public string SenderPhone { get; set; }

		public string ReceiverName { get; set; }

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
		public virtual Status Status { get; set; }
	}
}
