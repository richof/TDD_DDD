using System;
using Loja_Domain.Entities;
using Loja_Infra_Data.EntityConfig;
using Xunit;
using System.Data.Entity.ModelConfiguration;


namespace Loja_Tests.InfraTests.DataTests.EntityConfigTests
{
    public class TestCategoriaConfig
    {
        private CategoriaConfig catConf;
        public TestCategoriaConfig()
        {
            catConf = new CategoriaConfig();
        }
        [Fact]
        public void Test_Acesso_Publico_CategoriaConfig()
        {
            Assert.True(catConf.GetType().IsPublic);

        }

        [Fact]
        public void Test_Herda_De_EntityTypeConfiguration_Categoria()
        {
           Assert.True(catConf.GetType().IsSubclassOf(typeof (EntityTypeConfiguration<Categoria>)));
        }

       
       
    }
}