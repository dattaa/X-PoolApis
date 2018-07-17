using System;

namespace CarPool.Business
{
    public class AuthRequest
    {
        public string EmailAddress { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
