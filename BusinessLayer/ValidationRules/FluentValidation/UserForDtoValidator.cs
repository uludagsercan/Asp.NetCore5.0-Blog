using EntityLayer.DTOs;
using FluentValidation;
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
            RuleFor(x => x.UserMail).NotNull().WithMessage("Bu alan boş geçilemez");
        }
    }
}
