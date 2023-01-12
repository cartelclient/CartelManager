using Authenticator;
using System;
using System.Collections.Specialized;
using System.Net;
using System.Windows.Forms;

namespace CartelManager.Handler
{
    internal class webhookSender
    {
        public static void Send(string url, string username, string content)
        {
            try
            {
                WebClient wc = new WebClient();
                wc.UploadValues(url, new NameValueCollection
                {
                {
                    "content", content
                },
                {
                    "username", username
                }
                });
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("There was an error sending your webhook login info, therefore the app has to exit. Send your error message in a staff channel (The error is automatically copied to your clipboard)");
                Clipboard.SetText(ex.Message);
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        public static void authLog(string action)
        {
            Auth.Log(User.Username, action);
        }
    }
}
