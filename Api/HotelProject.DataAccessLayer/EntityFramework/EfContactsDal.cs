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
    public class EfContactsDal : GenericRepository<Contacts>, IContactsDal
    {
        public EfContactsDal(Context context) : base(context)
        {
        }

        public int GetContactCount()
        {
            var context = new Context();
            var value = context.Contacts.Count();
            return value;
        }
    }
}
