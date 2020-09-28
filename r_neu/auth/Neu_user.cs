using System;
using System.Configuration;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;

namespace r_neu.auth
{
    class Neu_user
    {
        private static readonly HttpClient HttpClient;

        static Neu_user()
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;

                if (appSettings.Count == 0)
                {
                    Console.WriteLine("AppSettings is empty.");
                }
                else
                {
                    foreach (var key in appSettings.AllKeys)
                    {
                        Console.WriteLine("Key: {0} Value: {1}", key, appSettings[key]);
                    }
                }
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
            HttpClient = new HttpClient();
        }
    }
}
