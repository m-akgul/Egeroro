using System;
using Egeroro.Entity.Concrete;

namespace Egeroro.Business.Abstract
{
	public interface IContactService
	{
        void ContactInsert(Contact entity);
        void ContactUpdate(Contact entity);
        void ContactDelete(Contact entity);
        List<Contact> GetList();
        Contact GetById(int id);
    }
}

