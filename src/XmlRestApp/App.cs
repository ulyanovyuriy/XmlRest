using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading;
using System.Xml.Linq;

namespace XmlRestApp
{
    public static class App
    {
        public static void Main(params string[] args)
        {
            Console.WriteLine("starting sample...");

            var host = new ServiceHost(typeof(RestService));
            host.Open();
            Console.WriteLine("host started");

            ThreadPool.QueueUserWorkItem(RunClient);

            Console.WriteLine("press any key to exit...");
            Console.ReadKey();
        }

        private static void RunClient(object state)
        {
            while (true)
            {
                using (var client = new RestClient())
                    client.Post(
                        Message.CreateMessage(
                            MessageVersion.None
                            , "http://fintech/ping", XElement.Parse("<ping/>")));

                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
        }
    }


}
