using System.Data.Entity;

namespace InternetShop.DataContext
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }

    internal class InternetShopDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public InternetShopDbContext() : base("name=DefaultConnection")
        {
        }
    }
}
