using Microsoft.EntityFrameworkCore;

namespace TrabalhoCriptomoeda.Model;

public class CriptoCoinContext : DbContext
{
    private static bool _alreadyAdded = false;
    public CriptoCoinContext(DbContextOptions<CriptoCoinContext> options) : base(options)
    {
        if(!_alreadyAdded)
            AddInitialCoins();
    }

    public DbSet<CriptoCoin> CriptoCoinItens { get; set; } = null!;

    private void AddInitialCoins()
    {
        CriptoCoinItens.Add(new CriptoCoin("BitCoin", "Coin dos Bits", 10));
        CriptoCoinItens.Add(new CriptoCoin("Spacebux", "Cripto estelar", 20));
        CriptoCoinItens.Add(new CriptoCoin("Dobrões", "Coin de piratas, para piratas", 30));
        SaveChanges();
        
        _alreadyAdded = true;
    }
}