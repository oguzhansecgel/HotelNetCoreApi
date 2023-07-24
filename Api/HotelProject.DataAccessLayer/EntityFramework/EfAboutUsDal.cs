using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repository;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfAboutUsDal : GenericRepository<AboutUs>, IAboutUsDal
    {
        public EfAboutUsDal(Context context) : base(context)
        {
        }

        public void Delete(Contacts t)
        {
            throw new NotImplementedException();
        }

        public void Insert(Contacts t)
        {
            throw new NotImplementedException();
        }

        public void Update(Contacts t)
        {
            throw new NotImplementedException();
        }
 
    }
}
