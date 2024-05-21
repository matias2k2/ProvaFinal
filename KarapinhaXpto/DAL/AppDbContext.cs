using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("name=MyConnection")
        {

            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.AutoDetectChangesEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Marcacao>()
               .HasRequired(m => m.Profissional)
               .WithMany(p => p.Marcacoes)
               .HasForeignKey(m => m.ProfissionalId);

            modelBuilder.Entity<Marcacao>()
                  .HasRequired(m => m.Servicos) 
                  .WithMany(s => s.Marcacoes) 
                  .HasForeignKey(m => m.ServicoId);

            modelBuilder.Entity<Marcacao>()
                .HasRequired(m => m.Categorias)
                .WithMany(s => s.Marcacoes)
                .HasForeignKey(m => m.CategoriaId);

            modelBuilder.Entity<Servico>()
              .HasOptional(s => s.Categoria)
              .WithOptionalPrincipal()
              .WillCascadeOnDelete(false);



            base.OnModelCreating(modelBuilder);
            
        }

        public DbSet<Servico> Servicos { get; set; }
        private DbSet<Marcacao> Marcacao { get; set; }
        private DbSet<Profissional> Profissional { get; set; }

        private DbSet<Categoria> Categorias { get; set; }
       
        private DbSet<Usuario> Usuario { get; set; }
    }
}
