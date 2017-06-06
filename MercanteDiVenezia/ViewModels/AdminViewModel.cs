using System;
using System.Windows.Input;
using MercanteDiVenezia.ExtensionsAndHelpers;

namespace MercanteDiVenezia.ViewModels
{
    public class AdminViewModel : ViewModel
    {
        public ICommand AddItemCommand => new Command(AddItem, CanAddItem);


        private void AddItem(object obj)
        {
            var vm1 = new NewItemViewModel();

            ShowDialog<NewItemView>(vm1);
        }

        private bool CanAddItem(object obj)
        {
            return true;
        }

    }
}