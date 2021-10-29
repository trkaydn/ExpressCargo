using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
	public class CommentValidator : AbstractValidator<Comment>
	{
		public CommentValidator()
		{
			RuleFor(x => x.FirstName).NotEmpty().WithMessage("Lütfen adınızı girin.");
			RuleFor(x => x.LastName).NotEmpty().WithMessage("Lütfen soyadınızı girin.");
			RuleFor(x => x.CommentContent).NotEmpty().WithMessage("Lütfen mesajınızı girin.");
		}
	}
}
