using XDK.Security.Abstractions;

namespace XDK.Sample.UserInterface.Controllers;

public class OAuthController : BaseOAuthController
{
    public OAuthController(IOAuthService oAuthService) : base(oAuthService) { }
}