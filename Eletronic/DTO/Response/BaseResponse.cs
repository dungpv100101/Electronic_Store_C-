using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BusinessObject.DTO.Response
{
    public class  BaseResponse
    {
        public long? errorCode { get; set; }
        public object? data { get; set; }
        public string? message { get; set; }
        
        public static BaseResponse Success(Object? data = null)
        {
            return new BaseResponse {
                errorCode = 200,
                data = data,
                message = "Success"
            };
        }

        public static BaseResponse Error(Object? data = null, String message = "Fail", long errorCode = 400)
        {
            return new BaseResponse
            {
                errorCode = errorCode,
                data = data,
                message = message
            };
        }

        public TValue? GetData<TValue>()
        {
            string jsonString = JsonSerializer.Serialize(this.data);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            TValue result = JsonSerializer.Deserialize<TValue>(jsonString, options);

            return result;
        }
    }
}
