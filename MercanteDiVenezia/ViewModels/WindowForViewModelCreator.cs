using System.Windows;
using System.Windows.Controls;

namespace MercanteDiVenezia.ViewModels
{
    public class WindowForViewModelCreator //todo add uts
    {
        public virtual Window Create<TView>(object dataContext, bool sizeToContent = true) where TView : UserControl, new()
        {
            var userControl = new TView { DataContext = dataContext };

            var contentUi = new ContentControl { Content = userControl };
            var dockPanel = new DockPanel();
            dockPanel.Children.Add(contentUi);
            var hostWindow = new Window
            {
                IsEnabled = true,
                Content = dockPanel
            };

            if (sizeToContent)
            {
                hostWindow.SizeToContent = SizeToContent.WidthAndHeight;
            }

            return hostWindow;
        }
    }
}