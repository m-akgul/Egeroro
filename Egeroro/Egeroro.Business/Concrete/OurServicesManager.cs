using System;
using Egeroro.Business.Abstract;
using Egeroro.Data.Abstract;
using Egeroro.Entity.Concrete;

namespace Egeroro.Business.Concrete
{
	public class OurServicesManager : IOurServicesService
    {
        IOurServicesDal _ourServicesDal;

        public OurServicesManager(IOurServicesDal ourServicesDal)
        {
            _ourServicesDal = ourServicesDal;
        }

        public void OurServicesDelete(OurServices entity)
        {
            _ourServicesDal.Delete(entity);
        }

        public void OurServicesInsert(OurServices entity)
        {
            _ourServicesDal.Insert(entity);
        }

        public void OurServicesUpdate(OurServices entity)
        {
            _ourServicesDal.Update(entity);
        }

        public OurServices GetById(int id)
        {
            return _ourServicesDal.GetById(id);
        }

        public List<OurServices> GetList()
        {
            return _ourServicesDal.GetList();
        }

    }
}

