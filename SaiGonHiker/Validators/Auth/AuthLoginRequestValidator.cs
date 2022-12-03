using FluentValidation;
using SaiGonHiker.Contracts.Constants;
using SaiGonHiker.Contracts.Dtos.Auth;

namespace SaiGonHiker.Validators.Auth
{
    public class AuthLoginRequestValidator : BaseValidator<AuthLoginRequest>
    {
        public AuthLoginRequestValidator()
        {
            RuleFor(a => a.UserName)
                .NotNull()
                .NotEmpty()
                .WithMessage(x => string.Format(ErrorTypes.Common.RequiredError,nameof(x.UserName)))
                .Matches(@"^[A-Za-z][A-Za-z0-9_]{4,30}$")
                .WithMessage(x => string.Format(ErrorTypes.Common.InvalidFormatError,nameof(x.UserName)));

            RuleFor(a => a.Password)
                .NotNull()
                .NotEmpty()
                .Matches(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$")
                .WithMessage(x => string.Format(ErrorTypes.Common.InvalidFormatError,nameof(x.Password)));
        }
    }
}