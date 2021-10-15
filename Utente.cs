using System;

namespace Progetto_Fatture
{
    public class Utente
    {

        public string ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Ruolo Work { get; set; }

        public Utente(string id, string name, string surname, Ruolo ruolo)
        {
            ID = id;
            Name = name;
            Surname = surname;
            Work = ruolo; 
        }

        public enum Ruolo
        {
            dirigente,
            dipendente,
            operaio,
            macchinista,
            fornitore
    }

}
}
