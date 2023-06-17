using DataTransferObjectLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserAddValidator : AbstractValidator<AppUserAddDto>
    {
        public AppUserAddValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("This field is required !");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("This field is required !");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("This field is required !");
            RuleFor(x => x.Email).NotEmpty().WithMessage("This field is required !");
            RuleFor(x => x.Password).NotEmpty().WithMessage("This field is required !");
            RuleFor(x => x.ConfirmedPassword).NotEmpty().WithMessage("This field is required !");

            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Up to 30 characters can be entered !");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Up to 30 characters can be entered !");
            RuleFor(x => x.Email).EmailAddress().WithMessage("This mail address is not valid !");
            RuleFor(x => x.ConfirmedPassword).Equal(y => y.Password).WithMessage("Password must be equal confirmed password !");
        }
    }
}
