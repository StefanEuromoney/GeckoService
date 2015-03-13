using System.Configuration;
using Geckonet.Core.Models;
using GeckoService.GeckonetExtensions;

namespace GeckoService
{
    public class ICustomWidgetHandler
    {
        internal string widgetKey;
        internal GeckoItems geckoData;

        public ICustomWidgetHandler()
        {
            geckoData = new GeckoItems();
        }

        public virtual void Push()
        {
            var push = new GeckoConnect.PushPayload<GeckoItems>()
            {
                ApiKey = ConfigurationManager.AppSettings["apikey"],
                Data = geckoData
            };

            var client = new GeckoConnect();
            client.Push(push, widgetKey);
        }
    }
}
