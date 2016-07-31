using System;
using System.Collections.Generic;
using Loja_Domain.Entities;
using Xunit;

namespace Loja_Tests.DomainTests.EntityTest
{
    public class TestCategoria
    {
        private readonly Categoria _categoria;
        private readonly Helpers _helper;

        public TestCategoria()
        {
            _categoria = new Categoria();
            _helper = new Helpers(_categoria);
        }

        [Fact]
        public void Test_Acesso_Publico_Categoria()
        {
            Assert.True(_categoria.GetType().IsPublic);
        }

        [Fact]
        public void Test_Categoria_Tem_Todas_As_Propriedades()
        {
            Assert.NotNull(_helper.GetInfoDaPropriedade("CategoriaId"));
            Assert.NotNull(_helper.GetInfoDaPropriedade("Nome"));
            Assert.NotNull(_helper.GetInfoDaPropriedade("Descricao"));
            Assert.NotNull(_helper.GetInfoDaPropriedade("Produtos"));
        }

        [Fact]
        public void Test_Categoria_Tipos_De_Dados()
        {
            Assert.Equal(typeof (Guid).FullName, _helper.GetNomeDoTipoDaPropriedade("CategoriaId"));
            Assert.Equal(typeof (string).FullName, _helper.GetNomeDoTipoDaPropriedade("Nome"));
            Assert.Equal(typeof (string).FullName, _helper.GetNomeDoTipoDaPropriedade("Descricao"));
            Assert.Equal(typeof(ICollection<Produto>).FullName, _helper.GetNomeDoTipoDaPropriedade("Produtos"));
        }

        public void Test_Metodos_Acessores_Propriedades()
        {
            Assert.True(_helper.GetInfoDaPropriedade("CategoriaId").CanRead &&
                        _helper.GetInfoDaPropriedade("CategoriaId").CanWrite);
            Assert.True(_helper.GetInfoDaPropriedade("Nome").CanRead && _helper.GetInfoDaPropriedade("Nome").CanWrite);
            Assert.True(_helper.GetInfoDaPropriedade("Descricao").CanRead &&
                        _helper.GetInfoDaPropriedade("Descricao").CanWrite);
            Assert.True(_helper.GetInfoDaPropriedade("Produtos").CanRead &&
                        _helper.GetInfoDaPropriedade("Produtos").CanWrite);
        }

        [Fact]
        public void Test_IdCategoria_Inicializa_No_Construtor()
        {
            var categoriaNova = new Categoria();
            Assert.NotEqual(Guid.Empty, _helper.GetValorDaPropriedade(categoriaNova, "CategoriaId"));
        }

        [Fact]
        public void Test_Produtos_Inicializa_No_Construtor()
        {
            Assert.NotNull(_helper.GetValorDaPropriedade(_categoria, "Produtos"));
        }

        #region helpers

        #endregion
    }
}