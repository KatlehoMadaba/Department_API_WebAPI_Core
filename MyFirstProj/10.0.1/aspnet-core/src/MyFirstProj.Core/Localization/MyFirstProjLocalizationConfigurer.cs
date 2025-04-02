using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace MyFirstProj.Localization;

public static class MyFirstProjLocalizationConfigurer
{
    public static void Configure(ILocalizationConfiguration localizationConfiguration)
    {
        localizationConfiguration.Sources.Add(
            new DictionaryBasedLocalizationSource(MyFirstProjConsts.LocalizationSourceName,
                new XmlEmbeddedFileLocalizationDictionaryProvider(
                    typeof(MyFirstProjLocalizationConfigurer).GetAssembly(),
                    "MyFirstProj.Localization.SourceFiles"
                )
            )
        );
    }
}
