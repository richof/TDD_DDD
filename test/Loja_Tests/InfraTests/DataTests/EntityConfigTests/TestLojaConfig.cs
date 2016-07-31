using System.Data.Entity.ModelConfiguration;
using Loja_Domain.Entities;
using Loja_Infra_Data.EntityConfig;
using Xunit;

namespace Loja_Tests.InfraTests.DataTests.EntityConfigTests
{
    public class TestLojaConfig
    {
        private readonly LojaConfig _lojaConf;

        public TestLojaConfig()
        {
            _lojaConf = new LojaConfig();
        }

       
        [Fact]
        public void Test_Herda_De_EntityTypeConfiguration_Loja()
        {
            Assert.True(_lojaConf.GetType().IsSubclassOf(typeof(EntityTypeConfiguration<Loja>)));
            
        } 
    }
}