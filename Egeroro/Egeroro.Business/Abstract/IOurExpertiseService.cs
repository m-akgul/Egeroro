using System;
using Egeroro.Entity.Concrete;

namespace Egeroro.Business.Abstract
{
	public interface IOurExpertiseService
	{
        void OurExpertiseInsert(OurExpertise entity);
        void OurExpertiseUpdate(OurExpertise entity);
        void OurExpertiseDelete(OurExpertise entity);
        List<OurExpertise> GetList();
        OurExpertise GetById(int id);
    }
}

