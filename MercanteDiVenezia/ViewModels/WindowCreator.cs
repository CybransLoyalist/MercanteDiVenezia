using System.Windows;
using System.Windows.Controls;

namespace MercanteDiVenezia.ViewModels
{
    public class WindowCreator
    {
        public virtual Window CreateFor(object view, bool sizeToContent = true)
        {
            var contentUi = new ContentControl { Content = view };
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