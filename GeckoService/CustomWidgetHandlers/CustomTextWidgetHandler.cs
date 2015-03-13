using System.Collections.Generic;
using Geckonet.Core.Models;

namespace GeckoService
{
     public class CustomTextWidgetHandler: ICustomWidgetHandler
     {
         private List<DataItem> textPages;

         public CustomTextWidgetHandler(string widgetKey)
         {
             textPages = new List<DataItem>();
             this.widgetKey = widgetKey;
         }

         public void AddTextPage(string textPage)
         {
             textPages.Add(new DataItem() { Text = textPage });
         }

         public override void Push()
         {
             geckoData.DataItems = textPages.ToArray();
             base.Push();
         }
    }
}
