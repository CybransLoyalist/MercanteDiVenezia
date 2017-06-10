using MercanteDiVenezia.Models;
using MercanteDiVenezia.Models.Repositories;
using MercanteDiVenezia.ViewModels;

namespace MercanteDiVenezia.Views
{
    public class ApplicationFactory
    {
        public MainWindowViewModel Build()
        {
            return new MainWindowViewModel(
                new AdminViewModel(
                    new WindowCreator(),
                    new WindowOperationsHandler(),
                    new NewItemViewModel(
                        new WindowCreator(),
                        new WindowOperationsHandler(),
                        new ItemsRepository(new MercanteDiVeneziaDbContext()))));
        }
    }
}