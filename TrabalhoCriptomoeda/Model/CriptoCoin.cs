
namespace TrabalhoCriptomoeda.Model;

public class CriptoCoin
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }

    public CriptoCoin()
    {
        Name = "";
        Description = "";
        Price = 0;
    }

    public CriptoCoin(string name, string description, decimal price)
    {
        Name = name;
        Description = description;
        Price = price;
    }

}

