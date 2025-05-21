using System;
using Microsoft.AspNetCore.Identity;

namespace Egeroro.Entity.Identity
{
	public class AppUser : IdentityUser<int>
	{
		public AppUser() : base()
		{
		}
		public AppUser(string userName) : base(userName)
		{
        }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}

