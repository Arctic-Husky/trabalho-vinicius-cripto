namespace TrabalhoCriptomoeda.Model;

public class CriptoWallet
{
    public int ID { get; set; }
    public string Owner { get; set; }
    public List<int> Coin_ID { get; set; }

    public CriptoWallet()
    {
        Owner = "";
    }

    public CriptoWallet(string owner)
    {
        Owner = owner;
    }
}