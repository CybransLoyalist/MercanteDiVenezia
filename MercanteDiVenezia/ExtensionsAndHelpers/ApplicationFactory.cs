using MercanteDiVenezia.ViewModels;

namespace MercanteDiVenezia.ExtensionsAndHelpers
{
    public class ApplicationFactory
    {
        public MainWindowViewModel Build()
        {
            var windowOperationsHandler = new WindowOperationsHandler();
            var windowForViewModelCreator = new WindowForViewModelCreator();

            return new MainWindowViewModel(
                new AdminViewModel(
                    new NewItemViewModel(
                        windowOperationsHandler,
                        windowForViewModelCreator),
                    windowOperationsHandler,
                    windowForViewModelCreator));
        }
    }
}