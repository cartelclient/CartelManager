using System;
using CartelManager.Handler;

namespace CartelManager
{
    internal class ConsoleWndw
    {
        static void Main(string[] args)
        {
            Startup();
        }

        static void Login()
        {

        }

        static void Startup()
        {
            discordPresence.Start();
            discordPresence.Update("Idling");
            Console.BufferWidth = Console.WindowWidth = 100;
            Console.BufferHeight = Console.WindowHeight = 28;
            Console.Title = "Cartel Manager";


            windowManager.MoveWindowToCenter();
            Options();
        }

        static void Options()
        {
            discordPresence.Update("Idling");
            Console.Clear();
            consoleWriter.writeLogo();
            Console.WriteLine("");

            consoleWriter.optionsWriter("User count");
            consoleWriter.optionsWriter("Display all users");
            consoleWriter.optionsWriter("Display user");
            consoleWriter.optionsWriter("Register user");
            consoleWriter.optionsWriter("Change password");
            consoleWriter.optionsWriter("Delete user");
            consoleWriter.optionsWriter("Display keys");
            consoleWriter.optionsWriter("Generate key");
            consoleWriter.optionsWriter("Delete key");
            consoleWriter.optionsWriter("Reset hwid");
            consoleWriter.optionsWriter("Exit");

            var input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();
                discordPresence.Update("Fetching user count");
                API.fetchUsers();
                Console.ReadLine();
            }

            if (input == "2")
            {
                Console.Clear();
                discordPresence.Update("Fetching all users");
                API.displayUsers();
                Console.ReadLine();
            }

            if (input == "3")
            {
                Console.Clear();
                discordPresence.Update("Fetching user info");
                Console.WriteLine("Username:");
                var user = Console.ReadLine();
                Console.Clear();
                API.displayUser(user);
                Console.ReadLine();
            }

            if (input == "4")
            {
                Console.Clear();
                Console.WriteLine("Please register users through the portal for now as this command is still in development");
                Console.ReadLine();
                //Console.Clear();
                //discordPresence.Update("Registering new user");
                //Console.WriteLine("Username:");
                //var user = Console.ReadLine();
                //Console.Clear();
                //Console.WriteLine("Password:");
                //var password = Console.ReadLine();
                //Console.Clear();
                //API.registerUser(user, password);
                //Console.ReadLine();
            }

            if (input == "5")
            {
                Console.Clear();
                discordPresence.Update("Changing user password");
                Console.WriteLine("Username:");
                var user = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Password:");
                var password = Console.ReadLine();
                Console.Clear();
                API.changePassword(user, password);
                Console.ReadLine();

            }

            if (input == "6")
            {
                Console.Clear();
                discordPresence.Update("Deleting user");
                Console.WriteLine("Username:");
                var user = Console.ReadLine();
                Console.Clear();
                API.deleteUser(user);
                Console.ReadLine();

            }

            if (input == "7")
            {
                Console.Clear();
                discordPresence.Update("Displaying keys");
                API.displayLicenses();
                Console.ReadLine();
            }

            if (input == "8")
            {
                Console.Clear();
                discordPresence.Update("Generating key");
                API.genLicense();
                Console.ReadLine();
            }
            if (input == "9")
            {
                Console.Clear();
                discordPresence.Update("Deleting key");
                Console.WriteLine("Key:");
                var key = Console.ReadLine();
                Console.Clear();
                API.deleteKey(key);
                Console.ReadLine();
            }

            if (input == "10")
            {
                Console.Clear();
                discordPresence.Update("Resetting users hwid");
                Console.WriteLine("Username");
                var user = Console.ReadLine();
                Console.Clear();
                API.resetHwid(user);
                Console.ReadLine();
            }

            else if (input == "11")
            {
                discordPresence.Dispose();
                Environment.Exit(0);
            }

            if (input != "1" || input != "2" || input != "3" || input != "4" || input != "5" || input != "6" || input != "7" || input != "8" || input != "9" || input != "10" || input != "11")
            {
                consoleWriter.resetOptions(); //reset the int varaible
                Options();
            }
        }
    }
}