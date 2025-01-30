using Event.Authentications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event.Repository.Interfaces
{
    public interface ITokenManager
    {
        Task<AuthToken> GenerateAsync(string username,string loginType);
    }
}
