//using System.Reflection;

//using Domain;

//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;

//namespace Database
//{
//    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
//    {
//        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
//        {
//        }

//        public DbSet<AppModel> AppModels { get; set; }
//        public DbSet<DevUser> DevUser { get; set; }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            base.OnModelCreating(modelBuilder);

//            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
//        }
//    }
//}
