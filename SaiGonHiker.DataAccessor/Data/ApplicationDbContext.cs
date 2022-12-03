using SaiGonHiker.DataAccessor.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SaiGonHiker.DataAccessor.Data.Seeds;

namespace SaiGonHiker.DataAccessor.Data
{
    public class ApplicationDbContext : IdentityDbContext<Users, IdentityRole<int>, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.SeedTourData();
            builder.SeedUserData();
            builder.SeedRolesData();
            builder.SeedUserRolesData();
            base.OnModelCreating(builder);

            builder.Entity<Users>(entity =>
            {
                entity.ToTable(name: "Users");
                entity.Property(users => users.Id).ValueGeneratedOnAdd();
            });

            builder.Entity<IdentityRole<int>>(entity =>
            {
                entity.ToTable(name: "Roles");
                entity.Property(roles => roles.Id).ValueGeneratedOnAdd();
            });

            builder.Entity<IdentityUserRole<int>>(entity =>
            {
                entity.ToTable("UserRoles");
            });

            builder.Entity<IdentityUserClaim<int>>(entity =>
            {
                entity.ToTable("UserClaims");
                entity.Property(userClaims => userClaims.Id).ValueGeneratedOnAdd();
            });

            builder.Entity<IdentityRoleClaim<int>>(entity =>
            {
                entity.ToTable("RoleClaims");
                entity.Property(roleClaims => roleClaims.Id).ValueGeneratedOnAdd();
            });

            builder.Entity<Tour>(entity =>
            {
                entity.ToTable(name: "Tour");
                entity.Property(tour => tour.Id).ValueGeneratedOnAdd();
                entity.HasQueryFilter(e => !e.IsDelete);
            });
        }
    }
}