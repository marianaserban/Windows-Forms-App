using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florarie.Models
{
    public class Floare : Produs
    {
        public TipFloare Tip { get; set; }
        public int Pret { get; set; }

        public override string DescrieProdus()
        {
            return "Produsul " + this.Denumire + " contine flori de tipul: " +
                this.Tip;
        }

        public Floare(String oDenumire, TipFloare unTip, int unPret)
        {
            this.Denumire = oDenumire;
            this.Tip = unTip;
            this.Pret = unPret;
        }
    }
}
