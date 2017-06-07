using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace MercanteDiVenezia.ViewModels
{
    public abstract class ViewModel //todo add uts
    {
        private Dictionary<ViewModel, Window> _openedChildren = new Dictionary<ViewModel, Window>();

        protected void ShowDialog<TView>(ViewModel viewModel) where TView : UserControl, new()
        {
            var view = new TView();
            view.DataContext = viewModel;
            var win = CreateWindowHostingViewModel(view, true);
            _openedChildren[viewModel] = win;
            win.ShowDialog();

        }

        private Window CreateWindowHostingViewModel(object viewModel, bool sizeToContent)
        {
            var contentUI = new ContentControl {Content = viewModel};
            var dockPanel = new DockPanel();
            dockPanel.Children.Add(contentUI);
            Window hostWindow = new Window
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

        public void Close(ViewModel child)
        {
            _openedChildren[child].Close();
            _openedChildren.Remove(child);
        }
    }
}