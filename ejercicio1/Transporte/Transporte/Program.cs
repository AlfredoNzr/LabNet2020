using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Transporte> ColeccionTransporte = new List<Transporte>();
            Random random = new Random(DateTime.Now.Millisecond);

            for (int i = 1; i <= 10; i++)
                if (i > 5)
                    ColeccionTransporte.Add(new Avion(random.Next(3, 200)));
                else
                    ColeccionTransporte.Add(new Automovil(random.Next(1, 5)));

            string ultimaClase = default;
            int contadorTransporte = default;
            
            foreach (Transporte transporte in ColeccionTransporte)
            {
                if (ultimaClase != transporte.GetType().Name)
                {
                    contadorTransporte = 0;
                    ultimaClase = transporte.GetType().Name;
                }
                
                Console.WriteLine(string.Format("{0} {1}: {2} pasajeros", transporte.GetType().Name,++contadorTransporte, transporte.Pasajeros));
            }

            Console.ReadKey();
        }
    }
}
