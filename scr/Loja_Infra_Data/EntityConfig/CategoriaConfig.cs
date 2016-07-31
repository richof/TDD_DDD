using System.Data.Entity.ModelConfiguration;
using Loja_Domain.Entities;

namespace Loja_Infra_Data.EntityConfig
{
    public class CategoriaConfig:EntityTypeConfiguration<Categoria>
    {
        public CategoriaConfig()
        {
            HasKey(c => c.CategoriaId);
            Property(c => c.Nome)
                .HasMaxLength(50)
                .IsRequired();
            Property(c => c.Descricao)
                .HasMaxLength(100);
            HasMany<Produto>(c => c.Produtos).WithOptional(p => p.Categoria).HasForeignKey(p => p.CategoriaId);
            ToTable("Categorias");
        }
    }
}