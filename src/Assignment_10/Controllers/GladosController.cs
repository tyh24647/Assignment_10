using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using Assignment_10.Filters;
using Assignment_10.Models;
using Assignment_10.Services;
using System.Security.Claims;
using System;

namespace Assignment_10.Controllers {
    [Route("[controller]")]
    [TypeFilter(typeof(AuthorizationFilter))]
    public class GladosController : Controller {

        private ISecurityProvider securityProvider;

        private AuthorizationFilter filter = new AuthorizationFilter();

        private UsersModel users = new UsersModel();

        public GladosController(ISecurityProvider securityProvider) {
            this.securityProvider = securityProvider;
        }

        [HttpGet]
        public string Get() {
            var claims = new List<Claim>();
            claims.Add(new Claim("Glados", "Cake"));
            claims.Add(new Claim("Tyler", "Test"));
            return this.securityProvider.GetToken(claims);
        }
        
    }
}

