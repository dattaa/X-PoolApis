using System;
using System.Collections.Generic;
using System.Text;

namespace CarPool.Contracts.ResponseDto
{
    public class AuthResponse:BaseResponse
    {
        public bool IsAuthenticated { get; set; }
      
    }
}
