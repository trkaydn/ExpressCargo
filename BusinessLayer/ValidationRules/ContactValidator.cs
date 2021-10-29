using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
	public class ContactValidator : AbstractValidator<Contact>
	{
		public ContactValidator()
		{
			RuleFor(x => x.FirstName).NotEmpty().WithMessage("Lütfen adınızı girin.");
			RuleFor(x => x.LastName).NotEmpty().WithMessage("Lütfen soyadınızı girin.");
			RuleFor(x => x.ContactMail).NotEmpty().WithMessage("Lütfen mail adresinizi girin.").EmailAddress().WithMessage("Lütfen geçerli bir E-Posta girin.");
			RuleFor(x => x.Message).NotEmpty().WithMessage("Lütfen mesajınızı girin.");
		}
	}
}
