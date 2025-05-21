using System;
using Egeroro.Entity.Concrete;

namespace Egeroro.Business.Abstract
{
	public interface IOurTeamService
	{
        void OurTeamInsert(OurTeam entity);
        void OurTeamUpdate(OurTeam entity);
        void OurTeamDelete(OurTeam entity);
        List<OurTeam> GetList();
        OurTeam GetById(int id);
    }
}

