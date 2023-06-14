using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Wydawnictwo
{
    public class Autor
    {
        public string imie, nazwisko;

        public Autor (string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
        
        public string GetImie()
        {
            return imie;
        }
        public string GetNazwisko()
        {
            return nazwisko;
        }
       
}

}