using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace MercanteDiVenezia.ViewModels
{
    public abstract class ViewModel //todo add uts
    {
        private Window _window;

        public void Show<TView>() where TView : UserControl, new()
        {
            var view = new TView {DataContext = this};
            _window = CreateWindowHostingViewModel(view, true);
            _window.ShowDialog();
        }

        public void CloseWindow()
        {
            _window.Close();
            _window = null;
        }

        private Window CreateWindowHostingViewModel(object viewModel, bool sizeToContent)
        {
            var contentUi = new ContentControl { Content = viewModel };
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