using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace Assignment_10.Models {
    public class UsersModel {
        
        private List<UserModel> All = new List<UserModel>();

        public void Add(UserModel userModel) {
            if (userModel == null) {
                return;
            }

            All.Add(userModel);
        }
        

    }
}
