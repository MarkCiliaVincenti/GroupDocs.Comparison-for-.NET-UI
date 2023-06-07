using GroupDocs.Comparison.UI.Api.Cloud.Storage;
using GroupDocs.Comparison.UI.Api.Cloud.Storage.Configuration;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.Configuration
{
    public static class ConfigurationExtensions
    {
        public static Config BindCloudApiSettings
            (this IConfiguration configuration, Config config)
        {
            configuration
                .GetSection(Keys.GROUPDOCSCOMPARISONUI_API_CLOUD_STORAGE_SECTION_SETTING_KEY)
                .Bind(config, c => c.BindNonPublicProperties = true);

            return config;
        }
    }
}