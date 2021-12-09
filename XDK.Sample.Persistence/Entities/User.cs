using System;
using XDK.Security.Abstractions;

namespace XDK.Sample.Persistence.Entities;

public class User : BaseUser<User, Claim, Guid> { }