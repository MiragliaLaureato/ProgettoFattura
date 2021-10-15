using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_Fatture
{
    public class HandlerFatture
    {

        private readonly List<Fattura> ListaFatture;

        public HandlerFatture(List<Fattura> listaFatture)
        {
            ListaFatture = listaFatture;
        }


        public void CreaFattura(Intestazione i, Dettagli d)
        {
            Fattura tmp = new Fattura {
            Dettagli = new List<Dettagli> { d },
            Header = i
            };
            Aggiungifattura(tmp);
        }
         
        public void Aggiungifattura(Fattura f)
        {
            ListaFatture.Add(f);
        }


        public List<Fattura> CercaFatturaByNomeCliente(string nome) 
            => ListaFatture
            .Where(
                f => f.Header.Cliente.RagSoc.Equals(nome)
                ).ToList();
    }
}
