using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florarie.Models
{
   public abstract class Produs
    {
        
        public String Denumire { get; set; }
        public abstract String DescrieProdus();
    }
}

