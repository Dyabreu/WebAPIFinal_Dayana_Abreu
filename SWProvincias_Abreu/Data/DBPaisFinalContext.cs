using Microsoft.EntityFrameworkCore;
using SWProvincias_Abreu.Models;

namespace SWProvincias_Abreu.Data
{
    public class DBPaisFinalContext:DbContext
    {
        public DBPaisFinalContext(DbContextOptions<DBPaisFinalContext> options) : base(options) { }

        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Provincia> Provincias { get; set; }

    }
}
