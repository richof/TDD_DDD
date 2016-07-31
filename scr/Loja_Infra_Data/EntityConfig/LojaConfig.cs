using System.Data.Entity.ModelConfiguration;
using Loja_Domain.Entities;

namespace Loja_Infra_Data.EntityConfig
{
    public class LojaConfig : EntityTypeConfiguration<Loja>
    {
        public LojaConfig()
        {
            HasKey(l => l.LojaId);
            Property(l => l.Endereco)
                .HasMaxLength(50)
                .IsRequired();
            HasMany(l => l.LojasProdutos).WithOptional(lp => lp.Loja).HasForeignKey(lp => lp.LojaId);
        }
    }
}