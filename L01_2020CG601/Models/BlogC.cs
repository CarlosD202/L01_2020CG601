using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Collections.Generic;

namespace L01_2020CG601.Models
{
    public class blogC : DbContext
    {
        public blogC(DbContextOptions<blogC> options) : base(options)
        {

        }
        public DbSet<usuarios> usuarios { get; set; }
        public DbSet<calificaciones> calificaciones { get; set; }

        public DbSet<comentarios> comentarios { get; set; }
    }
}
