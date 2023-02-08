using System.Security.Principal;

namespace CartelManager.Handler
{
    internal class Data
    {
        public static string SSLkey = "";
        
        public static string webhook = "";
        public static string authKey = "";
        public static string aid = "";
        public static string secret = "";
        public static string programSecret = "";
        public static string apiKey = "";

        public static string version = "1.0";

        public static string HwID = WindowsIdentity.GetCurrent().User.Value.ToString();
    }
}
