using ABCCommunity.Debugging;

namespace ABCCommunity
{
    public class ABCCommunityConsts
    {
        public const string LocalizationSourceName = "ABCCommunity";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "83505f7e0c654edd824cf27489aa7b18";
    }
}
