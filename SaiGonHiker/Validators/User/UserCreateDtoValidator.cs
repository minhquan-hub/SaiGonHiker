using FluentValidation;
using SaiGonHiker.Contracts.Constants;
using SaiGonHiker.Contracts.Dtos.Users;

namespace SaiGonHiker.Validators.User
{
    public class UserCreateDtoValidator : BaseValidator<UserCreateDto>
    {
        public UserCreateDtoValidator() 
        {
            RuleFor(a => a.FullName)
                .NotNull()
                .NotEmpty()
                .WithMessage(x => string.Format(ErrorTypes.Common.RequiredError,nameof(x.FullName)));

            RuleFor(a => a.UserName)
                .NotNull()
                .NotEmpty()
                .WithMessage(x => string.Format(ErrorTypes.Common.RequiredError,nameof(x.UserName)))
                .Matches(@"^[A-Za-z][A-Za-z0-9_]{4,30}$")
                .WithMessage(x => string.Format(ErrorTypes.Common.InvalidFormatError,nameof(x.UserName)));

            RuleFor(a => a.Password)
                .NotNull()
                .NotEmpty()
                .WithMessage(x => string.Format(ErrorTypes.Common.RequiredError,nameof(x.Password)))
                .Matches(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$")
                .WithMessage(x => string.Format(ErrorTypes.Common.InvalidFormatError,nameof(x.Password)));

            RuleFor(a => a.Email)
                .NotNull()
                .NotEmpty()
                .WithMessage(x => string.Format(ErrorTypes.Common.RequiredError,nameof(x.Email)))
                .Matches(@"^[a-z][a-z0-9_\.]{5,32}@[a-z0-9]{2,}(\.[a-z0-9]{2,4}){1,2}$")
                .WithMessage(x => string.Format(ErrorTypes.Common.InvalidFormatError,nameof(x.Email)));
        
            RuleFor(a => a.PhoneNumber)
                .NotNull()
                .NotEmpty()
                .WithMessage(x => string.Format(ErrorTypes.Common.RequiredError,nameof(x.PhoneNumber)))
                .Matches(@"(84|0[3|5|7|8|9])+([0-9]{8,12})\b")
                .WithMessage(x => string.Format(ErrorTypes.Common.InvalidFormatError, nameof(x.PhoneNumber)));

            RuleFor(a => a.Gender)
                .NotNull()
                .NotEmpty()
                .WithMessage(x => string.Format(ErrorTypes.Common.RequiredError,nameof(x.Gender)))
                .Must(a => (a.Equals("Male") || a.Equals("Female")))
                .WithMessage(x => string.Format(ErrorTypes.Common.GendersError));

            RuleFor(a => a.RoleId)
                .NotNull()
                .NotEmpty()
                .WithMessage(x => string.Format(ErrorTypes.Common.RequiredError,nameof(x.RoleId)));

            RuleFor(a => a.Address)
                .NotNull()
                .NotEmpty()
                .WithMessage(x => string.Format(ErrorTypes.Common.RequiredError,nameof(x.Address)));  
        }
    }
}