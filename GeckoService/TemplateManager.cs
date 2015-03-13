using System;
using System.IO;
using RazorEngine.Templating;

namespace GeckoService
{
    public class TemplateManager
    {
        static readonly string TemplateFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "WidgetHTMLTemplates");

        static public string ReturnPopulatedTemplate<T>(string templateName, T model)
        {
            var templatePath = Path.Combine(TemplateFolderPath, templateName + ".cshtml");

            var templateService = new TemplateService();
            var populatedTemplate = templateService.Parse(File.ReadAllText(templatePath), model, null, null);

            return populatedTemplate;
        }
    }
}
