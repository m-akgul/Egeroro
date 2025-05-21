using System;
using Microsoft.AspNetCore.Identity;

namespace Egeroro.Entity.Identity
{
	public class AppRole : IdentityRole<int>
	{
		public AppRole() : base()
		{
		}

		public AppRole(string roleName) : base(roleName)
		{

		}
	}
}

