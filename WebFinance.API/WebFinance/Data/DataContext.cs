using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebFinance.Models;

namespace WebFinance.Data
{
    public class DataContext : DbContext
    {
        private readonly DataContext _context;

        public DataContext(DataContext context)
        {
            _context = context;
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DataContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("data source=LUCASCRUZ\\SQLEXPRESS;Database=Finance;User Id=sa;Password=869256;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<Financa> Financas { get; set; }

        public IEnumerable<Pessoa> GetPessoas()
        {
            return Pessoas;
        }
    }
}
