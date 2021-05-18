using System.Web.Mvc;

namespace Ivanna.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public TaxType TaxType { get; set; }
        public ProductZone Zone { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Tax { get; set; }
    }

}