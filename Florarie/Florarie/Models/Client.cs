using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florarie.Models
{
    public class Client
    {
        public String Nume { get; set; }
        public String Prenume { get; set; }
        public int Telefon { get; set; }

        public Client(String unNume, String unPrenume, int unNrTelefon)
        {
            this.Nume = unNume;
            this.Prenume = unPrenume;
            this.Telefon = unNrTelefon;
        }
    }
}
