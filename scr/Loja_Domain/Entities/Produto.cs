using System;
using System.Collections.Generic;

namespace Loja_Domain.Entities
{
    public class Produto
    {
        public Produto()
        {
            ProdutoId = Guid.NewGuid();
        }

        public Guid ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string Imagem { get; set; }
        public Guid CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
        public  ICollection<LojaProduto> LojasProdutos { get; set; }
    }
}