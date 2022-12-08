using Biosfera3.Models;
using Microsoft.EntityFrameworkCore;

namespace Biosfera3.Settings
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
        public DbSet<Pesquisador> Pesquisadores { get; set; }
        public DbSet<Sensor> Sensores { get; set; }
        public DbSet<Area> Areas { get; set; }
    }
}
