using FluentValidation;

namespace MetasMermer.Services.Contacts;

public class ContactDtoValidator : AbstractValidator<ContactDto>
{
    public ContactDtoValidator()
    {
        this.ApplyNotEmptyToAllStrings();
    }
}
