using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using curso.api.Buisiness.Entities;
using curso.api.Infraestructure.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace curso.api.Infraestructure.Data
{
    public class CursoDbContext : DbContext
    {
        public CursoDbContext(DbContextOptions<CursoDbContext> options) :base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CursoMapping());
            modelBuilder.ApplyConfiguration(new UsuarioMapping());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Usuario> Usuario { get; set; }
    }
}