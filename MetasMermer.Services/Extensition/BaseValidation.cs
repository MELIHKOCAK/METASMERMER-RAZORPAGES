using FluentValidation;
using System.Linq.Expressions;
using System.Reflection;

namespace MetasMermer.Services;

public static class BaseValidation
{
    private static IRuleBuilder<T, string> CheckEmpty<T>(this IRuleBuilder<T, string> ruleBuilder)
    {
        return ruleBuilder
            .NotEmpty()
            .WithMessage("Boş alan bırakıldı veya girdiğiniz değerler hatalıdır. Lütfen kontrol ediniz.");
    }

    public static void ApplyNotEmptyToAllStrings<T>(this AbstractValidator<T> validator)
    {
        // T tipindeki (DTO) tüm string property'leri bul
        var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .Where(p => p.PropertyType == typeof(string));

        foreach (var property in properties)
        {
            // x => x.PropertyName expression'ını oluştur
            var parameter = Expression.Parameter(typeof(T), "x");
            var propertyAccess = Expression.Property(parameter, property);
            var lambda = Expression.Lambda<Func<T, string>>(propertyAccess, parameter);

            // Kuralı bağla
            validator.RuleFor(lambda)
                .CheckEmpty();
        }
    }
}
