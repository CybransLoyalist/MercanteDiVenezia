using System;
using System.Windows.Input;
using MercanteDiVenezia.ExtensionsAndHelpers;
using MercanteDiVenezia.Models;

namespace MercanteDiVenezia.ViewModels
{
    public class NewItemViewModel : ViewModel
    {
        public Item Item { get; set; } = new Item();

        public ICommand SaveItemCommand => new Command(SaveItem, CanSaveItem);

        private void SaveItem(object obj)
        {
            var x = Item;
            Item.Name = "xxxxxxxx"; //todo not yet changing value in view
        }

        private bool CanSaveItem(object obj)
        {
            return true;
        }
    }
}