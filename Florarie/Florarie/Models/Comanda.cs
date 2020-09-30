using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Florarie.Models
{
    public class Comanda
    {
        public Floare floare { get; set; }
        public String Modalitate { get; set; }
        private int _cantitate;
        public int Cantitate
        {
            get
            {
                return _cantitate;
            }

            set
            {
                if (value <=0 || value > 200)
                {
                    throw new CustomExceptionCantitate();
                }
                _cantitate = value;
            }
        }


        public Comanda(Floare oFloare, String oModalitate, int oCantitate)
        {
            this.floare = oFloare;
            this.Modalitate = oModalitate;
            this.Cantitate = oCantitate;
        }

        public string DetaliiComanda()
        {
            return "Comanda plasata: " + floare.DescrieProdus() + ". Modalitatea de plata: "
                + this.Modalitate + ". Cantitate: " + this.Cantitate;
        }
    }

}

