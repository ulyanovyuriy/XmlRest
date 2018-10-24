using System;
using System.ServiceModel.Channels;
using System.Xml.Linq;

namespace XmlRestApp
{
    public class RestService : IRestService
    {
        public Message Post(Message r)
        {
            Console.WriteLine($"Post: {DateTime.Now}");

            return Message.CreateMessage(
                MessageVersion.None
                , "http://fintech/pong"
                , XElement.Parse("<pong/>"));
        }
    }
}
