using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_12E_EF_CF
{
    class EscuelaContext:DbContext
    {
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Curso> Cursos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { 
            optionsBuilder.UseSqlServer(@"Server=A-PROFH-360;Database=EscuelaDBCF12E;Trusted_Connection=True;"); }
    }
}
