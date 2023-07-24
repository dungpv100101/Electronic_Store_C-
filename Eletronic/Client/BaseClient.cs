using BusinessObject.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Eletronic.Client
{
    public class BaseClient
    {
        public static WebClient _client = new WebClient();
        public BaseResponse CallApi(string url, Object data)
        {
            var response = _client.DownloadString(url);

            if (response != null)
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                BaseResponse result = JsonSerializer.Deserialize<BaseResponse>(response, options);

                return result;
            }

            return null;
        }
    }
}
