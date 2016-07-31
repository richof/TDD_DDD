using System.Data.Entity.ModelConfiguration;
using Loja_Domain.Entities;

namespace Loja_Infra_Data.EntityConfig
{
    public class LojaProdutoConfig:EntityTypeConfiguration<LojaProduto>
    {
        public LojaProdutoConfig()
        {
            HasKey(lp =>new 
            {
                lp.ProdutoId,
                lp.LojaId
            });
            Property(lp => lp.Quantidade)
                .IsRequired();

        }
    }
}