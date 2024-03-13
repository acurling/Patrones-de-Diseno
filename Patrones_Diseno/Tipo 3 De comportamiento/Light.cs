using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_Diseno.Tipo_3_De_comportamiento
{
    internal class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("La luz está encendida.");
        }

        public void TurnOff()
        {
            Console.WriteLine("La luz está apagada.");
        }
    }
}
