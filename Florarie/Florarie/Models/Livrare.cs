using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florarie.Models
{
    public class Livrare
    {
        public DateTime DataLivrare { get; set; }
        public String Adresa { get; set; }
        public Client client { get; set; }
        public Comanda comanda { get; set; }

        public Livrare(DateTime oData, String oAdresa, Client unClient, Comanda oComanda)
        {
            this.DataLivrare = oData;
            this.Adresa = oAdresa;
            this.client = unClient;
            this.comanda = oComanda;
        }
        public String DetaliiLivrare()
        {
            return comanda.DetaliiComanda() + "Clientul: " + client.Nume + " " + client.Prenume + " cu nr. de telefon "
                + client.Telefon + " are adresa: " + this.Adresa + ". Comanda trebuie " +
                "livrata in data de " + this.DataLivrare;
        }
    }
}
