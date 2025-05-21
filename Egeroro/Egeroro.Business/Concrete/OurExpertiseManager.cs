using System;
using Egeroro.Business.Abstract;
using Egeroro.Data.Abstract;
using Egeroro.Entity.Concrete;

namespace Egeroro.Business.Concrete
{
	public class OurExpertiseManager : IOurExpertiseService
    {
        IOurExpertiseDal _ourExpertiseDal;

        public OurExpertiseManager(IOurExpertiseDal ourExpertiseDal)
        {
            _ourExpertiseDal = ourExpertiseDal;
        }

        public void OurExpertiseDelete(OurExpertise entity)
        {
            _ourExpertiseDal.Delete(entity);
        }

        public void OurExpertiseInsert(OurExpertise entity)
        {
            _ourExpertiseDal.Insert(entity);
        }

        public void OurExpertiseUpdate(OurExpertise entity)
        {
            _ourExpertiseDal.Update(entity);
        }

        public OurExpertise GetById(int id)
        {
            return _ourExpertiseDal.GetById(id);
        }

        public List<OurExpertise> GetList()
        {
            return _ourExpertiseDal.GetList();
        }

    }
}

