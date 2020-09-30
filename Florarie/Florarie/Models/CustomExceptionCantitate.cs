using System;
using System.Runtime.Serialization;

namespace Florarie.Models
{
    class CustomExceptionCantitate : Exception
    {
        public override string Message
        {
            get
            {
                return "Cantitatea trebuie sa fie mai mare ca 0 si mai" +
                    " mica ca 200";
            }
        }
    }
}