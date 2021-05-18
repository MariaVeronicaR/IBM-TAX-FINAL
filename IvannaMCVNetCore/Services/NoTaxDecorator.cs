using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ibm.Services
{
    public class NoTaxDecorator : Decorator
    {
        public NoTaxDecorator(ICalculator calculadora) : base(calculadora) { }
        public override decimal Calculate(decimal p) => calculadora.Calculate(p);
    }
}
