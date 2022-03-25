using EntityLayer.DTOs;
using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.FluentValidation
{
    public class UserForDtoValidator:AbstractValidator<UserForDto>
    {
        public UserForDtoValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("User mail alanı boş geçilemez");
            RuleFor(x => x.Username).NotEmpty().WithMessage("User name alanı boş geçilemez");
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("User mail alanı boş geçilemez");
            RuleFor(x => x.UserMail).EmailAddress().WithMessage("User mail alanı hatalı girilmiştir");
            RuleFor(x => x.UserPassowrd).NotEmpty().WithMessage("User şifre alanı boş geçilemez");
            RuleFor(x => x.UserPasswordConfimation).NotEmpty().WithMessage("User şifre onaylama alanı boş geçilemez");
            RuleFor(x => x.UserPassowrd).MinimumLength(8).WithMessage("User şifre alanı en az 8 karakter uzunluğunda olmalıdır");
            
        }
    }
}
