using System;
using Wydawnictwo;

public class Czasopismo
{
    private string nazwa;

    public Czasopismo (string nazwa)
    {
        this.nazwa = nazwa; 
    }
    public string GetNazwa
    {
        get { return nazwa; }
    }
}