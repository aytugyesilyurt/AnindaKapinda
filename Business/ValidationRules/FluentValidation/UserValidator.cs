using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty().NotNull().WithMessage("İsim boş bırakılamaz");
            RuleFor(u => u.Password).NotEmpty().NotNull().MinimumLength(8).WithMessage("Şifre boş veya 8 karakterden az olamaz.");
            RuleFor(u => u.Mail).NotEmpty().NotNull().WithMessage("Eposta boş bırakılamaz.").EmailAddress().WithMessage("Geçerli bir mail adresi giriniz.")/*.Matches(regex)*/;
        }
    }
}
