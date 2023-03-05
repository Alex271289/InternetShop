using InternetShop.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace InternetShop.Data
{
    public class ShopContext : DbContext
    {

        DbSet<Product> products;
        DbSet<Client> clients;
    }
}
