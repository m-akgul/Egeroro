using System;
using Egeroro.Business.Abstract;
using Egeroro.Data.Abstract;
using Egeroro.Entity.Concrete;

namespace Egeroro.Business.Concrete
{
	public class FleetManager : IFleetService
    {
        IFleetDal _fleetDal;

        public FleetManager(IFleetDal fleetDal)
        {
            _fleetDal = fleetDal;
        }

        public void FleetDelete(Fleet entity)
        {
            _fleetDal.Delete(entity);
        }

        public void FleetInsert(Fleet entity)
        {
            _fleetDal.Insert(entity);
        }

        public void FleetUpdate(Fleet entity)
        {
            _fleetDal.Update(entity);
        }

        public Fleet GetById(int id)
        {
            return _fleetDal.GetById(id);
        }

        public List<Fleet> GetList()
        {
            return _fleetDal.GetList();
        }
    }
}

