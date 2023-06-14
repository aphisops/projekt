using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Wydawnictwo;

    public class Ksiazka
    {
        private string typ, tytul;
	    private Autor autor;	

        public Ksiazka (string typ, Autor autor, string tytul)
        {
            this.typ = typ;
            this.autor = autor;
            this.tytul = tytul;
        }
        public string GetTyp()
        {
            return typ;
        }
        public Autor GetAutor()
        {
            return autor;
        }
       
    }
