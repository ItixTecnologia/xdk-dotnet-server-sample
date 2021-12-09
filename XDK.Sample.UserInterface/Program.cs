using XDK.Sample.UserInterface;
using XDK.Sample.UserInterface.Filters;
using XDK.UserInterface.API;

var startup = new Startup();

Setup.RunServer<Startup, SampleExceptionFilter, Guid>(args, startup);