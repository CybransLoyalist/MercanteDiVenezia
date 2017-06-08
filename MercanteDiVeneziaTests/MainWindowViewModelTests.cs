using System;
using MercanteDiVenezia.ViewModels;
using NUnit.Framework;

namespace MercanteDiVeneziaTests
{
    [TestFixture]
    public class MainWindowViewModelTests
    {
        private MainWindowViewModel _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = new MainWindowViewModel();
        }
    }
}
