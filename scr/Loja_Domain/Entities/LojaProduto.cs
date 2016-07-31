using System;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace Loja_Domain.Entities
{
    public class LojaProduto
    { 
        public Guid ProdutoId { get; set; }
        public Guid LojaId { get; set; }
        public int Quantidade { get; set; }
        public Produto Produto { get; set; }
        public Loja Loja { get; set; }
       
    }
}