using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using app.Data.EntityConfig;
using appCRUD.Dominio.Modelos;

namespace app.Data.Context
{
    public class AppContext : DbContext 
    {
        public AppContext()
            :base ("DefaultConnection")
        {
            
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p=>p.Name == p.ReflectedType.Name + "Id")
                .Configure(p=>p.IsKey());
            modelBuilder.Properties<string>()
                .Configure(p=>p.HasColumnType("varchar"));
            modelBuilder.Properties<string>()
                .Configure(p=>p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new UsuarioConfig());
            modelBuilder.Configurations.Add(new EnderecoConfig());



            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }

            return base.SaveChanges();
        }
    }
}