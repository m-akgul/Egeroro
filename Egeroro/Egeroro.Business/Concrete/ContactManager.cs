using System;
using Egeroro.Business.Abstract;
using Egeroro.Data.Abstract;
using Egeroro.Entity.Concrete;

namespace Egeroro.Business.Concrete
{
	public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void ContactDelete(Contact entity)
        {
            _contactDal.Delete(entity);
        }

        public void ContactInsert(Contact entity)
        {
            _contactDal.Insert(entity);
        }

        public void ContactUpdate(Contact entity)
        {
            _contactDal.Update(entity);
        }

        public Contact GetById(int id)
        {
            return _contactDal.GetById(id);
        }

        public List<Contact> GetList()
        {
            return _contactDal.GetList();
        }
    }
}

