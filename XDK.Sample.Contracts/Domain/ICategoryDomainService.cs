using System;
using XDK.Data.Models;
using XDK.Domain.Abstractions;
using XDK.Sample.Models;

namespace XDK.Sample.Contracts.Domain;

public interface ICategoryDomainService : IEntityDomainService<CategoryModel, CategoryModel>
{
    PagedListModel<CategoryModel> GetCategory(Guid categoryId);
}