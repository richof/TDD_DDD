using System.Data.Entity.ModelConfiguration;
using Loja_Domain.Entities;

namespace Loja_Infra_Data.EntityConfig
{
    public class ProdutoConfig : EntityTypeConfiguration<Produto>

    {
        public ProdutoConfig()
        {
            HasKey(p => p.ProdutoId);
            Property(p => p.Nome)
                .HasMaxLength(50)
                .IsRequired();
            Property(p => p.Descricao)
                .IsRequired();
            Property(p => p.Imagem)
                .HasMaxLength(300);
            Property(p => p.CategoriaId);
            HasMany(p => p.LojasProdutos).WithOptional(lp => lp.Produto).HasForeignKey(lp => lp.ProdutoId);
            ToTable("Produtos");
        }
    }
}