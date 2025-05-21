using System;
using Egeroro.Entity.Concrete;

namespace Egeroro.Business.Abstract
{
	public interface IOurServicesService
	{
        void OurServicesInsert(OurServices entity);
        void OurServicesUpdate(OurServices entity);
        void OurServicesDelete(OurServices entity);
        List<OurServices> GetList();
        OurServices GetById(int id);
    }
}

