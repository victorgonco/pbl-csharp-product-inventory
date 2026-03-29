
using Xunit;
using ProductInventory.Api.Services;

namespace ProductInventory.Api.Tests.Services
{
    public class ProductsReadServiceTest
    {
        // TODO: Seguir adicionando testes desta classe para usar TDD como guia.
        // TODO: A partir daqui, criar o teste de controoller, criar a controller e ir seguindo
        // TODO: Setar um teste integrado para consultar o banco, quebrar o teste e depois colocar o contexto do dapper
        // Nota: A idéia é forçar o desenvolvimento a ser guiado pela funcionalidade desenhada, que é o crud descrito no readme.md
        // Já pensando no que precisa ser resultado das rotinas para poder fazer a funcionalidade acontecer.
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