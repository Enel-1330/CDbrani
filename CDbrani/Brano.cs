using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranoCD
{
    internal class Brano
    {
        public string _titolo 
        {
            get
            {
                return _titolo;
            }
            private set
            {
                _titolo = value;
            }
        }
        public string _autore
        {
            get
            {
                return _autore;
            }
            private set
            {
                _autore = value;

            }
        }
        public double _durata
        {
            get { return _durata; }

            private set
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
            string durata = _durata.ToString();
            return _autore + _titolo + durata;
        }

        public bool shortSong (double durata)
        {
            return (durata < _durata);
        }

    }
}
