
using Eletronic.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eletronic.Client
{
    public class BaseClient
    {
        public static WebClient _client = new WebClient();
        public BaseResponse Get(string url)
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

        public BaseResponse Post(string url, Object data)
        {
            try
            {
                string jsonData = System.Text.Json.JsonSerializer.Serialize(data);

                _client.Headers[HttpRequestHeader.ContentType] = "application/json";

                var response = _client.UploadString(url, "POST", jsonData);

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
            } catch (Exception ex)
            {
                MessageBox.Show("Error When Call API");
                return null;
            }
        }
    }
}
