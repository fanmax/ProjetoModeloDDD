using ProjetoModeloDDD.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Infra.Data.Mapping
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            // Primary Key
            this.HasKey(t => t.ClienteId);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.Sobrenome)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(254);

            // Table & Column Mappings
            this.ToTable("Cliente");
            this.Property(t => t.ClienteId).HasColumnName("ClienteId");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Sobrenome).HasColumnName("Sobrenome");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.DataCadastro).HasColumnName("DataCadastro");
            this.Property(t => t.Ativo).HasColumnName("Ativo");
        }
    }
}
