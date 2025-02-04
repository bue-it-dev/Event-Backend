
using Event.auth;
using Event.Authentications;
using Event.Models;
using Event.Repository.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace Event.Repository.Implementations
{
    public class TokenManager : ITokenManager
    {
        private readonly HrmDBContext _context;
        private readonly IOldHrmRepository _oldHrmRepository;
        private readonly JwtSettings _jwtSettings;

        public TokenManager(IConfiguration configuration, HrmDBContext context, IOldHrmRepository oldHrmRepository)
        {
            _context = context;
            _oldHrmRepository = oldHrmRepository;
            _jwtSettings = configuration.GetSection("Jwt").Get<JwtSettings>();
        }

        public async Task<AuthToken> GenerateAsync( string username, string loginType = null )
        {
            var employee = await _oldHrmRepository.GetEmployeebyUsername( username );
            List<Claim> claims;
            claims = new List<Claim>() {
                new Claim (JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim (JwtRegisteredClaimNames.UniqueName, username),
                new Claim (JwtRegisteredClaimNames.NameId, employee.id.ToString()),
                new Claim ("name", employee.FullName),
                new Claim ("role", (loginType == null || loginType == "") ?employee.RoleName:loginType),
                new Claim ("entity", employee.departmentName),
                new Claim ("jobTitle", employee.JobName)
                };
           
            JwtSecurityToken token = new TokenBuilder()
            .AddAudience(_jwtSettings.Audience )
            .AddIssuer(_jwtSettings.Issuer )
            .AddExpiry(_jwtSettings.ExpiryInMinutes )
            .AddKey(_jwtSettings.Key )
            .AddClaims( claims )
            .Build();

            string accessToken = new JwtSecurityTokenHandler().WriteToken( token );

            return new AuthToken()
            {
                AccessToken = accessToken,
                ExpiresIn = _jwtSettings.ExpiryInMinutes
            };
        }
    }

}
