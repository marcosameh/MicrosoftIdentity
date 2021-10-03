using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicrosoftIdentity.Data
{
    public partial class JoinsContext : IdentityDbContext<ApplicationUser>
    {
        public override DbSet<ApplicationUser> Users { get; set; }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {

            var entity = modelBuilder.Entity<ApplicationUser>();

            entity.Property(e => e.CareerStarted)
           .IsRequired(false);

            entity.Property(e => e.Photo)
           .IsRequired(false);



            base.OnModelCreating(modelBuilder);


        }
    }
}
