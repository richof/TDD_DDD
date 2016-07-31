using System.Data.Entity.ModelConfiguration;
using Loja_Domain.Entities;
using Loja_Infra_Data.EntityConfig;
using Xunit;

namespace Loja_Tests.InfraTests.DataTests.EntityConfigTests
{
    public class TestProdutoConfig
    {
        private readonly ProdutoConfig _pConfig;

        public TestProdutoConfig()
        {
            _pConfig = new ProdutoConfig();
        }
        [Fact]
        public void Test_Herda_De_EntityTypeConfiguration_Produto()
        {
            Assert.True(_pConfig.GetType().IsSubclassOf(typeof(EntityTypeConfiguration<Produto>)));
        }  
    }
}