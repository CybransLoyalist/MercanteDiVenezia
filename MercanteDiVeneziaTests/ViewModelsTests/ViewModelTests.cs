using System.Windows;
using MercanteDiVenezia;
using MercanteDiVenezia.ViewModels;
using Moq;
using NUnit.Framework;

namespace MercanteDiVeneziaTests.ViewModelsTests
{
    [TestFixture, RequiresSTA]
    class ViewModelTests
    {
        private ViewModel _sut;
        private Mock<WindowCreator> _windowCreatorMock;
        private Mock<WindowOperationsHandler> _windowOperationsHandlerMock;
        private Window _window;

        [SetUp]
        public void SetUp()
        {
            _window = new Window();

            _windowCreatorMock = new Mock<WindowCreator>();
            _windowCreatorMock.Setup(a => a.CreateFor(It.IsAny<AdminView>(), true)).Returns(_window);

            _windowOperationsHandlerMock = new Mock<WindowOperationsHandler>();

            _sut = new AdminViewModel(_windowCreatorMock.Object, _windowOperationsHandlerMock.Object, null);
        }

        [Test]
        public void ShowingWindow_ShallCreateWindow()
        {
            _sut.Show<AdminView>();

            _windowCreatorMock.Verify(a => a.CreateFor(It.IsAny<AdminView>(), true));
        }

        [Test]
        public void ShowingWindow_ShallCauseHandler_ToShowWindow()
        {
            _sut.Show<AdminView>();

            _windowOperationsHandlerMock.Verify(a => a.Show(_window));
        }

        [Test]
        public void ClosingWindow_ShallCauseHandler_ToCloseWindow()
        {
            _sut.Show<AdminView>();
            _sut.CloseWindow();

            _windowOperationsHandlerMock.Verify(a => a.Close(_window));
        }

        [Test]
        public void IfWindowIsNotOpen_ShallDoNothingWhenClosing()
        {
            _sut.CloseWindow();

            _windowOperationsHandlerMock.Verify(a => a.Close(_window), Times.Never);
        }
    }
}
