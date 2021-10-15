using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_Fatture
{
    public class Prodotto
    {

        public string ID { get; set; }
        public string Nome { get; set; }
        public string Descr { get; set; }
        public double Price { get; set; }
        public double IVA { get; set; }


    public Prodotto(string id, string nome, string descr, double price, double iva)
        {
            ID = id;
            Nome = nome;
            Descr = descr;
            Price = price;
            IVA = iva; 
        }
        

    }
}
