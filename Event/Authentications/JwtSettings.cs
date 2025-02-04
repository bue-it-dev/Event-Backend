using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event.auth
{
    public  class JwtSettings
    {
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public int ExpiryInMinutes { get; set; }
        public string Key { get; set; }
    }
}
