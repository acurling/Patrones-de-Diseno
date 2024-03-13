using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_Diseno.Tipo_2_Estructurales
{
    internal class LuxuryCar : CarDecorator
    {
        public LuxuryCar(ICar car) : base(car) { }

        public override string GetDescription()
        {
            return base.GetDescription() + ", con características de lujo";
        }
    }
}
