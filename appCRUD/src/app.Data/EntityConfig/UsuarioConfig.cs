using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using appCRUD.Dominio.Modelos;

namespace app.Data.EntityConfig
{
    public class UsuarioConfig : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfig()
        {
            HasKey(c => c.Id);
            Property(c => c.Id)
                .HasColumnName("UsuarioId");

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);
               
            Property(c => c.CPF)
                .IsRequired()
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnAnnotation("Index", new IndexAnnotation(
                    new IndexAttribute("IX_CPF") {IsUnique = true}));

            Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.DataNascimento)
                .IsRequired();

            Property(c => c.Ativo)
                .IsRequired();

            Property(c => c.Excluido)
               .IsRequired();

            ToTable("Usuarios");

        }
    }
}