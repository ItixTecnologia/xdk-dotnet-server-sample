using System;
using XDK.Application.Abstractions;
using XDK.Data.Models;
using XDK.Sample.Models;

namespace XDK.Sample.Contracts.Application;

public interface ICategoryAppService : IEntityAppService<CategoryModel, CategoryModel>
{
    PagedListModel<CategoryModel> GetCategory(Guid categoryId);
}