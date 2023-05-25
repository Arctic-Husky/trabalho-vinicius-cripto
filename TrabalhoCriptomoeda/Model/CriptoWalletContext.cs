using Microsoft.EntityFrameworkCore;

namespace TrabalhoCriptomoeda.Model;

public class CriptoWalletContext : DbContext
{
    public CriptoWalletContext(DbContextOptions<CriptoWalletContext> options) : base(options)
    {
        
    }

    public DbSet<CriptoWallet> CriptoWalletItens { get; set; } = null!;
}