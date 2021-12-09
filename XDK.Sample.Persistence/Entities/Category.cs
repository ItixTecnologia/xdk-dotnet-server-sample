using System.Collections.Generic;
using XDK.Data.Abstractions.Entities;

namespace XDK.Sample.Persistence.Entities;

/// <summary>
/// Categoria.
/// </summary>
public class Category : BaseEntity
{
    /// <summary>
    /// Descrição.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Produtos associados.
    /// </summary>
    public ICollection<Product> Products { get; set; }

    public Category()
    {
        Products = new HashSet<Product>();
    }
}