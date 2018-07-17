using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarPool.Contracts;
using CarPool.Contracts.ResponseDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarPoolApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Auth")]
    public class AuthController : Controller
    {
        // GET: api/Auth
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [HttpGet]
        [Route("Authenticate")]
        public async Task<AuthResponse> AuthenticateUser(AuthRequest request)
        {

            AuthProvider provider = new AuthProvider();
            provider.ClientProxyObj = new DocumentDB();

            return await provider.GetAuthenticationTokenDetails(request);
        }

        [HttpGet]
        [Route(RouteInfo.RequestOTP)]
        public async Task<BaseResponse> RequestOTP(string emailAddress)
        {

            var provider = new AuthProvider();
            provider.ClientProxyObj = new DocumentDB();

            return await provider.RequestOTP(emailAddress);
        }


        // GET: api/Auth/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Auth
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Auth/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
