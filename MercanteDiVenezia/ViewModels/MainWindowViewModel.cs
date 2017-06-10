namespace MercanteDiVenezia.ViewModels
{
    public class MainWindowViewModel
    {
        public AdminViewModel AdminViewModel { get; }

        public MainWindowViewModel(AdminViewModel adminViewModel)
        {
            AdminViewModel = adminViewModel;
        }

        //new branch commit
    }
}
