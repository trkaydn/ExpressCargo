using System.ComponentModel.DataAnnotations;

namespace ExpressCargo.Models
{
	public class ChangePasswordVM
	{
		public string OldPassword { get; set; }

		public string NewPassword { get; set; }

		public string NewPasswordControl { get; set; }
	}
}
