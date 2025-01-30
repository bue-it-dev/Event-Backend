using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event.Authentications;
using Event.DTOs;
using Event.Models;
using Event.Repository.Interfaces;

namespace Event.Helper

{
    public class AuthRepository : IAuthRepository
    {
        private readonly ITokenManager _tokenManager;
        private readonly HrmDBContext _context;

        public AuthRepository(ITokenManager tokenManager, HrmDBContext context)
        {
            _tokenManager = tokenManager;
            _context = context;
        }

        public virtual async Task<AuthenticateResponsDTO> AuthenticateAsync(string userName, string password)
        {

            var authenticated = await LDAB.Authentication(userName, password);

            if (authenticated)
            {
               
                AuthToken token;
               
                    token = await _tokenManager.GenerateAsync(userName, null);
                
                return new AuthenticateResponsDTO
                {
                    AccessToken = token.AccessToken,
                    ExpiresIn = token.ExpiresIn,
                };
            }
            return null;
        }
  
     
    }
}
