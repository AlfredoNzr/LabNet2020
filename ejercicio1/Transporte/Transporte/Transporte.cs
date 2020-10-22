using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    public abstract class Transporte: ITransporte
    {
        private int pasajeros;

        public Transporte(int cantPasajeros)
        {
            this.pasajeros = cantPasajeros;
        }
        public abstract string Avanzar();

        public abstract string Detenerse();

        public int Pasajeros
        {
            get { return this.pasajeros; }
        }
    }
}
