using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ivanna.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Active { get; set; }
        public string ZipCode { get; set; }
    }
}