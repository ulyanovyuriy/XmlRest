using System.ServiceModel;
using System.ServiceModel.Channels;

namespace XmlRestApp
{
    public class RestClient : ClientBase<IRestService>, IRestService
    {
        public Message Post(Message r)
        {
            return Channel.Post(r);
        }
    }
}
