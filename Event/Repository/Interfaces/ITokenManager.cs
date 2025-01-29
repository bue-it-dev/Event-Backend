using BUECarSystem.Authentications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BUECarSystem.Interfaces.Repositories
{
    public interface ITokenManager
    {
        Task<AuthToken> GenerateAsync(string username,string loginType);
    }
}
