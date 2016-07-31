using System;
using System.Collections.Generic;

namespace Loja_Domain.Entities
{
    public class Categoria
    {
        public Categoria()
        {
            CategoriaId = Guid.NewGuid();
            Produtos = new List<Produto>();
        }

        public Guid CategoriaId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}