using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace ExpressCargo.Models
{
	public class CreateOrderVM
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
		public List<SelectListItem> Sizes { get; set; }
		public List<SelectListItem> Cities { get; set; }
		public string City { get; set; }
	}
}
