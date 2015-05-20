using ProjetoModeloDDD.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Infra.Data.Mapping
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            // Primary Key
            this.HasKey(t => t.ProdutoId);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("Produto");
            this.Property(t => t.ProdutoId).HasColumnName("ProdutoId");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Valor).HasColumnName("Valor");
            this.Property(t => t.Disponivel).HasColumnName("Disponivel");
            this.Property(t => t.ClienteId).HasColumnName("ClienteId");

            // Relationships
            this.HasRequired(t => t.Cliente)
                .WithMany(t => t.Produtos)
                .HasForeignKey(d => d.ClienteId);

        }
    }
}
