using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event.Authentications
{
    public class AuthToken
    {
        public long ExpiresIn { get; set; }
        public string AccessToken { get; set; }
    }
}
