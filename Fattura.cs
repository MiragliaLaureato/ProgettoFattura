using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_Fatture
{
    public class Fattura
    {

        public Intestazione Header { get; set; }
        public List<Dettagli> Dettagli { get; set; }

        public Dettagli CercaDettagli(string id)
        {
            return null; 
        }

        public bool UpdateDettagli(Dettagli d)
        {
            return false; 
        }

        public bool AggiungiDettagli(Dettagli d)
        {
            return false; 
        }

        public bool RimuoviDettagli(string id)
        {
            return false;
        }




    }
}
