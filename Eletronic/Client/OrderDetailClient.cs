using DataAccess.DTO.Response;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Client
{
    public class OrderDetailClient : BaseClient
    {
        public readonly string ORDER_DETAIL_URL = "https://localhost:7246/v1/api/OrderDetail/";

        public List<OrderDetail> GetListOrderDetail(int? orderId)
        {
            string apiUrl = ORDER_DETAIL_URL + "List" + $"?orderId={orderId}";

            BaseResponse baseResponse = Get(apiUrl);

            List<OrderDetail> orderDetails = baseResponse.GetData<List<OrderDetail>>();

            return orderDetails;
        }

        public bool Add(OrderDetail order)
        {
            string apiUrl = ORDER_DETAIL_URL + "Add";

            BaseResponse baseResponse = Post(apiUrl, order);
            return baseResponse != null;
        }
    }
}
