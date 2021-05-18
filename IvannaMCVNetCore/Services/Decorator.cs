using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ibm.Services
{
    public abstract class Decorator : ICalculator
    {
        protected ICalculator calculadora;

        public Decorator(ICalculator calculadora)
        {
            this.calculadora = calculadora;
        }

        public virtual decimal Calculate(decimal p) => calculadora.Calculate(p);
    }
}
