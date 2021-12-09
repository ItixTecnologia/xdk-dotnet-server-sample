using XDK.Application.Abstractions;
using XDK.Sample.Models;

namespace XDK.Sample.Contracts.Application;

public interface IProductAppService : IEntityAppService<ProductModel, ProductModel> { }