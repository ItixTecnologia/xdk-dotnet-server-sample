using System.Collections.Generic;
using XDK.Data.Abstractions.Entities;

namespace XDK.Sample.Persistence.Entities;

public class Brand : BaseEntity
{
    public string Name { get; set; }
    public string EnterpriseName { get; set; }
    public ICollection<Product> Products { get; set; } = new HashSet<Product>();
}