using DTOLayer.DTOs.AnnouncementDTO;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<AnnouncementAddDTO>
    {
        public AnnouncementValidator() 
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen boş bir başlık giriniz");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Lütfen duyuru içeriği giriniz");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen en az 5 karakter giriniz");
            RuleFor(x => x.Content).MinimumLength(10).WithMessage("Lütfen en az 10 karakter giriniz");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter giriniz");
            RuleFor(x => x.Content).MaximumLength(500).WithMessage("Lütfen en fazla 500 karakter giriniz");
        }

    }
}
