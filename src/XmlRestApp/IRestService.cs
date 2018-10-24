using System.ServiceModel;
using System.ServiceModel.Channels;

namespace XmlRestApp
{
    [ServiceContract]
    public interface IRestService
    {
        [OperationContract(
            Action = "*"
            , ReplyAction = "*")]
        Message Post(Message r);
    }
}
