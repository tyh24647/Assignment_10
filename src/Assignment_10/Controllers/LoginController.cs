using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Assignment_10.Models;
using Assignment_10.Filters;
using System.Security.Claims;
using Assignment_10.Services;
using System.Net;

namespace Assignment_10.Controllers {
    [Route("[controller]")]
    [TypeFilter(typeof(AuthorizationFilter))]
    [TypeFilter(typeof(ExceptionHandlerFilter))]
    public class LoginController : Controller {

        private UsersModel users = new UsersModel();

        private ISecurityProvider securityProvider;

        public LoginController(UsersModel users, ISecurityProvider securityProvider) {
            this.securityProvider = securityProvider;
            this.users = users;
        }

        [HttpPost]
        public IActionResult Post([FromBody]UserModel newUser) {
            if (users.All[newUser.Username].Password.Equals(newUser.Password)) {
                var claims = new List<Claim>();
                claims.Add(new Claim("username", newUser.Username));
                Token token = new Token() {
                    token = this.securityProvider.GetToken(claims)
                };
                return new JsonResult(token);
            } else if (!users.All.ContainsKey(newUser.Username)) {
                return new HttpStatusCodeResult((int)HttpStatusCode.NotFound);
            } else {
                return new HttpStatusCodeResult((int)HttpStatusCode.Unauthorized);
            }
        }

    }

    public class Token {
        public string token { get; set; }
    }
}
