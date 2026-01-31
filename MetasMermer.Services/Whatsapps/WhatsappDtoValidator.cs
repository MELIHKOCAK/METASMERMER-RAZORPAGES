using FluentValidation;

namespace MetasMermer.Services.Whatsapps;

public class WhatsappDtoValidator : AbstractValidator<WhatsappDto>
{
    public WhatsappDtoValidator()
    {
        this.ApplyNotEmptyToAllStrings();

        RuleFor(x => x.PhoneNumber)
            .Must(value => value.All(char.IsDigit));
    }
}
