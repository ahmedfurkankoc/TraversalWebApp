using DTOLayer.DTOs.ContactDTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.ContactUs
{
    public class SendContactUsValidator : AbstractValidator<SendMessageDTO>
    {
        public SendContactUsValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Mail alanı boş geçilemez");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu alanı boş geçilemez");
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Mesaj alanı boş geçilemez");
            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("Konu alanına en az 5 karakter girmelisiniz.");
            RuleFor(x => x.Subject).MaximumLength(150).WithMessage("Konu alanına en fazla 150 karakter girmelisiniz.");
            RuleFor(x => x.Message).MaximumLength(150).WithMessage("Mesaj alanına en fazla 150 karakter girmelisiniz.");
            RuleFor(x => x.Message).MinimumLength(5).WithMessage("Mesaj alanına en az 5 karakter girmelisiniz.");
        }
    }
}
