namespace MercanteDiVenezia.ViewModels
{
    public class MainWindowViewModel
    {
        public AdminViewModel AdminViewModel { get; private set; }

        public MainWindowViewModel() : this(new AdminViewModel())
        {
        }

        public MainWindowViewModel(AdminViewModel adminViewModel)
        {
            AdminViewModel = adminViewModel;
        }

        public int Add(int a, int b)//todo to be removed
        {
            return a + b;
        }
    }
}
