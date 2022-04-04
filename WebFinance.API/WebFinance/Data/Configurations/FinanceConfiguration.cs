using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebFinance.Models;

namespace WebFinance.Data.Configurations
{
    public class FinanceConfiguration : IEntityTypeConfiguration<Financa>
    {
        public void Configure(EntityTypeBuilder<Financa> builder)
        {
            throw new NotImplementedException();
        }
    }
}
