using System.Collections.Generic;

namespace InternetShop.Data.Model
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Basket { get; set; }
    }
}
