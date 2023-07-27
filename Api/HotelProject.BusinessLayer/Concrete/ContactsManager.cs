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
    public class ContactsManager : IContactsService
    {
        private readonly IContactsDal _contactsDal;

        public ContactsManager(IContactsDal contactsDal)
        {
            _contactsDal = contactsDal;
        }

        public void TDelete(Contacts t)
        {
            throw new NotImplementedException();
        }

        public List<Contacts> TGetAll()
        {
            return _contactsDal.GetAll();
        }

        public Contacts TGetByID(int id)
        {
            return _contactsDal.GetByID(id);

		}

        public int TGetContactCount()
        {
            return _contactsDal.GetContactCount();
        }

        public void TInsert(Contacts t)
        {
            _contactsDal.Insert(t);
        }

        public void TUpdate(Contacts t)
        {
            throw new NotImplementedException();
        }
    }
}
