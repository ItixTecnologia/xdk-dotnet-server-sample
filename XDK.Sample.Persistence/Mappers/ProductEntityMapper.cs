using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XDK.Data.EntityFramework.Abstractions;
using XDK.Sample.Persistence.Entities;

namespace XDK.Sample.Persistence.Mappers;

public class ProductEntityMapper : BaseEntityMapper<Product>
{
    public override void Map(EntityTypeBuilder<Product> entityBuilder)
    {
        entityBuilder.HasMany(p => p.Categories).WithMany(c => c.Products);
        entityBuilder.HasOne(p => p.ParentProduct);
        entityBuilder.HasOne(p => p.Brand).WithMany(p => p.Products).HasForeignKey(it => it.BrandId);
    }
}