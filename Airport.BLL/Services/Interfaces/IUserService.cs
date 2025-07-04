﻿using Airport.BLL.DTOs.Identity;
using Airport.DAL.EF.Entities.HelpModels.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.BLL.Services.Interfaces
{
    namespace JWTAuthentication.WebApi.Services
    {
        public interface IUserService
        {
            Task<string> RegisterAsync(RegisterModel model);

            Task<AuthenticationModel> GetTokenAsync(TokenRequestModel model);

            Task<string> AddRoleAsync(AddRoleModel model);

            Task<AuthenticationModel> RefreshTokenAsync(string jwtToken);

            bool RevokeToken(string token);

            ApplicationUser GetById(string id);
        }
    }
}
