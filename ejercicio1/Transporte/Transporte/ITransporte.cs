using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    public interface ITransporte
    {
        int Pasajeros
        {
            get;
        }
        string Avanzar();

        string Detenerse();

    }
}
