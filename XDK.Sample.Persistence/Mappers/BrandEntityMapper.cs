using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XDK.Data.EntityFramework.Abstractions;
using XDK.Sample.Persistence.Entities;

namespace XDK.Sample.Persistence.Mappers;

public class BrandEntityMapper : BaseEntityMapper<Brand>
{
    public override void Map(EntityTypeBuilder<Brand> entityBuilder)
    {
        entityBuilder.HasMany(p => p.Products).WithOne(p => p.Brand).HasForeignKey(k => k.BrandId);
    }
}