using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercanteDiVenezia.ViewModels
{
    public class MainWindowViewModel
    {
        public string Message { get; set; } = "Elo siora, gratsy, działa :D";

        public int Add(int a, int b)//todo to be removed
        {
            return a + b;
        }
    }
}
