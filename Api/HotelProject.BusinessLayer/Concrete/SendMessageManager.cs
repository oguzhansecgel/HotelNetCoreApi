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
	public class SendMessageManager : ISendMessageService
	{
		private readonly ISendMessageDal _sendMessageDal;

		public SendMessageManager(ISendMessageDal sendMessageDal)
		{
			_sendMessageDal = sendMessageDal;
		}

		public void TDelete(SendMessage t)
		{
			_sendMessageDal.Delete(t);

		}

		public List<SendMessage> TGetAll()
		{
			return _sendMessageDal.GetAll();
		}

		public SendMessage TGetByID(int id)
		{
			return _sendMessageDal.GetByID(id);
		}

        public int TGetSendMessagesCount()
        {
            return _sendMessageDal.SendMessagesCount();
        }

        public void TInsert(SendMessage t)
		{
			_sendMessageDal.Insert(t);
		}

		public void TUpdate(SendMessage t)
		{
			_sendMessageDal.Update(t);

		}
	}
}
