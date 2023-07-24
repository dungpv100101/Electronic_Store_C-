﻿using AutoMapper;
using BusinessObject.DTO.Response;
using Eletronic.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectronicAPI.Services.Impl
{
    public class ReportServiceImpl : IReportService
    {
        private readonly Electronic_Shop_SystemContext context;
        private readonly IMapper _mapper;

        public ReportServiceImpl(Electronic_Shop_SystemContext _context, IMapper _mapper)
        {
            this.context = _context;
            this._mapper = _mapper;
        }
        public BaseResponse GetReportInfo(DateTime startDate, DateTime toDate)
        {
            int totalProductSell = calToTalProductSell(startDate, toDate);
            int totalOrder = calTotalOrder(startDate, toDate);
            double totalMoney = calTotalMoney(startDate, toDate);
        }

        private int calToTalProductSell(DateTime fromDate, DateTime toDate)
        {
            int total = 0;

            List<Order> listOrder = context.Orders
                .Include(s => s.OrderDetails)
                .Where(s => s.OrderDate > fromDate && s.OrderDate < toDate).ToList();

            foreach (Order order in listOrder)
            {
                total += order.OrderDetails.Count;
            }

            return total;
        }

        private double calTotalMoney(DateTime fromDate, DateTime toDate)
        {
            double total = 0;

            List<OrderDetail> listOrderDetails = context.OrderDetails
                .Include(s => s.Order)
                .Include(s => s.Product)
                .Where(s => s.Order.OrderDate > fromDate && s.Order.OrderDate < toDate).ToList();

            foreach (OrderDetail orderDetail in listOrderDetails)
            {
                total += orderDetail.Product.SellPrice - orderDetail.Product.Price;
            }

            return total;
        }

        private int calTotalOrder(DateTime fromDate, DateTime toDate)
        {
            int total = 0;

            List<Order> listOrder = context.Orders
                .Include(s => s.OrderDetails)
                .Where(s => s.OrderDate > fromDate && s.OrderDate < toDate && s.DeliverDate != null).ToList();

            total = listOrder.Count;

            return total;
        }
    }
}