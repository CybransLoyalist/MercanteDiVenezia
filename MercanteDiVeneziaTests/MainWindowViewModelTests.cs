using System;
using MercanteDiVenezia.ViewModels;
using Moq;
using NUnit.Framework;

namespace MercanteDiVeneziaTests
{
    [TestFixture]
    public class MainWindowViewModelTests
    {
        private MainWindowViewModel _sut;
        private Mock<AdminViewModel> _adminViewModelMock;

        [SetUp]
        public void SetUp()
        {
            _adminViewModelMock = new Mock<AdminViewModel>();
            _sut = new MainWindowViewModel(_adminViewModelMock.Object);
        }
    }
}
