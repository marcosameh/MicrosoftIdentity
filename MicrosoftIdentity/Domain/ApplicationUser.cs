using Microsoft.AspNetCore.Identity;
using System;

namespace MicrosoftIdentity
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        
        public DateTime?CareerStarted { get; set; }

        [PersonalData]

        public string Photo { get; set; }
    }
}