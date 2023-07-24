using DataAccess.DTO;
using DataAccess.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Client
{
    public class ReportClient : BaseClient
    {
        public readonly string ORDER_URL = "https://localhost:7246/v1/api/Report/";
        public ReportDTO GetReportData(DateTime startDate, DateTime toDate)
        {
            string apiUrl = ORDER_URL + "GetReportData" + $"?startDate={startDate.ToString("MM/dd/yyyy")}&toDate={toDate.ToString("MM/dd/yyyy")}";

            BaseResponse baseResponse = Get(apiUrl);

            ReportDTO result = baseResponse.GetData<ReportDTO>();

            return result;
        }
    }
}
