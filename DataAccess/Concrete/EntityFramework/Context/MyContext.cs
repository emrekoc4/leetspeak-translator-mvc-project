using Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class MyContext : IdentityDbContext<AppUser,AppRole,string>  //Inheriting from identitydbcontext in the context class, makes possible to use AspNetCoreIdentity's features
    {
        public MyContext()
        {

        }
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-HPVI9J8\\SQLEXPRESS;Database=LeetSpeakDatabase;Trusted_Connection=True;");
        }

        public virtual DbSet<UserContentsDto> UserContentsDtos { get; set; }
        public virtual DbSet<Contents> Contents { get; set; }
    }
    }

