using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XDK.Sample.Contracts.Application;
using XDK.Sample.Models;
using XDK.UserInterface.API.Abstractions;

namespace XDK.Sample.UserInterface.Controllers;

[AllowAnonymous]
public class SampleController : BaseEntityController<IProductAppService, ProductModel, ProductModel, Guid> { }