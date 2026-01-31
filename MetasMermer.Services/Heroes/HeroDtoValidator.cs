using FluentValidation;

namespace MetasMermer.Services.Heroes;

public class HeroDtoValidator : AbstractValidator<HeroDto>
{
    public HeroDtoValidator()
    {
        this.ApplyNotEmptyToAllStrings();
    }
}
