using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace Assignment_10.Models {
    public class UsersModel {
        
        public Dictionary<string, UserModel> All = new Dictionary<string, UserModel>() {
             { "glados", new UserModel() { Username = "glados", Password = "cake" } },
             { "Tyler", new UserModel() { Username = "Tyler", Password = "test" } }
        };
    }
}
