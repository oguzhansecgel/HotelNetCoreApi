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
    public class SubscribeManager : ISubscribeService
    {
        private readonly ISubscriberDal _subscriberDal;

        public SubscribeManager(ISubscriberDal subscriberDal)
        {
            this._subscriberDal = subscriberDal;
        }

        public void TDelete(Subscriber t)
        {
            _subscriberDal.Delete(t);
        }

        public List<Subscriber> TGetAll()
        {
            return _subscriberDal.GetAll();
        }

        public Subscriber TGetByID(int id)
        {
            return _subscriberDal.GetByID(id);
        }

        public void TInsert(Subscriber t)
        {
            _subscriberDal.Insert(t);
        }

        public void TUpdate(Subscriber t)
        {
            _subscriberDal.Update(t);
        }
    }
}
