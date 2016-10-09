using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Webshop
    {
        public List<Product> Products { get; set; }
        public Webshop()
        {
            Products = new List<Product>();
        }
    }
}
