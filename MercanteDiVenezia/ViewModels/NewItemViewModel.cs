using System;
using System.ComponentModel;
using System.Windows.Input;
using MercanteDiVenezia.ExtensionsAndHelpers;
using MercanteDiVenezia.Models;

namespace MercanteDiVenezia.ViewModels
{
    public class NewItemViewModel : ViewModel
    {
        public NewItemViewModel(
            WindowOperationsHandler windowOperationsHandler,
            WindowForViewModelCreator windowForViewModelCreator) : base(windowOperationsHandler, windowForViewModelCreator)
        {
        }

        public Item Item { get; set; } = new Item();

        public ICommand SaveItemCommand => new Command(SaveItem, CanSaveItem);

        private void SaveItem(object obj)
        {
            var mercanteDiVeneziaDbContext = new MercanteDiVeneziaDbContext();
            mercanteDiVeneziaDbContext.Items.Add(Item);
            mercanteDiVeneziaDbContext.SaveChanges();
            CloseWindow();
        }

        private bool CanSaveItem(object obj)
        {
            return true;
        }
    }
}