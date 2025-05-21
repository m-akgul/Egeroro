using System;
using Egeroro.Data.Abstract;
using Egeroro.Data.Repository;
using Egeroro.Entity.Concrete;

namespace Egeroro.Data.EntityFramework
{
	public class EFOurTeamDal : GenericRepository<OurTeam>, IOurTeamDal
    {
		public EFOurTeamDal()
		{
		}
	}
}

