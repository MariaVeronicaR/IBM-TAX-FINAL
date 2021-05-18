using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ibm.Services
{
    public class DiscountDecorator : Decorator
    {

        public DiscountDecorator(ICalculator calculadora) : base(calculadora) { }

        //Utilice 10% de descuento como ejemplo
        public override decimal Calculate(decimal p) => calculadora.Calculate(p) - p * 0.10m;

    }

}
