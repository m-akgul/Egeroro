using System;
using Egeroro.Business.Abstract;
using Egeroro.Data.Abstract;
using Egeroro.Entity.Concrete;

namespace Egeroro.Business.Concrete
{
	public class GalleryManager : IGalleryService
    {
        IGalleryDal _galleryDal;

        public GalleryManager(IGalleryDal galleryDal)
        {
            _galleryDal = galleryDal;
        }

        public void GalleryDelete(Gallery entity)
        {
            _galleryDal.Delete(entity);
        }

        public void GalleryInsert(Gallery entity)
        {
            _galleryDal.Insert(entity);
        }

        public void GalleryUpdate(Gallery entity)
        {
            _galleryDal.Update(entity);
        }

        public Gallery GetById(int id)
        {
            return _galleryDal.GetById(id);
        }

        public List<Gallery> GetList()
        {
            return _galleryDal.GetList();
        }
    }
}

