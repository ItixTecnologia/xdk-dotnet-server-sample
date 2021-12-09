using System;
using XDK.Data.Abstractions;
using XDK.Data.Models;
using XDK.Domain.Abstractions;
using XDK.Sample.Contracts.Domain;
using XDK.Sample.Models;
using XDK.Sample.Persistence;
using XDK.Sample.Persistence.Entities;

namespace XDK.Sample.Domain.Services;

public class CategoryDomainService : BaseEntityDomainService<Category, CategoryModel, CategoryModel>, ICategoryDomainService
{
    private readonly IUnitOfWork<SampleAdditionalDatabaseContext> _unitOfWorkAdditionalContext;

    public CategoryDomainService(
        IServiceProvider serviceProvider,
        IUnitOfWork unitOfWork,
        IUnitOfWork<SampleAdditionalDatabaseContext> unitOfWorkAdditionalContext
    ) : base(serviceProvider, unitOfWork)
    {
        _unitOfWorkAdditionalContext = unitOfWorkAdditionalContext;
    }

    public PagedListModel<CategoryModel> GetCategory(Guid categoryId)
    {
        var result = _unitOfWorkAdditionalContext.GetRepository<Category>().GetPagedList(c => c.Id == categoryId);
        return Mapper.Map<PagedListModel<CategoryModel>>(result);
    }
}