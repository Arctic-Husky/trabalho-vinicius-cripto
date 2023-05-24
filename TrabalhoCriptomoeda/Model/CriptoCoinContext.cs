using Microsoft.EntityFrameworkCore;

namespace TrabalhoCriptomoeda.Model;

public class CriptoCoinContext : DbContext
{
    public CriptoCoinContext(DbContextOptions<CriptoCoinContext> options) : base(options)
    {
        
    }

    public DbSet<CriptoCoin> CriptoCoinItens { get; set; } = null!;
}