using System.Threading.Tasks;
using FluentValidation;
using XDK.Data.Abstractions;
using XDK.Data.Abstractions.Entities;
using XDK.Data.Models.Enums;
using XDK.Data.Validator;
using XDK.Sample.Persistence.Entities;

namespace XDK.Sample.Persistence.Validators;

public class ProductValidator : BaseEntityValidator<Product>
{
    public ProductValidator(ValidationErrorContext ctx) : base(ctx) { }

    // É async e tem unit of work para permitir o dev fazer operações assíncronas e acessar dados do repositório.
    public override Task Validate(IUnitOfWork unitOfWork, Product current, Product original, EntityState state)
    {
        switch (state)
        {
            case EntityState.Deleted:
                RuleFor(p => p.Description).MinimumLength(10);
                RuleFor(p => p.Name).NotEmpty();
                RuleFor(a => a.Price).Custom(
                    (price, ctx) =>
                    {
                        if (price > 100)
                        {
                            ctx.AddFailure("Price", "We can't add expensive products");
                        }
                    }
                );
                ValidateRules(current);
                break;
        }
        
        return Task.FromResult(0);
    }
}