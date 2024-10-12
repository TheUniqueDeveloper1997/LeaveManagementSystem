using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { 
                    Id= "95df01df-0207-4e91-8317-5ca19706d6d7",
                    Name = "Employee",
                    NormalizedName= "EMPLOYEE"
                }, 
                new IdentityRole {
                    Id = "e86df6b4-4cbf-49b5-a9c3-d4476ca8a5b3",
                    Name = "Supervisor",
                    NormalizedName = "SUPERVISOR"
                }, 
                new IdentityRole {
                    Id = "a52d797b-d8a4-4cc3-a52b-8b56628f7925",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                }
            );
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = "9c9dc2b8-239a-41c8-a9e9-7913048d8a5a",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                UserName = "admin@localhost.com",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true,
                FirstName = "Default",
                LastName = "Admin",
                DateOfBirth = new DateOnly(1950,12,01)
            });
            builder.Entity<IdentityUserRole<string>>().HasData(
                    new IdentityUserRole<string>
                    {
                        RoleId = "a52d797b-d8a4-4cc3-a52b-8b56628f7925",
                        UserId = "9c9dc2b8-239a-41c8-a9e9-7913048d8a5a"
                    }
            );
        }
        public DbSet<LeaveType> LeaveTypes { get; set; }

    }
}
