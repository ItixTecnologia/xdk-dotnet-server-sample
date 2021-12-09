using XDK.Sample.Contracts.Application;
using XDK.Sample.Models;
using XDK.UserInterface.API.Abstractions;

namespace XDK.Sample.UserInterface.Controllers;

public class BrandController : BaseEntityController<IBrandAppService, BrandModel, BrandModel, Guid> { }