using Microsoft.EntityFrameworkCore;
using XDK.Data.EntityFramework;
using XDK.Sample.Persistence.Entities;

namespace XDK.Sample.Persistence.Repositories;

public class ProductRepository : Repository<Product>
{
    public ProductRepository(DbContext dbContext) : base(dbContext) { }

    public void UpdateStockUnits()
    {
        return;
    }
}