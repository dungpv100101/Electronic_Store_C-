using BusinessObject.DTO.Response;

namespace ElectronicAPI.Services
{
    public interface IReportService
    {
        BaseResponse GetReportInfo(DateTime? startDate, DateTime? toDate);
    }
}
