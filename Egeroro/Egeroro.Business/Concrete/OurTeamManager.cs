using System;
using Egeroro.Business.Abstract;
using Egeroro.Data.Abstract;
using Egeroro.Entity.Concrete;

namespace Egeroro.Business.Concrete
{
	public class OurTeamManager : IOurTeamService
    {
        IOurTeamDal _ourTeamDal;

        public OurTeamManager(IOurTeamDal ourTeamDal)
        {
            _ourTeamDal = ourTeamDal;
        }

        public void OurTeamDelete(OurTeam entity)
        {
            _ourTeamDal.Delete(entity);
        }

        public void OurTeamInsert(OurTeam entity)
        {
            _ourTeamDal.Insert(entity);
        }

        public void OurTeamUpdate(OurTeam entity)
        {
            _ourTeamDal.Update(entity);
        }

        public OurTeam GetById(int id)
        {
            return _ourTeamDal.GetById(id);
        }

        public List<OurTeam> GetList()
        {
            return _ourTeamDal.GetList();
        }
    }
}

