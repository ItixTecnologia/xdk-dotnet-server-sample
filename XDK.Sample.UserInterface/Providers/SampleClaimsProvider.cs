using System.Security.Claims;
using XDK.Security.Abstractions;
using XDK.Security.Tools;

namespace XDK.Sample.UserInterface.Providers;

public class SampleClaimsProvider : IClaimsProvider
{
    public async Task<Claim[]> GenerateClaims<TUser, TClaim, TId>(TUser user)
        where TUser : BaseUser<TUser, TClaim, TId>
        where TClaim : BaseClaim<TUser, TClaim, TId>
    {
        await Task.Delay(0);

        var claims = new List<Claim>
        {
            new(Constants.Claims.Subject, user.Id!.ToString()!),
            new(ClaimTypes.NameIdentifier, user.Username),
            new(ClaimTypes.Email, user.Email),
            new("id", user.Id.ToString()!),
            new("teste", "teste"),
            new("testando", "testando")
        };

        foreach (var claim in user.Claims)
        {
            claims.Add(new Claim(claim.Type, claim.Value));
        }

        return claims.ToArray();
    }
}