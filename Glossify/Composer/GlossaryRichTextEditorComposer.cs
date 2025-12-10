using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Cms.Core.Configuration.Models;
using Umbraco.Cms.Core.Models.ContentEditing;

namespace SiteWideGlossay.Composer
{
    public class GlossaryRichTextEditorComposer : IComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            builder.Services.PostConfigure<RichTextEditorSettings>(settings =>
            {
                // Add plugin - Plugins is a string array
                if (!settings.Plugins.Contains("glossarylink"))
                {
                    var pluginsList = settings.Plugins.ToList();
                    pluginsList.Add("glossarylink");
                    settings.Plugins = pluginsList.ToArray();
                }

                // Add custom config
                settings.CustomConfig["external_plugins"] =
                    "{\"glossarylink\":\"/App_Plugins/Glossify/plugin.min.js\"}";

                settings.CustomConfig["extended_valid_elements"] =
                    "span[class|data-glossary-id|data-glossary-name|data-glossary-definition]";

                settings.CustomConfig["content_css"] =
                    "/App_Plugins/Glossify/glossary-editor.css";

                // Add commands
                var commandsList = settings.Commands.ToList();

                commandsList.Add(new RichTextEditorSettings.RichTextEditorCommand
                {
                    Alias = "glossarylink",
                    Name = "Glossary Link",
                    Mode = RichTextEditorCommandMode.All
                });

                commandsList.Add(new RichTextEditorSettings.RichTextEditorCommand
                {
                    Alias = "glossaryclear",
                    Name = "Clear Glossary",
                    Mode = RichTextEditorCommandMode.All
                });

                settings.Commands = commandsList.ToArray();
            });
        }
    }
}
