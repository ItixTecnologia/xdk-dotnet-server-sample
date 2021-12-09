using XDK.Core.Abstractions;

namespace XDK.Sample.Models;

public class UserModel : BaseModel
{
    public string Email { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}