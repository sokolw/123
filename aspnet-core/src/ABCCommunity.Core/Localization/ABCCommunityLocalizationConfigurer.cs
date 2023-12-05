using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ABCCommunity.Localization
{
    public static class ABCCommunityLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ABCCommunityConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ABCCommunityLocalizationConfigurer).GetAssembly(),
                        "ABCCommunity.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
