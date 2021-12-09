using Microsoft.AspNetCore.Mvc;
using XDK.Sample.Contracts.Application;
using XDK.Sample.Models;
using XDK.UserInterface.API.Abstractions;

namespace XDK.Sample.UserInterface.Controllers;

public class CategoriesController : BaseEntityController<ICategoryAppService, CategoryModel, CategoryModel, Guid>
{
    [HttpGet("additional-dbcontext/{id}")]
    public IActionResult GetMultiContext([FromRoute] Guid id)
    {
        return JsonResponse(GetService<ICategoryAppService>().GetCategory(id));
    }
}
