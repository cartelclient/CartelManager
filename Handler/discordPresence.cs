using DiscordRPC;

namespace CartelManager.Handler
{
    internal class discordPresence
    {
        public static DiscordRpcClient client;


        public static void Start()
        {
            client = new DiscordRpcClient("1058474224794206288");
            client.Initialize(); ;
        }

        public static void Update(string State)
        {
            if (client.IsInitialized)
            {
                client.SetPresence(new RichPresence()
                {
                    Details = $"Cartel Admin Tool",
                    State = State,
                    Assets = new Assets()
                    {
                        LargeImageKey = "logo",
                        LargeImageText = "Cartel Manager",
                    }
                });
            }
        }

        public static void Dispose()
        {
            if (client.IsInitialized)
            {
                client.Dispose();
            }
        }
    }
}