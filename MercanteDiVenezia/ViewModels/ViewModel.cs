using System.Windows;
using System.Windows.Controls;

namespace MercanteDiVenezia.ViewModels
{
    public abstract class ViewModel
    {
        private Window _openedWindow;
        private readonly WindowCreator _windowCreator;
        private readonly WindowOperationsHandler _windowOperationsHandler;

        protected ViewModel(
            WindowCreator windowCreator,
            WindowOperationsHandler windowOperationsHandler)
        {
            _windowCreator = windowCreator;
            _windowOperationsHandler = windowOperationsHandler;
        }

        public void Show<TView>() where TView : UserControl, new()
        {
            var view = new TView {DataContext = this};
            _openedWindow = _windowCreator.CreateFor(view);
            _windowOperationsHandler.Show(_openedWindow);
        }

        public void CloseWindow()
        {
            if (WindowIsOpened())
            {
                _windowOperationsHandler.Close(_openedWindow);
                _openedWindow = null;
            }
        }

        private bool WindowIsOpened()
        {
            return _openedWindow != null;
        }
    }
}