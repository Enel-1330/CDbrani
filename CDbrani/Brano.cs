using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranoCD
{
    internal class Brano
    {
        public string _titolo { get; set; }
        public string _autore { get; set; }
        public double _durata
        {
            get { return _durata; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("non puoi inserire una durata negativa");
                }
                else
                {
                    _durata = value;
                }
                _durata = value;
            }
        }

        public Brano(string titolo, string autore, double durata)
        {
            _titolo = titolo;
            _autore = autore;
            _durata = durata;

        }
        public string toString()
        {
            return _titolo;
        }

        public string GetTitolo()
        {
            return _titolo;
        }

        public double GetDurata()
        {
            return _durata;
        }
        public string GetAutore()
        {
            return _autore;
        }

        public string SetTitolo(string titolo)
        {
            _titolo = titolo;
            return _titolo;
        }

        public string SetAutore(string autore)
        {
            _autore = autore;
            return _autore;
        }

        public double SetDurata(double durata)
        {
            _durata = durata;
            return _durata;
        }


    }
}
