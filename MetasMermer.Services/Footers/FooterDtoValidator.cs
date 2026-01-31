using FluentValidation;

namespace MetasMermer.Services.Footers;

public class FooterDtoValidator : AbstractValidator<FooterDto>
{
    public FooterDtoValidator()
    {
        this.ApplyNotEmptyToAllStrings();
    }
}
