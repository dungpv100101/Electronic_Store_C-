using DataAccess.Client;
using DataAccess.DTO.Response;
using DataAccess.Models;
using Eletronic.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eletronic.Client
{
    public class AuthClient : BaseClient
    {
        public readonly string AUTH_URL = "https://localhost:7246/v1/api/Auth/";
        public User Login(LoginDTO request)
        {
            string apiUrl = AUTH_URL + "Login";

            BaseResponse baseResponse = Post(apiUrl, request);

            return baseResponse.GetData<User>();
        }

        public bool Logout()
        {
            string apiUrl = AUTH_URL + "Logout";

            BaseResponse baseResponse = Post(apiUrl, null);

            return baseResponse.errorCode == 200;
        }
    }
}
