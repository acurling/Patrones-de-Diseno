using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_Diseno.Tipo_3_De_comportamiento
{
    internal class TurnOffCommand : ICommand    
    {
        private readonly Light light;

        public TurnOffCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.TurnOff();
        }
    }
}
