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
	public class MessageCategoryManager : IMessageCategoryService
	{
		private readonly IMessageCatergoryDal _messageCatergoryDal;

		public MessageCategoryManager(IMessageCatergoryDal messageCatergoryDal)
		{
			_messageCatergoryDal = messageCatergoryDal;
		}

		public void TDelete(MessageCategory t)
		{
			throw new NotImplementedException();
		}

		public List<MessageCategory> TGetAll()
		{
			return _messageCatergoryDal.GetAll();
		}

		public MessageCategory TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public void TInsert(MessageCategory t)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(MessageCategory t)
		{
			throw new NotImplementedException();
		}
	}
}
