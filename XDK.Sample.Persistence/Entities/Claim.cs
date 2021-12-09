using System;
using XDK.Security.Abstractions;

namespace XDK.Sample.Persistence.Entities;

public class Claim : BaseClaim<User, Claim, Guid> { }