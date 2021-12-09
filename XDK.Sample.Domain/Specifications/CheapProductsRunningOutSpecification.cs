using System;
using System.Linq.Expressions;
using XDK.Data.Abstractions;
using XDK.Sample.Persistence.Entities;

namespace XDK.Sample.Domain.Specifications;

public class CheapProductsRunningOutSpecification : BaseSpecification<Product>
{
    private readonly decimal _cheapPriceThreshold;

    public CheapProductsRunningOutSpecification(decimal cheapPriceThreshold)
    {
        _cheapPriceThreshold = cheapPriceThreshold;
    }

    public override Expression<Func<Product, bool>> IsSatisfiedBy()
    {
        return product => product.Quantity < 50 && product.Price <= _cheapPriceThreshold;
    }
}