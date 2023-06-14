using System.Collections.Generic;   

public class Drukarnia
{
    public bool albumy;
    private List<Zlecenie> zlecenia;

    public Drukarnia(Produkt produkt) // sprawdzanie czy zamawiamy albumy, tworzenie listy zlecen
    {
        if (produkt.nazwa == "albumy")
        {
            albumy = true;
        }
        zlecenia = new List<Zlecenie>();
    }
    public void DodajZlecenie(Zlecenie zlecenie) // dodanie zlecenia do listy
    {
        zlecenia.Add(zlecenie);
    }

    public void WykonajZlecenie(Zlecenie zlecenie)
    {
          
        if (albumy != true)
        {
            zlecenie.Wykonaj();
        }
        else 
        {
            
        }
    }
}