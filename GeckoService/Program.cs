using System.Configuration;
using GeckoService.Models;

namespace GeckoService
{
    class Program
    {
        private static void Main()
        {
            CustomTextWidgetHandler textWidget = new CustomTextWidgetHandler(ConfigurationManager.AppSettings["testwidetextwidgetkey"]);

            textWidget.AddTextPage(TemplateManager.ReturnPopulatedTemplate("BannerTemplate", new ReleaseModel { Name = "This is a test." }));
            textWidget.Push();

            //UpdateTestTextWidget();
            //UpdateTestWideTextWidget();
        }

        private static void UpdateTestWideTextWidget()
        {
            CustomTextWidgetHandler textWidget = new CustomTextWidgetHandler(ConfigurationManager.AppSettings["testwidetextwidgetkey"]);
            textWidget.AddTextPage("<div style=\"text-align:center\">This is a banner.</div>");
            textWidget.Push();
        }

        private static void UpdateTestTextWidget()
        {
            CustomTextWidgetHandler textWidget = new CustomTextWidgetHandler(ConfigurationManager.AppSettings["testtextwidgetkey"]);
            textWidget.AddTextPage("This is a test.");
            textWidget.AddTextPage("This is also a test.");
            textWidget.AddTextPage("I promise that this is probably (not) the last test.");
            textWidget.Push();
        }
    }
}