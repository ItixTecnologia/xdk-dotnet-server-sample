using System;
using System.Collections.Generic;
using XDK.Data.Abstractions.Entities;

namespace XDK.Sample.Persistence.Entities;

/// <summary>
/// Produto.
/// </summary>
public class Product : BaseEntity
{
    /// <summary>
    /// Nome.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Descrição.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Quantidade.
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Preço.
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Categorias do produto.
    /// </summary>
    public ICollection<Category> Categories { get; set; }

    /// <summary>
    /// Produto principal.
    /// </summary>
    public Product ParentProduct { get; set; }

    /// <summary>
    /// Identificador do produto principal
    /// </summary>
    public Guid? ParentProductId { get; set; }

    /// <summary>
    /// Marca do produto.
    /// </summary>
    public Brand Brand { get; set; }

    /// <summary>
    /// Identificador da marca do produto.
    /// </summary>
    public Guid? BrandId { get; set; }

    public Product()
    {
        Categories = new HashSet<Category>();
    }
}