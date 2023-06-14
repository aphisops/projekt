using System;

public class Zlecenie 
{

    private string status;
    private Produkt produkt;
    private int ile;


    public Zlecenie (Produkt produkt, int ile) // okreslenie jaki produkt zamawiamy i ile 
    {
        this.produkt = produkt;
        this.ile = ile;
        status = "nowe zamowienie";
    }

    public void Wykonaj()   // zmiana statusu zamowienia
    {
        status = "zamowienie wykonane";
    }
}