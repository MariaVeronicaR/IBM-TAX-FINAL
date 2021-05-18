﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ibm.Services
{
    public class BaseTaxDecorator : Decorator
    {
        public BaseTaxDecorator(ICalculator calculadora) : base(calculadora) { }

        public override decimal Calculate(decimal p) => calculadora.Calculate(p) + p * 0.16m;
    }

}
