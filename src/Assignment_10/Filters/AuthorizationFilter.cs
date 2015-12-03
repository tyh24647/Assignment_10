using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace Assignment_10.Filters {
    public class AuthorizationFilter : IAuthorizationFilter {
        public void OnAuthorization(AuthorizationContext context) {
            string headerValue = context.HttpContext.Request.Headers.Get("Authorization");
        }
    }
}
