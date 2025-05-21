using System;
using Egeroro.Entity.Concrete;

namespace Egeroro.Business.Abstract
{
	public interface IAboutUsService
	{
		void AboutUsInsert(AboutUs entity);
		void AboutUsUpdate(AboutUs entity);
		void AboutUsDelete(AboutUs entity);
        List<AboutUs> GetList();
        AboutUs GetById(int id);

    }
}

