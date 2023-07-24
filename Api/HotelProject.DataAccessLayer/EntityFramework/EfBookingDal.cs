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
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(Context context) : base(context)
        {
        }

		public void BookingStatusChangeApproved(Booking booking)
		{
			var context = new Context();
			var values = context.Bokings.Where(x=>x.BookingID==booking.BookingID).FirstOrDefault();
			values.Status = "Onaylandı";
			context.SaveChanges();
		}

		public void BookingStatusChangeApproved2(int id)
		{
			var context = new Context();
			var values = context.Bokings.Find(id);
			values.Status = "Onaylandı";
			context.SaveChanges();
		}
	}
}
