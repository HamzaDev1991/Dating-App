using API_DatingApp.Entites;
using Microsoft.EntityFrameworkCore;

namespace API_DatingApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public virtual DbSet<AppUser> TbUsers { get; set; }

    }
}
