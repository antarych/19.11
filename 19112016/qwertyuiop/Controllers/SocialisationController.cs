using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using qwertyuiop.Models;
using System.Web.Http;
using Backend;

namespace qwertyuiop.Controllers
{
    public class SocializationController : ApiController
    {
        public SocializationController(IServiceA serviceA)
        {
            _serviceA = serviceA;
        }
        [HttpGet]
        [Route("user/lol")]
        public string SuccessfulMethod()
        {
            return "success";
        }

        [HttpGet]
        [Route("user/{userId}/matches")]
        public MatchedUser[] MatchUsersFor(int userId)
        {
            return new[]
            {
                new MatchedUser(userId, 3),
                new MatchedUser(userId, 13)
            };
        }
        private IServiceA _serviceA;
    }
}