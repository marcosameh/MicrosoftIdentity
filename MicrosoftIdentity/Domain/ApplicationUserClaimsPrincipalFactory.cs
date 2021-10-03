using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MicrosoftIdentity.Domain
{
    public class ApplicationUserClaimsPrincipalFactory:UserClaimsPrincipalFactory<ApplicationUser,IdentityRole>
    {
        public ApplicationUserClaimsPrincipalFactory(UserManager<ApplicationUser>userManager,RoleManager<IdentityRole> roleManager,IOptions<IdentityOptions>options):base(userManager,roleManager,options)
        {
                
        }
        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(ApplicationUser user)
        {
            var Identity = await base.GenerateClaimsAsync(user);

            Identity.AddClaim(new Claim("Carearstared", user.CareerStarted.ToString()));
            return Identity;
        }
    }
}
