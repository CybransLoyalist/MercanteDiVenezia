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

        [Test]
        public void Adding_3_To_5_ShallGet_8()
        {
            Assert.AreEqual(8, _sut.Add(3,5));
        }
    }
}
