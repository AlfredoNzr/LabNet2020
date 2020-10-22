using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    public class Automovil : Transporte
    {
        public Automovil(int cantPasajeros) : base(cantPasajeros)
        {

        }
        public override string Avanzar()
        {
            return "Automovil avanzando";
        }

        public override string Detenerse()
        {
            return "Automovil deteniendose";
        }
    }
}
