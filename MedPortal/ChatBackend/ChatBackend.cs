using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;


namespace ChatBackend
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ChatBackend : IChatBackend
    {
        DisplayMessageDelegate _displayMessageDelegate = null;

        private ChatBackend() { }

        public ChatBackend(DisplayMessageDelegate dmd)
        {
            _displayMessageDelegate = dmd;
            StartService();
        }



        public void DisplayMessage(CompositeType composite)
        {
            if(composite == null)
            {
                throw new ArgumentException("composite");
            }
            if(_displayMessageDelegate != null)
            {
                _displayMessageDelegate(composite);
            }
        }

        private string _LoggedinUsername = null;
        private ServiceHost host = null;
        private ChannelFactory<IChatBackend> channelFactory = null;
        private IChatBackend _channel;

        public void SendMessage(string text)
        {
            _channel.DisplayMessage(new CompositeType( _LoggedinUsername, text));
        }

        private void StartService()
        {
            host = new ServiceHost(this);
            host.Open();
            channelFactory = new ChannelFactory<IChatBackend>("ChatEndpoint");
            _channel = channelFactory.CreateChannel();

            //displayed locally
            _displayMessageDelegate(new CompositeType("Info", "Welcome to MedPortal's Ask The Doctor, Go ahead and ask your question " +
                                                        "and a health care professional will be with you shortly"));
        }

        private void StopService()
        {
            if(host != null)
            {
                _channel.DisplayMessage(new CompositeType("Event", _LoggedinUsername + " has left the chat"));

                if(host.State != CommunicationState.Closed)
                {
                    channelFactory.Close();
                    host.Close();
                }
            }
        }
    }
}
