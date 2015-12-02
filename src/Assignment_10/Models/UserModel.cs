using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Assignment_10.Models {
    public class UserModel {

        [Required]
        [MinLength(1)]
        public string Username { get; set; }

        [Required]
        [MinLength(1)]
        public string Password { get; set; }

    }
}
