using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XDK.Sample.Contracts.Application;
using XDK.Sample.Models;
using XDK.Sample.Persistence.Entities;
using XDK.Security.Abstractions;

namespace XDK.Sample.UserInterface.Controllers;

public class AuthController : BaseAuthController<User, Claim, Persistence.Entities.Application, Guid>
{
    public AuthController(
        ISecurityRepository<User, Claim, Persistence.Entities.Application, Guid> securityRepository,
        ITokenService tokenService
    ) : base(securityRepository, tokenService) { }

    [AllowAnonymous]
    [HttpPost("create-user")]
    public IActionResult Create([FromBody] UserModel model)
    {
        var createdUser = GetService<IUserAppService>().Create(model);
        return JsonResponse(createdUser);
    }
}