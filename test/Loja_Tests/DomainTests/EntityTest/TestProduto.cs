using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using Loja_Domain.Entities;
using Xunit;

namespace Loja_Tests.DomainTests.EntityTest
{
    public class TestProduto
    {
        private readonly Helpers _helper;
        private readonly Produto _produto;

        public TestProduto()
        {
            _produto = new Produto();
            _helper = new Helpers(_produto);
        }

        [Fact]
        public void Test_Acesso_Publico_Produto()
        {
            Assert.True(_produto.GetType().IsPublic);
        }

        [Fact]
        public void Test_Produto_Tem_Todas_As_Propriedades()
        {
            Assert.NotNull(_helper.GetInfoDaPropriedade("ProdutoId"));
            Assert.NotNull(_helper.GetInfoDaPropriedade("Nome"));
            Assert.NotNull(_helper.GetInfoDaPropriedade("Descricao"));
            Assert.NotNull(_helper.GetInfoDaPropriedade("Preco"));
            Assert.NotNull(_helper.GetInfoDaPropriedade("Imagem"));
            Assert.NotNull(_helper.GetInfoDaPropriedade("CategoriaId"));
            Assert.NotNull(_helper.GetInfoDaPropriedade("Categoria"));
            Assert.NotNull(_helper.GetInfoDaPropriedade("LojasProdutos"));
        }

        [Fact]
        public void Test_Produto_Tipos_De_Dados()
        {
            Assert.Equal(typeof (Guid).FullName, _helper.GetNomeDoTipoDaPropriedade("ProdutoId"));
            Assert.Equal(typeof (string).FullName, _helper.GetNomeDoTipoDaPropriedade("Nome"));
            Assert.Equal(typeof (string).FullName, _helper.GetNomeDoTipoDaPropriedade("Descricao"));
            Assert.Equal(typeof(decimal).FullName,_helper.GetNomeDoTipoDaPropriedade("Preco"));
            Assert.Equal(typeof (string).FullName, _helper.GetNomeDoTipoDaPropriedade("Imagem"));
            Assert.Equal(typeof (Guid).FullName, _helper.GetNomeDoTipoDaPropriedade("CategoriaId"));
            Assert.Equal(typeof (Categoria).FullName, _helper.GetNomeDoTipoDaPropriedade("Categoria"));
            Assert.Equal(typeof(ICollection<LojaProduto>).FullName,_helper.GetNomeDoTipoDaPropriedade("LojasProdutos"));
        }

        [Fact]
        public void Test_Metodos_Acessores_Propriedades()
        {
            Assert.True(_helper.GetInfoDaPropriedade("ProdutoId").CanRead &&
                        _helper.GetInfoDaPropriedade("ProdutoId").CanWrite);
            Assert.True(_helper.GetInfoDaPropriedade("Nome").CanRead && _helper.GetInfoDaPropriedade("Nome").CanWrite);
            Assert.True(_helper.GetInfoDaPropriedade("Descricao").CanRead &&
                        _helper.GetInfoDaPropriedade("Descricao").CanWrite);
            Assert.True(_helper.GetInfoDaPropriedade("Imagem").CanRead &&
                        _helper.GetInfoDaPropriedade("Imagem").CanWrite);
            Assert.True(_helper.GetInfoDaPropriedade("CategoriaId").CanRead &&
                        _helper.GetInfoDaPropriedade("CategoriaId").CanWrite);
            Assert.True(_helper.GetInfoDaPropriedade("Categoria").CanRead &&
                        _helper.GetInfoDaPropriedade("Categoria").CanWrite);
        }

        [Fact]
        public void Test_IdProduto_Inicializa_No_Construtor()
        {
            var produto = new Produto();
            Assert.NotEqual(Guid.Empty, _helper.GetValorDaPropriedade(produto, "ProdutoId"));
        }

        #region helpers

        #endregion
    }
}