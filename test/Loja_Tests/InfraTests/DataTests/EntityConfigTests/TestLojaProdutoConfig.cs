using System.Data.Entity.ModelConfiguration;
using Loja_Domain.Entities;
using Loja_Infra_Data.EntityConfig;
using Xunit;

namespace Loja_Tests.InfraTests.DataTests.EntityConfigTests
{
    public class TestLojaProdutoConfig
    {
        private readonly LojaProdutoConfig _lpConfig;

        public TestLojaProdutoConfig()
        {
            _lpConfig = new LojaProdutoConfig();
        }
        [Fact]
        public void Test_Herda_De_EntityTypeConfiguration_LojaProduto()
        {
            Assert.True(_lpConfig.GetType().IsSubclassOf(typeof(EntityTypeConfiguration<LojaProduto>)));
        } 
    }
}