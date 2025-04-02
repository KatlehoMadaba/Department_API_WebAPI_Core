using MyFirstProj.Debugging;

namespace MyFirstProj;

public class MyFirstProjConsts
{
    public const string LocalizationSourceName = "MyFirstProj";

    public const string ConnectionStringName = "Default";

    public const bool MultiTenancyEnabled = true;


    /// <summary>
    /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
    /// </summary>
    public static readonly string DefaultPassPhrase =
        DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "ce4f4e90d4a54b3399a13e5c42eb5792";
}
