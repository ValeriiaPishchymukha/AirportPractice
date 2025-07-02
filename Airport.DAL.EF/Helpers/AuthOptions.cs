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
        public const string ISSUER = "MyAuthServer"; // Token issuer
        public const string AUDIENCE = "MyAuthClient"; // Token audience
        private const string KEY = "mysupersecret_secretkey!123"; // Encryption key
        public static SymmetricSecurityKey GetSymmetricSecurityKey() =>
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(KEY));
    }
}
