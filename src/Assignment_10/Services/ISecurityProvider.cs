using System.Collections.Generic;
using System.Security.Claims;

namespace Assignment_10.Services {
    public interface ISecurityProvider {
        string GetToken(List<Claim> claims);
        bool Validate(string token);
    }
}
