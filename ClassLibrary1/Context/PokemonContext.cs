using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class PokemonContext : DbContext
    {
        public DbSet<Pokemon> Pokemon { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Port=5440; Database=postgres; UserId=postgres; Password=123456");
        }
    }
}
