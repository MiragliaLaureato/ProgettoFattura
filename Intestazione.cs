using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_Fatture
{
    public class Intestazione
    {
        public Utente Utente { get; set; }
        public Cliente Cliente { get; set; }
        public int NumeroFattura { get; set; }
        public DateTime DataFattura { get; set; }
        public double Totale { get; set; }

        public Intestazione(Utente utente, Cliente cliente,DateTime data, int numfatt)
        {
            Utente = utente;
            Cliente = cliente;
            DataFattura = data;
            NumeroFattura = numfatt;
            Totale = 0; 
        }

        public void CalcolaTotale()
        {

        }





    }
}
