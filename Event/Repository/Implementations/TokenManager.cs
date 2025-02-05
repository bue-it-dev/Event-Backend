
using Event.auth;
using Event.Authentications;
using Event.Models;
using Event.Models.EventModel;
using Event.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace Event.Repository.Implementations
{
    public class TokenManager : ITokenManager
    {
        private readonly HrmDBContext _context;
        private readonly EventContext _eventContext;
        private readonly IOldHrmRepository _oldHrmRepository;
        private readonly JwtSettings _jwtSettings;

        public TokenManager(IConfiguration configuration, HrmDBContext context, IOldHrmRepository oldHrmRepository, EventContext eventContext)
        {
            _context = context;
            _oldHrmRepository = oldHrmRepository;
            _jwtSettings = configuration.GetSection("Jwt").Get<JwtSettings>();
            _eventContext = eventContext;
        }

        public async Task<AuthToken> GenerateAsync(string username)
        {
            var employee = await _oldHrmRepository.GetEmployeebyUsername(username);
            var traveluser = await _eventContext.Users.Where(e => e.UserName == username).FirstOrDefaultAsync();
            if (traveluser != null)
            {
                var usertypedetails = await _eventContext.UserTypeLookups.Where(e => e.UserTypeId == traveluser.UserTypeId).FirstOrDefaultAsync();
                List<Claim> claims;
                claims = new List<Claim>() {
                new Claim (JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim (JwtRegisteredClaimNames.UniqueName, username),
                new Claim (JwtRegisteredClaimNames.NameId, employee.id.ToString()),
                new Claim ("name", employee.FullName),
                new Claim ("RoleID", traveluser.UserTypeId.ToString()),
                new Claim ("UserID", traveluser.UserId.ToString()),
                new Claim ("isAcademic", traveluser.IsAcadmic.ToString()),
                new Claim ("RoleName", usertypedetails.UserTypeName),
                new Claim ("entity", employee.departmentName),
                new Claim ("jobTitle", employee.JobName)
                };
                JwtSecurityToken token = new TokenBuilder()
                .AddAudience(_jwtSettings.Audience)
                .AddIssuer(_jwtSettings.Issuer)
                .AddExpiry(_jwtSettings.ExpiryInMinutes)
                .AddKey(_jwtSettings.Key)
                .AddClaims(claims)
                .Build();

                string accessToken = new JwtSecurityTokenHandler().WriteToken(token);

                return new AuthToken()
                {
                    AccessToken = accessToken,
                    ExpiresIn = _jwtSettings.ExpiryInMinutes
                };
            }
            else
            {
                List<Claim> claims;
                claims = new List<Claim>() {
                new Claim (JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim (JwtRegisteredClaimNames.UniqueName, username),
                new Claim (JwtRegisteredClaimNames.NameId, employee.id.ToString()),
                new Claim ("name", employee.FullName),
                new Claim ("RoleID", "1"),
                new Claim ("RoleName", "Staff"),
                new Claim ("entity", employee.departmentName),
                new Claim ("jobTitle", employee.JobName)
                };
                JwtSecurityToken token = new TokenBuilder()
                .AddAudience(_jwtSettings.Audience)
                .AddIssuer(_jwtSettings.Issuer)
                .AddExpiry(_jwtSettings.ExpiryInMinutes)
                .AddKey(_jwtSettings.Key)
                .AddClaims(claims)
                .Build();

                string accessToken = new JwtSecurityTokenHandler().WriteToken(token);

                return new AuthToken()
                {
                    AccessToken = accessToken,
                    ExpiresIn = _jwtSettings.ExpiryInMinutes

                };
            }

        }

    }
}
