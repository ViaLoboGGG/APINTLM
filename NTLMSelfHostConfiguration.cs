using System.ServiceModel.Channels;
using System.Web.Http.SelfHost;
using System.Web.Http.SelfHost.Channels;


namespace APINTLM
{
    public class NTLMSelfHostConfiguration : HttpSelfHostConfiguration
    {
        public NTLMSelfHostConfiguration(string baseAddress) : base(baseAddress) { }
        public NTLMSelfHostConfiguration(Uri baseAddress) : base(baseAddress) { }

    }
}
