using System.Windows.Input;
using MercanteDiVenezia.ExtensionsAndHelpers;
using MercanteDiVenezia.Views;

namespace MercanteDiVenezia.ViewModels
{
    public class AdminViewModel : ViewModel
    {
        private readonly NewItemViewModel _newItemViewModel;

        public AdminViewModel(
            WindowCreator windowCreator,
            WindowOperationsHandler windowOperationsHandler,
            NewItemViewModel newItemViewModel) : base(windowCreator, windowOperationsHandler)
        {
            _newItemViewModel = newItemViewModel;
        }

        public ICommand AddItemCommand => new Command(AddItem, CanAddItem);

        private void AddItem(object obj)
        {
            _newItemViewModel.Show<NewItemView>();
        }

        private bool CanAddItem(object obj)
        {
            return true;
        }

    }
}