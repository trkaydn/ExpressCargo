using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
	public class OrderValidator : AbstractValidator<Order>
	{
		public OrderValidator()
		{
			RuleFor(x => x.SenderName)
				.NotEmpty().WithMessage("Gönderici adı boş geçilemez.")
				.MinimumLength(5).WithMessage("Gönderici adı en az 5 karakterden oluşmalıdır.");

			RuleFor(x => x.SenderPhone).NotEmpty().WithMessage("Gönderici telefonu boş geçilemez.")
				.MinimumLength(5).WithMessage("Gönderici telefonu en az 5 karakterden oluşmalıdır.");

			RuleFor(x => x.ReceiverName)
			.NotEmpty().WithMessage("Alıcı adı boş geçilemez.")
			.MinimumLength(5).WithMessage("Alıcı adı en az 5 karakter olmalıdır.");

			RuleFor(x => x.ReceiverPhone).NotEmpty().WithMessage("Alıcı telefonu boş geçilemez.")
				.MinimumLength(5).WithMessage("Alıcı telefonu en az 5 karakterden oluşmalıdır.");

			RuleFor(x => x.ShippingAddress)
				.NotEmpty().WithMessage("Açık adres boş geçilemez.")
				.MinimumLength(5).WithMessage("Açık adres en az 5 karakterden oluşmalıdır.");

			RuleFor(x => x.SizeID)
				.GreaterThan(0).WithMessage("Lütfen bir boyut seçin.");

			RuleFor(x => x.ReceiverDistrictID)
				.GreaterThan(0).WithMessage("Lütfen bir şehir ve ilçe seçin.");

		}
	}
}
