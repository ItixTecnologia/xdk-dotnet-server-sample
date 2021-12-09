using System;
using XDK.Application.Abstractions;
using XDK.Data.Models;
using XDK.Sample.Contracts.Application;
using XDK.Sample.Contracts.Domain;
using XDK.Sample.Models;

namespace XDK.Sample.Application.Services;

public class CategoryAppService : BaseEntityAppService<ICategoryDomainService, CategoryModel, CategoryModel>, ICategoryAppService
{
    public CategoryAppService(IServiceProvider serviceProvider)
        : base(serviceProvider) { }

    public PagedListModel<CategoryModel> GetCategory(Guid categoryId)
    {
        return GetDomainService<ICategoryDomainService>().GetCategory(categoryId);
    }
}
