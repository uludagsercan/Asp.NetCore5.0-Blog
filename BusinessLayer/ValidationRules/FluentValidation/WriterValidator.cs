using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.FluentValidation
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar ismi alanı boş geçilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Yazar mail alanı boş geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Yazar şifre alanı boş geçilemez");
            //büyük harf içermeli
        }
    }
}
