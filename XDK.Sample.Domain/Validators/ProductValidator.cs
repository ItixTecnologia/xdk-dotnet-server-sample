using System.Threading.Tasks;
using FluentValidation;
using XDK.Data.Abstractions;
using XDK.Data.Abstractions.Entities;
using XDK.Data.Models.Enums;
using XDK.Data.Validator;
using XDK.Sample.Persistence.Entities;

namespace XDK.Sample.Domain.Validators;

public class ProductValidator : BaseEntityValidator<Product>
{
    public ProductValidator(ValidationErrorContext ctx) : base(ctx) { }

    // É async e tem unit of work para permitir o dev fazer operações assíncronas e acessar dados do repositório.
    public override async Task Validate(IUnitOfWork unitOfWork, Product current, Product original, EntityState state)
    {
        await Task.Delay(0);

        switch (state)
        {
            case EntityState.Added:
                RuleFor(p => p.Description).MinimumLength(10);
                RuleFor(p => p.Name).NotEmpty();
                ValidateRules(current);
                break;
        }
    }
}