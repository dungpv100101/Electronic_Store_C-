using BusinessObject.DTO.Response;
using Eletronic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eletronic.Client
{
    public class UserClient : BaseClient
    {
        public readonly string USER_URL = "https://localhost:7246/v1/api/User/";

        public List<User> GetListUser(string? username)
        {
            string apiUrl = USER_URL + "List" + $"?username={username}";

            BaseResponse baseResponse = Get(apiUrl);

            List<User> users = baseResponse.GetData<List<User>>();

            return users;
        }

        public bool SetStaff(int userId, int isStaff)
        {
            string apiUrl = USER_URL + "SetStaff" + $"?userId={userId}&isStaff={isStaff}";

            BaseResponse baseResponse = Post(apiUrl, null);

            return baseResponse != null;
        }

        public bool Add(User user)
        {
            string apiUrl = USER_URL + "Add";

            BaseResponse baseResponse = Post(apiUrl, user);
            return baseResponse != null;
        }
    }
}
