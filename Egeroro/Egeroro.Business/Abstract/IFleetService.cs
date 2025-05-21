using System;
using Egeroro.Entity.Concrete;

namespace Egeroro.Business.Abstract
{
	public interface IFleetService
	{
        void FleetInsert(Fleet entity);
        void FleetUpdate(Fleet entity);
        void FleetDelete(Fleet entity);
        List<Fleet> GetList();
        Fleet GetById(int id);
    }
}

