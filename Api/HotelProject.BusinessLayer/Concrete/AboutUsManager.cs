using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class AboutUsManager : IAboutUsService
    {
        private readonly IAboutUsDal _aboutUsDal;

        public AboutUsManager(IAboutUsDal aboutUsDal)
        {
            _aboutUsDal = aboutUsDal;
        }

        public void TDelete(AboutUs t)
        {
            _aboutUsDal.Delete(t);
        }

        public List<AboutUs> TGetAll()
        {
            return _aboutUsDal.GetAll();
        }

        public AboutUs TGetByID(int id)
        {
            return _aboutUsDal.GetByID(id);
        }

        public void TInsert(AboutUs t)
        {
            _aboutUsDal.Insert(t);
        }

        public void TUpdate(AboutUs t)
        {
            _aboutUsDal.Update(t);

        }
    }
}
