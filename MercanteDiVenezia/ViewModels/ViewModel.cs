using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace MercanteDiVenezia.ViewModels
{
    public abstract class ViewModel
    {
        private Window _window;
        private readonly WindowOperationsHandler _windowOperationsHandler;
        private readonly WindowForViewModelCreator _windowForViewModelCreator;

        protected ViewModel(
            WindowOperationsHandler windowOperationsHandler,
            WindowForViewModelCreator windowForViewModelCreator)
        {
            _windowOperationsHandler = windowOperationsHandler;
            _windowForViewModelCreator = windowForViewModelCreator;
        }

        public void Show<TView>() where TView : UserControl, new()
        {
            if (_window != null)
            {
                throw new Exception("Window is already open!");
            }
            _window = _windowForViewModelCreator.Create<TView>(this);
            _windowOperationsHandler.Show(_window);
        }

        public void CloseWindow()
        {
            if (_window != null)
            {
                _windowOperationsHandler.Close(_window);
                _window = null;
            }
        }
    }
}