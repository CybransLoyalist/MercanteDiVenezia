using System.Collections.Generic;
using System.Linq;
using MercanteDiVenezia.Models;
using MercanteDiVenezia.Models.Repositories;
using Moq;
using NUnit.Framework;

namespace MercanteDiVeneziaTests.ModelsTests.RepositoriesTests
{
    [TestFixture]
    class ItemsRepositoryTests
    {
        private ItemsRepository _sut;
        private Mock<MercanteDiVeneziaDbContext> _dbMock;
        private readonly DbSetMockCreator _dbSetMockCreator = new DbSetMockCreator();

        [SetUp]
        public void SetUp()
        {
            _dbMock = new Mock<MercanteDiVeneziaDbContext>();
            _sut = new ItemsRepository(_dbMock.Object);
        }

        [Test]
        public void GetRatesShallGetThemOrderedByYearThanMonth()
        {
            var rates = new List<Item>
            {
                new Item {Id = 1, Name = "mask1", Quantity = 10, Value = 10.5M},
                new Item {Id = 1, Name = "mask2", Quantity = 4, Value = 50.5M},
                new Item {Id = 1, Name = "mask3", Quantity = 0, Value = 30.5M},
            }.AsQueryable();

            _dbMock.Setup(c => c.Items).Returns(_dbSetMockCreator.Create(rates).Object);

            var result = _sut.GetDbSet().ToList();
            Assert.AreEqual(3, result.Count());
        }
    }
}
