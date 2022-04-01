using Microsoft.EntityFrameworkCore;
using WebFinance.Models;

namespace WebFinance.Data
{
    public class DataContext : DbContext
    {
        private readonly DataContext _context;

        public DataContext()
        {
        }


        public DataContext(DataContext context)
        {
            _context = context;
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

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
        public DbSet<Pessoa> Pessoa { get; set; }

        public DbSet<Financa> Financa { get; set; }

        public IEnumerable<Pessoa> GetPessoas()
        {
            return Pessoa;
        }

        public IEnumerable<Financa> GetFinanca()
        {
            return Financa;
        }
    }
}
