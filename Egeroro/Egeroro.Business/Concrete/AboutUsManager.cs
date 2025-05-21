using System;
using Egeroro.Business.Abstract;
using Egeroro.Data.Abstract;
using Egeroro.Entity.Concrete;

namespace Egeroro.Business.Concrete
{
    public class AboutUsManager : IAboutUsService
    {
        IAboutUsDal _aboutUsDal;

        public AboutUsManager(IAboutUsDal aboutUsDal)
        {
            _aboutUsDal = aboutUsDal;
        }

        public void AboutUsDelete(AboutUs entity)
        {
            _aboutUsDal.Delete(entity);
        }

        public void AboutUsInsert(AboutUs entity)
        {
            _aboutUsDal.Insert(entity);
        }

        public void AboutUsUpdate(AboutUs entity)
        {
            _aboutUsDal.Update(entity);
        }

        public AboutUs GetById(int id)
        {
            return _aboutUsDal.GetById(id);
        }

        public List<AboutUs> GetList()
        {
            return _aboutUsDal.GetList();
        }
    }
}

