using System;
using System.Collections.Generic;

namespace Loja_Domain.Entities
{
    public class Loja
    {
        public Guid LojaId { get; set; }
        public string Endereco { get; set; }
        public ICollection<LojaProduto> LojasProdutos { get; set; }

        public Loja()
        {
           LojaId=Guid.NewGuid(); 
            LojasProdutos= new List<LojaProduto>();
        }  
    }
}