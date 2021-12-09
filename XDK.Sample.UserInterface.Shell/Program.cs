using XDK.Sample.UserInterface.Shell;
using XDK.Sample.UserInterface.Shell.Filters;
using XDK.UserInterface.API;

var startup = new Startup();

Setup.RunServer<Startup, SampleShellExceptionFilter, Guid>(args, startup);