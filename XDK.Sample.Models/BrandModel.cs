using System.Collections.Generic;
using XDK.Core.Abstractions;

namespace XDK.Sample.Models;

public class BrandModel : BaseModel
{
    public string Name { get; set; }
    public string EnterpriseName { get; set; }
    public ICollection<ProductModel> Products { get; set; } = new HashSet<ProductModel>();
}