using System;
using System.ComponentModel.Composition.Hosting;
using System.Net.Http;

namespace CartelManager.Handler
{
    internal class API
    {
        private static readonly HttpClient client = new HttpClient();

        // get user info // 
        public static async void fetchUsers()
        {
            try
            {
                var response = await client.GetStringAsync($"https://developers.auth.gg/USERS/?type=count&authorization={Data.authKey}");
                Console.WriteLine(response);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("502"))
                {
                    Console.WriteLine("API returned 502 error code, auth.gg is most likely down currently");
                }
            }
        }

        public static async void displayUsers()
        {
            try
            {
                var response = await client.GetStringAsync($"https://developers.auth.gg/USERS/?type=fetchall&authorization={Data.authKey}");
                Console.WriteLine(response);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("502"))
                {
                    Console.WriteLine("API returned 502 error code, auth.gg is most likely down currently");
                }
            }
        }

        public static async void displayUser(string username)
        {
            try
            {
                var response = await client.GetStringAsync($"https://developers.auth.gg/USERS/?type=fetch&authorization={Data.authKey}&user={username}");
                Console.WriteLine(response);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("502"))
                {
                    Console.WriteLine("API returned 502 error code, auth.gg is most likely down currently");
                }
            }
        }

        // change user info // 
        public static async void changePassword(string username, string password)
        {
            try
            {
                var response = await client.GetStringAsync($"https://developers.auth.gg/USERS/?type=changepw&authorization={Data.authKey}&user={username}&password={password}");
                if (response.Contains("Password has been updated"))
                {
                    Console.WriteLine($"Changed {username}'s password succuessfully");
                }
                if (response.Contains("No user found"))
                {
                    Console.WriteLine($"Username '{username}' was not found");
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("502"))
                {
                    Console.WriteLine("API returned 502 error code, auth.gg is most likely down currently");
                }
            }
        }

        public static async void deleteUser(string username)
        {
            try
            {
                var response = await client.GetStringAsync($"https://developers.auth.gg/USERS/?type=delete&authorization={Data.authKey}&user={username}");
                if (response.Contains("User has been removed"))
                {
                    Console.WriteLine($"Deleted {username} from the database");
                }
                if (response.Contains("No user found"))
                {
                    Console.WriteLine($"Username '{username}' was not found"); ;
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("502"))
                {
                    Console.WriteLine("API returned 502 error code, auth.gg is most likely down currently");
                }
            }
        }

        public static async void registerUser(string username, string password)
        {
            try
            {
                var response = await client.GetStringAsync($"https://developers.auth.gg/USERS/?type=changepw&authorization={Data.authKey}&user={username}&password={password}");
                Console.WriteLine(response);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("502"))
                {
                    Console.WriteLine("API returned 502 error code, auth.gg is most likely down currently");
                }
            }
        }

        public static async void resetHwid(string username)
        {
            try
            {
                var response = await client.GetStringAsync($"https://developers.auth.gg/HWID/?type=reset&authorization={Data.authKey}&user={username}");
                if (response.Contains("HWID has been succesfully reset"))
                {
                    Console.WriteLine($"Succuessfully reset {username}'s HWID");
                }
                if (response.Contains("No user found"))
                {
                    Console.WriteLine($"Username '{username}' was not found"); ;
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("502"))
                {
                    Console.WriteLine("API returned 502 error code, auth.gg is most likely down currently");
                }
            }
        }

        // keys // 

        public static async void genLicense()
        {
            try
            {
                var response = await client.GetStringAsync($"https://developers.auth.gg/LICENSES/?type=generate&days=9998&amount=1&level=1&authorization={Data.authKey}");
                Console.WriteLine(response);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("502"))
                {
                    Console.WriteLine("API returned 502 error code, auth.gg is most likely down currently");
                }
            }
        }

        public static async void displayLicenses()
        {
            try
            {
                var response = await client.GetStringAsync($"https://developers.auth.gg/LICENSES/?type=fetchall&authorization={Data.authKey}");
                Console.WriteLine(response);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("502"))
                {
                    Console.WriteLine("API returned 502 error code, auth.gg is most likely down currently");
                }
            }
        }

        public static async void deleteKey(string key)
        {
            try
            {
                var response = await client.GetStringAsync($"https://developers.auth.gg/LICENSES/?type=delete&license={key}&authorization={Data.authKey}");
                if (response.Contains("License has been deleted"))
                {
                    Console.WriteLine($"{key} has been deleted");
                }
                else
                {
                    Console.WriteLine(response);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("502"))
                {
                    Console.WriteLine("API returned 502 error code, auth.gg is most likely down currently");
                }
            }
        }
    }
}