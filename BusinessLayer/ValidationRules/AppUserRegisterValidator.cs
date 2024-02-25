using DTOLayer.DTOs.AppUserDTO;
using FluentValidation;


namespace BusinessLayer.ValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDTO>
    {
        public AppUserRegisterValidator() 
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez.");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez.");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Mail alanı boş geçilemez.");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçilemez.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez.");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar alanı boş geçilemez.");
            RuleFor(x => x.Username).MinimumLength(5).WithMessage("Lütfen en az 5 karakter giriniz");
            RuleFor(x => x.Username).MinimumLength(20).WithMessage("Lütfen en fazla 20 karakter giriniz");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Şifreler birbiriyle uyuşmuyor");
        }
    }
}
