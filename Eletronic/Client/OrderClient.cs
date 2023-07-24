﻿
using DataAccess.DTO.Response;
using DataAccess.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Client
{
    public class OrderClient : BaseClient
    {
        public readonly string ORDER_URL = "https://localhost:7246/v1/api/Order/";

        public List<Order> GetListOrder(int? userId, string? username)
        {
            string apiUrl = ORDER_URL + "List" + $"?userId={userId}&username={username}";

            BaseResponse baseResponse = Get(apiUrl);

            List<Order> orders = baseResponse.GetData<List<Order>>();

            return orders;
        }

        public bool Delivered(int orderId)
        {
            string apiUrl = ORDER_URL + "Delevired" + $"?orderId={orderId}";

            BaseResponse baseResponse = Post(apiUrl, null);

            return baseResponse != null;
        }

        public bool Add(Order order)
        {
            string apiUrl = ORDER_URL + "Add";
            
            BaseResponse baseResponse = Post(apiUrl, order);
            return baseResponse != null;
        }
    }
}
