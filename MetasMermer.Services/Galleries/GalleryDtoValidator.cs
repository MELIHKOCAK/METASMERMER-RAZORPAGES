using FluentValidation;

namespace MetasMermer.Services.Galleries;

public class GalleryDtoValidator : AbstractValidator<GalleryDto>
{
    public GalleryDtoValidator()
    {
        this.ApplyNotEmptyToAllStrings();
    }
}
