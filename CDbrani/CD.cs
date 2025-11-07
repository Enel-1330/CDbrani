using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;

namespace CDbrani
{
    internal class CD
    {
        public string _titolo {get; private set; }
        public string _autore {get; private set; }

        private List<Brano> cd = new List<Brano>();

        public CD(string titolo, string autore, List<Brano> brani) 
        {
            _titolo = titolo;
            _autore = autore;
            cd = brani;
        }

        public string getTitolo()
        {
            return _titolo;
        }

        public void setTitolo(string nuovoTitolo)
        {
            _titolo= nuovoTitolo;
        }

        public string getAutore()
        {
            return _autore;
        }

        public void setAutore(string nuovoAutore)
        {
            _autore = nuovoAutore;
        }

        public override string ToString()
        {
            string listaBrani = "";

            for (int i = 0; i < cd.Count(); i++)
            {
                listaBrani += cd[i]._titolo + ", ";
            }

            return listaBrani;   
        }

        public double Durata()
        {
            double durataTotale = 0;

            for (int i = 0; i < cd.Count(); i++) 
            { 
                durataTotale += cd[i]._durata;
            }
            
            return durataTotale;
        }
    }
}
