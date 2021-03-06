using OrchardCore.Modules;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentFields.Indexing;
using OrchardCore.ContentFields.Settings;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentTypes.Editors;
using OrchardCore.DisplayManagement.Descriptors;
using OrchardCore.Indexing;

namespace OrchardCore.ContentFields
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            // Boolean Field
            services.AddSingleton<ContentField, BooleanField>();
            services.AddScoped<IContentFieldDisplayDriver, BooleanFieldDisplayDriver>();
            services.AddScoped<IContentPartFieldDefinitionDisplayDriver, BooleanFieldSettingsDriver>();
            services.AddScoped<IContentFieldIndexHandler, BooleanFieldIndexHandler>();

            // Text Field
            services.AddSingleton<ContentField, TextField>();
            services.AddScoped<IContentFieldDisplayDriver, TextFieldDisplayDriver>();
            services.AddScoped<IContentPartFieldDefinitionDisplayDriver, TextFieldSettingsDriver>();
            services.AddScoped<IContentFieldIndexHandler, TextFieldIndexHandler>();

            // Html Field
            services.AddSingleton<ContentField, HtmlField>();
            services.AddScoped<IContentFieldDisplayDriver, HtmlFieldDisplayDriver>();
            services.AddScoped<IContentPartFieldDefinitionDisplayDriver, HtmlFieldSettingsDriver>();
            services.AddScoped<IContentFieldIndexHandler, HtmlFieldIndexHandler>();

            // Link Field
            services.AddSingleton<ContentField, LinkField>();
            services.AddScoped<IContentFieldDisplayDriver, LinkFieldDisplayDriver>();
            services.AddScoped<IContentPartFieldDefinitionDisplayDriver, LinkFieldSettingsDriver>();
            services.AddScoped<IContentFieldIndexHandler, LinkFieldIndexHandler>();

            // Numeric Field
            services.AddSingleton<ContentField, NumericField>();
            services.AddScoped<IContentFieldDisplayDriver, NumericFieldDisplayDriver>();
            services.AddScoped<IContentPartFieldDefinitionDisplayDriver, NumericFieldSettingsDriver>();
            services.AddScoped<IContentFieldIndexHandler, NumericFieldIndexHandler>();
        }
    }
}
