using System;
using System.ComponentModel;
using System.Windows.Input;
using MercanteDiVenezia.ExtensionsAndHelpers;
using MercanteDiVenezia.Models;

namespace MercanteDiVenezia.ViewModels
{
    public class NewItemViewModel : ViewModel
    {
        private ViewModel _parent;

        public NewItemViewModel(ViewModel parent)
        {
            _parent = parent;
        }

        public Item Item { get; set; } = new Item();

        public ICommand SaveItemCommand => new Command(SaveItem, CanSaveItem);

        private void SaveItem(object obj)
        {
            var x = Item;
            var mercanteDiVeneziaDbContext = new MercanteDiVeneziaDbContext();
            mercanteDiVeneziaDbContext.Items.Add(Item);
            mercanteDiVeneziaDbContext.SaveChanges();
            CloseWindow();
        }

        private void CloseWindow()
        {
            _parent.Close(this);
        }

        private bool CanSaveItem(object obj)
        {
            return true;
        }


    }
}