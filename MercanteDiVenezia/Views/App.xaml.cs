using System.Windows;

namespace MercanteDiVenezia.Views
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var mainWindow = new MainWindow { DataContext = new ApplicationFactory().Build() };

            mainWindow.Show();
            base.OnStartup(e);
        }
    }
}
