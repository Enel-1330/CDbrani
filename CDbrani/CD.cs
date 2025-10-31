using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDbrani
{
    internal class CD
    {
        public string _titolo { get; private set; }
        public string _autore { get; private set; }
        

        public CD(string titolo, string autore) 
        {
            List<Brano> cd = new List<Brano>();
            _titolo = titolo;
            _autore = autore;
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
            foreach () { }
        }

    }
}
