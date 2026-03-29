
using Xunit;
using ProductInventory.Api.Services;

namespace ProductInventory.Api.Tests.Services
{
    public class ProductsReadServiceTest
    {

        [Fact]
        public void Should_Return_Values_When_Called()
        {
            ProductsReadService productsReadService = new ProductsReadService();
            var result = productsReadService.FindAll();

            Assert.True(result.Count > 0, "Deve retornar algo");
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void Should_Call_With_Values(int value)
        {
            Assert.True(value != 9, "Numeros diferentes de 9");
        }

    }
}