using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    public class Avion : Transporte
    {
        public Avion(int cantPasajeros) : base(cantPasajeros)
        {

        }
        public override string Avanzar()
        {
            return "Avion avanzando";
        }

        public override string Detenerse()
        {
            return "Avion deteniendose";
        }
    }
}
