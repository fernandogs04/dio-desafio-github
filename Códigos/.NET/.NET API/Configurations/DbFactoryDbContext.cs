using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using curso.api.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace curso.api.Configurations
{
    public class DbFactoryDbContext : IDesignTimeDbContextFactory<CursoDbContext>
    {
        public CursoDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CursoDbContext>();
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=CURSO;Trusted_Connection=True");
            CursoDbContext contexto = new CursoDbContext(optionsBuilder.Options);

            return contexto;
        }
    }
}