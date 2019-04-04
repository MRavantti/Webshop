using System.Collections.Generic;
using System.Linq;
using E_Commerce.Models;
using E_Commerce.Repositories;
using E_Commerce.Services;
using FakeItEasy;
using NUnit.Framework;

namespace E_Commerce.UntitTests.Services
{
    public class ProductServicesTests
    {
        private IProductsRepository productsRepository;
        private ProductsService productsService;

        [SetUp]
        public void SetUp()
        {
            this.productsRepository = A.Fake<IProductsRepository>();
            this.productsService = new ProductsService(this.productsRepository);
        }

        [Test]
        public void Get_ReturnsResultFromRepository()
        {
            // Arrange
            var productItem = new Products
            {
                Id = 500,
                Name = "LOL",
                Stock = 1,
                Price = 100,
                Description = "Laughing",
                Image_url = "http://lol.com"
            };

            var productItems = new List<Products>
            {
                productItem
            };

            A.CallTo(() => this.productsRepository.Get()).Returns(productItems);

            // Act
            var result = this.productsService.Get().Single();

            // Assert
            Assert.That(result, Is.EqualTo(productItem));
        }
    }
}
