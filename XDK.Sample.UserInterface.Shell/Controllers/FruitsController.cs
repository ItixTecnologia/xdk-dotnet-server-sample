using Microsoft.AspNetCore.Mvc;
using XDK.Core.Abstractions;
using XDK.Data.Models;
using XDK.UserInterface.API.Abstractions.Shell;

namespace XDK.Sample.UserInterface.Shell.Controllers;

public class TestModel : BaseModel
{
    public string Description { get; set; }
}

public class FruitsController : BaseEntityController<TestModel, Guid>
{
    public override IActionResult List(SearchRequest data)
    {
        return JsonResponse(new PagedListModel<TestModel>());
    }

    public override IActionResult GetByIds(Guid[] data)
    {
        throw new NotImplementedException();
    }

    public override IActionResult Search(SearchRequest data)
    {
        throw new NotImplementedException();
    }

    public override IActionResult GetComposite(Guid[] ids)
    {
        throw new NotImplementedException();
    }

    public override IActionResult Get(Guid id)
    {
        throw new NotImplementedException();
    }

    public override IActionResult Create(TestModel data)
    {
        throw new NotImplementedException();
    }

    public override IActionResult Update(TestModel data, Guid id)
    {
        throw new NotImplementedException();
    }

    public override IActionResult DeleteComposite(Guid[] id)
    {
        throw new NotImplementedException();
    }

    public override IActionResult Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    public override IActionResult DeleteMany(Guid[] ids)
    {
        throw new NotImplementedException();
    }
}