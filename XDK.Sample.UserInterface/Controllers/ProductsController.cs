using Microsoft.AspNetCore.Mvc;
using XDK.Sample.Contracts.Application;
using XDK.Sample.Models;
using XDK.UserInterface.API.Abstractions;

namespace XDK.Sample.UserInterface.Controllers;

public class ProductsController : BaseEntityController<IProductAppService, ProductModel, ProductModel, Guid>
{
    [HttpGet("test-error")]
    public void Test()
    {
        throw new Exception("Erro de sistema");
    }
}