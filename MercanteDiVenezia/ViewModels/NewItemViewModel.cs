using System.Windows.Input;
using MercanteDiVenezia.ExtensionsAndHelpers;
using MercanteDiVenezia.Models;
using MercanteDiVenezia.Models.Repositories;

namespace MercanteDiVenezia.ViewModels
{
    public class NewItemViewModel : ViewModel
    {
        private readonly ItemsRepository _itemsRepository;

        public NewItemViewModel(
            WindowCreator windowCreator,
            WindowOperationsHandler windowOperationsHandler,
            ItemsRepository itemsRepository) : base(windowCreator, windowOperationsHandler)
        {
            _itemsRepository = itemsRepository;
        }

        public Item Item { get; set; } = new Item();

        public ICommand SaveItemCommand => new Command(SaveItem, CanSaveItem);

        private void SaveItem(object obj)
        {
            _itemsRepository.AddToDbSet(Item);
            _itemsRepository.SaveChanges();
            CloseWindow();
        }

        private bool CanSaveItem(object obj)
        {
            return true;
        }

    }
}