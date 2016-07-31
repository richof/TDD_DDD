using System;
using System.Collections.Generic;
using Loja_Domain.Entities;
using Xunit;

namespace Loja_Tests.DomainTests.EntityTest
{
    public class TestLoja
    {
        private readonly Loja _loja;
        private readonly Helpers _helper;
        public TestLoja()
        {
            _loja = new Loja();
            _helper=new Helpers(_loja);

        }

        [Fact]
        public void Test_Loja_Tem_Todas_As_Propriedades()
        {
            Assert.NotNull(_helper.GetInfoDaPropriedade("LojaId"));
            Assert.NotNull(_helper.GetInfoDaPropriedade("Endereco"));
            Assert.NotNull(_helper.GetInfoDaPropriedade("LojasProdutos"));
            Assert.Equal(3,_loja.GetType().GetProperties().Length);
        }

        [Fact]
        public void Test_Loja_Tipos_De_Dados()
        {
            Assert.Equal(typeof(Guid).FullName,_helper.GetNomeDoTipoDaPropriedade("LojaId"));
            Assert.Equal(typeof(string).FullName, _helper.GetNomeDoTipoDaPropriedade("Endereco"));
            Assert.Equal(typeof(ICollection<LojaProduto>).FullName, _helper.GetNomeDoTipoDaPropriedade("LojasProdutos"));
           
        }
        [Fact]
        public void Test_Loja_Metodos_Acessores()
        {
            Assert.NotNull(_helper.GetInfoDaPropriedade("LojaId").CanWrite && _helper.GetInfoDaPropriedade("LojaId").CanRead);
            Assert.NotNull(_helper.GetInfoDaPropriedade("Endereco").CanWrite && _helper.GetInfoDaPropriedade("Endereco").CanRead);
            Assert.NotNull(_helper.GetInfoDaPropriedade("LojasProdutos").CanWrite && _helper.GetInfoDaPropriedade("LojasProdutos").CanRead);

        }
        [Fact]
        public void Test_LojaId_Inicializa_No_Construtor()
        {
            var lojaNova = new Loja();
            Assert.NotEqual(Guid.Empty, _helper.GetValorDaPropriedade(lojaNova, "LojasProdutos"));
        }
        [Fact]
        public void Test_LojasProdutos_Inicializa_No_Construtor()
        {
            var lojaNova = new Loja();
            Assert.NotNull(_helper.GetValorDaPropriedade(lojaNova,"LojasProdutos"));
        }
    }
}