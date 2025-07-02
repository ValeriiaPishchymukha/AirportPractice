using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DAL.EF.Helpers
{
    public class AuthOptions
    {
        public const string Issuer = "MyAuthServer"; // Token issuer
        public const string Audience = "MyAuthClient"; // Token audience
        public const string Key = "ThisIsASecretKeyThatIsAtLeast32Chars!"; // Encryption key
        public const int DurationInMinutes = 60;
        public static SymmetricSecurityKey GetSymmetricSecurityKey() =>
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Key));
    }
}
