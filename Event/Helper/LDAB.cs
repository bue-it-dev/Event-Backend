using Event.DTOs;
using Microsoft.Extensions.Options;
using RestSharp;
using System;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace BUECarSystem.Helper
{
    public class LDAB
    {
        private readonly IOptions<LDAPDTO> _appSettings;
        static string ldapIP = "";

        public LDAB(IOptions<LDAPDTO> appSettings)
        {
            _appSettings = appSettings;
            ldapIP = _appSettings.Value.LDAB;
        }

        public static async Task<bool> Authentication(string userName, string password)
        {
            const string url = "https://pgs.bue.edu.eg/LDAP/api/Authenticate";

            try
            {
                var options = new RestClientOptions(url)
                {
                    ThrowOnAnyError = true,
                    Timeout = TimeSpan.FromMilliseconds(-1)
                };
                var client = new RestClient(options);
                var request = new RestRequest()
                    .AddHeader("Content-Type", "application/json")
                    .AddJsonBody(new
                    {
                        username = userName,
                        password = password
                    });
                var response = await client.PostAsync<bool>(request);
                return response;
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }
    }
}