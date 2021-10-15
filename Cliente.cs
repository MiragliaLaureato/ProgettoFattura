using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_Fatture
{
    public class Cliente
    {

        public string ID { get; set; }
        public string RagSoc { get; set; }
        public string PIva { get; set; }
        public string Indirizzo { get; set; }

        public Cliente(string id, string rag, string piva, string ind)
        {
            ID = id;
            RagSoc = rag;
            PIva = piva;
            Indirizzo = ind; 
        }


    }
}
