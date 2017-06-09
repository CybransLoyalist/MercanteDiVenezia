using System;
using System.Windows;
using MercanteDiVenezia;
using MercanteDiVenezia.ViewModels;
using Moq;
using NUnit.Framework;

namespace MercanteDiVeneziaTests
{

    [TestFixture, RequiresSTA]
    public class ViewModelTests
    { 
        private ViewModel _sut;
        private Mock<WindowOperationsHandler> _windowOperationsHandlerMock;
        private Mock<WindowForViewModelCreator> _windowForViewModelCreatorMock;
        private Mock<NewItemViewModel> _newItemViewModelMock;

        private Window _window;

        [SetUp]
        public void SetUp()
        {
            _window = new Window();

            _windowOperationsHandlerMock = new Mock<WindowOperationsHandler>();
            _windowOperationsHandlerMock.Setup(a => a.Show(_window));
            _windowOperationsHandlerMock.Setup(a => a.Close(_window));

            _windowForViewModelCreatorMock = new Mock<WindowForViewModelCreator>();

            _newItemViewModelMock = new Mock<NewItemViewModel>(null, null);

            _sut = new AdminViewModel(
                _newItemViewModelMock.Object,
                _windowOperationsHandlerMock.Object,
                _windowForViewModelCreatorMock.Object);

            _windowForViewModelCreatorMock.Setup(a => a.Create<AdminView>(_sut, true)).Returns(_window);
        }

        [Test]
        public void ShowingWindow_ShallCreateNewWindow()
        {
            _sut.Show<AdminView>();
            _windowForViewModelCreatorMock.Verify(a => a.Create<AdminView>(_sut, true));
        }

        [Test]
        public void ShowingWindow_ShallShowWindow_ByHandler()
        {
            _sut.Show<AdminView>();

            _windowOperationsHandlerMock.Verify(a => a.Show(_window));
        }

        [Test]
        public void IfTryingToOpenTheSameWindowTwice_ShallThrowException()
        {
            _sut.Show<AdminView>();
            Assert.Throws<Exception>(() => _sut.Show<AdminView>());
        }

        [Test]
        public void ClosingWindow_IfNotOpened_ShallDoNothing()
        {
            _sut.CloseWindow();

            _windowOperationsHandlerMock.Verify(a => a.Close(_window), Times.Never);
        }

        [Test]
        public void ClosingWindow_IfOpened_ShallCloseFromHandler()
        {
            _sut.Show<AdminView>();
            _sut.CloseWindow();

            _windowOperationsHandlerMock.Verify(a => a.Close(_window));
        }
    }
}