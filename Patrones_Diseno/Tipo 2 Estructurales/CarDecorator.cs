using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_Diseno.Tipo_2_Estructurales
{
    internal class CarDecorator : ICar
    {
        private readonly ICar car;

        public CarDecorator(ICar car)
        {
            this.car = car;
        }

        public virtual string GetDescription()
        {
            return car.GetDescription();
        }
    }
}
