using System.Collections.Generic;

public class UmowaOPrace
{
    private List<Produkt> produkty;

    public UmowaOPrace()
    {
        produkty = new List<Produkt>();
    }

    public void DodajProdukt(Produkt produkt)
    {
        produkty.Add(produkt);
    }

    public void UsunProdukt(Produkt produkt)
    {
        produkty.Remove(produkt);
    }

    public List<Produkt> GetProdukty()
    {
        return produkty;
    }
}