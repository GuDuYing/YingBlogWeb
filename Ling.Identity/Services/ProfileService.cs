using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using IdentityModel;
using IdentityServer4.Extensions;
using IdentityServer4.Models;
using IdentityServer4.Services;
using Ling.Identity.Interfaces.Services;
using Ling.Identity.Models;

namespace Ling.Identity.Services
{
    public class ProfileService : IProfileService
    {
        private readonly IUserService _userManager;

        public ProfileService(IUserService userManager)
        {
            _userManager = userManager;
        }

        public async Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            var sub = context.Subject.GetSubjectId();
            if (int.TryParse(sub, out int userId))
            {
                var user = await _userManager.GetAsync(userId);

                context.IssuedClaims.AddRange(user.GetClaims());
            }
            else
            {
                // what SHOULD I do here?
            }
        }

        public async Task IsActiveAsync(IsActiveContext context)
        {
            var sub = context.Subject.GetSubjectId();
            if (int.TryParse(sub, out int userId))
            {
                var user = await _userManager.GetAsync(userId);

                context.IsActive = user != null;
            }
            else
            {
                context.IsActive = false;
            }
        }
    }

    internal static class UserExtensions
    {
        public static IEnumerable<Claim> GetClaims(this User user)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtClaimTypes.Subject, user.Id.ToString()),
                new Claim(JwtClaimTypes.PreferredUserName, user.Username),
                new Claim(JwtClaimTypes.Name, user.Username)
            };

            return claims;
        }
    }
}

