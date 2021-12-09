using XDK.Data.Abstractions;
using XDK.Sample.Mobile.Maui.Stores;
using Application = Microsoft.Maui.Controls.Application;

namespace XDK.Sample.Mobile.Maui
{
    public partial class App : Application
    {
        public App(TestStore testStore, IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            MainPage = new MainPage(testStore, unitOfWork);
        }
    }
}
