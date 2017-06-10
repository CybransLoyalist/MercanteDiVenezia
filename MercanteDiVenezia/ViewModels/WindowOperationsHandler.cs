using System.Windows;
using MercanteDiVenezia.ExtensionsAndHelpers;

namespace MercanteDiVenezia.ViewModels
{
    [ExcludeFromCoverage]
    public class WindowOperationsHandler
    {
        public virtual void Show(Window window)
        {
            window.ShowDialog();
        }

        public virtual void Close(Window window)
        {
            window.Close();
        }
    }
}