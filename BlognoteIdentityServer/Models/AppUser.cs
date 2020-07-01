using System;
using Microsoft.AspNetCore.Identity;

namespace BlognoteIdentityServer.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
