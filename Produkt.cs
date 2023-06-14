public class Produkt
{
    private string stan;

    public Produkt(string stan)
    {
        this.stan = stan;
    }

    public void zmienStan(string nowyStan)
    {
        stan = nowyStan;
    }

    public string PobierzStan()
    {
        return stan;
    }
}