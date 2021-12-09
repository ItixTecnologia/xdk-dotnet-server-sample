using XDK.Core.Abstractions;
using System.Collections.Generic;
using System;

namespace XDK.Sample.Models;

public class ProductModel : BaseModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public ProductModel ParentProduct { get; set; }
    public Guid? ParentProductId { get; set; }
    public ICollection<CategoryModel> Categories { get; set; } = new HashSet<CategoryModel>();
    public BrandModel Brand { get; set; }
    public Guid? BrandId { get; set; }
}