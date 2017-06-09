using System.Windows.Input;
using MercanteDiVenezia.ExtensionsAndHelpers;

namespace MercanteDiVenezia.ViewModels
{
    public class AdminViewModel : ViewModel
    {
        private readonly NewItemViewModel _newItemViewModel;

        public AdminViewModel(
            NewItemViewModel newItemViewModel,
            WindowOperationsHandler windowOperationsHandler,
            WindowForViewModelCreator windowForViewModelCreator) : base(windowOperationsHandler, windowForViewModelCreator)
        {
            _newItemViewModel = newItemViewModel;
        }

        public ICommand AddItemCommand => new Command(AddItem, CanAddItem);

        private void AddItem(object obj)
        {;
            _newItemViewModel.Show<Views.NewItemView>();
        }

        private bool CanAddItem(object obj)
        {
            return true;
        }
    }
}