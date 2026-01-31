using FluentValidation;

namespace MetasMermer.Services.Solutions;

public class SolutionDtoValidator :AbstractValidator<SolutionDto>
{
    public SolutionDtoValidator()
    {
        this.ApplyNotEmptyToAllStrings();
    }
}
