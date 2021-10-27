using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode.SOLID.GoodCode
{

    class Dip
    {
        public interface IMessenger
        {
            void SendMessage();
        }

        public class Instant : IMessenger
        {
            public void SendMessage()
            {
                
            }
        }

        public class Email : IMessenger
        {
            public void SendMessage()
            {

            }
        }

        public class Sms : IMessenger
        {
            public void SendMessage()
            {

            }
        }

        public class Notification
        {
            private IMessenger _iMessenger;
            public IMessenger MessageService
            {
                set
                {
                    _iMessenger = value;
                }
            }

            public void DoNotify()
            {
                _iMessenger.SendMessage();
            }
        }
    }
   
    class A
    {
        public void Run()
        {
            Dip.Notification notification = new Dip.Notification();
            notification.MessageService = new Dip.Email();
            notification.DoNotify();
        }
    }
}

namespace CleanCode.SOLID.BadCode
{
    public class Email
    {
        public void SendMail()
        {

        }
    }

    public class Notification
    {
        private Email _email;

        public Notification()
        {
            _email = new Email();

        }

        public void PromotionNotification()
        {
            _email.SendMail();
        }

        public void SmsNotification()
        {

        }

        public void InstantNotification()
        {

        }
    }
}
