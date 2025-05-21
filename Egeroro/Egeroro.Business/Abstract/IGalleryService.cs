using System;
using Egeroro.Entity.Concrete;

namespace Egeroro.Business.Abstract
{
	public interface IGalleryService
	{
        void GalleryInsert(Gallery entity);
        void GalleryUpdate(Gallery entity);
        void GalleryDelete(Gallery entity);
        List<Gallery> GetList();
        Gallery GetById(int id);
    }
}

