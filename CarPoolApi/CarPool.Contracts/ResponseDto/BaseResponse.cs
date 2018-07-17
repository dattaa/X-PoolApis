using System.Net;

namespace CarPool.Contracts.ResponseDto
{
    public class BaseResponse
    {
        public string Message { get; set; }

        public HttpStatusCode ResultCode { get; set; }
    }
}