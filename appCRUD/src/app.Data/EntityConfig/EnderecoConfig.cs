using System.Data.Entity.ModelConfiguration;
using appCRUD.Dominio.Modelos;

namespace app.Data.EntityConfig
{
    public class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            HasKey(e => e.EnderecoId);

            Property(e => e.Logradouro)
                .IsRequired()
                .HasMaxLength(150);

            Property(e => e.Numero)
                .IsRequired();

            Property(e => e.Bairro)
                .IsRequired()
                .HasMaxLength(50);
            
            Property(e => e.Cep)
                .IsRequired()
                .HasMaxLength(8)
                .IsFixedLength();


            //Endereco pertece a cliente
            // HasOptional() sem pai

            HasRequired(c => c.Usuario)
                .WithMany(e => e.Enderecos)
                .HasForeignKey(c => c.UsuarioId);

            ToTable("Enderecos");



        }
    }
}