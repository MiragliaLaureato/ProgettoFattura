using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_Fatture
{
    public class Dettagli
    {
        public List<Prodotto> Prodotti { get; set; }

        public Dettagli()
        {
            Prodotti = new List<Prodotto>();
        }


        

        public bool RimuoviProdotto(Prodotto p)
        {
            return false;
        }

        public Prodotto CercaProdottoByString(string id)
        {
            return null; 
        }

        public Prodotto CercaProdotto(Prodotto p)
        {
            return null;
        }

        public bool AggiungiProdotto(Prodotto p)
        {
            return false; 
        }

    }
}
