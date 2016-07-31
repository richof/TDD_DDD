using System;
using System.Linq;
using Loja_Domain.Entities;
using Xunit;

namespace Loja_Tests.DomainTests.EntityTest
{
    public class TestLojaProduto
    {
        private readonly LojaProduto _lp;
        private readonly Helpers helper;
        public TestLojaProduto()
        {
            _lp = new LojaProduto();
            helper=new Helpers(_lp);
        }

        [Fact]
        public void Test_LojaProduto_Tem_Todas_As_Propriedades()
        {
            Assert.NotNull(helper.GetInfoDaPropriedade("ProdutoId"));
            Assert.NotNull(helper.GetInfoDaPropriedade("LojaId"));
            Assert.NotNull(helper.GetInfoDaPropriedade("Quantidade"));
            Assert.NotNull(helper.GetInfoDaPropriedade("Produto"));          
            Assert.NotNull(helper.GetInfoDaPropriedade("Loja"));
            Assert.Equal(5,_lp.GetType().GetProperties().Length);
        }

        [Fact]
        public void Test_LojaProduto_Tipos_De_Dados()
        {
            Assert.Equal(typeof(Guid).FullName,helper.GetNomeDoTipoDaPropriedade("ProdutoId"));
            Assert.Equal(typeof(Guid).FullName, helper.GetNomeDoTipoDaPropriedade("LojaId"));
            Assert.Equal(typeof(Produto).FullName, helper.GetNomeDoTipoDaPropriedade("Produto"));
            Assert.Equal(typeof(int).FullName, helper.GetNomeDoTipoDaPropriedade("Quantidade"));
            Assert.Equal(typeof(Loja).FullName, helper.GetNomeDoTipoDaPropriedade("Loja"));

        }

        public void Test_LojaProduto_Metodos_Acessores()
        {
            Assert.NotNull(helper.GetInfoDaPropriedade("ProdutoId").CanRead && helper.GetInfoDaPropriedade("ProdutoId").CanWrite);
            Assert.NotNull(helper.GetInfoDaPropriedade("LojaId").CanRead && helper.GetInfoDaPropriedade("LojaId").CanWrite);
            Assert.NotNull(helper.GetInfoDaPropriedade("Quantidade").CanRead && helper.GetInfoDaPropriedade("Quantidade").CanWrite);
            Assert.NotNull(helper.GetInfoDaPropriedade("Produto").CanRead && helper.GetInfoDaPropriedade("Produto").CanWrite);
            Assert.NotNull(helper.GetInfoDaPropriedade("Loja").CanRead && helper.GetInfoDaPropriedade("Loja").CanWrite);
        }
    }
}