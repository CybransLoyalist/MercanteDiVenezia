namespace MercanteDiVenezia.ViewModels
{
    public class MainWindowViewModel
    {
        public AdminViewModel AdminViewModel { get; }

        public MainWindowViewModel() : this(new AdminViewModel())
        {
        }

        public MainWindowViewModel(AdminViewModel adminViewModel)
        {
            AdminViewModel = adminViewModel;
        }

        //master
    }
}
