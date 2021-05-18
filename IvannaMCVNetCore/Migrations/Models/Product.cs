using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Ibm.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public TaxType TaxType { get; set; }
        public ProductZone Zone { get; set; }
        [DefaultValue("true")]
        public bool Discount { get; set; }
        public decimal? Tax { get; set; }

        internal void Deconstruct(out decimal price, out TaxType taxType, out ProductZone zone, out bool discount)
        {
            price = Price;
            taxType = TaxType;
            zone = Zone;
            discount = Discount;
        }
    }
}
